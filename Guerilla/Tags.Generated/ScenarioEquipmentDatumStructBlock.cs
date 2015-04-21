// ReSharper disable All

using Moonfish.Model;
using Moonfish.Tags.BlamExtension;
using Moonfish.Tags;
using OpenTK;
using System;
using System.IO;

namespace Moonfish.Guerilla.Tags
{
    public partial class ScenarioEquipmentDatumStructBlock : ScenarioEquipmentDatumStructBlockBase
    {
        public ScenarioEquipmentDatumStructBlock( BinaryReader binaryReader ) : base( binaryReader )
        {
        }
    };

    [LayoutAttribute( Size = 4, Alignment = 4 )]
    public class ScenarioEquipmentDatumStructBlockBase : IGuerilla
    {
        internal EquipmentFlags equipmentFlags;

        internal ScenarioEquipmentDatumStructBlockBase( BinaryReader binaryReader )
        {
            equipmentFlags = ( EquipmentFlags ) binaryReader.ReadInt32( );
        }

        public int Write( System.IO.BinaryWriter binaryWriter, Int32 nextAddress )
        {
            using ( binaryWriter.BaseStream.Pin( ) )
            {
                binaryWriter.Write( ( Int32 ) equipmentFlags );
                return nextAddress;
            }
        }

        [FlagsAttribute]
        internal enum EquipmentFlags : int
        {
            InitiallyAtRestDoesNotFall = 1,
            Obsolete = 2,
            DoesAccelerateMovesDueToExplosions = 4,
        };
    };
}