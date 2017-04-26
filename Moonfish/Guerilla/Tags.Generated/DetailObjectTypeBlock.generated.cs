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
    using Moonfish.Guerilla;
    using System.IO;
    using System.Collections.Generic;
    using System.Linq;
    
    [JetBrains.Annotations.UsedImplicitlyAttribute(ImplicitUseTargetFlags.WithMembers)]
    [TagBlockOriginalNameAttribute("detail_object_type_block")]
    public partial class DetailObjectTypeBlock : GuerillaBlock, IWriteDeferrable
    {
        public Moonfish.Tags.String32 Name;
        public byte SequenceIndex;
        public TypeFlags DetailObjectTypeTypeFlags;
        private byte[] fieldpad = new byte[2];
        public float ColorOverrideFactor;
        private byte[] fieldpad0 = new byte[8];
        public float NearFadeDistance;
        public float FarFadeDistance;
        public float Size;
        private byte[] fieldpad1 = new byte[4];
        public Moonfish.Tags.ColourR8G8B8 MinimumColor;
        public Moonfish.Tags.ColourR8G8B8 MaximumColor;
        public Moonfish.Tags.ColourA1R1G1B1 AmbientColor;
        private byte[] fieldpad2 = new byte[4];
        public override int SerializedSize
        {
            get
            {
                return 96;
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
            this.Name = binaryReader.ReadString32();
            this.SequenceIndex = binaryReader.ReadByte();
            this.DetailObjectTypeTypeFlags = ((TypeFlags)(binaryReader.ReadByte()));
            this.fieldpad = binaryReader.ReadBytes(2);
            this.ColorOverrideFactor = binaryReader.ReadSingle();
            this.fieldpad0 = binaryReader.ReadBytes(8);
            this.NearFadeDistance = binaryReader.ReadSingle();
            this.FarFadeDistance = binaryReader.ReadSingle();
            this.Size = binaryReader.ReadSingle();
            this.fieldpad1 = binaryReader.ReadBytes(4);
            this.MinimumColor = binaryReader.ReadColourR8G8B8();
            this.MaximumColor = binaryReader.ReadColourR8G8B8();
            this.AmbientColor = binaryReader.ReadColourA1R1G1B1();
            this.fieldpad2 = binaryReader.ReadBytes(4);
            return pointerQueue;
        }
        public override void ReadInstances(Moonfish.Guerilla.BlamBinaryReader binaryReader, System.Collections.Generic.Queue<Moonfish.Tags.BlamPointer> pointerQueue)
        {
            base.ReadInstances(binaryReader, pointerQueue);
        }
        public override void DeferReferences(Moonfish.Guerilla.LinearBinaryWriter writer)
        {
            base.DeferReferences(writer);
        }
        public override void Write(Moonfish.Guerilla.LinearBinaryWriter writer)
        {
            base.Write(writer);
            writer.Write(this.Name);
            writer.Write(this.SequenceIndex);
            writer.Write(((byte)(this.DetailObjectTypeTypeFlags)));
            writer.Write(this.fieldpad);
            writer.Write(this.ColorOverrideFactor);
            writer.Write(this.fieldpad0);
            writer.Write(this.NearFadeDistance);
            writer.Write(this.FarFadeDistance);
            writer.Write(this.Size);
            writer.Write(this.fieldpad1);
            writer.Write(this.MinimumColor);
            writer.Write(this.MaximumColor);
            writer.Write(this.AmbientColor);
            writer.Write(this.fieldpad2);
        }
        [System.FlagsAttribute()]
        public enum TypeFlags : byte
        {
            None = 0,
            Unused = 1,
            Unused0 = 2,
            InterpolateColorInHSV = 4,
            MoreColors = 8,
        }
    }
}
