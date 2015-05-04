// ReSharper disable All
using Moonfish.Model;
using Moonfish.Tags.BlamExtension;
using Moonfish.Tags;
using OpenTK;
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace Moonfish.Tags
{
    public partial struct TagClass
    {
        public static readonly TagClass Deca = (TagClass)"deca";
    };
};

namespace Moonfish.Guerilla.Tags
{
    [TagClassAttribute("deca")]
    public partial class DecalBlock : DecalBlockBase
    {
        public DecalBlock() : base()
        {
        }
    };
    [LayoutAttribute(Size = 172, Alignment = 4)]
    public class DecalBlockBase : GuerillaBlock
    {
        internal Flags flags;
        /// <summary>
        /// controls how the decal wraps onto surface geometry
        /// </summary>
        internal TypeControlsHowTheDecalWrapsOntoSurfaceGeometry type;
        internal Layer layer;
        internal short maxOverlappingCount;
        [TagReference("deca")]
        internal Moonfish.Tags.TagReference nextDecalInChain;
        /// <summary>
        /// 0 defaults to 0.125
        /// </summary>
        internal Moonfish.Model.Range radiusWorldUnits;
        internal float radiusOverlapRejectionMuliplier;
        internal Moonfish.Tags.ColourR8G8B8 colorLowerBounds;
        internal Moonfish.Tags.ColourR8G8B8 colorUpperBounds;
        internal Moonfish.Model.Range lifetimeSeconds;
        internal Moonfish.Model.Range decayTimeSeconds;
        internal byte[] invalidName_;
        internal byte[] invalidName_0;
        internal byte[] invalidName_1;
        internal byte[] invalidName_2;
        internal byte[] invalidName_3;
        internal byte[] invalidName_4;
        [TagReference("bitm")]
        internal Moonfish.Tags.TagReference bitmap;
        internal byte[] invalidName_5;
        internal float maximumSpriteExtentPixels;
        internal byte[] invalidName_6;
        public override int SerializedSize { get { return 172; } }
        public override int Alignment { get { return 4; } }
        public DecalBlockBase() : base()
        {
        }
        public override Queue<BlamPointer> ReadFields(BinaryReader binaryReader)
        {
            var blamPointers = new Queue<BlamPointer>(base.ReadFields(binaryReader));
            flags = (Flags)binaryReader.ReadInt16();
            type = (TypeControlsHowTheDecalWrapsOntoSurfaceGeometry)binaryReader.ReadInt16();
            layer = (Layer)binaryReader.ReadInt16();
            maxOverlappingCount = binaryReader.ReadInt16();
            nextDecalInChain = binaryReader.ReadTagReference();
            radiusWorldUnits = binaryReader.ReadRange();
            radiusOverlapRejectionMuliplier = binaryReader.ReadSingle();
            colorLowerBounds = binaryReader.ReadColorR8G8B8();
            colorUpperBounds = binaryReader.ReadColorR8G8B8();
            lifetimeSeconds = binaryReader.ReadRange();
            decayTimeSeconds = binaryReader.ReadRange();
            invalidName_ = binaryReader.ReadBytes(40);
            invalidName_0 = binaryReader.ReadBytes(2);
            invalidName_1 = binaryReader.ReadBytes(2);
            invalidName_2 = binaryReader.ReadBytes(2);
            invalidName_3 = binaryReader.ReadBytes(2);
            invalidName_4 = binaryReader.ReadBytes(20);
            bitmap = binaryReader.ReadTagReference();
            invalidName_5 = binaryReader.ReadBytes(20);
            maximumSpriteExtentPixels = binaryReader.ReadSingle();
            invalidName_6 = binaryReader.ReadBytes(4);
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
            invalidName_[12].ReadPointers(binaryReader, blamPointers);
            invalidName_[13].ReadPointers(binaryReader, blamPointers);
            invalidName_[14].ReadPointers(binaryReader, blamPointers);
            invalidName_[15].ReadPointers(binaryReader, blamPointers);
            invalidName_[16].ReadPointers(binaryReader, blamPointers);
            invalidName_[17].ReadPointers(binaryReader, blamPointers);
            invalidName_[18].ReadPointers(binaryReader, blamPointers);
            invalidName_[19].ReadPointers(binaryReader, blamPointers);
            invalidName_[20].ReadPointers(binaryReader, blamPointers);
            invalidName_[21].ReadPointers(binaryReader, blamPointers);
            invalidName_[22].ReadPointers(binaryReader, blamPointers);
            invalidName_[23].ReadPointers(binaryReader, blamPointers);
            invalidName_[24].ReadPointers(binaryReader, blamPointers);
            invalidName_[25].ReadPointers(binaryReader, blamPointers);
            invalidName_[26].ReadPointers(binaryReader, blamPointers);
            invalidName_[27].ReadPointers(binaryReader, blamPointers);
            invalidName_[28].ReadPointers(binaryReader, blamPointers);
            invalidName_[29].ReadPointers(binaryReader, blamPointers);
            invalidName_[30].ReadPointers(binaryReader, blamPointers);
            invalidName_[31].ReadPointers(binaryReader, blamPointers);
            invalidName_[32].ReadPointers(binaryReader, blamPointers);
            invalidName_[33].ReadPointers(binaryReader, blamPointers);
            invalidName_[34].ReadPointers(binaryReader, blamPointers);
            invalidName_[35].ReadPointers(binaryReader, blamPointers);
            invalidName_[36].ReadPointers(binaryReader, blamPointers);
            invalidName_[37].ReadPointers(binaryReader, blamPointers);
            invalidName_[38].ReadPointers(binaryReader, blamPointers);
            invalidName_[39].ReadPointers(binaryReader, blamPointers);
            invalidName_0[0].ReadPointers(binaryReader, blamPointers);
            invalidName_0[1].ReadPointers(binaryReader, blamPointers);
            invalidName_1[0].ReadPointers(binaryReader, blamPointers);
            invalidName_1[1].ReadPointers(binaryReader, blamPointers);
            invalidName_2[0].ReadPointers(binaryReader, blamPointers);
            invalidName_2[1].ReadPointers(binaryReader, blamPointers);
            invalidName_3[0].ReadPointers(binaryReader, blamPointers);
            invalidName_3[1].ReadPointers(binaryReader, blamPointers);
            invalidName_4[0].ReadPointers(binaryReader, blamPointers);
            invalidName_4[1].ReadPointers(binaryReader, blamPointers);
            invalidName_4[2].ReadPointers(binaryReader, blamPointers);
            invalidName_4[3].ReadPointers(binaryReader, blamPointers);
            invalidName_4[4].ReadPointers(binaryReader, blamPointers);
            invalidName_4[5].ReadPointers(binaryReader, blamPointers);
            invalidName_4[6].ReadPointers(binaryReader, blamPointers);
            invalidName_4[7].ReadPointers(binaryReader, blamPointers);
            invalidName_4[8].ReadPointers(binaryReader, blamPointers);
            invalidName_4[9].ReadPointers(binaryReader, blamPointers);
            invalidName_4[10].ReadPointers(binaryReader, blamPointers);
            invalidName_4[11].ReadPointers(binaryReader, blamPointers);
            invalidName_4[12].ReadPointers(binaryReader, blamPointers);
            invalidName_4[13].ReadPointers(binaryReader, blamPointers);
            invalidName_4[14].ReadPointers(binaryReader, blamPointers);
            invalidName_4[15].ReadPointers(binaryReader, blamPointers);
            invalidName_4[16].ReadPointers(binaryReader, blamPointers);
            invalidName_4[17].ReadPointers(binaryReader, blamPointers);
            invalidName_4[18].ReadPointers(binaryReader, blamPointers);
            invalidName_4[19].ReadPointers(binaryReader, blamPointers);
            invalidName_5[0].ReadPointers(binaryReader, blamPointers);
            invalidName_5[1].ReadPointers(binaryReader, blamPointers);
            invalidName_5[2].ReadPointers(binaryReader, blamPointers);
            invalidName_5[3].ReadPointers(binaryReader, blamPointers);
            invalidName_5[4].ReadPointers(binaryReader, blamPointers);
            invalidName_5[5].ReadPointers(binaryReader, blamPointers);
            invalidName_5[6].ReadPointers(binaryReader, blamPointers);
            invalidName_5[7].ReadPointers(binaryReader, blamPointers);
            invalidName_5[8].ReadPointers(binaryReader, blamPointers);
            invalidName_5[9].ReadPointers(binaryReader, blamPointers);
            invalidName_5[10].ReadPointers(binaryReader, blamPointers);
            invalidName_5[11].ReadPointers(binaryReader, blamPointers);
            invalidName_5[12].ReadPointers(binaryReader, blamPointers);
            invalidName_5[13].ReadPointers(binaryReader, blamPointers);
            invalidName_5[14].ReadPointers(binaryReader, blamPointers);
            invalidName_5[15].ReadPointers(binaryReader, blamPointers);
            invalidName_5[16].ReadPointers(binaryReader, blamPointers);
            invalidName_5[17].ReadPointers(binaryReader, blamPointers);
            invalidName_5[18].ReadPointers(binaryReader, blamPointers);
            invalidName_5[19].ReadPointers(binaryReader, blamPointers);
            invalidName_6[0].ReadPointers(binaryReader, blamPointers);
            invalidName_6[1].ReadPointers(binaryReader, blamPointers);
            invalidName_6[2].ReadPointers(binaryReader, blamPointers);
            invalidName_6[3].ReadPointers(binaryReader, blamPointers);
        }
        public override int Write(BinaryWriter binaryWriter, int nextAddress)
        {
            base.Write(binaryWriter, nextAddress);
using(binaryWriter.BaseStream.Pin())
            {
                binaryWriter.Write((Int16)flags);
                binaryWriter.Write((Int16)type);
                binaryWriter.Write((Int16)layer);
                binaryWriter.Write(maxOverlappingCount);
                binaryWriter.Write(nextDecalInChain);
                binaryWriter.Write(radiusWorldUnits);
                binaryWriter.Write(radiusOverlapRejectionMuliplier);
                binaryWriter.Write(colorLowerBounds);
                binaryWriter.Write(colorUpperBounds);
                binaryWriter.Write(lifetimeSeconds);
                binaryWriter.Write(decayTimeSeconds);
                binaryWriter.Write(invalidName_, 0, 40);
                binaryWriter.Write(invalidName_0, 0, 2);
                binaryWriter.Write(invalidName_1, 0, 2);
                binaryWriter.Write(invalidName_2, 0, 2);
                binaryWriter.Write(invalidName_3, 0, 2);
                binaryWriter.Write(invalidName_4, 0, 20);
                binaryWriter.Write(bitmap);
                binaryWriter.Write(invalidName_5, 0, 20);
                binaryWriter.Write(maximumSpriteExtentPixels);
                binaryWriter.Write(invalidName_6, 0, 4);
                return nextAddress;
            }
        }
        [FlagsAttribute]
        internal enum Flags : short
        {
            GeometryInheritedByNextDecalInChain = 1,
            InterpolateColorInHsv = 2,
            MoreColors = 4,
            NoRandomRotation = 8,
            UNUSED = 16,
            SAPIENSnapToAxis = 32,
            SAPIENIncrementalCounter = 64,
            UNUSED0 = 128,
            PreserveAspect = 256,
            UNUSED1 = 512,
        };
        internal enum TypeControlsHowTheDecalWrapsOntoSurfaceGeometry : short
        {
            Scratch = 0,
            Splatter = 1,
            Burn = 2,
            PaintedSign = 3,
        };
        internal enum Layer : short
        {
            LitAlphaBlendPrelight = 0,
            LitAlphaBlend = 1,
            DoubleMultiply = 2,
            Multiply = 3,
            Max = 4,
            Add = 5,
            Error = 6,
        };
    };
}
