// ReSharper disable All
using Moonfish.Model;
using Moonfish.Tags.BlamExtension;
using Moonfish.Tags;
using OpenTK;
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace Moonfish.Guerilla.Tags
{
    public partial class ShaderTextureStateConstantBlock : ShaderTextureStateConstantBlockBase
    {
        public ShaderTextureStateConstantBlock() : base()
        {
        }
    };
    [LayoutAttribute(Size = 8, Alignment = 4)]
    public class ShaderTextureStateConstantBlockBase : GuerillaBlock
    {
        internal Moonfish.Tags.StringIdent sourceParameter;
        internal byte[] invalidName_;
        internal Constant constant;
        public override int SerializedSize { get { return 8; } }
        public override int Alignment { get { return 4; } }
        public ShaderTextureStateConstantBlockBase() : base()
        {
        }
        public override Queue<BlamPointer> ReadFields(BinaryReader binaryReader)
        {
            var blamPointers = new Queue<BlamPointer>(base.ReadFields(binaryReader));
            sourceParameter = binaryReader.ReadStringID();
            invalidName_ = binaryReader.ReadBytes(2);
            constant = (Constant)binaryReader.ReadInt16();
            return blamPointers;
        }
        public override void ReadPointers(BinaryReader binaryReader, Queue<BlamPointer> blamPointers)
        {
            base.ReadPointers(binaryReader, blamPointers);
            invalidName_[0].ReadPointers(binaryReader, blamPointers);
            invalidName_[1].ReadPointers(binaryReader, blamPointers);
        }
        public override int Write(BinaryWriter binaryWriter, int nextAddress)
        {
            base.Write(binaryWriter, nextAddress);
using(binaryWriter.BaseStream.Pin())
            {
                binaryWriter.Write(sourceParameter);
                binaryWriter.Write(invalidName_, 0, 2);
                binaryWriter.Write((Int16)constant);
                return nextAddress;
            }
        }
        internal enum Constant : short
        {
            MipmapBiasValue = 0,
            ColorkeyColor = 1,
            BorderColor = 2,
            BorderAlphaValue = 3,
            BumpenvMat00 = 4,
            BumpenvMat01 = 5,
            BumpenvMat10 = 6,
            BumpenvMat11 = 7,
            BumpenvLumScaleValue = 8,
            BumpenvLumOffsetValue = 9,
        };
    };
}
