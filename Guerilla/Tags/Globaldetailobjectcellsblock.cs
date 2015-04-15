// ReSharper disable All
using Moonfish.Model;
using Moonfish.Tags.BlamExtension;
using Moonfish.Tags;
using OpenTK;
using System;
using System.IO;

namespace Moonfish.Guerilla.Tags
{
    public  partial class GlobalDetailObjectCellsBlock : GlobalDetailObjectCellsBlockBase
    {
        public  GlobalDetailObjectCellsBlock(BinaryReader binaryReader): base(binaryReader)
        {
            
        }
    };
    [LayoutAttribute(Size = 32, Alignment = 4)]
    public class GlobalDetailObjectCellsBlockBase  : IGuerilla
    {
        internal short invalidName_;
        internal short invalidName_0;
        internal short invalidName_1;
        internal short invalidName_2;
        internal int invalidName_3;
        internal int invalidName_4;
        internal int invalidName_5;
        internal byte[] invalidName_6;
        internal  GlobalDetailObjectCellsBlockBase(BinaryReader binaryReader)
        {
            invalidName_ = binaryReader.ReadInt16();
            invalidName_0 = binaryReader.ReadInt16();
            invalidName_1 = binaryReader.ReadInt16();
            invalidName_2 = binaryReader.ReadInt16();
            invalidName_3 = binaryReader.ReadInt32();
            invalidName_4 = binaryReader.ReadInt32();
            invalidName_5 = binaryReader.ReadInt32();
            invalidName_6 = binaryReader.ReadBytes(12);
        }
        public int Write(System.IO.BinaryWriter binaryWriter, Int32 nextAddress)
        {
            using(binaryWriter.BaseStream.Pin())
            {
                binaryWriter.Write(invalidName_);
                binaryWriter.Write(invalidName_0);
                binaryWriter.Write(invalidName_1);
                binaryWriter.Write(invalidName_2);
                binaryWriter.Write(invalidName_3);
                binaryWriter.Write(invalidName_4);
                binaryWriter.Write(invalidName_5);
                binaryWriter.Write(invalidName_6, 0, 12);
                return nextAddress;
            }
        }
    };
}
