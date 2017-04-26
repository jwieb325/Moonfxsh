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
    [TagBlockOriginalNameAttribute("pathfinding_hints_block")]
    public partial class PathfindingHintsBlock : GuerillaBlock, IWriteDeferrable
    {
        public HintTypeEnum HintType;
        public short NextHintIndex;
        public short HintData0;
        public short HintData1;
        public short HintData2;
        public short HintData3;
        public short HintData4;
        public short HintData5;
        public short HintData6;
        public short HintData7;
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
            this.HintType = ((HintTypeEnum)(binaryReader.ReadInt16()));
            this.NextHintIndex = binaryReader.ReadInt16();
            this.HintData0 = binaryReader.ReadInt16();
            this.HintData1 = binaryReader.ReadInt16();
            this.HintData2 = binaryReader.ReadInt16();
            this.HintData3 = binaryReader.ReadInt16();
            this.HintData4 = binaryReader.ReadInt16();
            this.HintData5 = binaryReader.ReadInt16();
            this.HintData6 = binaryReader.ReadInt16();
            this.HintData7 = binaryReader.ReadInt16();
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
            writer.Write(((short)(this.HintType)));
            writer.Write(this.NextHintIndex);
            writer.Write(this.HintData0);
            writer.Write(this.HintData1);
            writer.Write(this.HintData2);
            writer.Write(this.HintData3);
            writer.Write(this.HintData4);
            writer.Write(this.HintData5);
            writer.Write(this.HintData6);
            writer.Write(this.HintData7);
        }
        public enum HintTypeEnum : short
        {
            IntersectionLink = 0,
            JumpLink = 1,
            ClimbLink = 2,
            VaultLink = 3,
            MountLink = 4,
            HoistLink = 5,
            WallJumpLink = 6,
            BreakableFloor = 7,
        }
    }
}
