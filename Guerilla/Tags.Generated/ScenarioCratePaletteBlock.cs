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
    public partial class ScenarioCratePaletteBlock : ScenarioCratePaletteBlockBase
    {
        public ScenarioCratePaletteBlock() : base()
        {
        }
    };
    [LayoutAttribute(Size = 40, Alignment = 4)]
    public class ScenarioCratePaletteBlockBase : GuerillaBlock
    {
        [TagReference("bloc")]
        internal Moonfish.Tags.TagReference name;
        internal byte[] invalidName_;
        public override int SerializedSize { get { return 40; } }
        public override int Alignment { get { return 4; } }
        public ScenarioCratePaletteBlockBase() : base()
        {
        }
        public override Queue<BlamPointer> ReadFields(BinaryReader binaryReader)
        {
            var blamPointers = new Queue<BlamPointer>(base.ReadFields(binaryReader));
            name = binaryReader.ReadTagReference();
            invalidName_ = binaryReader.ReadBytes(32);
            return blamPointers;
        }
        public override void ReadPointers(BinaryReader binaryReader, Queue<BlamPointer> blamPointers)
        {
            base.ReadPointers(binaryReader, blamPointers);
        }
        public override int Write(BinaryWriter binaryWriter, int nextAddress)
        {
            base.Write(binaryWriter, nextAddress);
using(binaryWriter.BaseStream.Pin())
            {
                binaryWriter.Write(name);
                binaryWriter.Write(invalidName_, 0, 32);
                return nextAddress;
            }
        }
    };
}
