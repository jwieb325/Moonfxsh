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
    [TagClassAttribute("clwd")]
    [TagBlockOriginalNameAttribute("cloth_block")]
    public partial class ClothBlock : GuerillaBlock, IWriteQueueable
    {
        public Flags ClothFlags;
        public Moonfish.Tags.StringIdent MarkerAttachmentName;
        [Moonfish.Tags.TagReferenceAttribute("shad")]
        public Moonfish.Tags.TagReference Shader;
        /// <summary>
        /// if not importing from a render model, type a grid size
        /// </summary>
        public short GridXDimension;
        public short GridYDimension;
        public float GridSpacingX;
        public float GridSpacingY;
        public ClothPropertiesBlock Properties = new ClothPropertiesBlock();
        public ClothVerticesBlock[] Vertices = new ClothVerticesBlock[0];
        public ClothIndicesBlock[] Indices = new ClothIndicesBlock[0];
        public ClothIndicesBlock[] StripIndices = new ClothIndicesBlock[0];
        public ClothLinksBlock[] Links = new ClothLinksBlock[0];
        public override int SerializedSize
        {
            get
            {
                return 108;
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
            this.ClothFlags = ((Flags)(binaryReader.ReadInt32()));
            this.MarkerAttachmentName = binaryReader.ReadStringIdent();
            this.Shader = binaryReader.ReadTagReference();
            this.GridXDimension = binaryReader.ReadInt16();
            this.GridYDimension = binaryReader.ReadInt16();
            this.GridSpacingX = binaryReader.ReadSingle();
            this.GridSpacingY = binaryReader.ReadSingle();
            pointerQueue = new System.Collections.Generic.Queue<Moonfish.Tags.BlamPointer>(pointerQueue.Concat(this.Properties.ReadFields(binaryReader)));
            pointerQueue.Enqueue(binaryReader.ReadBlamPointer(20));
            pointerQueue.Enqueue(binaryReader.ReadBlamPointer(2));
            pointerQueue.Enqueue(binaryReader.ReadBlamPointer(2));
            pointerQueue.Enqueue(binaryReader.ReadBlamPointer(16));
            return pointerQueue;
        }
        public override void ReadInstances(Moonfish.Guerilla.BlamBinaryReader binaryReader, System.Collections.Generic.Queue<Moonfish.Tags.BlamPointer> pointerQueue)
        {
            base.ReadInstances(binaryReader, pointerQueue);
            this.Properties.ReadInstances(binaryReader, pointerQueue);
            this.Vertices = base.ReadBlockArrayData<ClothVerticesBlock>(binaryReader, pointerQueue.Dequeue());
            this.Indices = base.ReadBlockArrayData<ClothIndicesBlock>(binaryReader, pointerQueue.Dequeue());
            this.StripIndices = base.ReadBlockArrayData<ClothIndicesBlock>(binaryReader, pointerQueue.Dequeue());
            this.Links = base.ReadBlockArrayData<ClothLinksBlock>(binaryReader, pointerQueue.Dequeue());
        }
        public override void Defer(Moonfish.Guerilla.QueueableBlamBinaryWriter queueableBinaryWriter)
        {
            base.Defer(queueableBinaryWriter);
            this.Properties.Defer(queueableBinaryWriter);
            queueableBinaryWriter.Defer(this.Vertices);
            queueableBinaryWriter.Defer(this.Indices);
            queueableBinaryWriter.Defer(this.StripIndices);
            queueableBinaryWriter.Defer(this.Links);
        }
        public override void Write(Moonfish.Guerilla.QueueableBlamBinaryWriter queueableBinaryWriter)
        {
            base.Write(queueableBinaryWriter);
            queueableBinaryWriter.Write(((int)(this.ClothFlags)));
            queueableBinaryWriter.Write(this.MarkerAttachmentName);
            queueableBinaryWriter.Write(this.Shader);
            queueableBinaryWriter.Write(this.GridXDimension);
            queueableBinaryWriter.Write(this.GridYDimension);
            queueableBinaryWriter.Write(this.GridSpacingX);
            queueableBinaryWriter.Write(this.GridSpacingY);
            this.Properties.Write(queueableBinaryWriter);
            queueableBinaryWriter.WritePointer(this.Vertices);
            queueableBinaryWriter.WritePointer(this.Indices);
            queueableBinaryWriter.WritePointer(this.StripIndices);
            queueableBinaryWriter.WritePointer(this.Links);
        }
        [System.FlagsAttribute()]
        public enum Flags : int
        {
            None = 0,
            DoesntUseWind = 1,
            UsesGridAttachTop = 2,
        }
    }
}
namespace Moonfish.Tags
{
    
    public partial struct TagClass
    {
        public static TagClass Clwd = ((TagClass)("clwd"));
    }
}
