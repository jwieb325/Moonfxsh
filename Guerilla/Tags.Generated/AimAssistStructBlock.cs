// ReSharper disable All
using Moonfish.Model;
using Moonfish.Tags.BlamExtension;
using Moonfish.Tags;
using OpenTK;
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace Moonfish.Guerilla.Tags
{
    public partial class AimAssistStructBlock : AimAssistStructBlockBase
    {
        public AimAssistStructBlock() : base()
        {
        }
    };
    [LayoutAttribute(Size = 36, Alignment = 4)]
    public class AimAssistStructBlockBase : GuerillaBlock
    {
        /// <summary>
        /// the maximum angle that autoaim works at full strength
        /// </summary>
        internal float autoaimAngleDegrees;
        /// <summary>
        /// the maximum distance that autoaim works at full strength
        /// </summary>
        internal float autoaimRangeWorldUnits;
        /// <summary>
        /// the maximum angle that magnetism works at full strength
        /// </summary>
        internal float magnetismAngleDegrees;
        /// <summary>
        /// the maximum distance that magnetism works at full strength
        /// </summary>
        internal float magnetismRangeWorldUnits;
        /// <summary>
        /// the maximum angle that a projectile is allowed to deviate from the gun barrel
        /// </summary>
        internal float deviationAngleDegrees;
        internal byte[] invalidName_;
        internal byte[] invalidName_0;
        public override int SerializedSize { get { return 36; } }
        public override int Alignment { get { return 4; } }
        public AimAssistStructBlockBase() : base()
        {
        }
        public override Queue<BlamPointer> ReadFields(BinaryReader binaryReader)
        {
            var blamPointers = new Queue<BlamPointer>(base.ReadFields(binaryReader));
            autoaimAngleDegrees = binaryReader.ReadSingle();
            autoaimRangeWorldUnits = binaryReader.ReadSingle();
            magnetismAngleDegrees = binaryReader.ReadSingle();
            magnetismRangeWorldUnits = binaryReader.ReadSingle();
            deviationAngleDegrees = binaryReader.ReadSingle();
            invalidName_ = binaryReader.ReadBytes(4);
            invalidName_0 = binaryReader.ReadBytes(12);
            return blamPointers;
        }
        public override void ReadPointers(BinaryReader binaryReader, Queue<BlamPointer> blamPointers)
        {
            base.ReadPointers(binaryReader, blamPointers);
            invalidName_[0].ReadPointers(binaryReader, blamPointers);
            invalidName_[1].ReadPointers(binaryReader, blamPointers);
            invalidName_[2].ReadPointers(binaryReader, blamPointers);
            invalidName_[3].ReadPointers(binaryReader, blamPointers);
            invalidName_0[0].ReadPointers(binaryReader, blamPointers);
            invalidName_0[1].ReadPointers(binaryReader, blamPointers);
            invalidName_0[2].ReadPointers(binaryReader, blamPointers);
            invalidName_0[3].ReadPointers(binaryReader, blamPointers);
            invalidName_0[4].ReadPointers(binaryReader, blamPointers);
            invalidName_0[5].ReadPointers(binaryReader, blamPointers);
            invalidName_0[6].ReadPointers(binaryReader, blamPointers);
            invalidName_0[7].ReadPointers(binaryReader, blamPointers);
            invalidName_0[8].ReadPointers(binaryReader, blamPointers);
            invalidName_0[9].ReadPointers(binaryReader, blamPointers);
            invalidName_0[10].ReadPointers(binaryReader, blamPointers);
            invalidName_0[11].ReadPointers(binaryReader, blamPointers);
        }
        public override int Write(BinaryWriter binaryWriter, int nextAddress)
        {
            base.Write(binaryWriter, nextAddress);
using(binaryWriter.BaseStream.Pin())
            {
                binaryWriter.Write(autoaimAngleDegrees);
                binaryWriter.Write(autoaimRangeWorldUnits);
                binaryWriter.Write(magnetismAngleDegrees);
                binaryWriter.Write(magnetismRangeWorldUnits);
                binaryWriter.Write(deviationAngleDegrees);
                binaryWriter.Write(invalidName_, 0, 4);
                binaryWriter.Write(invalidName_0, 0, 12);
                return nextAddress;
            }
        }
    };
}
