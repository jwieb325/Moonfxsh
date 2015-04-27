// ReSharper disable All

using Moonfish.Model;
using Moonfish.Tags.BlamExtension;
using Moonfish.Tags;
using OpenTK;
using System;
using System.IO;

namespace Moonfish.Guerilla.Tags
{
    public partial class PersistentBackgroundAnimationBlock : PersistentBackgroundAnimationBlockBase
    {
        public PersistentBackgroundAnimationBlock( BinaryReader binaryReader ) : base( binaryReader )
        {
        }
    };

    [LayoutAttribute( Size = 16, Alignment = 4 )]
    public class PersistentBackgroundAnimationBlockBase : IGuerilla
    {
        internal byte[] invalidName_;
        internal int animationPeriodMilliseconds;
        internal BackgroundAnimationKeyframeReferenceBlock[] interpolatedKeyframes;

        internal PersistentBackgroundAnimationBlockBase( BinaryReader binaryReader )
        {
            invalidName_ = binaryReader.ReadBytes( 4 );
            animationPeriodMilliseconds = binaryReader.ReadInt32( );
            interpolatedKeyframes = Guerilla.ReadBlockArray<BackgroundAnimationKeyframeReferenceBlock>( binaryReader );
        }

        public int Write( System.IO.BinaryWriter binaryWriter, Int32 nextAddress )
        {
            using ( binaryWriter.BaseStream.Pin( ) )
            {
                binaryWriter.Write( invalidName_, 0, 4 );
                binaryWriter.Write( animationPeriodMilliseconds );
                nextAddress = Guerilla.WriteBlockArray<BackgroundAnimationKeyframeReferenceBlock>( binaryWriter,
                    interpolatedKeyframes, nextAddress );
                return nextAddress;
            }
        }
    };
}