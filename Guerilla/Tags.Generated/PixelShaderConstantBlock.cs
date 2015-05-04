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
    public partial class PixelShaderConstantBlock : PixelShaderConstantBlockBase
    {
        public PixelShaderConstantBlock() : base()
        {
        }
    };
    [LayoutAttribute(Size = 6, Alignment = 4)]
    public class PixelShaderConstantBlockBase : GuerillaBlock
    {
        internal ParameterType parameterType;
        internal byte combinerIndex;
        internal byte registerIndex;
        internal ComponentMask componentMask;
        internal byte[] invalidName_;
        internal byte[] invalidName_0;
        public override int SerializedSize { get { return 6; } }
        public override int Alignment { get { return 4; } }
        public PixelShaderConstantBlockBase() : base()
        {
        }
        public override Queue<BlamPointer> ReadFields(BinaryReader binaryReader)
        {
            var blamPointers = new Queue<BlamPointer>(base.ReadFields(binaryReader));
            parameterType = (ParameterType)binaryReader.ReadByte();
            combinerIndex = binaryReader.ReadByte();
            registerIndex = binaryReader.ReadByte();
            componentMask = (ComponentMask)binaryReader.ReadByte();
            invalidName_ = binaryReader.ReadBytes(1);
            invalidName_0 = binaryReader.ReadBytes(1);
            return blamPointers;
        }
        public override void ReadPointers(BinaryReader binaryReader, Queue<BlamPointer> blamPointers)
        {
            base.ReadPointers(binaryReader, blamPointers);
            invalidName_[0].ReadPointers(binaryReader, blamPointers);
            invalidName_0[0].ReadPointers(binaryReader, blamPointers);
        }
        public override int Write(BinaryWriter binaryWriter, int nextAddress)
        {
            base.Write(binaryWriter, nextAddress);
using(binaryWriter.BaseStream.Pin())
            {
                binaryWriter.Write((Byte)parameterType);
                binaryWriter.Write(combinerIndex);
                binaryWriter.Write(registerIndex);
                binaryWriter.Write((Byte)componentMask);
                binaryWriter.Write(invalidName_, 0, 1);
                binaryWriter.Write(invalidName_0, 0, 1);
                return nextAddress;
            }
        }
        internal enum ParameterType : byte
        {
            Bitmap = 0,
            Value = 1,
            Color = 2,
            Switch = 3,
        };
        internal enum ComponentMask : byte
        {
            XValue = 0,
            YValue = 1,
            ZValue = 2,
            WValue = 3,
            XyzRgbColor = 4,
        };
    };
}
