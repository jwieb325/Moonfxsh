// ReSharper disable All
using Moonfish.Model;
using Moonfish.Tags.BlamExtension;
using Moonfish.Tags;
using OpenTK;
using System;
using System.IO;

namespace Moonfish.Guerilla.Tags
{
    public  partial class GlobalGeometryBlockResourceBlock : GlobalGeometryBlockResourceBlockBase
    {
        public  GlobalGeometryBlockResourceBlock(BinaryReader binaryReader): base(binaryReader)
        {
            
        }
    };
    [LayoutAttribute(Size = 16, Alignment = 4)]
    public class GlobalGeometryBlockResourceBlockBase  : IGuerilla
    {
        internal Type type;
        internal byte[] invalidName_;
        internal short primaryLocator;
        internal short secondaryLocator;
        internal int resourceDataSize;
        internal int resourceDataOffset;
        internal  GlobalGeometryBlockResourceBlockBase(BinaryReader binaryReader)
        {
            type = (Type)binaryReader.ReadByte();
            invalidName_ = binaryReader.ReadBytes(3);
            primaryLocator = binaryReader.ReadInt16();
            secondaryLocator = binaryReader.ReadInt16();
            resourceDataSize = binaryReader.ReadInt32();
            resourceDataOffset = binaryReader.ReadInt32();
        }
        public int Write(System.IO.BinaryWriter binaryWriter, Int32 nextAddress)
        {
            using(binaryWriter.BaseStream.Pin())
            {
                binaryWriter.Write((Byte)type);
                binaryWriter.Write(invalidName_, 0, 3);
                binaryWriter.Write(primaryLocator);
                binaryWriter.Write(secondaryLocator);
                binaryWriter.Write(resourceDataSize);
                binaryWriter.Write(resourceDataOffset);
                return nextAddress = (int)binaryWriter.BaseStream.Position;
            }
        }
        internal enum Type : byte
        {
            TagBlock = 0,
            TagData = 1,
            VertexBuffer = 2,
        };
    };
}
