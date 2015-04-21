// ReSharper disable All

using Moonfish.Model;
using Moonfish.Tags.BlamExtension;
using Moonfish.Tags;
using OpenTK;
using System;
using System.IO;

namespace Moonfish.Guerilla.Tags
{
    public partial class HudMessagesBlock : HudMessagesBlockBase
    {
        public HudMessagesBlock( BinaryReader binaryReader ) : base( binaryReader )
        {
        }
    };

    [LayoutAttribute( Size = 64, Alignment = 4 )]
    public class HudMessagesBlockBase : IGuerilla
    {
        internal Moonfish.Tags.String32 name;
        internal short startIndexIntoTextBlob;
        internal short startIndexOfMessageBlock;
        internal byte panelCount;
        internal byte[] invalidName_;
        internal byte[] invalidName_0;

        internal HudMessagesBlockBase( BinaryReader binaryReader )
        {
            name = binaryReader.ReadString32( );
            startIndexIntoTextBlob = binaryReader.ReadInt16( );
            startIndexOfMessageBlock = binaryReader.ReadInt16( );
            panelCount = binaryReader.ReadByte( );
            invalidName_ = binaryReader.ReadBytes( 3 );
            invalidName_0 = binaryReader.ReadBytes( 24 );
        }

        public int Write( System.IO.BinaryWriter binaryWriter, Int32 nextAddress )
        {
            using ( binaryWriter.BaseStream.Pin( ) )
            {
                binaryWriter.Write( name );
                binaryWriter.Write( startIndexIntoTextBlob );
                binaryWriter.Write( startIndexOfMessageBlock );
                binaryWriter.Write( panelCount );
                binaryWriter.Write( invalidName_, 0, 3 );
                binaryWriter.Write( invalidName_0, 0, 24 );
                return nextAddress;
            }
        }
    };
}