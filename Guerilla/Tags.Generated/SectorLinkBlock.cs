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
    public partial class SectorLinkBlock : SectorLinkBlockBase
    {
        public SectorLinkBlock() : base()
        {
        }
    };
    [LayoutAttribute(Size = 16, Alignment = 4)]
    public class SectorLinkBlockBase : GuerillaBlock
    {
        internal short vertex1;
        internal short vertex2;
        internal LinkFlags linkFlags;
        internal short hintIndex;
        internal short forwardLink;
        internal short reverseLink;
        internal short leftSector;
        internal short rightSector;
        public override int SerializedSize { get { return 16; } }
        public override int Alignment { get { return 4; } }
        public SectorLinkBlockBase() : base()
        {
        }
        public override Queue<BlamPointer> ReadFields(BinaryReader binaryReader)
        {
            var blamPointers = new Queue<BlamPointer>(base.ReadFields(binaryReader));
            vertex1 = binaryReader.ReadInt16();
            vertex2 = binaryReader.ReadInt16();
            linkFlags = (LinkFlags)binaryReader.ReadInt16();
            hintIndex = binaryReader.ReadInt16();
            forwardLink = binaryReader.ReadInt16();
            reverseLink = binaryReader.ReadInt16();
            leftSector = binaryReader.ReadInt16();
            rightSector = binaryReader.ReadInt16();
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
                binaryWriter.Write(vertex1);
                binaryWriter.Write(vertex2);
                binaryWriter.Write((Int16)linkFlags);
                binaryWriter.Write(hintIndex);
                binaryWriter.Write(forwardLink);
                binaryWriter.Write(reverseLink);
                binaryWriter.Write(leftSector);
                binaryWriter.Write(rightSector);
                return nextAddress;
            }
        }
        [FlagsAttribute]
        internal enum LinkFlags : short
        {
            SectorLinkFromCollisionEdge = 1,
            SectorIntersectionLink = 2,
            SectorLinkBsp2dCreationError = 4,
            SectorLinkTopologyError = 8,
            SectorLinkChainError = 16,
            SectorLinkBothSectorsWalkable = 32,
            SectorLinkMagicHangingLink = 64,
            SectorLinkThreshold = 128,
            SectorLinkCrouchable = 256,
            SectorLinkWallBase = 512,
            SectorLinkLedge = 1024,
            SectorLinkLeanable = 2048,
            SectorLinkStartCorner = 4096,
            SectorLinkEndCorner = 8192,
        };
    };
}
