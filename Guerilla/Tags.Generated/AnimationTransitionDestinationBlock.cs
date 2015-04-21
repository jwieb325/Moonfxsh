// ReSharper disable All

using Moonfish.Model;
using Moonfish.Tags.BlamExtension;
using Moonfish.Tags;
using OpenTK;
using System;
using System.IO;

namespace Moonfish.Guerilla.Tags
{
    public partial class AnimationTransitionDestinationBlock : AnimationTransitionDestinationBlockBase
    {
        public AnimationTransitionDestinationBlock( BinaryReader binaryReader ) : base( binaryReader )
        {
        }
    };

    [LayoutAttribute( Size = 20, Alignment = 4 )]
    public class AnimationTransitionDestinationBlockBase : IGuerilla
    {
        /// <summary>
        /// name of the mode & state this transitions to
        /// </summary>
        internal Moonfish.Tags.StringID fullName;

        /// <summary>
        /// name of the mode
        /// </summary>
        internal Moonfish.Tags.StringID mode;

        internal AnimationDestinationStateStructBlock stateInfo;
        internal AnimationIndexStructBlock animation;

        internal AnimationTransitionDestinationBlockBase( BinaryReader binaryReader )
        {
            fullName = binaryReader.ReadStringID( );
            mode = binaryReader.ReadStringID( );
            stateInfo = new AnimationDestinationStateStructBlock( binaryReader );
            animation = new AnimationIndexStructBlock( binaryReader );
        }

        public int Write( System.IO.BinaryWriter binaryWriter, Int32 nextAddress )
        {
            using ( binaryWriter.BaseStream.Pin( ) )
            {
                binaryWriter.Write( fullName );
                binaryWriter.Write( mode );
                stateInfo.Write( binaryWriter );
                animation.Write( binaryWriter );
                return nextAddress;
            }
        }
    };
}