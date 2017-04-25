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
    [TagClassAttribute("jpt!")]
    [TagBlockOriginalNameAttribute("damage_effect_block")]
    public partial class DamageEffectBlock : GuerillaBlock, IWriteQueueable
    {
        public Moonfish.Model.Range Radius;
        public float CutoffScale;
        public Flags DamageEffectFlags;
        public SideEffectEnum SideEffect;
        public CategoryEnum Category;
        public DamageEffectFlags0 DamageEffectDamageEffectFlags0;
        public float AOECoreRadius;
        public float DamageLowerBound;
        public Moonfish.Model.Range DamageUpperBound;
        public float DmgInnerConeAngle;
        public DamageOuterConeAngleStructBlock Blah = new DamageOuterConeAngleStructBlock();
        public float ActiveCamouflageDamage;
        public float Stun;
        public float MaximumStun;
        public float StunTime;
        public float InstantaneousAcceleration;
        public float RiderDirectDamageScale;
        public float RiderMaximumTransferDamageScale;
        public float RiderMinimumTransferDamageScale;
        public Moonfish.Tags.StringIdent GeneralDamage;
        public Moonfish.Tags.StringIdent SpecificDamage;
        public float AIStunRadius;
        public Moonfish.Model.Range AIStunBounds;
        public float ShakeRadius;
        public float EMPRadius;
        public DamageEffectPlayerResponseBlock[] PlayerResponses = new DamageEffectPlayerResponseBlock[0];
        /// <summary>
        /// EMPTY STRING
        /// </summary>
        public float Duration;
        public FadeFunctionEnum FadeFunction;
        private byte[] fieldpad = new byte[2];
        public float Rotation;
        public float Pushback;
        public Moonfish.Model.Range Jitter;
        /// <summary>
        /// The wobble function and weight affects how the camera shake oscilates over time.
        ///If the weight is one, then the wobble function completely scales the translational
        ///and rotational magnitudes.  The less the weight, the less the effect wobble has.
        ///If the wobble weight is 0 then wobble is completely ignored.
        /// </summary>
        public float Duration0;
        public FalloffFunctionEnum FalloffFunction;
        private byte[] fieldpad0 = new byte[2];
        public float RandomTranslation;
        public float RandomRotation;
        public WobbleFunctionEnum WobbleFunction;
        private byte[] fieldpad1 = new byte[2];
        public float WobbleFunctionPeriod;
        public float WobbleWeight;
        /// <summary>
        /// EMPTY STRING
        /// </summary>
        [Moonfish.Tags.TagReferenceAttribute("snd!")]
        public Moonfish.Tags.TagReference Sound;
        /// <summary>
        /// Controls particle velocities when a damage effect shatters a materal.
        ///
        ///All particles created within 'forward radius' will be kicked along the
        ///damage direction with a speed equivalent to 'forward velocity' at the
        ///epicenter of the damage and 0 at the outer radius.  'Forward exponent'
        ///is used to modify the velocity scale.  A low exponent (like 0.5) means that
        ///particles between the epicenter and the radius will be kicked out with a speed
        ///closer to 'forward velocity' than if a higher exponent (like 2.0) was used
        ///
        ///The outward fields work in a similar way, except instead of kicking along the
        ///damage direction, they get kick away from the damage epicenter.
        /// </summary>
        public float ForwardVelocity;
        public float ForwardRadius;
        public float ForwardExponent;
        public float OutwardVelocity;
        public float OutwardRadius;
        public float OutwardExponent;
        public override int SerializedSize
        {
            get
            {
                return 200;
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
            this.Radius = binaryReader.ReadRange();
            this.CutoffScale = binaryReader.ReadSingle();
            this.DamageEffectFlags = ((Flags)(binaryReader.ReadInt32()));
            this.SideEffect = ((SideEffectEnum)(binaryReader.ReadInt16()));
            this.Category = ((CategoryEnum)(binaryReader.ReadInt16()));
            this.DamageEffectDamageEffectFlags0 = ((DamageEffectFlags0)(binaryReader.ReadInt32()));
            this.AOECoreRadius = binaryReader.ReadSingle();
            this.DamageLowerBound = binaryReader.ReadSingle();
            this.DamageUpperBound = binaryReader.ReadRange();
            this.DmgInnerConeAngle = binaryReader.ReadSingle();
            pointerQueue = new System.Collections.Generic.Queue<Moonfish.Tags.BlamPointer>(pointerQueue.Concat(this.Blah.ReadFields(binaryReader)));
            this.ActiveCamouflageDamage = binaryReader.ReadSingle();
            this.Stun = binaryReader.ReadSingle();
            this.MaximumStun = binaryReader.ReadSingle();
            this.StunTime = binaryReader.ReadSingle();
            this.InstantaneousAcceleration = binaryReader.ReadSingle();
            this.RiderDirectDamageScale = binaryReader.ReadSingle();
            this.RiderMaximumTransferDamageScale = binaryReader.ReadSingle();
            this.RiderMinimumTransferDamageScale = binaryReader.ReadSingle();
            this.GeneralDamage = binaryReader.ReadStringIdent();
            this.SpecificDamage = binaryReader.ReadStringIdent();
            this.AIStunRadius = binaryReader.ReadSingle();
            this.AIStunBounds = binaryReader.ReadRange();
            this.ShakeRadius = binaryReader.ReadSingle();
            this.EMPRadius = binaryReader.ReadSingle();
            pointerQueue.Enqueue(binaryReader.ReadBlamPointer(76));
            this.Duration = binaryReader.ReadSingle();
            this.FadeFunction = ((FadeFunctionEnum)(binaryReader.ReadInt16()));
            this.fieldpad = binaryReader.ReadBytes(2);
            this.Rotation = binaryReader.ReadSingle();
            this.Pushback = binaryReader.ReadSingle();
            this.Jitter = binaryReader.ReadRange();
            this.Duration0 = binaryReader.ReadSingle();
            this.FalloffFunction = ((FalloffFunctionEnum)(binaryReader.ReadInt16()));
            this.fieldpad0 = binaryReader.ReadBytes(2);
            this.RandomTranslation = binaryReader.ReadSingle();
            this.RandomRotation = binaryReader.ReadSingle();
            this.WobbleFunction = ((WobbleFunctionEnum)(binaryReader.ReadInt16()));
            this.fieldpad1 = binaryReader.ReadBytes(2);
            this.WobbleFunctionPeriod = binaryReader.ReadSingle();
            this.WobbleWeight = binaryReader.ReadSingle();
            this.Sound = binaryReader.ReadTagReference();
            this.ForwardVelocity = binaryReader.ReadSingle();
            this.ForwardRadius = binaryReader.ReadSingle();
            this.ForwardExponent = binaryReader.ReadSingle();
            this.OutwardVelocity = binaryReader.ReadSingle();
            this.OutwardRadius = binaryReader.ReadSingle();
            this.OutwardExponent = binaryReader.ReadSingle();
            return pointerQueue;
        }
        public override void ReadInstances(Moonfish.Guerilla.BlamBinaryReader binaryReader, System.Collections.Generic.Queue<Moonfish.Tags.BlamPointer> pointerQueue)
        {
            base.ReadInstances(binaryReader, pointerQueue);
            this.Blah.ReadInstances(binaryReader, pointerQueue);
            this.PlayerResponses = base.ReadBlockArrayData<DamageEffectPlayerResponseBlock>(binaryReader, pointerQueue.Dequeue());
        }
        public override void Defer(Moonfish.Guerilla.QueueableBlamBinaryWriter queueableBinaryWriter)
        {
            base.Defer(queueableBinaryWriter);
            this.Blah.Defer(queueableBinaryWriter);
            queueableBinaryWriter.Defer(this.PlayerResponses);
        }
        public override void Write(Moonfish.Guerilla.QueueableBlamBinaryWriter queueableBinaryWriter)
        {
            base.Write(queueableBinaryWriter);
            queueableBinaryWriter.Write(this.Radius);
            queueableBinaryWriter.Write(this.CutoffScale);
            queueableBinaryWriter.Write(((int)(this.DamageEffectFlags)));
            queueableBinaryWriter.Write(((short)(this.SideEffect)));
            queueableBinaryWriter.Write(((short)(this.Category)));
            queueableBinaryWriter.Write(((int)(this.DamageEffectDamageEffectFlags0)));
            queueableBinaryWriter.Write(this.AOECoreRadius);
            queueableBinaryWriter.Write(this.DamageLowerBound);
            queueableBinaryWriter.Write(this.DamageUpperBound);
            queueableBinaryWriter.Write(this.DmgInnerConeAngle);
            this.Blah.Write(queueableBinaryWriter);
            queueableBinaryWriter.Write(this.ActiveCamouflageDamage);
            queueableBinaryWriter.Write(this.Stun);
            queueableBinaryWriter.Write(this.MaximumStun);
            queueableBinaryWriter.Write(this.StunTime);
            queueableBinaryWriter.Write(this.InstantaneousAcceleration);
            queueableBinaryWriter.Write(this.RiderDirectDamageScale);
            queueableBinaryWriter.Write(this.RiderMaximumTransferDamageScale);
            queueableBinaryWriter.Write(this.RiderMinimumTransferDamageScale);
            queueableBinaryWriter.Write(this.GeneralDamage);
            queueableBinaryWriter.Write(this.SpecificDamage);
            queueableBinaryWriter.Write(this.AIStunRadius);
            queueableBinaryWriter.Write(this.AIStunBounds);
            queueableBinaryWriter.Write(this.ShakeRadius);
            queueableBinaryWriter.Write(this.EMPRadius);
            queueableBinaryWriter.WritePointer(this.PlayerResponses);
            queueableBinaryWriter.Write(this.Duration);
            queueableBinaryWriter.Write(((short)(this.FadeFunction)));
            queueableBinaryWriter.Write(this.fieldpad);
            queueableBinaryWriter.Write(this.Rotation);
            queueableBinaryWriter.Write(this.Pushback);
            queueableBinaryWriter.Write(this.Jitter);
            queueableBinaryWriter.Write(this.Duration0);
            queueableBinaryWriter.Write(((short)(this.FalloffFunction)));
            queueableBinaryWriter.Write(this.fieldpad0);
            queueableBinaryWriter.Write(this.RandomTranslation);
            queueableBinaryWriter.Write(this.RandomRotation);
            queueableBinaryWriter.Write(((short)(this.WobbleFunction)));
            queueableBinaryWriter.Write(this.fieldpad1);
            queueableBinaryWriter.Write(this.WobbleFunctionPeriod);
            queueableBinaryWriter.Write(this.WobbleWeight);
            queueableBinaryWriter.Write(this.Sound);
            queueableBinaryWriter.Write(this.ForwardVelocity);
            queueableBinaryWriter.Write(this.ForwardRadius);
            queueableBinaryWriter.Write(this.ForwardExponent);
            queueableBinaryWriter.Write(this.OutwardVelocity);
            queueableBinaryWriter.Write(this.OutwardRadius);
            queueableBinaryWriter.Write(this.OutwardExponent);
        }
        [System.FlagsAttribute()]
        public enum Flags : int
        {
            None = 0,
            DontScaleDamageByDistance = 1,
            AreaDamagePlayersOnlyareaOfEffectDamageOnlyAffectsPlayers = 2,
        }
        /// <summary>
        /// EMPTY STRING
        /// </summary>
        public enum SideEffectEnum : short
        {
            None = 0,
            Harmless = 1,
            LethalToTheUnsuspecting = 2,
            Emp = 3,
        }
        public enum CategoryEnum : short
        {
            None = 0,
            Falling = 1,
            Bullet = 2,
            Grenade = 3,
            HighExplosive = 4,
            Sniper = 5,
            Melee = 6,
            Flame = 7,
            MountedWeapon = 8,
            Vehicle = 9,
            Plasma = 10,
            Needle = 11,
            Shotgun = 12,
        }
        [System.FlagsAttribute()]
        public enum DamageEffectFlags0 : int
        {
            None = 0,
            DoesNotHurtOwner = 1,
            CanCauseHeadshots = 2,
            PingsResistantUnits = 4,
            DoesNotHurtFriends = 8,
            DoesNotPingUnits = 16,
            DetonatesExplosives = 32,
            OnlyHurtsShields = 64,
            CausesFlamingDeath = 128,
            DamageIndicatorsAlwaysPointDown = 256,
            SkipsShields = 512,
            OnlyHurtsOneInfectionForm = 1024,
            ObsoleteWasCanCauseMultiplayerHeadshots = 2048,
            InfectionFormPop = 4096,
            IgnoreSeatScaleForDirDmg = 8192,
            ForcesHardPing = 16384,
            DoesNotHurtPlayers = 32768,
        }
        public enum FadeFunctionEnum : short
        {
            Linear = 0,
            Late = 1,
            VeryLate = 2,
            Early = 3,
            VeryEarly = 4,
            Cosine = 5,
            Zero = 6,
            One = 7,
        }
        public enum FalloffFunctionEnum : short
        {
            Linear = 0,
            Late = 1,
            VeryLate = 2,
            Early = 3,
            VeryEarly = 4,
            Cosine = 5,
            Zero = 6,
            One = 7,
        }
        public enum WobbleFunctionEnum : short
        {
            One = 0,
            Zero = 1,
            Cosine = 2,
            CosinevariablePeriod = 3,
            DiagonalWave = 4,
            DiagonalWavevariablePeriod = 5,
            Slide = 6,
            SlidevariablePeriod = 7,
            Noise = 8,
            Jitter = 9,
            Wander = 10,
            Spark = 11,
        }
    }
}
namespace Moonfish.Tags
{
    
    public partial struct TagClass
    {
        public static TagClass Jpt = ((TagClass)("jpt!"));
    }
}
