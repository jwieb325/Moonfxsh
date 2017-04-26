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
    [TagBlockOriginalNameAttribute("platform_sound_effect_block")]
    public partial class PlatformSoundEffectBlock : GuerillaBlock, IWriteDeferrable
    {
        public PlatformSoundEffectFunctionBlock[] FunctionInputs = new PlatformSoundEffectFunctionBlock[0];
        public PlatformSoundEffectConstantBlock[] ConstantInputs = new PlatformSoundEffectConstantBlock[0];
        public PlatformSoundEffectOverrideDescriptorBlock[] TemplateOverrideDescriptors = new PlatformSoundEffectOverrideDescriptorBlock[0];
        public int InputOverrides;
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
            pointerQueue.Enqueue(binaryReader.ReadBlamPointer(16));
            pointerQueue.Enqueue(binaryReader.ReadBlamPointer(4));
            pointerQueue.Enqueue(binaryReader.ReadBlamPointer(1));
            this.InputOverrides = binaryReader.ReadInt32();
            return pointerQueue;
        }
        public override void ReadInstances(Moonfish.Guerilla.BlamBinaryReader binaryReader, System.Collections.Generic.Queue<Moonfish.Tags.BlamPointer> pointerQueue)
        {
            base.ReadInstances(binaryReader, pointerQueue);
            this.FunctionInputs = base.ReadBlockArrayData<PlatformSoundEffectFunctionBlock>(binaryReader, pointerQueue.Dequeue());
            this.ConstantInputs = base.ReadBlockArrayData<PlatformSoundEffectConstantBlock>(binaryReader, pointerQueue.Dequeue());
            this.TemplateOverrideDescriptors = base.ReadBlockArrayData<PlatformSoundEffectOverrideDescriptorBlock>(binaryReader, pointerQueue.Dequeue());
        }
        public override void DeferReferences(Moonfish.Guerilla.LinearBinaryWriter writer)
        {
            base.DeferReferences(writer);
            writer.Defer(this.FunctionInputs);
            writer.Defer(this.ConstantInputs);
            writer.Defer(this.TemplateOverrideDescriptors);
        }
        public override void Write(Moonfish.Guerilla.LinearBinaryWriter writer)
        {
            base.Write(writer);
            writer.WritePointer(this.FunctionInputs);
            writer.WritePointer(this.ConstantInputs);
            writer.WritePointer(this.TemplateOverrideDescriptors);
            writer.Write(this.InputOverrides);
        }
    }
}
