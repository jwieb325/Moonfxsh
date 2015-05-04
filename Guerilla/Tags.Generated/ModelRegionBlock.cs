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
    public partial class ModelRegionBlock : ModelRegionBlockBase
    {
        public ModelRegionBlock() : base()
        {
        }
    };

    [LayoutAttribute(Size = 16, Alignment = 4)]
    public class ModelRegionBlockBase : GuerillaBlock
    {
        internal Moonfish.Tags.StringIdent name;
        internal byte collisionRegionIndex;
        internal byte physicsRegionIndex;
        internal byte[] invalidName_;
        internal ModelPermutationBlock[] permutations;

        public override int SerializedSize
        {
            get { return 16; }
        }

        public override int Alignment
        {
            get { return 4; }
        }

        public ModelRegionBlockBase() : base()
        {
        }

        public override Queue<BlamPointer> ReadFields(BinaryReader binaryReader)
        {
            var blamPointers = new Queue<BlamPointer>(base.ReadFields(binaryReader));
            name = binaryReader.ReadStringID();
            collisionRegionIndex = binaryReader.ReadByte();
            physicsRegionIndex = binaryReader.ReadByte();
            invalidName_ = binaryReader.ReadBytes(2);
            blamPointers.Enqueue(ReadBlockArrayPointer<ModelPermutationBlock>(binaryReader));
            return blamPointers;
        }

        public override void ReadPointers(BinaryReader binaryReader, Queue<BlamPointer> blamPointers)
        {
            base.ReadPointers(binaryReader, blamPointers);
            permutations = ReadBlockArrayData<ModelPermutationBlock>(binaryReader, blamPointers.Dequeue());
        }

        public override int Write(BinaryWriter binaryWriter, int nextAddress)
        {
            base.Write(binaryWriter, nextAddress);
            using (binaryWriter.BaseStream.Pin())
            {
                binaryWriter.Write(name);
                binaryWriter.Write(collisionRegionIndex);
                binaryWriter.Write(physicsRegionIndex);
                binaryWriter.Write(invalidName_, 0, 2);
                nextAddress = Guerilla.WriteBlockArray<ModelPermutationBlock>(binaryWriter, permutations, nextAddress);
                return nextAddress;
            }
        }
    };
}