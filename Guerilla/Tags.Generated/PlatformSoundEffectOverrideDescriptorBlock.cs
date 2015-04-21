// ReSharper disable All

using Moonfish.Model;
using Moonfish.Tags.BlamExtension;
using Moonfish.Tags;
using OpenTK;
using System;
using System.IO;

namespace Moonfish.Guerilla.Tags
{
    public partial class PlatformSoundEffectOverrideDescriptorBlock : PlatformSoundEffectOverrideDescriptorBlockBase
    {
        public PlatformSoundEffectOverrideDescriptorBlock( BinaryReader binaryReader ) : base( binaryReader )
        {
        }
    };

    [LayoutAttribute( Size = 1, Alignment = 4 )]
    public class PlatformSoundEffectOverrideDescriptorBlockBase : IGuerilla
    {
        internal byte overrideDescriptor;

        internal PlatformSoundEffectOverrideDescriptorBlockBase( BinaryReader binaryReader )
        {
            overrideDescriptor = binaryReader.ReadByte( );
        }

        public int Write( System.IO.BinaryWriter binaryWriter, Int32 nextAddress )
        {
            using ( binaryWriter.BaseStream.Pin( ) )
            {
                binaryWriter.Write( overrideDescriptor );
                return nextAddress;
            }
        }
    };
}