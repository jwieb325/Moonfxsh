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
    [TagBlockOriginalNameAttribute("character_perception_block")]
    public partial class CharacterPerceptionBlock : GuerillaBlock, IWriteDeferrable
    {
        public PerceptionFlags CharacterPerceptionPerceptionFlags;
        public float MaxVisionDistance;
        public float CentralVisionAngle;
        public float MaxVisionAngle;
        public float PeripheralVisionAngle;
        public float PeripheralDistance;
        public float HearingDistance;
        public float NoticeProjectileChance;
        public float NoticeVehicleChance;
        public float CombatPerceptionTime;
        public float GuardPerceptionTime;
        public float NoncombatPerceptionTime;
        public float FirstAckSurpriseDistance;
        public override int SerializedSize
        {
            get
            {
                return 52;
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
            this.CharacterPerceptionPerceptionFlags = ((PerceptionFlags)(binaryReader.ReadInt32()));
            this.MaxVisionDistance = binaryReader.ReadSingle();
            this.CentralVisionAngle = binaryReader.ReadSingle();
            this.MaxVisionAngle = binaryReader.ReadSingle();
            this.PeripheralVisionAngle = binaryReader.ReadSingle();
            this.PeripheralDistance = binaryReader.ReadSingle();
            this.HearingDistance = binaryReader.ReadSingle();
            this.NoticeProjectileChance = binaryReader.ReadSingle();
            this.NoticeVehicleChance = binaryReader.ReadSingle();
            this.CombatPerceptionTime = binaryReader.ReadSingle();
            this.GuardPerceptionTime = binaryReader.ReadSingle();
            this.NoncombatPerceptionTime = binaryReader.ReadSingle();
            this.FirstAckSurpriseDistance = binaryReader.ReadSingle();
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
            writer.Write(((int)(this.CharacterPerceptionPerceptionFlags)));
            writer.Write(this.MaxVisionDistance);
            writer.Write(this.CentralVisionAngle);
            writer.Write(this.MaxVisionAngle);
            writer.Write(this.PeripheralVisionAngle);
            writer.Write(this.PeripheralDistance);
            writer.Write(this.HearingDistance);
            writer.Write(this.NoticeProjectileChance);
            writer.Write(this.NoticeVehicleChance);
            writer.Write(this.CombatPerceptionTime);
            writer.Write(this.GuardPerceptionTime);
            writer.Write(this.NoncombatPerceptionTime);
            writer.Write(this.FirstAckSurpriseDistance);
        }
        [System.FlagsAttribute()]
        public enum PerceptionFlags : int
        {
            None = 0,
            Flag1 = 1,
        }
    }
}
