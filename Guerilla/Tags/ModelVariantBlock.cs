// ReSharper disable All
using Moonfish.Model;
using Moonfish.Tags.BlamExtension;
using Moonfish.Tags;
using OpenTK;
using System;
using System.IO;

namespace Moonfish.Guerilla.Tags
{
    public  partial class ModelVariantBlock : ModelVariantBlockBase
    {
        public  ModelVariantBlock(BinaryReader binaryReader): base(binaryReader)
        {
            
        }
    };
    [LayoutAttribute(Size = 56, Alignment = 4)]
    public class ModelVariantBlockBase  : IGuerilla
    {
        internal Moonfish.Tags.StringID name;
        internal byte[] invalidName_;
        internal ModelVariantRegionBlock[] regions;
        internal ModelVariantObjectBlock[] objects;
        internal byte[] invalidName_0;
        internal Moonfish.Tags.StringID dialogueSoundEffect;
        [TagReference("udlg")]
        internal Moonfish.Tags.TagReference dialogue;
        internal  ModelVariantBlockBase(BinaryReader binaryReader)
        {
            name = binaryReader.ReadStringID();
            invalidName_ = binaryReader.ReadBytes(16);
            regions = Guerilla.ReadBlockArray<ModelVariantRegionBlock>(binaryReader);
            objects = Guerilla.ReadBlockArray<ModelVariantObjectBlock>(binaryReader);
            invalidName_0 = binaryReader.ReadBytes(8);
            dialogueSoundEffect = binaryReader.ReadStringID();
            dialogue = binaryReader.ReadTagReference();
        }
        public int Write(System.IO.BinaryWriter binaryWriter, Int32 nextAddress)
        {
            using(binaryWriter.BaseStream.Pin())
            {
                binaryWriter.Write(name);
                binaryWriter.Write(invalidName_, 0, 16);
                Guerilla.WriteBlockArray<ModelVariantRegionBlock>(binaryWriter, regions, nextAddress);
                Guerilla.WriteBlockArray<ModelVariantObjectBlock>(binaryWriter, objects, nextAddress);
                binaryWriter.Write(invalidName_0, 0, 8);
                binaryWriter.Write(dialogueSoundEffect);
                binaryWriter.Write(dialogue);
                return nextAddress = (int)binaryWriter.BaseStream.Position;
            }
        }
    };
}
