// ReSharper disable All
using Moonfish.Model;
using Moonfish.Tags.BlamExtension;
using Moonfish.Tags;
using OpenTK;
using System;
using System.IO;

namespace Moonfish.Tags
{
    public partial struct TagClass
    {
        public static readonly TagClass SpasClass = (TagClass)"spas";
    };
};

namespace Moonfish.Guerilla.Tags
{
    [TagClassAttribute("spas")]
    public  partial class ShaderPassBlock : ShaderPassBlockBase
    {
        public  ShaderPassBlock(BinaryReader binaryReader): base(binaryReader)
        {
            
        }
    };
    [LayoutAttribute(Size = 36, Alignment = 4)]
    public class ShaderPassBlockBase  : IGuerilla
    {
        internal byte[] documentation;
        internal ShaderPassParameterBlock[] parameters;
        internal byte[] invalidName_;
        internal byte[] invalidName_0;
        internal ShaderPassImplementationBlock[] implementations;
        internal ShaderPassPostprocessDefinitionNewBlock[] postprocessDefinition;
        internal  ShaderPassBlockBase(BinaryReader binaryReader)
        {
            documentation = Guerilla.ReadData(binaryReader);
            parameters = Guerilla.ReadBlockArray<ShaderPassParameterBlock>(binaryReader);
            invalidName_ = binaryReader.ReadBytes(2);
            invalidName_0 = binaryReader.ReadBytes(2);
            implementations = Guerilla.ReadBlockArray<ShaderPassImplementationBlock>(binaryReader);
            postprocessDefinition = Guerilla.ReadBlockArray<ShaderPassPostprocessDefinitionNewBlock>(binaryReader);
        }
        public int Write(System.IO.BinaryWriter binaryWriter, Int32 nextAddress)
        {
            using(binaryWriter.BaseStream.Pin())
            {
                Guerilla.WriteData(binaryWriter);
                Guerilla.WriteBlockArray<ShaderPassParameterBlock>(binaryWriter, parameters, nextAddress);
                binaryWriter.Write(invalidName_, 0, 2);
                binaryWriter.Write(invalidName_0, 0, 2);
                Guerilla.WriteBlockArray<ShaderPassImplementationBlock>(binaryWriter, implementations, nextAddress);
                Guerilla.WriteBlockArray<ShaderPassPostprocessDefinitionNewBlock>(binaryWriter, postprocessDefinition, nextAddress);
                return nextAddress = (int)binaryWriter.BaseStream.Position;
            }
        }
    };
}
