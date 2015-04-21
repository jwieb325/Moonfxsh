// ReSharper disable All

using Moonfish.Model;
using Moonfish.Tags.BlamExtension;
using Moonfish.Tags;
using OpenTK;
using System;
using System.IO;

namespace Moonfish.Guerilla.Tags
{
    public partial class PhysicsModelNodeConstraintEdgeBlock : PhysicsModelNodeConstraintEdgeBlockBase
    {
        public PhysicsModelNodeConstraintEdgeBlock( BinaryReader binaryReader ) : base( binaryReader )
        {
        }
    };

    [LayoutAttribute( Size = 24, Alignment = 4 )]
    public class PhysicsModelNodeConstraintEdgeBlockBase : IGuerilla
    {
        internal byte[] invalidName_;
        internal Moonfish.Tags.ShortBlockIndex1 nodeA;
        internal Moonfish.Tags.ShortBlockIndex1 nodeB;
        internal PhysicsModelConstraintEdgeConstraintBlock[] constraints;

        /// <summary>
        /// if you don't fill this out we will pluck the material from the first primitive, of the first rigid body attached to node a
        /// </summary>
        internal Moonfish.Tags.StringID nodeAMaterial;

        /// <summary>
        /// if you don't fill this out we will pluck the material from the first primitive, of the first rigid body attached to node b, if node b is none we use whatever material a has
        /// </summary>
        internal Moonfish.Tags.StringID nodeBMaterial;

        internal PhysicsModelNodeConstraintEdgeBlockBase( BinaryReader binaryReader )
        {
            invalidName_ = binaryReader.ReadBytes( 4 );
            nodeA = binaryReader.ReadShortBlockIndex1( );
            nodeB = binaryReader.ReadShortBlockIndex1( );
            constraints = Guerilla.ReadBlockArray<PhysicsModelConstraintEdgeConstraintBlock>( binaryReader );
            nodeAMaterial = binaryReader.ReadStringID( );
            nodeBMaterial = binaryReader.ReadStringID( );
        }

        public int Write( System.IO.BinaryWriter binaryWriter, Int32 nextAddress )
        {
            using ( binaryWriter.BaseStream.Pin( ) )
            {
                binaryWriter.Write( invalidName_, 0, 4 );
                binaryWriter.Write( nodeA );
                binaryWriter.Write( nodeB );
                nextAddress = Guerilla.WriteBlockArray<PhysicsModelConstraintEdgeConstraintBlock>( binaryWriter,
                    constraints, nextAddress );
                binaryWriter.Write( nodeAMaterial );
                binaryWriter.Write( nodeBMaterial );
                return nextAddress;
            }
        }
    };
}