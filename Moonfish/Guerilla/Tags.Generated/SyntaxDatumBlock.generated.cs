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
    [TagBlockOriginalNameAttribute("syntax_datum_block")]
    public partial class SyntaxDatumBlock : GuerillaBlock, IWriteDeferrable
    {
        public short DatumHeader;
        public short ScriptIndexFunctionIndexConstantTypeUnion;
        public short Type;
        public short Flags;
        public int NextNodeIndex;
        public int Data;
        public int SourceOffset;
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
            this.DatumHeader = binaryReader.ReadInt16();
            this.ScriptIndexFunctionIndexConstantTypeUnion = binaryReader.ReadInt16();
            this.Type = binaryReader.ReadInt16();
            this.Flags = binaryReader.ReadInt16();
            this.NextNodeIndex = binaryReader.ReadInt32();
            this.Data = binaryReader.ReadInt32();
            this.SourceOffset = binaryReader.ReadInt32();
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
            writer.Write(this.DatumHeader);
            writer.Write(this.ScriptIndexFunctionIndexConstantTypeUnion);
            writer.Write(this.Type);
            writer.Write(this.Flags);
            writer.Write(this.NextNodeIndex);
            writer.Write(this.Data);
            writer.Write(this.SourceOffset);
        }
    }
}
