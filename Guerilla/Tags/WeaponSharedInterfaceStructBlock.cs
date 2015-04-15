// ReSharper disable All
using Moonfish.Model;
using Moonfish.Tags.BlamExtension;
using Moonfish.Tags;
using OpenTK;
using System;
using System.IO;

namespace Moonfish.Guerilla.Tags
{
    public  partial class WeaponSharedInterfaceStructBlock : WeaponSharedInterfaceStructBlockBase
    {
        public  WeaponSharedInterfaceStructBlock(BinaryReader binaryReader): base(binaryReader)
        {
            
        }
    };
    [LayoutAttribute(Size = 16, Alignment = 4)]
    public class WeaponSharedInterfaceStructBlockBase  : IGuerilla
    {
        internal byte[] invalidName_;
        internal  WeaponSharedInterfaceStructBlockBase(BinaryReader binaryReader)
        {
            invalidName_ = binaryReader.ReadBytes(16);
        }
        public int Write(System.IO.BinaryWriter binaryWriter, Int32 nextAddress)
        {
            using(binaryWriter.BaseStream.Pin())
            {
                binaryWriter.Write(invalidName_, 0, 16);
                return nextAddress;
            }
        }
    };
}
