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
    [TagBlockOriginalNameAttribute("sound_effect_templates_block")]
    public partial class SoundEffectTemplatesBlock : GuerillaBlock, IWriteDeferrable
    {
        public Moonfish.Tags.StringIdent DspEffect;
        /// <summary>
        /// DON'T MODIFY THIS TAG UNLESS YOU KNOW WHAT YOU ARE DOING
        /// </summary>
        private byte[] Explanation;
        public Flags SoundEffectTemplatesFlags;
        public short FieldShortInteger;
        public short FieldShortInteger0;
        public SoundEffectTemplateParameterBlock[] Parameters = new SoundEffectTemplateParameterBlock[0];
        public override int SerializedSize
        {
            get
            {
                return 28;
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
            this.DspEffect = binaryReader.ReadStringIdent();
            pointerQueue.Enqueue(binaryReader.ReadBlamPointer(1));
            this.SoundEffectTemplatesFlags = ((Flags)(binaryReader.ReadInt32()));
            this.FieldShortInteger = binaryReader.ReadInt16();
            this.FieldShortInteger0 = binaryReader.ReadInt16();
            pointerQueue.Enqueue(binaryReader.ReadBlamPointer(36));
            return pointerQueue;
        }
        public override void ReadInstances(Moonfish.Guerilla.BlamBinaryReader binaryReader, System.Collections.Generic.Queue<Moonfish.Tags.BlamPointer> pointerQueue)
        {
            base.ReadInstances(binaryReader, pointerQueue);
            this.Explanation = base.ReadDataByteArray(binaryReader, pointerQueue.Dequeue());
            this.Parameters = base.ReadBlockArrayData<SoundEffectTemplateParameterBlock>(binaryReader, pointerQueue.Dequeue());
        }
        public override void DeferReferences(Moonfish.Guerilla.LinearBinaryWriter writer)
        {
            base.DeferReferences(writer);
            writer.Defer(this.Explanation);
            writer.Defer(this.Parameters);
        }
        public override void Write(Moonfish.Guerilla.LinearBinaryWriter writer)
        {
            base.Write(writer);
            writer.Write(this.DspEffect);
            writer.WritePointer(this.Explanation);
            writer.Write(((int)(this.SoundEffectTemplatesFlags)));
            writer.Write(this.FieldShortInteger);
            writer.Write(this.FieldShortInteger0);
            writer.WritePointer(this.Parameters);
        }
        [System.FlagsAttribute()]
        public enum Flags : int
        {
            None = 0,
            UseHighLevelParameters = 1,
            CustomParameters = 2,
        }
    }
}
