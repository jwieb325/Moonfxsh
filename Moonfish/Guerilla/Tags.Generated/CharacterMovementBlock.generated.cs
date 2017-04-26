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
    [TagBlockOriginalNameAttribute("character_movement_block")]
    public partial class CharacterMovementBlock : GuerillaBlock, IWriteDeferrable
    {
        public MovementFlags CharacterMovementMovementFlags;
        public float PathfindingRadius;
        public float DestinationRadius;
        public float DiveGrenadeChance;
        public ObstacleLeapMinSizeEnum ObstacleLeapMinSize;
        public ObstacleLeapMaxSizeEnum ObstacleLeapMaxSize;
        public ObstacleIgnoreSizeEnum ObstacleIgnoreSize;
        public ObstacleSmashableSizeEnum ObstacleSmashableSize;
        private byte[] fieldpad = new byte[2];
        public JumpHeightEnum JumpHeight;
        public MovementHints CharacterMovementMovementHints;
        public float ThrottleScale;
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
        public override System.Collections.Generic.Queue<Moonfish.Tags.BlamPointer> ReadFields(Moonfish.Guerilla.BlamBinaryReader binaryReader)
        {
            System.Collections.Generic.Queue<Moonfish.Tags.BlamPointer> pointerQueue = new System.Collections.Generic.Queue<Moonfish.Tags.BlamPointer>(base.ReadFields(binaryReader));
            this.CharacterMovementMovementFlags = ((MovementFlags)(binaryReader.ReadInt32()));
            this.PathfindingRadius = binaryReader.ReadSingle();
            this.DestinationRadius = binaryReader.ReadSingle();
            this.DiveGrenadeChance = binaryReader.ReadSingle();
            this.ObstacleLeapMinSize = ((ObstacleLeapMinSizeEnum)(binaryReader.ReadInt16()));
            this.ObstacleLeapMaxSize = ((ObstacleLeapMaxSizeEnum)(binaryReader.ReadInt16()));
            this.ObstacleIgnoreSize = ((ObstacleIgnoreSizeEnum)(binaryReader.ReadInt16()));
            this.ObstacleSmashableSize = ((ObstacleSmashableSizeEnum)(binaryReader.ReadInt16()));
            this.fieldpad = binaryReader.ReadBytes(2);
            this.JumpHeight = ((JumpHeightEnum)(binaryReader.ReadInt16()));
            this.CharacterMovementMovementHints = ((MovementHints)(binaryReader.ReadInt32()));
            this.ThrottleScale = binaryReader.ReadSingle();
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
            writer.Write(((int)(this.CharacterMovementMovementFlags)));
            writer.Write(this.PathfindingRadius);
            writer.Write(this.DestinationRadius);
            writer.Write(this.DiveGrenadeChance);
            writer.Write(((short)(this.ObstacleLeapMinSize)));
            writer.Write(((short)(this.ObstacleLeapMaxSize)));
            writer.Write(((short)(this.ObstacleIgnoreSize)));
            writer.Write(((short)(this.ObstacleSmashableSize)));
            writer.Write(this.fieldpad);
            writer.Write(((short)(this.JumpHeight)));
            writer.Write(((int)(this.CharacterMovementMovementHints)));
            writer.Write(this.ThrottleScale);
        }
        [System.FlagsAttribute()]
        public enum MovementFlags : int
        {
            None = 0,
            DangerCrouchAllowMovement = 1,
            NoSidestep = 2,
            PreferToCombarNearFriends = 4,
            HoptoCoverPathSegements = 8,
            Perch = 16,
            HasFlyingMode = 32,
            DisallowCrouch = 64,
        }
        public enum ObstacleLeapMinSizeEnum : short
        {
            None = 0,
            Tiny = 1,
            Small = 2,
            Medium = 3,
            Large = 4,
            Huge = 5,
            Immobile = 6,
        }
        public enum ObstacleLeapMaxSizeEnum : short
        {
            None = 0,
            Tiny = 1,
            Small = 2,
            Medium = 3,
            Large = 4,
            Huge = 5,
            Immobile = 6,
        }
        public enum ObstacleIgnoreSizeEnum : short
        {
            None = 0,
            Tiny = 1,
            Small = 2,
            Medium = 3,
            Large = 4,
            Huge = 5,
            Immobile = 6,
        }
        public enum ObstacleSmashableSizeEnum : short
        {
            None = 0,
            Tiny = 1,
            Small = 2,
            Medium = 3,
            Large = 4,
            Huge = 5,
            Immobile = 6,
        }
        public enum JumpHeightEnum : short
        {
            NONE = 0,
            Down = 1,
            Step = 2,
            Crouch = 3,
            Stand = 4,
            Storey = 5,
            Tower = 6,
            Infinite = 7,
        }
        [System.FlagsAttribute()]
        public enum MovementHints : int
        {
            None = 0,
            VaultStep = 1,
            VaultCrouch = 2,
            MountStep = 32,
            MountCrouch = 64,
            MountStand = 128,
            HoistCrouch = 2048,
            HoistStand = 4096,
        }
    }
}
