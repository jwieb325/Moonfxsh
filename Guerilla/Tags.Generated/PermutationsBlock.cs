// ReSharper disable All

using Moonfish.Model;
using Moonfish.Tags.BlamExtension;
using Moonfish.Tags;
using OpenTK;
using System;
using System.IO;

namespace Moonfish.Guerilla.Tags
{
    public partial class PermutationsBlock : PermutationsBlockBase
    {
        public PermutationsBlock( BinaryReader binaryReader ) : base( binaryReader )
        {
        }
    };

    [LayoutAttribute( Size = 12, Alignment = 4 )]
    public class PermutationsBlockBase : IGuerilla
    {
        internal Moonfish.Tags.StringID name;
        internal RigidBodyIndicesBlock[] rigidBodies;

        internal PermutationsBlockBase( BinaryReader binaryReader )
        {
            name = binaryReader.ReadStringID( );
            rigidBodies = Guerilla.ReadBlockArray<RigidBodyIndicesBlock>( binaryReader );
        }

        public int Write( System.IO.BinaryWriter binaryWriter, Int32 nextAddress )
        {
            using ( binaryWriter.BaseStream.Pin( ) )
            {
                binaryWriter.Write( name );
                nextAddress = Guerilla.WriteBlockArray<RigidBodyIndicesBlock>( binaryWriter, rigidBodies, nextAddress );
                return nextAddress;
            }
        }
    };
}