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
    [TagBlockOriginalNameAttribute("model_variant_permutation_block")]
    public partial class ModelVariantPermutationBlock : GuerillaBlock, IWriteDeferrable
    {
        public Moonfish.Tags.StringIdent PermutationName;
        private byte[] fieldpad = new byte[1];
        public Flags ModelVariantPermutationFlags;
        private byte[] fieldpad0 = new byte[2];
        public float Probability;
        public ModelVariantStateBlock[] States = new ModelVariantStateBlock[0];
        private byte[] fieldpad1 = new byte[5];
        private byte[] fieldpad2 = new byte[7];
        public override int SerializedSize
        {
            get
            {
                return 32;
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
            this.PermutationName = binaryReader.ReadStringIdent();
            this.fieldpad = binaryReader.ReadBytes(1);
            this.ModelVariantPermutationFlags = ((Flags)(binaryReader.ReadByte()));
            this.fieldpad0 = binaryReader.ReadBytes(2);
            this.Probability = binaryReader.ReadSingle();
            pointerQueue.Enqueue(binaryReader.ReadBlamPointer(24));
            this.fieldpad1 = binaryReader.ReadBytes(5);
            this.fieldpad2 = binaryReader.ReadBytes(7);
            return pointerQueue;
        }
        public override void ReadInstances(Moonfish.Guerilla.BlamBinaryReader binaryReader, System.Collections.Generic.Queue<Moonfish.Tags.BlamPointer> pointerQueue)
        {
            base.ReadInstances(binaryReader, pointerQueue);
            this.States = base.ReadBlockArrayData<ModelVariantStateBlock>(binaryReader, pointerQueue.Dequeue());
        }
        public override void DeferReferences(Moonfish.Guerilla.LinearBinaryWriter writer)
        {
            base.DeferReferences(writer);
            writer.Defer(this.States);
        }
        public override void Write(Moonfish.Guerilla.LinearBinaryWriter writer)
        {
            base.Write(writer);
            writer.Write(this.PermutationName);
            writer.Write(this.fieldpad);
            writer.Write(((byte)(this.ModelVariantPermutationFlags)));
            writer.Write(this.fieldpad0);
            writer.Write(this.Probability);
            writer.WritePointer(this.States);
            writer.Write(this.fieldpad1);
            writer.Write(this.fieldpad2);
        }
        [System.FlagsAttribute()]
        public enum Flags : byte
        {
            None = 0,
            CopyStatesToAllPermutations = 1,
        }
    }
}
