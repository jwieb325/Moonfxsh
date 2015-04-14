// ReSharper disable All
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
    [LayoutAttribute(Size = 306, Alignment = 4)]
    public class ShaderPassPostprocessImplementationNewBlockBase  : IGuerilla
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
            textures = new TagBlockIndexStructBlock(binaryReader);
            renderStates = new TagBlockIndexStructBlock(binaryReader);
            textureStates = new TagBlockIndexStructBlock(binaryReader);
            invalidName_ = binaryReader.ReadBytes(240);
            psFragments = new TagBlockIndexStructBlock(binaryReader);
            psPermutations = new TagBlockIndexStructBlock(binaryReader);
            psCombiners = new TagBlockIndexStructBlock(binaryReader);
            vertexShader = binaryReader.ReadTagReference();
            invalidName_0 = binaryReader.ReadBytes(8);
            invalidName_1 = binaryReader.ReadBytes(8);
            invalidName_2 = binaryReader.ReadBytes(4);
            invalidName_3 = binaryReader.ReadBytes(4);
            defaultRenderStates = new TagBlockIndexStructBlock(binaryReader);
            renderStateExterns = new TagBlockIndexStructBlock(binaryReader);
            textureStateExterns = new TagBlockIndexStructBlock(binaryReader);
            pixelConstantExterns = new TagBlockIndexStructBlock(binaryReader);
            vertexConstantExterns = new TagBlockIndexStructBlock(binaryReader);
            psConstants = new TagBlockIndexStructBlock(binaryReader);
            vsConstants = new TagBlockIndexStructBlock(binaryReader);
            pixelConstantInfo = new TagBlockIndexStructBlock(binaryReader);
            vertexConstantInfo = new TagBlockIndexStructBlock(binaryReader);
            renderStateInfo = new TagBlockIndexStructBlock(binaryReader);
            textureStateInfo = new TagBlockIndexStructBlock(binaryReader);
        }
        public int Write(System.IO.BinaryWriter binaryWriter, Int32 nextAddress)
        {
            using(binaryWriter.BaseStream.Pin())
            {
                textures.Write(binaryWriter);
                renderStates.Write(binaryWriter);
                textureStates.Write(binaryWriter);
                binaryWriter.Write(invalidName_, 0, 240);
                psFragments.Write(binaryWriter);
                psPermutations.Write(binaryWriter);
                psCombiners.Write(binaryWriter);
                binaryWriter.Write(vertexShader);
                binaryWriter.Write(invalidName_0, 0, 8);
                binaryWriter.Write(invalidName_1, 0, 8);
                binaryWriter.Write(invalidName_2, 0, 4);
                binaryWriter.Write(invalidName_3, 0, 4);
                defaultRenderStates.Write(binaryWriter);
                renderStateExterns.Write(binaryWriter);
                textureStateExterns.Write(binaryWriter);
                pixelConstantExterns.Write(binaryWriter);
                vertexConstantExterns.Write(binaryWriter);
                psConstants.Write(binaryWriter);
                vsConstants.Write(binaryWriter);
                pixelConstantInfo.Write(binaryWriter);
                vertexConstantInfo.Write(binaryWriter);
                renderStateInfo.Write(binaryWriter);
                textureStateInfo.Write(binaryWriter);
                return nextAddress = (int)binaryWriter.BaseStream.Position;
            }
        }
    };
}
