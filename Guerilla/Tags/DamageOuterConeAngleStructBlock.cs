// ReSharper disable All
using Moonfish.Model;
using Moonfish.Tags.BlamExtension;
using Moonfish.Tags;
using OpenTK;
using System;
using System.IO;

namespace Moonfish.Guerilla.Tags
{
    public  partial class DamageOuterConeAngleStructBlock : DamageOuterConeAngleStructBlockBase
    {
        public  DamageOuterConeAngleStructBlock(BinaryReader binaryReader): base(binaryReader)
        {
            
        }
    };
    [LayoutAttribute(Size = 4, Alignment = 4)]
    public class DamageOuterConeAngleStructBlockBase  : IGuerilla
    {
        internal float dmgOuterConeAngle;
        internal  DamageOuterConeAngleStructBlockBase(BinaryReader binaryReader)
        {
            dmgOuterConeAngle = binaryReader.ReadSingle();
        }
        public int Write(System.IO.BinaryWriter binaryWriter, Int32 nextAddress)
        {
            using(binaryWriter.BaseStream.Pin())
            {
                binaryWriter.Write(dmgOuterConeAngle);
                return nextAddress = (int)binaryWriter.BaseStream.Position;
            }
        }
    };
}
