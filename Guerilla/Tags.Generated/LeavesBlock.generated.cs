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
    using Moonfish.Tags;
    using Moonfish.Model;
    using System.IO;
    using System.Collections.Generic;
    using System.Linq;
    
    [TagBlockOriginalNameAttribute("leaves_block")]
    public partial class LeavesBlock : GuerillaBlock, IWriteQueueable
    {
        public Flags LeavesFlags;
        public byte BSP2DReferenceCount;
        public short FirstBSP2DReference;
        public override int SerializedSize
        {
            get
            {
                return 4;
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
            this.LeavesFlags = ((Flags)(binaryReader.ReadByte()));
            this.BSP2DReferenceCount = binaryReader.ReadByte();
            this.FirstBSP2DReference = binaryReader.ReadInt16();
            return pointerQueue;
        }
        public override void ReadInstances(System.IO.BinaryReader binaryReader, System.Collections.Generic.Queue<Moonfish.Tags.BlamPointer> pointerQueue)
        {
            base.ReadInstances(binaryReader, pointerQueue);
        }
        public override void QueueWrites(Moonfish.Guerilla.QueueableBinaryWriter queueableBinaryWriter)
        {
            base.QueueWrites(queueableBinaryWriter);
        }
        public override void Write_(Moonfish.Guerilla.QueueableBinaryWriter queueableBinaryWriter)
        {
            base.Write_(queueableBinaryWriter);
            queueableBinaryWriter.Write(((byte)(this.LeavesFlags)));
            queueableBinaryWriter.Write(this.BSP2DReferenceCount);
            queueableBinaryWriter.Write(this.FirstBSP2DReference);
        }
        [System.FlagsAttribute()]
        public enum Flags : byte
        {
            None = 0,
            ContainsDoubleSidedSurfaces = 1,
        }
    }
}
