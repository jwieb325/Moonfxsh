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
    public partial class LiquidCoreBlock : LiquidCoreBlockBase
    {
        public LiquidCoreBlock() : base()
        {
        }
    };
    [LayoutAttribute(Size = 56, Alignment = 4)]
    public class LiquidCoreBlockBase : GuerillaBlock
    {
        internal byte[] invalidName_;
        internal short bitmapIndex;
        internal byte[] invalidName_0;
        internal ScalarFunctionStructBlock thickness;
        internal ColorFunctionStructBlock color;
        internal ScalarFunctionStructBlock brightnessTime;
        internal ScalarFunctionStructBlock brightnessFacing;
        internal ScalarFunctionStructBlock alongAxisScale;
        public override int SerializedSize { get { return 56; } }
        public override int Alignment { get { return 4; } }
        public LiquidCoreBlockBase() : base()
        {
        }
        public override Queue<BlamPointer> ReadFields(BinaryReader binaryReader)
        {
            var blamPointers = new Queue<BlamPointer>(base.ReadFields(binaryReader));
            invalidName_ = binaryReader.ReadBytes(12);
            bitmapIndex = binaryReader.ReadInt16();
            invalidName_0 = binaryReader.ReadBytes(2);
            thickness = new ScalarFunctionStructBlock();
            blamPointers.Concat(thickness.ReadFields(binaryReader));
            color = new ColorFunctionStructBlock();
            blamPointers.Concat(color.ReadFields(binaryReader));
            brightnessTime = new ScalarFunctionStructBlock();
            blamPointers.Concat(brightnessTime.ReadFields(binaryReader));
            brightnessFacing = new ScalarFunctionStructBlock();
            blamPointers.Concat(brightnessFacing.ReadFields(binaryReader));
            alongAxisScale = new ScalarFunctionStructBlock();
            blamPointers.Concat(alongAxisScale.ReadFields(binaryReader));
            return blamPointers;
        }
        public override void ReadPointers(BinaryReader binaryReader, Queue<BlamPointer> blamPointers)
        {
            base.ReadPointers(binaryReader, blamPointers);
            invalidName_[0].ReadPointers(binaryReader, blamPointers);
            invalidName_[1].ReadPointers(binaryReader, blamPointers);
            invalidName_[2].ReadPointers(binaryReader, blamPointers);
            invalidName_[3].ReadPointers(binaryReader, blamPointers);
            invalidName_[4].ReadPointers(binaryReader, blamPointers);
            invalidName_[5].ReadPointers(binaryReader, blamPointers);
            invalidName_[6].ReadPointers(binaryReader, blamPointers);
            invalidName_[7].ReadPointers(binaryReader, blamPointers);
            invalidName_[8].ReadPointers(binaryReader, blamPointers);
            invalidName_[9].ReadPointers(binaryReader, blamPointers);
            invalidName_[10].ReadPointers(binaryReader, blamPointers);
            invalidName_[11].ReadPointers(binaryReader, blamPointers);
            invalidName_0[0].ReadPointers(binaryReader, blamPointers);
            invalidName_0[1].ReadPointers(binaryReader, blamPointers);
            thickness.ReadPointers(binaryReader, blamPointers);
            color.ReadPointers(binaryReader, blamPointers);
            brightnessTime.ReadPointers(binaryReader, blamPointers);
            brightnessFacing.ReadPointers(binaryReader, blamPointers);
            alongAxisScale.ReadPointers(binaryReader, blamPointers);
        }
        public override int Write(BinaryWriter binaryWriter, int nextAddress)
        {
            base.Write(binaryWriter, nextAddress);
using(binaryWriter.BaseStream.Pin())
            {
                binaryWriter.Write(invalidName_, 0, 12);
                binaryWriter.Write(bitmapIndex);
                binaryWriter.Write(invalidName_0, 0, 2);
                thickness.Write(binaryWriter);
                color.Write(binaryWriter);
                brightnessTime.Write(binaryWriter);
                brightnessFacing.Write(binaryWriter);
                alongAxisScale.Write(binaryWriter);
                return nextAddress;
            }
        }
    };
}
