using Moonfish.Model;
using Moonfish.Tags.BlamExtension;
using Moonfish.Tags;
using OpenTK;
using System;
using System.IO;

namespace Moonfish.Guerilla.Tags
{
    public  partial class CharacterRetreatBlock : CharacterRetreatBlockBase
    {
        public  CharacterRetreatBlock(BinaryReader binaryReader): base(binaryReader)
        {
            
        }
    };
    [LayoutAttribute(Size = 76)]
    public class CharacterRetreatBlockBase
    {
        internal RetreatFlags retreatFlags;
        /// <summary>
        /// When shield vitality drops below given amount, retreat is triggered by low_shield_retreat_impulse
        /// </summary>
        internal float shieldThreshold;
        /// <summary>
        /// When confronting an enemy of over the given scariness, retreat is triggered by scary_target_retreat_impulse
        /// </summary>
        internal float scaryTargetThreshold;
        /// <summary>
        /// When perceived danger rises above the given threshold, retreat is triggered by danger_retreat_impulse
        /// </summary>
        internal float dangerThreshold;
        /// <summary>
        /// When enemy closer than given threshold, retreat is triggered by proximity_retreat_impulse
        /// </summary>
        internal float proximityThreshold;
        /// <summary>
        /// actor cowers for at least the given amount of time
        /// </summary>
        internal Moonfish.Model.Range minMaxForcedCowerTimeBounds;
        /// <summary>
        /// actor times out of cower after the given amount of time
        /// </summary>
        internal Moonfish.Model.Range minMaxCowerTimeoutBounds;
        /// <summary>
        /// If target reaches is within the given proximity, an ambush is triggered by the proximity ambush impulse
        /// </summary>
        internal float proximityAmbushThreshold;
        /// <summary>
        /// If target is less than threshold (0-1) aware of me, an ambush is triggered by the vulnerable enemy ambush impulse
        /// </summary>
        internal float awarenessAmbushThreshold;
        /// <summary>
        /// If leader-dead-retreat-impulse is active, gives the chance that we will flee when our leader dies within 4 world units of us
        /// </summary>
        internal float leaderDeadRetreatChance;
        /// <summary>
        /// If peer-dead-retreat-impulse is active, gives the chance that we will flee when one of our peers (friend of the same race) dies within 4 world units of us
        /// </summary>
        internal float peerDeadRetreatChance;
        /// <summary>
        /// If peer-dead-retreat-impulse is active, gives the chance that we will flee when a second peer (friend of the same race) dies within 4 world units of us
        /// </summary>
        internal float secondPeerDeadRetreatChance;
        /// <summary>
        /// The angle from the intended destination direction that a zig-zag will cause
        /// </summary>
        internal float zigZagAngleDegrees;
        /// <summary>
        /// How long it takes to zig left and then zag right.
        /// </summary>
        internal float zigZagPeriodSeconds;
        /// <summary>
        /// The likelihood of throwing down a grenade to cover our retreat
        /// </summary>
        internal float retreatGrenadeChance;
        /// <summary>
        /// If I want to flee and I don't have flee animations with my current weapon, throw it away and try a ...
        /// </summary>
        [TagReference("weap")]
        internal Moonfish.Tags.TagReference backupWeapon;
        internal  CharacterRetreatBlockBase(BinaryReader binaryReader)
        {
            this.retreatFlags = (RetreatFlags)binaryReader.ReadInt32();
            this.shieldThreshold = binaryReader.ReadSingle();
            this.scaryTargetThreshold = binaryReader.ReadSingle();
            this.dangerThreshold = binaryReader.ReadSingle();
            this.proximityThreshold = binaryReader.ReadSingle();
            this.minMaxForcedCowerTimeBounds = binaryReader.ReadRange();
            this.minMaxCowerTimeoutBounds = binaryReader.ReadRange();
            this.proximityAmbushThreshold = binaryReader.ReadSingle();
            this.awarenessAmbushThreshold = binaryReader.ReadSingle();
            this.leaderDeadRetreatChance = binaryReader.ReadSingle();
            this.peerDeadRetreatChance = binaryReader.ReadSingle();
            this.secondPeerDeadRetreatChance = binaryReader.ReadSingle();
            this.zigZagAngleDegrees = binaryReader.ReadSingle();
            this.zigZagPeriodSeconds = binaryReader.ReadSingle();
            this.retreatGrenadeChance = binaryReader.ReadSingle();
            this.backupWeapon = binaryReader.ReadTagReference();
        }
        internal  virtual byte[] ReadData(BinaryReader binaryReader)
        {
            var blamPointer = binaryReader.ReadBlamPointer(1);
            var data = new byte[blamPointer.elementCount];
            if(blamPointer.elementCount > 0)
            {
                using (binaryReader.BaseStream.Pin())
                {
                    binaryReader.BaseStream.Position = blamPointer[0];
                    data = binaryReader.ReadBytes(blamPointer.elementCount);
                }
            }
            return data;
        }
        [FlagsAttribute]
        internal enum RetreatFlags : int
        
        {
            ZigZagWhenFleeing = 1,
            Unused1 = 2,
        };
    };
}