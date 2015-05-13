//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Moonfish.Guerilla.Tags
{
    using Moonfish.Tags;
    using Moonfish.Model;
    using System.IO;
    using System.Collections.Generic;
    using System.Linq;
    
    public partial class GlobalLeafConnectionBlock : GuerillaBlock, IWriteQueueable
    {
        public int PlaneIndex;
        public int BackLeafIndex;
        public int FrontLeafIndex;
        public LeafConnectionVertexBlock[] Vertices = new LeafConnectionVertexBlock[0];
        public float Area;
        public override int SerializedSize
        {
            get
            {
                return 24;
            }
        }
        public override int Alignment
        {
            get
            {
                return 4;
            }
        }
        public override System.Collections.Generic.Queue<Moonfish.Tags.BlamPointer> ReadFields(System.IO.BinaryReader binaryReader)
        {
            System.Collections.Generic.Queue<Moonfish.Tags.BlamPointer> pointerQueue = new System.Collections.Generic.Queue<Moonfish.Tags.BlamPointer>(base.ReadFields(binaryReader));
            this.PlaneIndex = binaryReader.ReadInt32();
            this.BackLeafIndex = binaryReader.ReadInt32();
            this.FrontLeafIndex = binaryReader.ReadInt32();
            pointerQueue.Enqueue(binaryReader.ReadBlamPointer(12));
            this.Area = binaryReader.ReadSingle();
            return pointerQueue;
        }
        public override void ReadInstances(System.IO.BinaryReader binaryReader, System.Collections.Generic.Queue<Moonfish.Tags.BlamPointer> pointerQueue)
        {
            base.ReadInstances(binaryReader, pointerQueue);
            this.Vertices = base.ReadBlockArrayData<LeafConnectionVertexBlock>(binaryReader, pointerQueue.Dequeue());
        }
        public override void QueueWrites(Moonfish.Guerilla.QueueableBinaryWriter queueableBinaryWriter)
        {
            base.QueueWrites(queueableBinaryWriter);
            queueableBinaryWriter.QueueWrite(this.Vertices);
        }
        public override void Write_(Moonfish.Guerilla.QueueableBinaryWriter queueableBinaryWriter)
        {
            base.Write_(queueableBinaryWriter);
            queueableBinaryWriter.Write(this.PlaneIndex);
            queueableBinaryWriter.Write(this.BackLeafIndex);
            queueableBinaryWriter.Write(this.FrontLeafIndex);
            queueableBinaryWriter.WritePointer(this.Vertices);
            queueableBinaryWriter.Write(this.Area);
        }
    }
}
