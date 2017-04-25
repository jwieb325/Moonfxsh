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
    [TagBlockOriginalNameAttribute("melee_aim_assist_struct_block")]
    public partial class MeleeAimAssistStructBlock : GuerillaBlock, IWriteQueueable
    {
        /// <summary>
        /// magnetism angle: the maximum angle that magnetism works at full strength
        ///magnetism range: the maximum distance that magnetism works at full strength
        ///throttle magnitude: additional throttle to apply towards target when melee-ing w/ magnetism
        ///throttle minimum distance: minimum distance to target that throttle magnetism kicks in
        ///throttle maximum adjustment angle: maximum angle throttle magnetism will have an effect, relative to the players movement throttle
        /// </summary>
        public float MagnetismAngle;
        public float MagnetismRange;
        public float ThrottleMagnitude;
        public float ThrottleMinimumDistance;
        public float ThrottleMaximumAdjustmentAngle;
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
            this.MagnetismAngle = binaryReader.ReadSingle();
            this.MagnetismRange = binaryReader.ReadSingle();
            this.ThrottleMagnitude = binaryReader.ReadSingle();
            this.ThrottleMinimumDistance = binaryReader.ReadSingle();
            this.ThrottleMaximumAdjustmentAngle = binaryReader.ReadSingle();
            return pointerQueue;
        }
        public override void ReadInstances(Moonfish.Guerilla.BlamBinaryReader binaryReader, System.Collections.Generic.Queue<Moonfish.Tags.BlamPointer> pointerQueue)
        {
            base.ReadInstances(binaryReader, pointerQueue);
        }
        public override void Defer(Moonfish.Guerilla.QueueableBlamBinaryWriter queueableBinaryWriter)
        {
            base.Defer(queueableBinaryWriter);
        }
        public override void Write(Moonfish.Guerilla.QueueableBlamBinaryWriter queueableBinaryWriter)
        {
            base.Write(queueableBinaryWriter);
            queueableBinaryWriter.Write(this.MagnetismAngle);
            queueableBinaryWriter.Write(this.MagnetismRange);
            queueableBinaryWriter.Write(this.ThrottleMagnitude);
            queueableBinaryWriter.Write(this.ThrottleMinimumDistance);
            queueableBinaryWriter.Write(this.ThrottleMaximumAdjustmentAngle);
        }
    }
}
