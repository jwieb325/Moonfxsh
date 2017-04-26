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
    [TagBlockOriginalNameAttribute("ai_conversation_block")]
    public partial class AiConversationBlock : GuerillaBlock, IWriteDeferrable
    {
        public Moonfish.Tags.String32 Name;
        public Flags AiConversationFlags;
        private byte[] fieldpad = new byte[2];
        public float TriggerDistance;
        public float RuntoplayerDist;
        private byte[] fieldpad0 = new byte[36];
        public AiConversationParticipantBlock[] Participants = new AiConversationParticipantBlock[0];
        public AiConversationLineBlock[] Lines = new AiConversationLineBlock[0];
        public GNullBlock[] GNullBlock = new GNullBlock[0];
        public override int SerializedSize
        {
            get
            {
                return 104;
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
            this.Name = binaryReader.ReadString32();
            this.AiConversationFlags = ((Flags)(binaryReader.ReadInt16()));
            this.fieldpad = binaryReader.ReadBytes(2);
            this.TriggerDistance = binaryReader.ReadSingle();
            this.RuntoplayerDist = binaryReader.ReadSingle();
            this.fieldpad0 = binaryReader.ReadBytes(36);
            pointerQueue.Enqueue(binaryReader.ReadBlamPointer(84));
            pointerQueue.Enqueue(binaryReader.ReadBlamPointer(76));
            pointerQueue.Enqueue(binaryReader.ReadBlamPointer(0));
            return pointerQueue;
        }
        public override void ReadInstances(Moonfish.Guerilla.BlamBinaryReader binaryReader, System.Collections.Generic.Queue<Moonfish.Tags.BlamPointer> pointerQueue)
        {
            base.ReadInstances(binaryReader, pointerQueue);
            this.Participants = base.ReadBlockArrayData<AiConversationParticipantBlock>(binaryReader, pointerQueue.Dequeue());
            this.Lines = base.ReadBlockArrayData<AiConversationLineBlock>(binaryReader, pointerQueue.Dequeue());
            this.GNullBlock = base.ReadBlockArrayData<GNullBlock>(binaryReader, pointerQueue.Dequeue());
        }
        public override void DeferReferences(Moonfish.Guerilla.LinearBinaryWriter writer)
        {
            base.DeferReferences(writer);
            writer.Defer(this.Participants);
            writer.Defer(this.Lines);
            writer.Defer(this.GNullBlock);
        }
        public override void Write(Moonfish.Guerilla.LinearBinaryWriter writer)
        {
            base.Write(writer);
            writer.Write(this.Name);
            writer.Write(((short)(this.AiConversationFlags)));
            writer.Write(this.fieldpad);
            writer.Write(this.TriggerDistance);
            writer.Write(this.RuntoplayerDist);
            writer.Write(this.fieldpad0);
            writer.WritePointer(this.Participants);
            writer.WritePointer(this.Lines);
            writer.WritePointer(this.GNullBlock);
        }
        [System.FlagsAttribute()]
        public enum Flags : short
        {
            None = 0,
            StopIfDeaththisConversationWillBeAbortedIfAnyParticipantDies = 1,
            StopIfDamagedanActorWillAbortThisConversationIfTheyAreDamaged = 2,
            StopIfVisibleEnemyanActorWillAbortThisConversationIfTheySeeAnEnemy = 4,
            StopIfAlertedToEnemyanActorWillAbortThisConversationIfTheySuspectAnEnemy = 8,
            PlayerMustBeVisiblethisConversationCannotTakePlaceUnlessTheParticipantsCanSeeANearbyPlayer = 16,
            StopOtherActionsparticipantsStopDoingWhateverTheyWereDoingInOrderToPerformThisConversation = 32,
            KeepTryingToPlayifThisConversationFailsInitiallyItWillKeepTestingToSeeWhenItCanPlay = 64,
            PlayerMustBeLookingthisConversationWillNotStartUntilThePlayerIsLookingAtOneOfTheParticipants = 128,
        }
    }
}
