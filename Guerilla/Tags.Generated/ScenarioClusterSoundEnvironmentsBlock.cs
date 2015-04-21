// ReSharper disable All

using Moonfish.Model;
using Moonfish.Tags.BlamExtension;
using Moonfish.Tags;
using OpenTK;
using System;
using System.IO;

namespace Moonfish.Guerilla.Tags
{
    public partial class ScenarioClusterSoundEnvironmentsBlock : ScenarioClusterSoundEnvironmentsBlockBase
    {
        public ScenarioClusterSoundEnvironmentsBlock( BinaryReader binaryReader ) : base( binaryReader )
        {
        }
    };

    [LayoutAttribute( Size = 4, Alignment = 4 )]
    public class ScenarioClusterSoundEnvironmentsBlockBase : IGuerilla
    {
        internal Moonfish.Tags.ShortBlockIndex1 type;
        internal byte[] invalidName_;

        internal ScenarioClusterSoundEnvironmentsBlockBase( BinaryReader binaryReader )
        {
            type = binaryReader.ReadShortBlockIndex1( );
            invalidName_ = binaryReader.ReadBytes( 2 );
        }

        public int Write( System.IO.BinaryWriter binaryWriter, Int32 nextAddress )
        {
            using ( binaryWriter.BaseStream.Pin( ) )
            {
                binaryWriter.Write( type );
                binaryWriter.Write( invalidName_, 0, 2 );
                return nextAddress;
            }
        }
    };
}