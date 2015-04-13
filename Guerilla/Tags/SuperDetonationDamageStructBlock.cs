using Moonfish.Model;
using Moonfish.Tags.BlamExtension;
using Moonfish.Tags;
using OpenTK;
using System;
using System.IO;

namespace Moonfish.Guerilla.Tags
{
    public  partial class SuperDetonationDamageStructBlock : SuperDetonationDamageStructBlockBase
    {
        public  SuperDetonationDamageStructBlock(BinaryReader binaryReader): base(binaryReader)
        {
            
        }
    };
    [LayoutAttribute(Size = 8)]
    public class SuperDetonationDamageStructBlockBase
    {
        [TagReference("jpt!")]
        internal Moonfish.Tags.TagReference superDetonationDamage;
        internal  SuperDetonationDamageStructBlockBase(BinaryReader binaryReader)
        {
            this.superDetonationDamage = binaryReader.ReadTagReference();
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