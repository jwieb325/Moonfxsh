﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using Fasterflect;
using Moonfish.Tags;
using Moonfish.Tags.BlamExtension;

namespace Moonfish.Guerilla
{
    public partial class Guerilla
    {
        /// <summary>
        ///     Returns the alignment value defined by the LayoutAttribute and will fallback on returning 4 if no LayoutAttribute
        ///     is
        ///     found
        /// </summary>
        /// <returns>Alignment of addressing</returns>
        public static int AlignmentOf( Type elementType )
        {
            var layoutAttribute = elementType.Attribute( typeof ( LayoutAttribute ) ) as LayoutAttribute;
            var elementSize = layoutAttribute != null ? layoutAttribute.Alignment : 4;
            return elementSize;
        }

        public static T[] ReadBlockArray<T>( BinaryReader binaryReader ) where T : IGuerilla
        {
            var elementSize = SizeOf( typeof ( T ) );
            var blamPointer = binaryReader.ReadBlamPointer( elementSize );
            var array = new T[blamPointer.elementCount];
            using ( binaryReader.BaseStream.Pin( ) )
            {
                for ( var i = 0; i < blamPointer.elementCount; ++i )
                {
                    binaryReader.BaseStream.Position = blamPointer[ i ];
                    array[ i ] = ( T ) Activator.CreateInstance( typeof ( T ), binaryReader );
                }
            }
            return array;
        }

        public static byte[] ReadData( BinaryReader binaryReader )
        {
            var blamPointer = binaryReader.ReadBlamPointer( 1 );
            var data = new byte[blamPointer.elementCount];
            if ( blamPointer.elementCount <= 0 ) return data;
            using ( binaryReader.BaseStream.Pin( ) )
            {
                binaryReader.BaseStream.Position = blamPointer[ 0 ];
                data = binaryReader.ReadBytes( blamPointer.elementCount );
            }
            return data;
        }

        /// <summary>
        ///     Returns the size defined by the LayoutAttribute and will fallback on Marshal.SizeOf() if no LayoutAttribute is
        ///     found
        /// </summary>
        /// <returns>Size of Type in bytes</returns>
        public static int SizeOf( Type elementType )
        {
            var layoutAttribute = elementType.Attribute( typeof ( LayoutAttribute ) ) as LayoutAttribute;
            var elementSize = layoutAttribute != null ? layoutAttribute.Size : Marshal.SizeOf( elementType );
            return elementSize;
        }

        public static int WriteBlockArray<T>( BinaryWriter binaryWriter, IList<T> blocks, int nextAddress )
            where T : IGuerilla
        {
            var elementType = blocks.GetType( ).GetElementType( );
            var blamPointer = new BlamPointer( blocks.Count, nextAddress, SizeOf( elementType ),
                AlignmentOf( elementType ) );

            binaryWriter.Write( blamPointer );
            nextAddress = blamPointer.EndAddress;
            binaryWriter.BaseStream.Pin( );
            {
                for ( var i = 0; i < blamPointer.elementCount; ++i )
                {
                    binaryWriter.BaseStream.Position = blamPointer[ i ];
                    nextAddress = blocks[ i ].Write( binaryWriter, nextAddress );
                }
            }
            return nextAddress;
        }

        public static int WriteData( BinaryWriter binaryWriter, byte[] data, int nextAddress )
        {
            var blamPointer = new BlamPointer( data.Length, nextAddress, sizeof ( byte ) );
            if ( blamPointer.elementCount <= 0 ) return nextAddress;
            using ( binaryWriter.BaseStream.Pin( ) )
            {
                binaryWriter.BaseStream.Position = blamPointer[ 0 ];
                binaryWriter.Write( data );
            }
            return blamPointer.EndAddress;
        }
    }
}