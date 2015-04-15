// ReSharper disable All
using Moonfish.Model;
using Moonfish.Tags.BlamExtension;
using Moonfish.Tags;
using OpenTK;
using System;
using System.IO;

namespace Moonfish.Guerilla.Tags
{
    public  partial class GlobalGeometryMaterialBlock : GlobalGeometryMaterialBlockBase
    {
        public  GlobalGeometryMaterialBlock(BinaryReader binaryReader): base(binaryReader)
        {
            
        }
    };
    [LayoutAttribute(Size = 32, Alignment = 4)]
    public class GlobalGeometryMaterialBlockBase  : IGuerilla
    {
        [TagReference("shad")]
        internal Moonfish.Tags.TagReference oldShader;
        [TagReference("shad")]
        internal Moonfish.Tags.TagReference shader;
        internal GlobalGeometryMaterialPropertyBlock[] properties;
        internal byte[] invalidName_;
        internal byte breakableSurfaceIndex;
        internal byte[] invalidName_0;
        internal  GlobalGeometryMaterialBlockBase(BinaryReader binaryReader)
        {
            oldShader = binaryReader.ReadTagReference();
            shader = binaryReader.ReadTagReference();
            properties = Guerilla.ReadBlockArray<GlobalGeometryMaterialPropertyBlock>(binaryReader);
            invalidName_ = binaryReader.ReadBytes(4);
            breakableSurfaceIndex = binaryReader.ReadByte();
            invalidName_0 = binaryReader.ReadBytes(3);
        }
        public int Write(System.IO.BinaryWriter binaryWriter, Int32 nextAddress)
        {
            using(binaryWriter.BaseStream.Pin())
            {
                binaryWriter.Write(oldShader);
                binaryWriter.Write(shader);
                nextAddress = Guerilla.WriteBlockArray<GlobalGeometryMaterialPropertyBlock>(binaryWriter, properties, nextAddress);
                binaryWriter.Write(invalidName_, 0, 4);
                binaryWriter.Write(breakableSurfaceIndex);
                binaryWriter.Write(invalidName_0, 0, 3);
                return nextAddress;
            }
        }
    };
}
