// ReSharper disable All

using Moonfish.Model;
using Moonfish.Tags.BlamExtension;
using Moonfish.Tags;
using OpenTK;
using System;
using System.IO;

namespace Moonfish.Guerilla.Tags
{
    public partial class StructureBspLeafBlock : StructureBspLeafBlockBase
    {
        public StructureBspLeafBlock( BinaryReader binaryReader ) : base( binaryReader )
        {
        }
    };

    [LayoutAttribute( Size = 8, Alignment = 4 )]
    public class StructureBspLeafBlockBase : IGuerilla
    {
        internal short cluster;
        internal short surfaceReferenceCount;
        internal int firstSurfaceReferenceIndex;

        internal StructureBspLeafBlockBase( BinaryReader binaryReader )
        {
            cluster = binaryReader.ReadInt16( );
            surfaceReferenceCount = binaryReader.ReadInt16( );
            firstSurfaceReferenceIndex = binaryReader.ReadInt32( );
        }

        public int Write( System.IO.BinaryWriter binaryWriter, Int32 nextAddress )
        {
            using ( binaryWriter.BaseStream.Pin( ) )
            {
                binaryWriter.Write( cluster );
                binaryWriter.Write( surfaceReferenceCount );
                binaryWriter.Write( firstSurfaceReferenceIndex );
                return nextAddress;
            }
        }
    };
}