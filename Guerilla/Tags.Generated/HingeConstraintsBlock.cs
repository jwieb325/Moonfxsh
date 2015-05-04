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
    public partial class HingeConstraintsBlock : HingeConstraintsBlockBase
    {
        public HingeConstraintsBlock() : base()
        {
        }
    };
    [LayoutAttribute(Size = 120, Alignment = 4)]
    public class HingeConstraintsBlockBase : GuerillaBlock
    {
        internal ConstraintBodiesStructBlock constraintBodies;
        internal byte[] invalidName_;
        public override int SerializedSize { get { return 120; } }
        public override int Alignment { get { return 4; } }
        public HingeConstraintsBlockBase() : base()
        {
        }
        public override Queue<BlamPointer> ReadFields(BinaryReader binaryReader)
        {
            var blamPointers = new Queue<BlamPointer>(base.ReadFields(binaryReader));
            constraintBodies = new ConstraintBodiesStructBlock();
            blamPointers = new Queue<BlamPointer>(blamPointers.Concat(constraintBodies.ReadFields(binaryReader)));
            invalidName_ = binaryReader.ReadBytes(4);
            return blamPointers;
        }
        public override void ReadPointers(BinaryReader binaryReader, Queue<BlamPointer> blamPointers)
        {
            base.ReadPointers(binaryReader, blamPointers);
            constraintBodies.ReadPointers(binaryReader, blamPointers);
        }
        public override int Write(BinaryWriter binaryWriter, int nextAddress)
        {
            base.Write(binaryWriter, nextAddress);
using(binaryWriter.BaseStream.Pin())
            {
                constraintBodies.Write(binaryWriter);
                binaryWriter.Write(invalidName_, 0, 4);
                return nextAddress;
            }
        }
    };
}
