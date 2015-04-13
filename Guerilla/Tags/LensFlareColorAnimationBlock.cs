using Moonfish.Model;
using Moonfish.Tags.BlamExtension;
using Moonfish.Tags;
using OpenTK;
using System;
using System.IO;

namespace Moonfish.Guerilla.Tags
{
    public  partial class LensFlareColorAnimationBlock : LensFlareColorAnimationBlockBase
    {
        public  LensFlareColorAnimationBlock(BinaryReader binaryReader): base(binaryReader)
        {
            
        }
    };
    [LayoutAttribute(Size = 8)]
    public class LensFlareColorAnimationBlockBase
    {
        internal ColorFunctionStructBlock function;
        internal  LensFlareColorAnimationBlockBase(BinaryReader binaryReader)
        {
            this.function = new ColorFunctionStructBlock(binaryReader);
        }
        internal  virtual byte[] ReadData(BinaryReader binaryReader)
        {
            var blamPointer = binaryReader.ReadBlamPointer(1);
            var data = new byte[blamPointer.elementCount];
            if(blamPointer.elementCount > 0)
            {
                using (binaryReader.BaseStream.Pin())
                {
                    binaryReader.BaseStream.Position = blamPointer[0];
                    data = binaryReader.ReadBytes(blamPointer.elementCount);
                }
            }
            return data;
        }
    };
}