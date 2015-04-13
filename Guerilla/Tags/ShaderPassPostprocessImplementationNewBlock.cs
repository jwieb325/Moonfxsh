using Moonfish.Model;
using Moonfish.Tags.BlamExtension;
using Moonfish.Tags;
using OpenTK;
using System;
using System.IO;

namespace Moonfish.Guerilla.Tags
{
    public  partial class ShaderPassPostprocessImplementationNewBlock : ShaderPassPostprocessImplementationNewBlockBase
    {
        public  ShaderPassPostprocessImplementationNewBlock(BinaryReader binaryReader): base(binaryReader)
        {
            
        }
    };
    [LayoutAttribute(Size = 306)]
    public class ShaderPassPostprocessImplementationNewBlockBase
    {
        internal TagBlockIndexStructBlock textures;
        internal TagBlockIndexStructBlock renderStates;
        internal TagBlockIndexStructBlock textureStates;
        internal byte[] invalidName_;
        internal TagBlockIndexStructBlock psFragments;
        internal TagBlockIndexStructBlock psPermutations;
        internal TagBlockIndexStructBlock psCombiners;
        [TagReference("vrtx")]
        internal Moonfish.Tags.TagReference vertexShader;
        internal byte[] invalidName_0;
        internal byte[] invalidName_1;
        internal byte[] invalidName_2;
        internal byte[] invalidName_3;
        internal TagBlockIndexStructBlock defaultRenderStates;
        internal TagBlockIndexStructBlock renderStateExterns;
        internal TagBlockIndexStructBlock textureStateExterns;
        internal TagBlockIndexStructBlock pixelConstantExterns;
        internal TagBlockIndexStructBlock vertexConstantExterns;
        internal TagBlockIndexStructBlock psConstants;
        internal TagBlockIndexStructBlock vsConstants;
        internal TagBlockIndexStructBlock pixelConstantInfo;
        internal TagBlockIndexStructBlock vertexConstantInfo;
        internal TagBlockIndexStructBlock renderStateInfo;
        internal TagBlockIndexStructBlock textureStateInfo;
        internal  ShaderPassPostprocessImplementationNewBlockBase(BinaryReader binaryReader)
        {
            this.textures = new TagBlockIndexStructBlock(binaryReader);
            this.renderStates = new TagBlockIndexStructBlock(binaryReader);
            this.textureStates = new TagBlockIndexStructBlock(binaryReader);
            this.invalidName_ = binaryReader.ReadBytes(240);
            this.psFragments = new TagBlockIndexStructBlock(binaryReader);
            this.psPermutations = new TagBlockIndexStructBlock(binaryReader);
            this.psCombiners = new TagBlockIndexStructBlock(binaryReader);
            this.vertexShader = binaryReader.ReadTagReference();
            this.invalidName_0 = binaryReader.ReadBytes(8);
            this.invalidName_1 = binaryReader.ReadBytes(8);
            this.invalidName_2 = binaryReader.ReadBytes(4);
            this.invalidName_3 = binaryReader.ReadBytes(4);
            this.defaultRenderStates = new TagBlockIndexStructBlock(binaryReader);
            this.renderStateExterns = new TagBlockIndexStructBlock(binaryReader);
            this.textureStateExterns = new TagBlockIndexStructBlock(binaryReader);
            this.pixelConstantExterns = new TagBlockIndexStructBlock(binaryReader);
            this.vertexConstantExterns = new TagBlockIndexStructBlock(binaryReader);
            this.psConstants = new TagBlockIndexStructBlock(binaryReader);
            this.vsConstants = new TagBlockIndexStructBlock(binaryReader);
            this.pixelConstantInfo = new TagBlockIndexStructBlock(binaryReader);
            this.vertexConstantInfo = new TagBlockIndexStructBlock(binaryReader);
            this.renderStateInfo = new TagBlockIndexStructBlock(binaryReader);
            this.textureStateInfo = new TagBlockIndexStructBlock(binaryReader);
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
