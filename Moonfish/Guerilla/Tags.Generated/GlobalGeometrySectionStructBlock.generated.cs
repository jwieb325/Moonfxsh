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
    
    public partial class GlobalGeometrySectionStructBlock : GuerillaBlock, IWriteQueueable
    {
        public GlobalGeometryPartBlockNew[] Parts = new GlobalGeometryPartBlockNew[0];
        public GlobalSubpartsBlock[] Subparts = new GlobalSubpartsBlock[0];
        public GlobalVisibilityBoundsBlock[] VisibilityBounds = new GlobalVisibilityBoundsBlock[0];
        public GlobalGeometrySectionRawVertexBlock[] RawVertices = new GlobalGeometrySectionRawVertexBlock[0];
        public GlobalGeometrySectionStripIndexBlock[] StripIndices = new GlobalGeometrySectionStripIndexBlock[0];
        public byte[] VisibilityMoppCode;
        public GlobalGeometrySectionStripIndexBlock[] MoppReorderTable = new GlobalGeometrySectionStripIndexBlock[0];
        public GlobalGeometrySectionVertexBufferBlock[] VertexBuffers = new GlobalGeometrySectionVertexBufferBlock[0];
        private byte[] fieldpad = new byte[4];
        public override int SerializedSize
        {
            get
            {
                return 68;
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
            pointerQueue.Enqueue(binaryReader.ReadBlamPointer(72));
            pointerQueue.Enqueue(binaryReader.ReadBlamPointer(8));
            pointerQueue.Enqueue(binaryReader.ReadBlamPointer(20));
            pointerQueue.Enqueue(binaryReader.ReadBlamPointer(196));
            pointerQueue.Enqueue(binaryReader.ReadBlamPointer(2));
            pointerQueue.Enqueue(binaryReader.ReadBlamPointer(1));
            pointerQueue.Enqueue(binaryReader.ReadBlamPointer(2));
            pointerQueue.Enqueue(binaryReader.ReadBlamPointer(32));
            this.fieldpad = binaryReader.ReadBytes(4);
            return pointerQueue;
        }
        public override void ReadInstances(System.IO.BinaryReader binaryReader, System.Collections.Generic.Queue<Moonfish.Tags.BlamPointer> pointerQueue)
        {
            base.ReadInstances(binaryReader, pointerQueue);
            this.Parts = base.ReadBlockArrayData<GlobalGeometryPartBlockNew>(binaryReader, pointerQueue.Dequeue());
            this.Subparts = base.ReadBlockArrayData<GlobalSubpartsBlock>(binaryReader, pointerQueue.Dequeue());
            this.VisibilityBounds = base.ReadBlockArrayData<GlobalVisibilityBoundsBlock>(binaryReader, pointerQueue.Dequeue());
            this.RawVertices = base.ReadBlockArrayData<GlobalGeometrySectionRawVertexBlock>(binaryReader, pointerQueue.Dequeue());
            this.StripIndices = base.ReadBlockArrayData<GlobalGeometrySectionStripIndexBlock>(binaryReader, pointerQueue.Dequeue());
            this.VisibilityMoppCode = base.ReadDataByteArray(binaryReader, pointerQueue.Dequeue());
            this.MoppReorderTable = base.ReadBlockArrayData<GlobalGeometrySectionStripIndexBlock>(binaryReader, pointerQueue.Dequeue());
            this.VertexBuffers = base.ReadBlockArrayData<GlobalGeometrySectionVertexBufferBlock>(binaryReader, pointerQueue.Dequeue());
        }
        public override void QueueWrites(Moonfish.Guerilla.QueueableBinaryWriter queueableBinaryWriter)
        {
            base.QueueWrites(queueableBinaryWriter);
            queueableBinaryWriter.QueueWrite(this.Parts);
            queueableBinaryWriter.QueueWrite(this.Subparts);
            queueableBinaryWriter.QueueWrite(VisibilityBounds);
            queueableBinaryWriter.QueueWrite(this.RawVertices);
            queueableBinaryWriter.QueueWrite(this.StripIndices);
            queueableBinaryWriter.QueueWrite(this.VisibilityMoppCode);
            queueableBinaryWriter.QueueWrite(this.MoppReorderTable);
            queueableBinaryWriter.QueueWrite(this.VertexBuffers);
        }
        public override void Write_(Moonfish.Guerilla.QueueableBinaryWriter queueableBinaryWriter)
        {
            base.Write_(queueableBinaryWriter);
            queueableBinaryWriter.WritePointer(this.Parts);
            queueableBinaryWriter.WritePointer(this.Subparts);
            queueableBinaryWriter.WritePointer(this.VisibilityBounds);
            queueableBinaryWriter.WritePointer(this.RawVertices);
            queueableBinaryWriter.WritePointer(this.StripIndices);
            queueableBinaryWriter.WritePointer(this.VisibilityMoppCode);
            queueableBinaryWriter.WritePointer(this.MoppReorderTable);
            queueableBinaryWriter.WritePointer(this.VertexBuffers);
            queueableBinaryWriter.Write(this.fieldpad);
        }
    }
}
