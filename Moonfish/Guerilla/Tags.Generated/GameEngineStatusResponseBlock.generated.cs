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
    [TagBlockOriginalNameAttribute("game_engine_status_response_block")]
    public partial class GameEngineStatusResponseBlock : GuerillaBlock, IWriteDeferrable
    {
        public Flags GameEngineStatusResponseFlags;
        private byte[] fieldpad = new byte[2];
        public StateEnum State;
        private byte[] fieldpad0 = new byte[2];
        public Moonfish.Tags.StringIdent FfaMessage;
        public Moonfish.Tags.StringIdent TeamMessage;
        [Moonfish.Tags.TagReferenceAttribute("null")]
        public Moonfish.Tags.TagReference TagReference;
        private byte[] fieldpad1 = new byte[4];
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
            this.GameEngineStatusResponseFlags = ((Flags)(binaryReader.ReadInt16()));
            this.fieldpad = binaryReader.ReadBytes(2);
            this.State = ((StateEnum)(binaryReader.ReadInt16()));
            this.fieldpad0 = binaryReader.ReadBytes(2);
            this.FfaMessage = binaryReader.ReadStringIdent();
            this.TeamMessage = binaryReader.ReadStringIdent();
            this.TagReference = binaryReader.ReadTagReference();
            this.fieldpad1 = binaryReader.ReadBytes(4);
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
            writer.Write(((short)(this.GameEngineStatusResponseFlags)));
            writer.Write(this.fieldpad);
            writer.Write(((short)(this.State)));
            writer.Write(this.fieldpad0);
            writer.Write(this.FfaMessage);
            writer.Write(this.TeamMessage);
            writer.Write(this.TagReference);
            writer.Write(this.fieldpad1);
        }
        [System.FlagsAttribute()]
        public enum Flags : short
        {
            None = 0,
            Unused = 1,
        }
        public enum StateEnum : short
        {
            WaitingForSpaceToClear = 0,
            Observing = 1,
            RespawningSoon = 2,
            SittingOut = 3,
            OutOfLives = 4,
            Playingwinning = 5,
            Playingtied = 6,
            Playinglosing = 7,
            GameOverwon = 8,
            GameOvertied = 9,
            GameOverlost = 10,
            YouHaveFlag = 11,
            EnemyHasFlag = 12,
            FlagNotHome = 13,
            CarryingOddball = 14,
            YouAreJuggy = 15,
            YouControlHill = 16,
            SwitchingSidesSoon = 17,
            PlayerRecentlyStarted = 18,
            YouHaveBomb = 19,
            FlagContested = 20,
            BombContested = 21,
            LimitedLivesLeftmultiple = 22,
            LimitedLivesLeftsingle = 23,
            LimitedLivesLeftfinal = 24,
            PlayingwinningUnlimited = 25,
            PlayingtiedUnlimited = 26,
            PlayinglosingUnlimited = 27,
        }
    }
}
