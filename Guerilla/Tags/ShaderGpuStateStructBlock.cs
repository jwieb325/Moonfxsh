// ReSharper disable All
using Moonfish.Model;
using Moonfish.Tags.BlamExtension;
using Moonfish.Tags;
using OpenTK;
using System;
using System.IO;

namespace Moonfish.Guerilla.Tags
{
    public  partial class ShaderGpuStateStructBlock : ShaderGpuStateStructBlockBase
    {
        public  ShaderGpuStateStructBlock(BinaryReader binaryReader): base(binaryReader)
        {
            
        }
    };
    [LayoutAttribute(Size = 56, Alignment = 4)]
    public class ShaderGpuStateStructBlockBase  : IGuerilla
    {
        internal RenderStateBlock[] renderStates;
        internal TextureStageStateBlock[] textureStageStates;
        internal RenderStateParameterBlock[] renderStateParameters;
        internal TextureStageStateParameterBlock[] textureStageParameters;
        internal TextureBlock[] textures;
        internal VertexShaderConstantBlock[] vnConstants;
        internal VertexShaderConstantBlock[] cnConstants;
        internal  ShaderGpuStateStructBlockBase(BinaryReader binaryReader)
        {
            renderStates = Guerilla.ReadBlockArray<RenderStateBlock>(binaryReader);
            textureStageStates = Guerilla.ReadBlockArray<TextureStageStateBlock>(binaryReader);
            renderStateParameters = Guerilla.ReadBlockArray<RenderStateParameterBlock>(binaryReader);
            textureStageParameters = Guerilla.ReadBlockArray<TextureStageStateParameterBlock>(binaryReader);
            textures = Guerilla.ReadBlockArray<TextureBlock>(binaryReader);
            vnConstants = Guerilla.ReadBlockArray<VertexShaderConstantBlock>(binaryReader);
            cnConstants = Guerilla.ReadBlockArray<VertexShaderConstantBlock>(binaryReader);
        }
        public int Write(System.IO.BinaryWriter binaryWriter, Int32 nextAddress)
        {
            using(binaryWriter.BaseStream.Pin())
            {
                nextAddress = Guerilla.WriteBlockArray<RenderStateBlock>(binaryWriter, renderStates, nextAddress);
                nextAddress = Guerilla.WriteBlockArray<TextureStageStateBlock>(binaryWriter, textureStageStates, nextAddress);
                nextAddress = Guerilla.WriteBlockArray<RenderStateParameterBlock>(binaryWriter, renderStateParameters, nextAddress);
                nextAddress = Guerilla.WriteBlockArray<TextureStageStateParameterBlock>(binaryWriter, textureStageParameters, nextAddress);
                nextAddress = Guerilla.WriteBlockArray<TextureBlock>(binaryWriter, textures, nextAddress);
                nextAddress = Guerilla.WriteBlockArray<VertexShaderConstantBlock>(binaryWriter, vnConstants, nextAddress);
                nextAddress = Guerilla.WriteBlockArray<VertexShaderConstantBlock>(binaryWriter, cnConstants, nextAddress);
                return nextAddress;
            }
        }
    };
}
