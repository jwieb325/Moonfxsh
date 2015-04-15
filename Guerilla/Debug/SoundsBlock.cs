// ReSharper disable All
using Moonfish.Model;
using Moonfish.Tags.BlamExtension;
using Moonfish.Tags;
using OpenTK;
using System;
using System.IO;

namespace Moonfish.Guerilla.Tags
{
    public  partial class SoundsBlock : SoundsBlockBase
    {
        public  SoundsBlock(BinaryReader binaryReader): base(binaryReader)
        {
            
        }
    };
    [LayoutAttribute(Size = 8, Alignment = 4)]
    public class SoundsBlockBase  : IGuerilla
    {
        [TagReference("snd!")]
        internal Moonfish.Tags.TagReference sound;
        internal  SoundsBlockBase(BinaryReader binaryReader)
        {
            sound = binaryReader.ReadTagReference();
        }
        public int Write(System.IO.BinaryWriter binaryWriter, Int32 nextAddress)
        {
            using(binaryWriter.BaseStream.Pin())
            {
                binaryWriter.Write(sound);
                return nextAddress;
            }
        }
    };
}
