//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Moonfish.Guerilla.Tags
{
    using Moonfish.Tags;
    using Moonfish.Model;
    using System.IO;
    using System.Collections.Generic;
    using System.Linq;
    
    public partial class GlobalDamageInfoBlock : GuerillaBlock, IWriteQueueable
    {
        public Flags GlobalDamageInfoFlags;
        public Moonfish.Tags.StringIdent GlobalIndirectMaterialName;
        public Moonfish.Tags.ShortBlockIndex2 IndirectDamageSection;
        private byte[] fieldpad = new byte[2];
        private byte[] fieldpad0 = new byte[4];
        public CollisionDamageReportingTypeEnum CollisionDamageReportingType;
        public ResponseDamageReportingTypeEnum ResponseDamageReportingType;
        private byte[] fieldpad1 = new byte[2];
        private byte[] fieldpad2 = new byte[20];
        public float MaximumVitality;
        public float MinimumStunDamage;
        public float StunTime;
        public float RechargeTime;
        public float RechargeFraction;
        private byte[] fieldpad3 = new byte[64];
        [Moonfish.Tags.TagReferenceAttribute("shad")]
        public Moonfish.Tags.TagReference ShieldDamagedFirstPersonShader;
        [Moonfish.Tags.TagReferenceAttribute("shad")]
        public Moonfish.Tags.TagReference ShieldDamagedShader;
        public float MaximumShieldVitality;
        public Moonfish.Tags.StringIdent GlobalShieldMaterialName;
        public float MinimumStunDamage0;
        public float StunTime0;
        public float RechargeTime0;
        public float ShieldDamagedThreshold;
        [Moonfish.Tags.TagReferenceAttribute("effe")]
        public Moonfish.Tags.TagReference ShieldDamagedEffect;
        [Moonfish.Tags.TagReferenceAttribute("effe")]
        public Moonfish.Tags.TagReference ShieldDepletedEffect;
        [Moonfish.Tags.TagReferenceAttribute("effe")]
        public Moonfish.Tags.TagReference ShieldRechargingEffect;
        public GlobalDamageSectionBlock[] DamageSections = new GlobalDamageSectionBlock[0];
        public GlobalDamageNodesBlock[] Nodes = new GlobalDamageNodesBlock[0];
        private byte[] fieldpad4 = new byte[2];
        private byte[] fieldpad5 = new byte[2];
        private byte[] fieldpad6 = new byte[4];
        private byte[] fieldpad7 = new byte[4];
        public DamageSeatInfoBlock[] DamageSeats = new DamageSeatInfoBlock[0];
        public DamageConstraintInfoBlock[] DamageConstraints = new DamageConstraintInfoBlock[0];
        [Moonfish.Tags.TagReferenceAttribute("shad")]
        public Moonfish.Tags.TagReference OvershieldFirstPersonShader;
        [Moonfish.Tags.TagReferenceAttribute("shad")]
        public Moonfish.Tags.TagReference OvershieldShader;
        public override int SerializedSize
        {
            get
            {
                return 248;
            }
        }
        public override int Alignment
        {
            get
            {
                return 4;
            }
        }
        public override System.Collections.Generic.Queue<Moonfish.Tags.BlamPointer> ReadFields(System.IO.BinaryReader binaryReader)
        {
            System.Collections.Generic.Queue<Moonfish.Tags.BlamPointer> pointerQueue = new System.Collections.Generic.Queue<Moonfish.Tags.BlamPointer>(base.ReadFields(binaryReader));
            this.GlobalDamageInfoFlags = ((Flags)(binaryReader.ReadInt32()));
            this.GlobalIndirectMaterialName = binaryReader.ReadStringID();
            this.IndirectDamageSection = binaryReader.ReadShortBlockIndex2();
            this.fieldpad = binaryReader.ReadBytes(2);
            this.fieldpad0 = binaryReader.ReadBytes(4);
            this.CollisionDamageReportingType = ((CollisionDamageReportingTypeEnum)(binaryReader.ReadByte()));
            this.ResponseDamageReportingType = ((ResponseDamageReportingTypeEnum)(binaryReader.ReadByte()));
            this.fieldpad1 = binaryReader.ReadBytes(2);
            this.fieldpad2 = binaryReader.ReadBytes(20);
            this.MaximumVitality = binaryReader.ReadSingle();
            this.MinimumStunDamage = binaryReader.ReadSingle();
            this.StunTime = binaryReader.ReadSingle();
            this.RechargeTime = binaryReader.ReadSingle();
            this.RechargeFraction = binaryReader.ReadSingle();
            this.fieldpad3 = binaryReader.ReadBytes(64);
            this.ShieldDamagedFirstPersonShader = binaryReader.ReadTagReference();
            this.ShieldDamagedShader = binaryReader.ReadTagReference();
            this.MaximumShieldVitality = binaryReader.ReadSingle();
            this.GlobalShieldMaterialName = binaryReader.ReadStringID();
            this.MinimumStunDamage0 = binaryReader.ReadSingle();
            this.StunTime0 = binaryReader.ReadSingle();
            this.RechargeTime0 = binaryReader.ReadSingle();
            this.ShieldDamagedThreshold = binaryReader.ReadSingle();
            this.ShieldDamagedEffect = binaryReader.ReadTagReference();
            this.ShieldDepletedEffect = binaryReader.ReadTagReference();
            this.ShieldRechargingEffect = binaryReader.ReadTagReference();
            pointerQueue.Enqueue(binaryReader.ReadBlamPointer(56));
            pointerQueue.Enqueue(binaryReader.ReadBlamPointer(16));
            this.fieldpad4 = binaryReader.ReadBytes(2);
            this.fieldpad5 = binaryReader.ReadBytes(2);
            this.fieldpad6 = binaryReader.ReadBytes(4);
            this.fieldpad7 = binaryReader.ReadBytes(4);
            pointerQueue.Enqueue(binaryReader.ReadBlamPointer(20));
            pointerQueue.Enqueue(binaryReader.ReadBlamPointer(20));
            this.OvershieldFirstPersonShader = binaryReader.ReadTagReference();
            this.OvershieldShader = binaryReader.ReadTagReference();
            return pointerQueue;
        }
        public override void ReadInstances(System.IO.BinaryReader binaryReader, System.Collections.Generic.Queue<Moonfish.Tags.BlamPointer> pointerQueue)
        {
            base.ReadInstances(binaryReader, pointerQueue);
            this.DamageSections = base.ReadBlockArrayData<GlobalDamageSectionBlock>(binaryReader, pointerQueue.Dequeue());
            this.Nodes = base.ReadBlockArrayData<GlobalDamageNodesBlock>(binaryReader, pointerQueue.Dequeue());
            this.DamageSeats = base.ReadBlockArrayData<DamageSeatInfoBlock>(binaryReader, pointerQueue.Dequeue());
            this.DamageConstraints = base.ReadBlockArrayData<DamageConstraintInfoBlock>(binaryReader, pointerQueue.Dequeue());
        }
        public override void QueueWrites(Moonfish.Guerilla.QueueableBinaryWriter queueableBinaryWriter)
        {
            base.QueueWrites(queueableBinaryWriter);
            queueableBinaryWriter.QueueWrite(this.DamageSections);
            queueableBinaryWriter.QueueWrite(this.Nodes);
            queueableBinaryWriter.QueueWrite(this.DamageSeats);
            queueableBinaryWriter.QueueWrite(this.DamageConstraints);
        }
        public override void Write_(Moonfish.Guerilla.QueueableBinaryWriter queueableBinaryWriter)
        {
            base.Write_(queueableBinaryWriter);
            queueableBinaryWriter.Write(((int)(this.GlobalDamageInfoFlags)));
            queueableBinaryWriter.Write(this.GlobalIndirectMaterialName);
            queueableBinaryWriter.Write(this.IndirectDamageSection);
            queueableBinaryWriter.Write(this.fieldpad);
            queueableBinaryWriter.Write(this.fieldpad0);
            queueableBinaryWriter.Write(((byte)(this.CollisionDamageReportingType)));
            queueableBinaryWriter.Write(((byte)(this.ResponseDamageReportingType)));
            queueableBinaryWriter.Write(this.fieldpad1);
            queueableBinaryWriter.Write(this.fieldpad2);
            queueableBinaryWriter.Write(this.MaximumVitality);
            queueableBinaryWriter.Write(this.MinimumStunDamage);
            queueableBinaryWriter.Write(this.StunTime);
            queueableBinaryWriter.Write(this.RechargeTime);
            queueableBinaryWriter.Write(this.RechargeFraction);
            queueableBinaryWriter.Write(this.fieldpad3);
            queueableBinaryWriter.Write(this.ShieldDamagedFirstPersonShader);
            queueableBinaryWriter.Write(this.ShieldDamagedShader);
            queueableBinaryWriter.Write(this.MaximumShieldVitality);
            queueableBinaryWriter.Write(this.GlobalShieldMaterialName);
            queueableBinaryWriter.Write(this.MinimumStunDamage0);
            queueableBinaryWriter.Write(this.StunTime0);
            queueableBinaryWriter.Write(this.RechargeTime0);
            queueableBinaryWriter.Write(this.ShieldDamagedThreshold);
            queueableBinaryWriter.Write(this.ShieldDamagedEffect);
            queueableBinaryWriter.Write(this.ShieldDepletedEffect);
            queueableBinaryWriter.Write(this.ShieldRechargingEffect);
            queueableBinaryWriter.WritePointer(this.DamageSections);
            queueableBinaryWriter.WritePointer(this.Nodes);
            queueableBinaryWriter.Write(this.fieldpad4);
            queueableBinaryWriter.Write(this.fieldpad5);
            queueableBinaryWriter.Write(this.fieldpad6);
            queueableBinaryWriter.Write(this.fieldpad7);
            queueableBinaryWriter.WritePointer(this.DamageSeats);
            queueableBinaryWriter.WritePointer(this.DamageConstraints);
            queueableBinaryWriter.Write(this.OvershieldFirstPersonShader);
            queueableBinaryWriter.Write(this.OvershieldShader);
        }
        [System.FlagsAttribute()]
        public enum Flags : int
        {
            None = 0,
            TakesShieldDamageForChildren = 1,
            TakesBodyDamageForChildren = 2,
            AlwaysShieldsFriendlyDamage = 4,
            PassesAreaDamageToChildren = 8,
            ParentNeverTakesBodyDamageForUs = 16,
            OnlyDamagedByExplosives = 32,
            ParentNeverTakesShieldDamageForUs = 64,
            CannotDieFromDamage = 128,
            PassesAttachedDamageToRiders = 256,
        }
        public enum CollisionDamageReportingTypeEnum : byte
        {
            TehGuardians11 = 0,
            FallingDamage = 1,
            GenericCollisionDamage = 2,
            GenericMeleeDamage = 3,
            GenericExplosion = 4,
            MagnumPistol = 5,
            PlasmaPistol = 6,
            Needler = 7,
            Smg = 8,
            PlasmaRifle = 9,
            BattleRifle = 10,
            Carbine = 11,
            Shotgun = 12,
            SniperRifle = 13,
            BeamRifle = 14,
            RocketLauncher = 15,
            FlakCannon = 16,
            BruteShot = 17,
            Disintegrator = 18,
            BrutePlasmaRifle = 19,
            EnergySword = 20,
            FragGrenade = 21,
            PlasmaGrenade = 22,
            FlagMeleeDamage = 23,
            BombMeleeDamage = 24,
            BombExplosionDamage = 25,
            BallMeleeDamage = 26,
            HumanTurret = 27,
            PlasmaTurret = 28,
            Banshee = 29,
            Ghost = 30,
            Mongoose = 31,
            Scorpion = 32,
            SpectreDriver = 33,
            SpectreGunner = 34,
            WarthogDriver = 35,
            WarthogGunner = 36,
            Wraith = 37,
            Tank = 38,
            SentinelBeam = 39,
            SentinelRpg = 40,
            Teleporter = 41,
        }
        public enum ResponseDamageReportingTypeEnum : byte
        {
            TehGuardians11 = 0,
            FallingDamage = 1,
            GenericCollisionDamage = 2,
            GenericMeleeDamage = 3,
            GenericExplosion = 4,
            MagnumPistol = 5,
            PlasmaPistol = 6,
            Needler = 7,
            Smg = 8,
            PlasmaRifle = 9,
            BattleRifle = 10,
            Carbine = 11,
            Shotgun = 12,
            SniperRifle = 13,
            BeamRifle = 14,
            RocketLauncher = 15,
            FlakCannon = 16,
            BruteShot = 17,
            Disintegrator = 18,
            BrutePlasmaRifle = 19,
            EnergySword = 20,
            FragGrenade = 21,
            PlasmaGrenade = 22,
            FlagMeleeDamage = 23,
            BombMeleeDamage = 24,
            BombExplosionDamage = 25,
            BallMeleeDamage = 26,
            HumanTurret = 27,
            PlasmaTurret = 28,
            Banshee = 29,
            Ghost = 30,
            Mongoose = 31,
            Scorpion = 32,
            SpectreDriver = 33,
            SpectreGunner = 34,
            WarthogDriver = 35,
            WarthogGunner = 36,
            Wraith = 37,
            Tank = 38,
            SentinelBeam = 39,
            SentinelRpg = 40,
            Teleporter = 41,
        }
    }
}
