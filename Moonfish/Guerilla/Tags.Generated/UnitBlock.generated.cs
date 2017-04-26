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
    [TagClassAttribute("unit")]
    [TagBlockOriginalNameAttribute("unit_block")]
    public partial class UnitBlock : ObjectBlock, IWriteDeferrable
    {
        public UnitFlags UnitUnitFlags;
        public DefaultTeamEnum DefaultTeam;
        public ConstantSoundVolumeEnum ConstantSoundVolume;
        [Moonfish.Tags.TagReferenceAttribute("effe")]
        public Moonfish.Tags.TagReference IntegratedLightToggle;
        public float CameraFieldOfView;
        public float CameraStiffness;
        public UnitCameraStructBlock UnitCamera = new UnitCameraStructBlock();
        public UnitSeatAccelerationStructBlock Acceleration = new UnitSeatAccelerationStructBlock();
        public float SoftPingThreshold;
        public float SoftPingInterruptTime;
        public float HardPingThreshold;
        public float HardPingInterruptTime;
        public float HardDeathThreshold;
        public float FeignDeathThreshold;
        public float FeignDeathTime;
        public float DistanceOfEvadeAnim;
        public float DistanceOfDiveAnim;
        public float StunnedMovementThreshold;
        public float FeignDeathChance;
        public float FeignRepeatChance;
        [Moonfish.Tags.TagReferenceAttribute("char")]
        public Moonfish.Tags.TagReference SpawnedTurretCharacter;
        public int SpawnedActorCount;
        public float SpawnedVelocity;
        public float AimingVelocityMaximum;
        public float AimingAccelerationMaximum;
        public float CasualAimingModifier;
        public float LookingVelocityMaximum;
        public float LookingAccelerationMaximum;
        public Moonfish.Tags.StringIdent RightHandNode;
        public Moonfish.Tags.StringIdent LeftHandNode;
        public UnitAdditionalNodeNamesStructBlock MoreDamnNodes = new UnitAdditionalNodeNamesStructBlock();
        [Moonfish.Tags.TagReferenceAttribute("jpt!")]
        public Moonfish.Tags.TagReference MeleeDamage;
        public UnitBoardingMeleeStructBlock YourMomma = new UnitBoardingMeleeStructBlock();
        public MotionSensorBlipSizeEnum MotionSensorBlipSize;
        private byte[] fieldpad3 = new byte[2];
        public UnitPosturesBlock[] Postures = new UnitPosturesBlock[0];
        public UnitHudReferenceBlock[] NEWHUDINTERFACES = new UnitHudReferenceBlock[0];
        public DialogueVariantBlock[] DialogueVariants = new DialogueVariantBlock[0];
        public float GrenadeVelocity;
        public GrenadeTypeEnum GrenadeType;
        public short GrenadeCount;
        public PoweredSeatBlock[] PoweredSeats = new PoweredSeatBlock[0];
        public UnitWeaponBlock[] Weapons = new UnitWeaponBlock[0];
        public UnitSeatBlock[] Seats = new UnitSeatBlock[0];
        public UnitBoostStructBlock Boost = new UnitBoostStructBlock();
        public UnitLipsyncScalesStructBlock Lipsync = new UnitLipsyncScalesStructBlock();
        public override int SerializedSize
        {
            get
            {
                return 492;
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
            this.UnitUnitFlags = ((UnitFlags)(binaryReader.ReadInt32()));
            this.DefaultTeam = ((DefaultTeamEnum)(binaryReader.ReadInt16()));
            this.ConstantSoundVolume = ((ConstantSoundVolumeEnum)(binaryReader.ReadInt16()));
            this.IntegratedLightToggle = binaryReader.ReadTagReference();
            this.CameraFieldOfView = binaryReader.ReadSingle();
            this.CameraStiffness = binaryReader.ReadSingle();
            pointerQueue = new System.Collections.Generic.Queue<Moonfish.Tags.BlamPointer>(pointerQueue.Concat(this.UnitCamera.ReadFields(binaryReader)));
            pointerQueue = new System.Collections.Generic.Queue<Moonfish.Tags.BlamPointer>(pointerQueue.Concat(this.Acceleration.ReadFields(binaryReader)));
            this.SoftPingThreshold = binaryReader.ReadSingle();
            this.SoftPingInterruptTime = binaryReader.ReadSingle();
            this.HardPingThreshold = binaryReader.ReadSingle();
            this.HardPingInterruptTime = binaryReader.ReadSingle();
            this.HardDeathThreshold = binaryReader.ReadSingle();
            this.FeignDeathThreshold = binaryReader.ReadSingle();
            this.FeignDeathTime = binaryReader.ReadSingle();
            this.DistanceOfEvadeAnim = binaryReader.ReadSingle();
            this.DistanceOfDiveAnim = binaryReader.ReadSingle();
            this.StunnedMovementThreshold = binaryReader.ReadSingle();
            this.FeignDeathChance = binaryReader.ReadSingle();
            this.FeignRepeatChance = binaryReader.ReadSingle();
            this.SpawnedTurretCharacter = binaryReader.ReadTagReference();
            this.SpawnedActorCount = binaryReader.ReadInt32();
            this.SpawnedVelocity = binaryReader.ReadSingle();
            this.AimingVelocityMaximum = binaryReader.ReadSingle();
            this.AimingAccelerationMaximum = binaryReader.ReadSingle();
            this.CasualAimingModifier = binaryReader.ReadSingle();
            this.LookingVelocityMaximum = binaryReader.ReadSingle();
            this.LookingAccelerationMaximum = binaryReader.ReadSingle();
            this.RightHandNode = binaryReader.ReadStringIdent();
            this.LeftHandNode = binaryReader.ReadStringIdent();
            pointerQueue = new System.Collections.Generic.Queue<Moonfish.Tags.BlamPointer>(pointerQueue.Concat(this.MoreDamnNodes.ReadFields(binaryReader)));
            this.MeleeDamage = binaryReader.ReadTagReference();
            pointerQueue = new System.Collections.Generic.Queue<Moonfish.Tags.BlamPointer>(pointerQueue.Concat(this.YourMomma.ReadFields(binaryReader)));
            this.MotionSensorBlipSize = ((MotionSensorBlipSizeEnum)(binaryReader.ReadInt16()));
            this.fieldpad3 = binaryReader.ReadBytes(2);
            pointerQueue.Enqueue(binaryReader.ReadBlamPointer(16));
            pointerQueue.Enqueue(binaryReader.ReadBlamPointer(8));
            pointerQueue.Enqueue(binaryReader.ReadBlamPointer(12));
            this.GrenadeVelocity = binaryReader.ReadSingle();
            this.GrenadeType = ((GrenadeTypeEnum)(binaryReader.ReadInt16()));
            this.GrenadeCount = binaryReader.ReadInt16();
            pointerQueue.Enqueue(binaryReader.ReadBlamPointer(8));
            pointerQueue.Enqueue(binaryReader.ReadBlamPointer(8));
            pointerQueue.Enqueue(binaryReader.ReadBlamPointer(176));
            pointerQueue = new System.Collections.Generic.Queue<Moonfish.Tags.BlamPointer>(pointerQueue.Concat(this.Boost.ReadFields(binaryReader)));
            pointerQueue = new System.Collections.Generic.Queue<Moonfish.Tags.BlamPointer>(pointerQueue.Concat(this.Lipsync.ReadFields(binaryReader)));
            return pointerQueue;
        }
        public override void ReadInstances(Moonfish.Guerilla.BlamBinaryReader binaryReader, System.Collections.Generic.Queue<Moonfish.Tags.BlamPointer> pointerQueue)
        {
            base.ReadInstances(binaryReader, pointerQueue);
            this.UnitCamera.ReadInstances(binaryReader, pointerQueue);
            this.Acceleration.ReadInstances(binaryReader, pointerQueue);
            this.MoreDamnNodes.ReadInstances(binaryReader, pointerQueue);
            this.YourMomma.ReadInstances(binaryReader, pointerQueue);
            this.Postures = base.ReadBlockArrayData<UnitPosturesBlock>(binaryReader, pointerQueue.Dequeue());
            this.NEWHUDINTERFACES = base.ReadBlockArrayData<UnitHudReferenceBlock>(binaryReader, pointerQueue.Dequeue());
            this.DialogueVariants = base.ReadBlockArrayData<DialogueVariantBlock>(binaryReader, pointerQueue.Dequeue());
            this.PoweredSeats = base.ReadBlockArrayData<PoweredSeatBlock>(binaryReader, pointerQueue.Dequeue());
            this.Weapons = base.ReadBlockArrayData<UnitWeaponBlock>(binaryReader, pointerQueue.Dequeue());
            this.Seats = base.ReadBlockArrayData<UnitSeatBlock>(binaryReader, pointerQueue.Dequeue());
            this.Boost.ReadInstances(binaryReader, pointerQueue);
            this.Lipsync.ReadInstances(binaryReader, pointerQueue);
        }
        public override void DeferReferences(Moonfish.Guerilla.LinearBinaryWriter writer)
        {
            base.DeferReferences(writer);
            this.UnitCamera.DeferReferences(writer);
            this.UnitCamera.DeferReferences(writer);
            this.Acceleration.DeferReferences(writer);
            this.Acceleration.DeferReferences(writer);
            this.MoreDamnNodes.DeferReferences(writer);
            this.MoreDamnNodes.DeferReferences(writer);
            this.YourMomma.DeferReferences(writer);
            this.YourMomma.DeferReferences(writer);
            writer.Defer(this.Postures);
            writer.Defer(this.NEWHUDINTERFACES);
            writer.Defer(this.DialogueVariants);
            writer.Defer(this.PoweredSeats);
            writer.Defer(this.Weapons);
            writer.Defer(this.Seats);
            this.Boost.DeferReferences(writer);
            this.Boost.DeferReferences(writer);
            this.Lipsync.DeferReferences(writer);
            this.Lipsync.DeferReferences(writer);
        }
        public override void Write(Moonfish.Guerilla.LinearBinaryWriter writer)
        {
            base.Write(writer);
            writer.Write(((int)(this.UnitUnitFlags)));
            writer.Write(((short)(this.DefaultTeam)));
            writer.Write(((short)(this.ConstantSoundVolume)));
            writer.Write(this.IntegratedLightToggle);
            writer.Write(this.CameraFieldOfView);
            writer.Write(this.CameraStiffness);
            this.UnitCamera.Write(writer);
            this.Acceleration.Write(writer);
            writer.Write(this.SoftPingThreshold);
            writer.Write(this.SoftPingInterruptTime);
            writer.Write(this.HardPingThreshold);
            writer.Write(this.HardPingInterruptTime);
            writer.Write(this.HardDeathThreshold);
            writer.Write(this.FeignDeathThreshold);
            writer.Write(this.FeignDeathTime);
            writer.Write(this.DistanceOfEvadeAnim);
            writer.Write(this.DistanceOfDiveAnim);
            writer.Write(this.StunnedMovementThreshold);
            writer.Write(this.FeignDeathChance);
            writer.Write(this.FeignRepeatChance);
            writer.Write(this.SpawnedTurretCharacter);
            writer.Write(this.SpawnedActorCount);
            writer.Write(this.SpawnedVelocity);
            writer.Write(this.AimingVelocityMaximum);
            writer.Write(this.AimingAccelerationMaximum);
            writer.Write(this.CasualAimingModifier);
            writer.Write(this.LookingVelocityMaximum);
            writer.Write(this.LookingAccelerationMaximum);
            writer.Write(this.RightHandNode);
            writer.Write(this.LeftHandNode);
            this.MoreDamnNodes.Write(writer);
            writer.Write(this.MeleeDamage);
            this.YourMomma.Write(writer);
            writer.Write(((short)(this.MotionSensorBlipSize)));
            writer.Write(this.fieldpad3);
            writer.WritePointer(this.Postures);
            writer.WritePointer(this.NEWHUDINTERFACES);
            writer.WritePointer(this.DialogueVariants);
            writer.Write(this.GrenadeVelocity);
            writer.Write(((short)(this.GrenadeType)));
            writer.Write(this.GrenadeCount);
            writer.WritePointer(this.PoweredSeats);
            writer.WritePointer(this.Weapons);
            writer.WritePointer(this.Seats);
            this.Boost.Write(writer);
            this.Lipsync.Write(writer);
        }
        [System.FlagsAttribute()]
        public enum UnitFlags : int
        {
            None = 0,
            CircularAiming = 1,
            DestroyedAfterDying = 2,
            HalfspeedInterpolation = 4,
            FiresFromCamera = 8,
            EntranceInsideBoundingSphere = 16,
            DoesntShowReadiedWeapon = 32,
            CausesPassengerDialogue = 64,
            ResistsPings = 128,
            MeleeAttackIsFatal = 256,
            DontRefaceDuringPings = 512,
            HasNoAiming = 1024,
            SimpleCreature = 2048,
            ImpactMeleeAttachesToUnit = 4096,
            ImpactMeleeDiesOnShields = 8192,
            CannotOpenDoorsAutomatically = 16384,
            MeleeAttackersCannotAttach = 32768,
            NotInstantlyKilledByMelee = 65536,
            ShieldSapping = 131072,
            RunsAroundFlaming = 262144,
            Inconsequential = 524288,
            SpecialCinematicUnit = 1048576,
            IgnoredByAutoaiming = 2097152,
            ShieldsFryInfectionForms = 4194304,
            Unused = 8388608,
            Unused0 = 16777216,
            ActsAsGunnerForParent = 33554432,
            ControlledByParentGunner = 67108864,
            ParentsPrimaryWeapon = 134217728,
            UnitHasBoost = 268435456,
        }
        public enum DefaultTeamEnum : short
        {
            Default = 0,
            Player = 1,
            Human = 2,
            Covenant = 3,
            Flood = 4,
            Sentinel = 5,
            Heretic = 6,
            Prophet = 7,
            Unused8 = 8,
            Unused9 = 9,
            Unused10 = 10,
            Unused11 = 11,
            Unused12 = 12,
            Unused13 = 13,
            Unused14 = 14,
            Unused15 = 15,
        }
        public enum ConstantSoundVolumeEnum : short
        {
            Silent = 0,
            Medium = 1,
            Loud = 2,
            Shout = 3,
            Quiet = 4,
        }
        public enum MotionSensorBlipSizeEnum : short
        {
            Medium = 0,
            Small = 1,
            Large = 2,
        }
        public enum GrenadeTypeEnum : short
        {
            HumanFragmentation = 0,
            CovenantPlasma = 1,
        }
    }
}
namespace Moonfish.Tags
{
    
    public partial struct TagClass
    {
        public static TagClass Unit = ((TagClass)("unit"));
    }
}
