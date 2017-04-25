using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Moonfish.Tags;

namespace Moonfish.Guerilla
{
    public class QueueableBlamBinaryWriter : BlamBinaryWriter
    {
        private readonly Dictionary<object, QueueItem> lookupDictionary;
        protected readonly Queue<QueueItem> Queue;
        private int queueAddress;

        public QueueableBlamBinaryWriter(Stream output, int serializedSize) : base(output, Encoding.Default, true)
        {
            queueAddress = serializedSize;
            Queue = new Queue<QueueItem>(100);
            lookupDictionary = new Dictionary<object, QueueItem>(100);
        }

        /// <summary>
        /// Writes the specified guerilla block.
        /// </summary>
        /// <param name="guerillaBlock">The guerilla block.</param>
        public void Write(GuerillaBlock guerillaBlock)
        {
            guerillaBlock.Defer(this);
            guerillaBlock.Write(this);
            Commit();
        }

        /// <summary>
        /// Defers writing the specified <see cref="GuerillaBlock"/> array until after the current allocation.
        /// </summary>
        /// <param name="blocks">The <see cref="GuerillaBlock"/> array.</param>
        public void Defer(GuerillaBlock[] blocks)
        {
            //  if the array is empty there's nothing to write, so return
            if (blocks.Length <= 0)
                return;

            Enqueue(blocks);

            //  all guerilla blocks implement IWriteQueueable
            foreach (IWriteQueueable block in blocks)
                block.Defer(this);
        }

        /// <summary>
        /// Defers the specified data to be written after the current write allocation.
        /// </summary>
        /// <param name="data">The data.</param>
        public void Defer(byte[] data)
        {
            //  if the array is empty there's nothing to write, so return
            if (data.Length <= 0)
                return;

            Enqueue(data);
        }

        /// <summary>
        /// Defers the specified data to be written after the current write allocation.
        /// </summary>
        /// <param name="data">The data.</param>
        public void Defer(short[] data)
        {
            //  if the array is empty there's nothing to write, so return
            if (data.Length <= 0)
                return;

            Enqueue(data);
        }

        public override void Write(VertexBuffer buffer)
        {
            Write((int) buffer.Type);
            Write(new byte[28]);
        }

        public virtual void WritePointer<T>(T instanceFIeld)
        {
            QueueItem queueItem;
            this.Write(lookupDictionary.TryGetValue(instanceFIeld, out queueItem) ? queueItem.Pointer : BlamPointer.Null);
        }

        /// <summary>
        /// Commits the deffered writes to the stream.
        /// </summary>
        /// <exception cref="IOException">Wrote more/less data than expected.</exception>
        /// <exception cref="System.IO.IOException">Attempted to write over existing data.</exception>
        public void Commit()
        {
            while (Queue.Count > 0)
            {
                var item = Dequeue();

                //  if the pointer has data, and the stream is not already at the data start address
                //  then seek the data start address using a current stream offset to preserve the read/write 
                //  cache.
                if (!BlamPointer.IsNull(item.Pointer) && BaseStream.Position != item.Pointer.StartAddress)
                {
#if DEBUG
                    var offset = item.Pointer.StartAddress - BaseStream.Position;
                    if (offset < 0)
                    {
                        throw new IOException("Attempted to write over existing data.");
                    }
#endif
                    BaseStream.Seek(item.Pointer.StartAddress, SeekOrigin.Begin);
                }

                item.Write(this);

#if DEBUG
                if (BaseStream.Position != item.Pointer.EndAddress)
                    throw new IOException("Wrote more/less data than expected.");
#endif

            }
        }

        protected BlamPointer GetItemPointer(object key)
        {
            QueueItem value;
            var success = lookupDictionary.TryGetValue(key, out value);
            if (!success)
                return BlamPointer.Null;
            return value.Pointer;
        }

        internal void Defer(byte[] data, int alignment)
        {
            Enqueue(data, alignment);
        }

        private QueueItem Dequeue()
        {
            var queueItem = Queue.Dequeue();
            lookupDictionary.Remove(queueItem.ReferenceField);
            return queueItem;
        }

        private void Enqueue(byte[] data, int alignment = 4)
        {
            var blamPointer = new BlamPointer(data.Length, queueAddress, 1, alignment);
            var dataQueueItem = new ByteDataQueueItem(data) {Pointer = blamPointer};
            lookupDictionary[data] = dataQueueItem;
            Queue.Enqueue(dataQueueItem);
            queueAddress = blamPointer.EndAddress;
        }

        private void Enqueue(short[] data)
        {
            var blamPointer = new BlamPointer(data.Length, queueAddress, 2);
            var dataQueueItem = new ShortDataQueueItem(data) {Pointer = blamPointer};
            lookupDictionary[data] = dataQueueItem;
            Queue.Enqueue(dataQueueItem);
            queueAddress = blamPointer.EndAddress;
        }

        private void Enqueue(GuerillaBlock[] dataBlocks)
        {
            var elementSize = dataBlocks.GetElementSize();
            var alignment = dataBlocks.GetAlignment();
            var blamPointer = new BlamPointer(dataBlocks.Length, queueAddress, elementSize, alignment);

            var guerillaQueueItem = new GuerillaQueueItem(dataBlocks) {Pointer = blamPointer};
            lookupDictionary[dataBlocks] = guerillaQueueItem;
            Queue.Enqueue(guerillaQueueItem);
            queueAddress = blamPointer.EndAddress;
        }

        private class ByteDataQueueItem : QueueItem
        {
            public ByteDataQueueItem(byte[] data)
            {
                Data = data;
            }

            private byte[] Data { get; }
            public override BlamPointer Pointer { get; set; }

            public override object ReferenceField
            {
                get { return Data; }
            }

            public override void Write(QueueableBlamBinaryWriter writer)
            {
                writer.Write(Data);
            }
        }

        private class ShortDataQueueItem : QueueItem
        {
            public ShortDataQueueItem(short[] data)
            {
                Data = data;
            }

            private short[] Data { get; }
            public override BlamPointer Pointer { get; set; }

            public override object ReferenceField
            {
                get { return Data; }
            }

            public override void Write(QueueableBlamBinaryWriter writer)
            {
                short[] buffer = Data;
                foreach (var item in buffer)
                {
                    writer.Write(item);
                }
            }
        }

        private class GuerillaQueueItem : QueueItem
        {
            public GuerillaQueueItem(GuerillaBlock[] dataBlocks)
            {
                DataBlocks = dataBlocks;
            }

            private GuerillaBlock[] DataBlocks { get; }
            public override BlamPointer Pointer { get; set; }

            public override object ReferenceField
            {
                get { return DataBlocks; }
            }

            public override void Write(QueueableBlamBinaryWriter writer)
            {
                foreach (var block in DataBlocks)
                {
                    block.Write(writer);
                }
            }
        }
    }

    /// <summary>
    ///     Queue item used for allocating space for read and write operations on
    ///     a stream.
    /// </summary>
    public abstract class QueueItem
    {
        /// <summary>Gets or sets the pointer to the allocated space in the stream.</summary>
        /// <value>The pointer to allocated space in the stream.</value>
        public abstract BlamPointer Pointer { get; set; }

        /// <summary>Gets the reference to the queued data.</summary>
        /// <remarks>This is used as a key to lookup queue items.</remarks>
        /// <value>The reference field.</value>
        public abstract object ReferenceField { get; }

        public abstract void Write(QueueableBlamBinaryWriter writer);
    }
}