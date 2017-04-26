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
    [TagClassAttribute("devo")]
    [TagBlockOriginalNameAttribute("cellular_automata_block")]
    public partial class CellularAutomataBlock : GuerillaBlock, IWriteDeferrable
    {
        public short UpdatesPerSecond;
        public short X;
        public short Y;
        public short Z;
        public float X0;
        public float Y0;
        public float Z0;
        private byte[] fieldpad = new byte[32];
        public Moonfish.Tags.StringIdent Marker;
        public float CellBirthChance;
        private byte[] fieldpad0 = new byte[32];
        public int CellGeneMutates1In;
        public int VirusGeneMutations1In;
        private byte[] fieldpad1 = new byte[32];
        public int InfectedCellLifespan;
        public short MinimumInfectionAge;
        private byte[] fieldpad2 = new byte[2];
        public float CellInfectionChance;
        public float InfectionThreshold;
        private byte[] fieldpad3 = new byte[32];
        public float NewCellFilledChance;
        public float NewCellInfectedChance;
        private byte[] fieldpad4 = new byte[32];
        public float DetailTextureChangeChance;
        private byte[] fieldpad5 = new byte[32];
        public short DetailTextureWidth;
        private byte[] fieldpad6 = new byte[2];
        [Moonfish.Tags.TagReferenceAttribute("bitm")]
        public Moonfish.Tags.TagReference DetailTexture;
        private byte[] fieldpad7 = new byte[32];
        [Moonfish.Tags.TagReferenceAttribute("bitm")]
        public Moonfish.Tags.TagReference MaskBitmap;
        private byte[] fieldpad8 = new byte[240];
        public override int SerializedSize
        {
            get
            {
                return 548;
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
            this.UpdatesPerSecond = binaryReader.ReadInt16();
            this.X = binaryReader.ReadInt16();
            this.Y = binaryReader.ReadInt16();
            this.Z = binaryReader.ReadInt16();
            this.X0 = binaryReader.ReadSingle();
            this.Y0 = binaryReader.ReadSingle();
            this.Z0 = binaryReader.ReadSingle();
            this.fieldpad = binaryReader.ReadBytes(32);
            this.Marker = binaryReader.ReadStringIdent();
            this.CellBirthChance = binaryReader.ReadSingle();
            this.fieldpad0 = binaryReader.ReadBytes(32);
            this.CellGeneMutates1In = binaryReader.ReadInt32();
            this.VirusGeneMutations1In = binaryReader.ReadInt32();
            this.fieldpad1 = binaryReader.ReadBytes(32);
            this.InfectedCellLifespan = binaryReader.ReadInt32();
            this.MinimumInfectionAge = binaryReader.ReadInt16();
            this.fieldpad2 = binaryReader.ReadBytes(2);
            this.CellInfectionChance = binaryReader.ReadSingle();
            this.InfectionThreshold = binaryReader.ReadSingle();
            this.fieldpad3 = binaryReader.ReadBytes(32);
            this.NewCellFilledChance = binaryReader.ReadSingle();
            this.NewCellInfectedChance = binaryReader.ReadSingle();
            this.fieldpad4 = binaryReader.ReadBytes(32);
            this.DetailTextureChangeChance = binaryReader.ReadSingle();
            this.fieldpad5 = binaryReader.ReadBytes(32);
            this.DetailTextureWidth = binaryReader.ReadInt16();
            this.fieldpad6 = binaryReader.ReadBytes(2);
            this.DetailTexture = binaryReader.ReadTagReference();
            this.fieldpad7 = binaryReader.ReadBytes(32);
            this.MaskBitmap = binaryReader.ReadTagReference();
            this.fieldpad8 = binaryReader.ReadBytes(240);
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
            writer.Write(this.UpdatesPerSecond);
            writer.Write(this.X);
            writer.Write(this.Y);
            writer.Write(this.Z);
            writer.Write(this.X0);
            writer.Write(this.Y0);
            writer.Write(this.Z0);
            writer.Write(this.fieldpad);
            writer.Write(this.Marker);
            writer.Write(this.CellBirthChance);
            writer.Write(this.fieldpad0);
            writer.Write(this.CellGeneMutates1In);
            writer.Write(this.VirusGeneMutations1In);
            writer.Write(this.fieldpad1);
            writer.Write(this.InfectedCellLifespan);
            writer.Write(this.MinimumInfectionAge);
            writer.Write(this.fieldpad2);
            writer.Write(this.CellInfectionChance);
            writer.Write(this.InfectionThreshold);
            writer.Write(this.fieldpad3);
            writer.Write(this.NewCellFilledChance);
            writer.Write(this.NewCellInfectedChance);
            writer.Write(this.fieldpad4);
            writer.Write(this.DetailTextureChangeChance);
            writer.Write(this.fieldpad5);
            writer.Write(this.DetailTextureWidth);
            writer.Write(this.fieldpad6);
            writer.Write(this.DetailTexture);
            writer.Write(this.fieldpad7);
            writer.Write(this.MaskBitmap);
            writer.Write(this.fieldpad8);
        }
    }
}
namespace Moonfish.Tags
{
    
    public partial struct TagClass
    {
        public static TagClass Devo = ((TagClass)("devo"));
    }
}
