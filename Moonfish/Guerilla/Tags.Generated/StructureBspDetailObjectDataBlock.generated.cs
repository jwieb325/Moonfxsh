//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Moonfish.Guerilla.Tags
{
    using JetBrains.Annotations;
    using Moonfish.Tags;
    using Moonfish.Model;
    using System.IO;
    using System.Collections.Generic;
    using System.Linq;
    
    [JetBrains.Annotations.UsedImplicitlyAttribute(ImplicitUseTargetFlags.WithMembers)]
    [TagBlockOriginalNameAttribute("structure_bsp_detail_object_data_block")]
    public partial class StructureBspDetailObjectDataBlock : GuerillaBlock, IWriteQueueable
    {
        public GlobalDetailObjectCellsBlock[] Cells = new GlobalDetailObjectCellsBlock[0];
        public GlobalDetailObjectBlock[] Instances = new GlobalDetailObjectBlock[0];
        public GlobalDetailObjectCountsBlock[] Counts = new GlobalDetailObjectCountsBlock[0];
        public GlobalZReferenceVectorBlock[] ZReferenceVectors = new GlobalZReferenceVectorBlock[0];
        private byte[] fieldpad = new byte[1];
        private byte[] fieldpad0 = new byte[3];
        public override int SerializedSize
        {
            get
            {
                return 36;
            }
        }
        public override int Alignment
        {
            get
            {
                return 4;
            }
        }
        public override System.Collections.Generic.Queue<Moonfish.Tags.BlamPointer> ReadFields(Moonfish.Guerilla.BlamBinaryReader binaryReader)
        {
            System.Collections.Generic.Queue<Moonfish.Tags.BlamPointer> pointerQueue = new System.Collections.Generic.Queue<Moonfish.Tags.BlamPointer>(base.ReadFields(binaryReader));
            pointerQueue.Enqueue(binaryReader.ReadBlamPointer(32));
            pointerQueue.Enqueue(binaryReader.ReadBlamPointer(6));
            pointerQueue.Enqueue(binaryReader.ReadBlamPointer(2));
            pointerQueue.Enqueue(binaryReader.ReadBlamPointer(16));
            this.fieldpad = binaryReader.ReadBytes(1);
            this.fieldpad0 = binaryReader.ReadBytes(3);
            return pointerQueue;
        }
        public override void ReadInstances(Moonfish.Guerilla.BlamBinaryReader binaryReader, System.Collections.Generic.Queue<Moonfish.Tags.BlamPointer> pointerQueue)
        {
            base.ReadInstances(binaryReader, pointerQueue);
            this.Cells = base.ReadBlockArrayData<GlobalDetailObjectCellsBlock>(binaryReader, pointerQueue.Dequeue());
            this.Instances = base.ReadBlockArrayData<GlobalDetailObjectBlock>(binaryReader, pointerQueue.Dequeue());
            this.Counts = base.ReadBlockArrayData<GlobalDetailObjectCountsBlock>(binaryReader, pointerQueue.Dequeue());
            this.ZReferenceVectors = base.ReadBlockArrayData<GlobalZReferenceVectorBlock>(binaryReader, pointerQueue.Dequeue());
        }
        public override void Defer(Moonfish.Guerilla.QueueableBlamBinaryWriter queueableBinaryWriter)
        {
            base.Defer(queueableBinaryWriter);
            queueableBinaryWriter.Defer(this.Cells);
            queueableBinaryWriter.Defer(this.Instances);
            queueableBinaryWriter.Defer(this.Counts);
            queueableBinaryWriter.Defer(this.ZReferenceVectors);
        }
        public override void Write(Moonfish.Guerilla.QueueableBlamBinaryWriter queueableBinaryWriter)
        {
            base.Write(queueableBinaryWriter);
            queueableBinaryWriter.WritePointer(this.Cells);
            queueableBinaryWriter.WritePointer(this.Instances);
            queueableBinaryWriter.WritePointer(this.Counts);
            queueableBinaryWriter.WritePointer(this.ZReferenceVectors);
            queueableBinaryWriter.Write(this.fieldpad);
            queueableBinaryWriter.Write(this.fieldpad0);
        }
    }
}
