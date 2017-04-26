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
    [TagBlockOriginalNameAttribute("sound_gestalt_promotions_block")]
    public partial class SoundGestaltPromotionsBlock : GuerillaBlock, IWriteDeferrable
    {
        public SoundPromotionRuleBlock[] SoundPromotionRules = new SoundPromotionRuleBlock[0];
        public SoundPromotionRuntimeTimerBlock[] SoundPromotionRuntimeTimers = new SoundPromotionRuntimeTimerBlock[0];
        private byte[] fieldpad = new byte[12];
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
            this.fieldpad = binaryReader.ReadBytes(12);
            return pointerQueue;
        }
        public override void ReadInstances(Moonfish.Guerilla.BlamBinaryReader binaryReader, System.Collections.Generic.Queue<Moonfish.Tags.BlamPointer> pointerQueue)
        {
            base.ReadInstances(binaryReader, pointerQueue);
            this.SoundPromotionRules = base.ReadBlockArrayData<SoundPromotionRuleBlock>(binaryReader, pointerQueue.Dequeue());
            this.SoundPromotionRuntimeTimers = base.ReadBlockArrayData<SoundPromotionRuntimeTimerBlock>(binaryReader, pointerQueue.Dequeue());
        }
        public override void DeferReferences(Moonfish.Guerilla.LinearBinaryWriter writer)
        {
            base.DeferReferences(writer);
            writer.Defer(this.SoundPromotionRules);
            writer.Defer(this.SoundPromotionRuntimeTimers);
        }
        public override void Write(Moonfish.Guerilla.LinearBinaryWriter writer)
        {
            base.Write(writer);
            writer.WritePointer(this.SoundPromotionRules);
            writer.WritePointer(this.SoundPromotionRuntimeTimers);
            writer.Write(this.fieldpad);
        }
    }
}
