// ReSharper disable All

using Moonfish.Model;
using Moonfish.Tags.BlamExtension;
using Moonfish.Tags;
using OpenTK;
using System;
using System.IO;

namespace Moonfish.Guerilla.Tags
{
    public partial class ScenarioSkyReferenceBlock : ScenarioSkyReferenceBlockBase
    {
        public ScenarioSkyReferenceBlock( BinaryReader binaryReader ) : base( binaryReader )
        {
        }
    };

    [LayoutAttribute( Size = 8, Alignment = 4 )]
    public class ScenarioSkyReferenceBlockBase : IGuerilla
    {
        [TagReference( "sky " )] internal Moonfish.Tags.TagReference sky;

        internal ScenarioSkyReferenceBlockBase( BinaryReader binaryReader )
        {
            sky = binaryReader.ReadTagReference( );
        }

        public int Write( System.IO.BinaryWriter binaryWriter, Int32 nextAddress )
        {
            using ( binaryWriter.BaseStream.Pin( ) )
            {
                binaryWriter.Write( sky );
                return nextAddress;
            }
        }
    };
}