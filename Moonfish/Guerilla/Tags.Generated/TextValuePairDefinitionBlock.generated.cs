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
    
    [TagClassAttribute("sily")]
    public partial class TextValuePairDefinitionBlock : GuerillaBlock, IWriteQueueable
    {
        public ParameterEnum Parameter;
        private byte[] fieldpad = new byte[4];
        [Moonfish.Tags.TagReferenceAttribute("unic")]
        public Moonfish.Tags.TagReference StringList;
        public Moonfish.Tags.StringIdent TitleText;
        public Moonfish.Tags.StringIdent HeaderText;
        public Moonfish.Tags.StringIdent DescriptionText;
        public TextValuePairReferenceBlock[] TextValuePairs = new TextValuePairReferenceBlock[0];
        public override int SerializedSize
        {
            get
            {
                return 36;
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
            this.Parameter = ((ParameterEnum)(binaryReader.ReadInt32()));
            this.fieldpad = binaryReader.ReadBytes(4);
            this.StringList = binaryReader.ReadTagReference();
            this.TitleText = binaryReader.ReadStringID();
            this.HeaderText = binaryReader.ReadStringID();
            this.DescriptionText = binaryReader.ReadStringID();
            pointerQueue.Enqueue(binaryReader.ReadBlamPointer(12));
            return pointerQueue;
        }
        public override void ReadInstances(System.IO.BinaryReader binaryReader, System.Collections.Generic.Queue<Moonfish.Tags.BlamPointer> pointerQueue)
        {
            base.ReadInstances(binaryReader, pointerQueue);
            this.TextValuePairs = base.ReadBlockArrayData<TextValuePairReferenceBlock>(binaryReader, pointerQueue.Dequeue());
        }
        public override void QueueWrites(Moonfish.Guerilla.QueueableBinaryWriter queueableBinaryWriter)
        {
            base.QueueWrites(queueableBinaryWriter);
            queueableBinaryWriter.QueueWrite(this.TextValuePairs);
        }
        public override void Write_(Moonfish.Guerilla.QueueableBinaryWriter queueableBinaryWriter)
        {
            base.Write_(queueableBinaryWriter);
            queueableBinaryWriter.Write(((int)(this.Parameter)));
            queueableBinaryWriter.Write(this.fieldpad);
            queueableBinaryWriter.Write(this.StringList);
            queueableBinaryWriter.Write(this.TitleText);
            queueableBinaryWriter.Write(this.HeaderText);
            queueableBinaryWriter.Write(this.DescriptionText);
            queueableBinaryWriter.WritePointer(this.TextValuePairs);
        }
        public enum ParameterEnum : int
        {
            MatchRoundSetting = 0,
            MatchCtfScoreToWin = 1,
            MatchSlayerScoreToWinRound = 2,
            MatchOddballScoreToWinRound = 3,
            MatchKingScoreToWinRound = 4,
            MatchRaceScoreToWinRound = 5,
            MatchHeadhunterScoreToWinRound = 6,
            MatchJuggernautScoreToWinRound = 7,
            MatchTerritoriesScoreToWinRound = 8,
            MatchAssaultScoreToWinRound = 9,
            MatchRoundTimeLimit = 10,
            MatchRoundsResetMap = 11,
            MatchTieResolution = 12,
            MatchObservers = 13,
            MatchJoinInProgress = 14,
            MaximumPlayers = 15,
            LivesPerRound = 16,
            RespawnTime = 17,
            SuicidePenalty = 18,
            Shields = 19,
            MotionSensor = 20,
            Invisibility = 21,
            TeamChanging = 22,
            TeamScoring = 23,
            FriendlyFire = 24,
            TeamRespawnSetting = 25,
            BetrayalRespawnPenalty = 26,
            TeamKillerManagement = 27,
            SlayerBonusPoints = 28,
            SlayerSuicidePointLoss = 29,
            SlayerDeathPointLoss = 30,
            HeadhunterMovingHeadBin = 31,
            HeadhunterPointMultiplier = 32,
            HeadhunterSuicidePointLoss = 33,
            HeadhunterDeathPointLoss = 34,
            HeadhunterUncontestedBin = 35,
            HeadhunterSpeedWithHeads = 36,
            HeadhunterMaxHeadsCarried = 37,
            KingUncontestedHill = 38,
            KingTeamTimeMultiplier = 39,
            KingMovingHill = 40,
            KingExtraDamageOnHill = 41,
            KingDmgResistanceOnHill = 42,
            OddballBallSpawnCount = 43,
            OddballBallHitDamage = 44,
            OddballSpeedWithBall = 45,
            OddballDrivingGunningWithBall = 46,
            OddballWaypointToBall = 47,
            RaceRandomTrack = 48,
            RaceUncontestedFlag = 49,
            CtfGameType = 50,
            CtfSuddenDeath = 51,
            CtfFlagMayBeReturned = 52,
            CtfFlagAtHomeToScore = 53,
            CtfFlagResetTime = 54,
            CtfSpeedWithFlag = 55,
            CtfFlagHitDamage = 56,
            CtfDrivingGunningWithFlag = 57,
            CtfWaypointToOwnFlag = 58,
            AssaultGameType = 59,
            AssaultSuddenDeath = 60,
            AssaultDetonationTime = 61,
            AssaultBombAtHomeToScore = 62,
            AssaultArmingTime = 63,
            AssaultSpeedWithBomb = 64,
            AssaultBombHitDamage = 65,
            AssaultDrivingGunningWithBomb = 66,
            AssaultWaypointToOwnBomb = 67,
            JuggernautBetrayalPointLoss = 68,
            JuggernautJuggyExtraDamage = 69,
            JuggernautJuggyInfiniteAmmo = 70,
            JuggernautJuggyOvershields = 71,
            JuggernautJuggyActiveCamo = 72,
            JuggernautJuggyMotionSensor = 73,
            TerritoriesTerritoryCount = 74,
            VehRespawn = 75,
            VehPrimaryLightLand = 76,
            VehSecondaryLightLand = 77,
            VehPrimaryHeavyLand = 78,
            VehPrimaryFlying = 79,
            VehSecondaryHeavyLand = 80,
            VehPrimaryTurret = 81,
            VehSecondaryTurret = 82,
            EquipWeaponsOnMap = 83,
            EquipOvershieldsOnMap = 84,
            EquipActiveCamoOnMap = 85,
            EquipGrenadesOnMap = 86,
            EquipWeaponRespawnTimes = 87,
            EquipStartingGrenades = 88,
            EquipPrimaryStartingEquipment = 89,
            UNSMaxLivingPlayers = 90,
            UNSTeamsEnabled = 91,
            UNSAssaultBombMayBeReturned = 92,
            UNSMaxTeams = 93,
            UNSEquipSecondaryStartingEquipment = 94,
            UNSAssaultFuseTime = 95,
            UNSJuggyMovement = 96,
            UNSStickyFuse = 97,
            UNSTerrContestTime = 98,
            UNSTerrControlTime = 99,
            UNSOddbCarrInvis = 100,
            UNSKingInvisInHill = 101,
            UNSBallCarrDmgResis = 102,
            UNSKingDmgResInHill = 103,
            UNSPlayersExDmg = 104,
            UNSPlayersDmgResis = 105,
            UNSCtfCarrDmgResis = 106,
            UNSCtfCarrInvis = 107,
            UNSJuggyDmgResis = 108,
            UNSBombCarrDmgResis = 109,
            UNSBombCarrInvis = 110,
            UNSForceEvenTeams = 111,
        }
    }
}
namespace Moonfish.Tags
{
    
    public partial struct TagClass
    {
        public static TagClass Sily = ((TagClass)("sily"));
    }
}