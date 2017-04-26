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
    [TagBlockOriginalNameAttribute("g_default_variants_block")]
    public partial class GDefaultVariantsBlock : GuerillaBlock, IWriteDeferrable
    {
        public Moonfish.Tags.StringIdent VariantName;
        public VariantTypeEnum VariantType;
        public GDefaultVariantSettingsBlock[] Settings = new GDefaultVariantSettingsBlock[0];
        public byte DescriptionIndex;
        private byte[] fieldpad = new byte[3];
        public override int SerializedSize
        {
            get
            {
                return 20;
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
            this.VariantName = binaryReader.ReadStringIdent();
            this.VariantType = ((VariantTypeEnum)(binaryReader.ReadInt32()));
            pointerQueue.Enqueue(binaryReader.ReadBlamPointer(8));
            this.DescriptionIndex = binaryReader.ReadByte();
            this.fieldpad = binaryReader.ReadBytes(3);
            return pointerQueue;
        }
        public override void ReadInstances(Moonfish.Guerilla.BlamBinaryReader binaryReader, System.Collections.Generic.Queue<Moonfish.Tags.BlamPointer> pointerQueue)
        {
            base.ReadInstances(binaryReader, pointerQueue);
            this.Settings = base.ReadBlockArrayData<GDefaultVariantSettingsBlock>(binaryReader, pointerQueue.Dequeue());
        }
        public override void DeferReferences(Moonfish.Guerilla.LinearBinaryWriter writer)
        {
            base.DeferReferences(writer);
            writer.Defer(this.Settings);
        }
        public override void Write(Moonfish.Guerilla.LinearBinaryWriter writer)
        {
            base.Write(writer);
            writer.Write(this.VariantName);
            writer.Write(((int)(this.VariantType)));
            writer.WritePointer(this.Settings);
            writer.Write(this.DescriptionIndex);
            writer.Write(this.fieldpad);
        }
        public enum VariantTypeEnum : int
        {
            Slayer = 0,
            Oddball = 1,
            Juggernaut = 2,
            King = 3,
            Ctf = 4,
            Invasion = 5,
            Territories = 6,
        }
    }
}
