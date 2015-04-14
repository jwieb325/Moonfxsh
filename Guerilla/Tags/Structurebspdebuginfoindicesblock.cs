// ReSharper disable All
using Moonfish.Model;
using Moonfish.Tags.BlamExtension;
using Moonfish.Tags;
using OpenTK;
using System;
using System.IO;

namespace Moonfish.Guerilla.Tags
{
    public  partial class StructureBspDebugInfoIndicesBlock : StructureBspDebugInfoIndicesBlockBase
    {
        public  StructureBspDebugInfoIndicesBlock(BinaryReader binaryReader): base(binaryReader)
        {
            
        }
    };
    [LayoutAttribute(Size = 4, Alignment = 4)]
    public class StructureBspDebugInfoIndicesBlockBase  : IGuerilla
    {
        internal int index;
        internal  StructureBspDebugInfoIndicesBlockBase(BinaryReader binaryReader)
        {
            index = binaryReader.ReadInt32();
        }
        public int Write(System.IO.BinaryWriter binaryWriter, Int32 nextAddress)
        {
            using(binaryWriter.BaseStream.Pin())
            {
                binaryWriter.Write(index);
                return nextAddress = (int)binaryWriter.BaseStream.Position;
            }
        }
    };
}
