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
    public partial class RasterizerDataBlock : RasterizerDataBlockBase
    {
        public RasterizerDataBlock() : base()
        {
        }
    };
    [LayoutAttribute(Size = 264, Alignment = 4)]
    public class RasterizerDataBlockBase : GuerillaBlock
    {
        [TagReference("bitm")]
        internal Moonfish.Tags.TagReference distanceAttenuation;
        [TagReference("bitm")]
        internal Moonfish.Tags.TagReference vectorNormalization;
        [TagReference("bitm")]
        internal Moonfish.Tags.TagReference gradients;
        [TagReference("bitm")]
        internal Moonfish.Tags.TagReference uNUSED;
        [TagReference("bitm")]
        internal Moonfish.Tags.TagReference uNUSED0;
        [TagReference("bitm")]
        internal Moonfish.Tags.TagReference uNUSED1;
        [TagReference("bitm")]
        internal Moonfish.Tags.TagReference glow;
        [TagReference("bitm")]
        internal Moonfish.Tags.TagReference uNUSED2;
        [TagReference("bitm")]
        internal Moonfish.Tags.TagReference uNUSED3;
        internal byte[] invalidName_;
        internal VertexShaderReferenceBlock[] globalVertexShaders;
        [TagReference("bitm")]
        internal Moonfish.Tags.TagReference default2D;
        [TagReference("bitm")]
        internal Moonfish.Tags.TagReference default3D;
        [TagReference("bitm")]
        internal Moonfish.Tags.TagReference defaultCubeMap;
        [TagReference("bitm")]
        internal Moonfish.Tags.TagReference uNUSED4;
        [TagReference("bitm")]
        internal Moonfish.Tags.TagReference uNUSED5;
        [TagReference("bitm")]
        internal Moonfish.Tags.TagReference uNUSED6;
        [TagReference("bitm")]
        internal Moonfish.Tags.TagReference uNUSED7;
        [TagReference("bitm")]
        internal Moonfish.Tags.TagReference uNUSED8;
        [TagReference("bitm")]
        internal Moonfish.Tags.TagReference uNUSED9;
        internal byte[] invalidName_0;
        [TagReference("shad")]
        internal Moonfish.Tags.TagReference globalShader;
        internal Flags flags;
        internal byte[] invalidName_1;
        internal float refractionAmountPixels;
        internal float distanceFalloff;
        internal Moonfish.Tags.ColourR8G8B8 tintColor;
        internal float hyperStealthRefractionPixels;
        internal float hyperStealthDistanceFalloff;
        internal Moonfish.Tags.ColourR8G8B8 hyperStealthTintColor;
        [TagReference("bitm")]
        internal Moonfish.Tags.TagReference uNUSED10;
        public override int SerializedSize { get { return 264; } }
        public override int Alignment { get { return 4; } }
        public RasterizerDataBlockBase() : base()
        {
        }
        public override Queue<BlamPointer> ReadFields(BinaryReader binaryReader)
        {
            var blamPointers = new Queue<BlamPointer>(base.ReadFields(binaryReader));
            distanceAttenuation = binaryReader.ReadTagReference();
            vectorNormalization = binaryReader.ReadTagReference();
            gradients = binaryReader.ReadTagReference();
            uNUSED = binaryReader.ReadTagReference();
            uNUSED0 = binaryReader.ReadTagReference();
            uNUSED1 = binaryReader.ReadTagReference();
            glow = binaryReader.ReadTagReference();
            uNUSED2 = binaryReader.ReadTagReference();
            uNUSED3 = binaryReader.ReadTagReference();
            invalidName_ = binaryReader.ReadBytes(16);
            blamPointers.Enqueue(ReadBlockArrayPointer<VertexShaderReferenceBlock>(binaryReader));
            default2D = binaryReader.ReadTagReference();
            default3D = binaryReader.ReadTagReference();
            defaultCubeMap = binaryReader.ReadTagReference();
            uNUSED4 = binaryReader.ReadTagReference();
            uNUSED5 = binaryReader.ReadTagReference();
            uNUSED6 = binaryReader.ReadTagReference();
            uNUSED7 = binaryReader.ReadTagReference();
            uNUSED8 = binaryReader.ReadTagReference();
            uNUSED9 = binaryReader.ReadTagReference();
            invalidName_0 = binaryReader.ReadBytes(36);
            globalShader = binaryReader.ReadTagReference();
            flags = (Flags)binaryReader.ReadInt16();
            invalidName_1 = binaryReader.ReadBytes(2);
            refractionAmountPixels = binaryReader.ReadSingle();
            distanceFalloff = binaryReader.ReadSingle();
            tintColor = binaryReader.ReadColorR8G8B8();
            hyperStealthRefractionPixels = binaryReader.ReadSingle();
            hyperStealthDistanceFalloff = binaryReader.ReadSingle();
            hyperStealthTintColor = binaryReader.ReadColorR8G8B8();
            uNUSED10 = binaryReader.ReadTagReference();
            return blamPointers;
        }
        public override void ReadPointers(BinaryReader binaryReader, Queue<BlamPointer> blamPointers)
        {
            base.ReadPointers(binaryReader, blamPointers);
            globalVertexShaders = ReadBlockArrayData<VertexShaderReferenceBlock>(binaryReader, blamPointers.Dequeue());
        }
        public override int Write(BinaryWriter binaryWriter, int nextAddress)
        {
            base.Write(binaryWriter, nextAddress);
using(binaryWriter.BaseStream.Pin())
            {
                binaryWriter.Write(distanceAttenuation);
                binaryWriter.Write(vectorNormalization);
                binaryWriter.Write(gradients);
                binaryWriter.Write(uNUSED);
                binaryWriter.Write(uNUSED0);
                binaryWriter.Write(uNUSED1);
                binaryWriter.Write(glow);
                binaryWriter.Write(uNUSED2);
                binaryWriter.Write(uNUSED3);
                binaryWriter.Write(invalidName_, 0, 16);
                nextAddress = Guerilla.WriteBlockArray<VertexShaderReferenceBlock>(binaryWriter, globalVertexShaders, nextAddress);
                binaryWriter.Write(default2D);
                binaryWriter.Write(default3D);
                binaryWriter.Write(defaultCubeMap);
                binaryWriter.Write(uNUSED4);
                binaryWriter.Write(uNUSED5);
                binaryWriter.Write(uNUSED6);
                binaryWriter.Write(uNUSED7);
                binaryWriter.Write(uNUSED8);
                binaryWriter.Write(uNUSED9);
                binaryWriter.Write(invalidName_0, 0, 36);
                binaryWriter.Write(globalShader);
                binaryWriter.Write((Int16)flags);
                binaryWriter.Write(invalidName_1, 0, 2);
                binaryWriter.Write(refractionAmountPixels);
                binaryWriter.Write(distanceFalloff);
                binaryWriter.Write(tintColor);
                binaryWriter.Write(hyperStealthRefractionPixels);
                binaryWriter.Write(hyperStealthDistanceFalloff);
                binaryWriter.Write(hyperStealthTintColor);
                binaryWriter.Write(uNUSED10);
                return nextAddress;
            }
        }
        [FlagsAttribute]
        internal enum Flags : short
        {
            TintEdgeDensity = 1,
        };
    };
}
