// ReSharper disable All
using Moonfish.Model;
using Moonfish.Tags.BlamExtension;
using Moonfish.Tags;
using OpenTK;
using System;
using System.IO;

namespace Moonfish.Guerilla.Tags
{
    public  partial class ShaderPostprocessLayerBlock : ShaderPostprocessLayerBlockBase
    {
        public  ShaderPostprocessLayerBlock(BinaryReader binaryReader): base(binaryReader)
        {
            
        }
    };
    [LayoutAttribute(Size = 2, Alignment = 4)]
    public class ShaderPostprocessLayerBlockBase  : IGuerilla
    {
        internal TagBlockIndexStructBlock passes;
        internal  ShaderPostprocessLayerBlockBase(BinaryReader binaryReader)
        {
            passes = new TagBlockIndexStructBlock(binaryReader);
        }
        public int Write(System.IO.BinaryWriter binaryWriter, Int32 nextAddress)
        {
            using(binaryWriter.BaseStream.Pin())
            {
                passes.Write(binaryWriter);
                return nextAddress;
            }
        }
    };
}
