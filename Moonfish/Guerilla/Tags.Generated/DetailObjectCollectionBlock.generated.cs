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
    [TagClassAttribute("dobc")]
    [TagBlockOriginalNameAttribute("detail_object_collection_block")]
    public partial class DetailObjectCollectionBlock : GuerillaBlock, IWriteQueueable
    {
        public CollectionTypeEnum CollectionType;
        private byte[] fieldpad = new byte[2];
        public float GlobalZOffset;
        private byte[] fieldpad0 = new byte[44];
        [Moonfish.Tags.TagReferenceAttribute("bitm")]
        public Moonfish.Tags.TagReference SpritePlate;
        public DetailObjectTypeBlock[] Types = new DetailObjectTypeBlock[0];
        private byte[] fieldpad1 = new byte[48];
        public override int SerializedSize
        {
            get
            {
                return 116;
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
            this.CollectionType = ((CollectionTypeEnum)(binaryReader.ReadInt16()));
            this.fieldpad = binaryReader.ReadBytes(2);
            this.GlobalZOffset = binaryReader.ReadSingle();
            this.fieldpad0 = binaryReader.ReadBytes(44);
            this.SpritePlate = binaryReader.ReadTagReference();
            pointerQueue.Enqueue(binaryReader.ReadBlamPointer(96));
            this.fieldpad1 = binaryReader.ReadBytes(48);
            return pointerQueue;
        }
        public override void ReadInstances(Moonfish.Guerilla.BlamBinaryReader binaryReader, System.Collections.Generic.Queue<Moonfish.Tags.BlamPointer> pointerQueue)
        {
            base.ReadInstances(binaryReader, pointerQueue);
            this.Types = base.ReadBlockArrayData<DetailObjectTypeBlock>(binaryReader, pointerQueue.Dequeue());
        }
        public override void Defer(Moonfish.Guerilla.QueueableBlamBinaryWriter queueableBinaryWriter)
        {
            base.Defer(queueableBinaryWriter);
            queueableBinaryWriter.Defer(this.Types);
        }
        public override void Write(Moonfish.Guerilla.QueueableBlamBinaryWriter queueableBinaryWriter)
        {
            base.Write(queueableBinaryWriter);
            queueableBinaryWriter.Write(((short)(this.CollectionType)));
            queueableBinaryWriter.Write(this.fieldpad);
            queueableBinaryWriter.Write(this.GlobalZOffset);
            queueableBinaryWriter.Write(this.fieldpad0);
            queueableBinaryWriter.Write(this.SpritePlate);
            queueableBinaryWriter.WritePointer(this.Types);
            queueableBinaryWriter.Write(this.fieldpad1);
        }
        public enum CollectionTypeEnum : short
        {
            ScreenFacing = 0,
            ViewerFacing = 1,
        }
    }
}
namespace Moonfish.Tags
{
    
    public partial struct TagClass
    {
        public static TagClass Dobc = ((TagClass)("dobc"));
    }
}
