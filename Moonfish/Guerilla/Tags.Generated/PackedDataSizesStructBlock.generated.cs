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
    [TagBlockOriginalNameAttribute("packed_data_sizes_struct_block")]
    public partial class PackedDataSizesStructBlock : GuerillaBlock, IWriteDeferrable
    {
        public byte FieldCharInteger;
        public byte FieldCharInteger0;
        public short FieldShortInteger;
        public short FieldShortInteger0;
        public short FieldShortInteger1;
        public int FieldLongInteger;
        public int FieldLongInteger0;
        public override int SerializedSize
        {
            get
            {
                return 16;
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
            this.FieldCharInteger = binaryReader.ReadByte();
            this.FieldCharInteger0 = binaryReader.ReadByte();
            this.FieldShortInteger = binaryReader.ReadInt16();
            this.FieldShortInteger0 = binaryReader.ReadInt16();
            this.FieldShortInteger1 = binaryReader.ReadInt16();
            this.FieldLongInteger = binaryReader.ReadInt32();
            this.FieldLongInteger0 = binaryReader.ReadInt32();
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
            writer.Write(this.FieldCharInteger);
            writer.Write(this.FieldCharInteger0);
            writer.Write(this.FieldShortInteger);
            writer.Write(this.FieldShortInteger0);
            writer.Write(this.FieldShortInteger1);
            writer.Write(this.FieldLongInteger);
            writer.Write(this.FieldLongInteger0);
        }
    }
}
