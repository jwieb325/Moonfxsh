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
    public partial class GloalWindPrimitivesBlock : GloalWindPrimitivesBlockBase
    {
        public GloalWindPrimitivesBlock() : base()
        {
        }
    };
    [LayoutAttribute(Size = 24, Alignment = 4)]
    public class GloalWindPrimitivesBlockBase : GuerillaBlock
    {
        internal OpenTK.Vector3 position;
        internal float radius;
        internal float strength;
        internal WindPrimitiveType windPrimitiveType;
        internal byte[] invalidName_;
        public override int SerializedSize { get { return 24; } }
        public override int Alignment { get { return 4; } }
        public GloalWindPrimitivesBlockBase() : base()
        {
        }
        public override Queue<BlamPointer> ReadFields(BinaryReader binaryReader)
        {
            var blamPointers = new Queue<BlamPointer>(base.ReadFields(binaryReader));
            position = binaryReader.ReadVector3();
            radius = binaryReader.ReadSingle();
            strength = binaryReader.ReadSingle();
            windPrimitiveType = (WindPrimitiveType)binaryReader.ReadInt16();
            invalidName_ = binaryReader.ReadBytes(2);
            return blamPointers;
        }
        public override void ReadPointers(BinaryReader binaryReader, Queue<BlamPointer> blamPointers)
        {
            base.ReadPointers(binaryReader, blamPointers);
            invalidName_[0].ReadPointers(binaryReader, blamPointers);
            invalidName_[1].ReadPointers(binaryReader, blamPointers);
        }
        public override int Write(BinaryWriter binaryWriter, int nextAddress)
        {
            base.Write(binaryWriter, nextAddress);
using(binaryWriter.BaseStream.Pin())
            {
                binaryWriter.Write(position);
                binaryWriter.Write(radius);
                binaryWriter.Write(strength);
                binaryWriter.Write((Int16)windPrimitiveType);
                binaryWriter.Write(invalidName_, 0, 2);
                return nextAddress;
            }
        }
        internal enum WindPrimitiveType : short
        {
            Vortex = 0,
            Gust = 1,
            Implosion = 2,
            Explosion = 3,
        };
    };
}
