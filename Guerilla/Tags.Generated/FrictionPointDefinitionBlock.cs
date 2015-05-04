// ReSharper disable All
using Moonfish.Model;
using Moonfish.Tags.BlamExtension;
using Moonfish.Tags;
using OpenTK;
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace Moonfish.Guerilla.Tags
{
    public partial class FrictionPointDefinitionBlock : FrictionPointDefinitionBlockBase
    {
        public FrictionPointDefinitionBlock() : base()
        {
        }
    };
    [LayoutAttribute(Size = 76, Alignment = 4)]
    public class FrictionPointDefinitionBlockBase : GuerillaBlock
    {
        internal Moonfish.Tags.StringIdent markerName;
        internal Flags flags;
        /// <summary>
        /// (0.0-1.0) fraction of total vehicle mass
        /// </summary>
        internal float fractionOfTotalMass;
        internal float radius;
        /// <summary>
        /// radius when the tire is blown off.
        /// </summary>
        internal float damagedRadius;
        internal FrictionType frictionType;
        internal byte[] invalidName_;
        internal float movingFrictionVelocityDiff;
        internal float eBrakeMovingFriction;
        internal float eBrakeFriction;
        internal float eBrakeMovingFrictionVelDiff;
        internal byte[] invalidName_0;
        internal Moonfish.Tags.StringIdent collisionGlobalMaterialName;
        internal byte[] invalidName_1;
        /// <summary>
        /// only need point can destroy flag set
        /// </summary>
        internal ModelStateDestroyedOnlyNeedPointCanDestroyFlagSet modelStateDestroyed;
        /// <summary>
        /// only need point can destroy flag set
        /// </summary>
        internal Moonfish.Tags.StringIdent regionName;
        internal byte[] invalidName_2;
        public override int SerializedSize { get { return 76; } }
        public override int Alignment { get { return 4; } }
        public FrictionPointDefinitionBlockBase() : base()
        {
        }
        public override Queue<BlamPointer> ReadFields(BinaryReader binaryReader)
        {
            var blamPointers = new Queue<BlamPointer>(base.ReadFields(binaryReader));
            markerName = binaryReader.ReadStringID();
            flags = (Flags)binaryReader.ReadInt32();
            fractionOfTotalMass = binaryReader.ReadSingle();
            radius = binaryReader.ReadSingle();
            damagedRadius = binaryReader.ReadSingle();
            frictionType = (FrictionType)binaryReader.ReadInt16();
            invalidName_ = binaryReader.ReadBytes(2);
            movingFrictionVelocityDiff = binaryReader.ReadSingle();
            eBrakeMovingFriction = binaryReader.ReadSingle();
            eBrakeFriction = binaryReader.ReadSingle();
            eBrakeMovingFrictionVelDiff = binaryReader.ReadSingle();
            invalidName_0 = binaryReader.ReadBytes(20);
            collisionGlobalMaterialName = binaryReader.ReadStringID();
            invalidName_1 = binaryReader.ReadBytes(2);
            modelStateDestroyed = (ModelStateDestroyedOnlyNeedPointCanDestroyFlagSet)binaryReader.ReadInt16();
            regionName = binaryReader.ReadStringID();
            invalidName_2 = binaryReader.ReadBytes(4);
            return blamPointers;
        }
        public override void ReadPointers(BinaryReader binaryReader, Queue<BlamPointer> blamPointers)
        {
            base.ReadPointers(binaryReader, blamPointers);
            invalidName_[0].ReadPointers(binaryReader, blamPointers);
            invalidName_[1].ReadPointers(binaryReader, blamPointers);
            invalidName_0[0].ReadPointers(binaryReader, blamPointers);
            invalidName_0[1].ReadPointers(binaryReader, blamPointers);
            invalidName_0[2].ReadPointers(binaryReader, blamPointers);
            invalidName_0[3].ReadPointers(binaryReader, blamPointers);
            invalidName_0[4].ReadPointers(binaryReader, blamPointers);
            invalidName_0[5].ReadPointers(binaryReader, blamPointers);
            invalidName_0[6].ReadPointers(binaryReader, blamPointers);
            invalidName_0[7].ReadPointers(binaryReader, blamPointers);
            invalidName_0[8].ReadPointers(binaryReader, blamPointers);
            invalidName_0[9].ReadPointers(binaryReader, blamPointers);
            invalidName_0[10].ReadPointers(binaryReader, blamPointers);
            invalidName_0[11].ReadPointers(binaryReader, blamPointers);
            invalidName_0[12].ReadPointers(binaryReader, blamPointers);
            invalidName_0[13].ReadPointers(binaryReader, blamPointers);
            invalidName_0[14].ReadPointers(binaryReader, blamPointers);
            invalidName_0[15].ReadPointers(binaryReader, blamPointers);
            invalidName_0[16].ReadPointers(binaryReader, blamPointers);
            invalidName_0[17].ReadPointers(binaryReader, blamPointers);
            invalidName_0[18].ReadPointers(binaryReader, blamPointers);
            invalidName_0[19].ReadPointers(binaryReader, blamPointers);
            invalidName_1[0].ReadPointers(binaryReader, blamPointers);
            invalidName_1[1].ReadPointers(binaryReader, blamPointers);
            invalidName_2[0].ReadPointers(binaryReader, blamPointers);
            invalidName_2[1].ReadPointers(binaryReader, blamPointers);
            invalidName_2[2].ReadPointers(binaryReader, blamPointers);
            invalidName_2[3].ReadPointers(binaryReader, blamPointers);
        }
        public override int Write(BinaryWriter binaryWriter, int nextAddress)
        {
            base.Write(binaryWriter, nextAddress);
using(binaryWriter.BaseStream.Pin())
            {
                binaryWriter.Write(markerName);
                binaryWriter.Write((Int32)flags);
                binaryWriter.Write(fractionOfTotalMass);
                binaryWriter.Write(radius);
                binaryWriter.Write(damagedRadius);
                binaryWriter.Write((Int16)frictionType);
                binaryWriter.Write(invalidName_, 0, 2);
                binaryWriter.Write(movingFrictionVelocityDiff);
                binaryWriter.Write(eBrakeMovingFriction);
                binaryWriter.Write(eBrakeFriction);
                binaryWriter.Write(eBrakeMovingFrictionVelDiff);
                binaryWriter.Write(invalidName_0, 0, 20);
                binaryWriter.Write(collisionGlobalMaterialName);
                binaryWriter.Write(invalidName_1, 0, 2);
                binaryWriter.Write((Int16)modelStateDestroyed);
                binaryWriter.Write(regionName);
                binaryWriter.Write(invalidName_2, 0, 4);
                return nextAddress;
            }
        }
        [FlagsAttribute]
        internal enum Flags : int
        {
            GetsDamageFromRegion = 1,
            Powered = 2,
            FrontTurning = 4,
            RearTurning = 8,
            AttachedToEBrake = 16,
            CanBeDestroyed = 32,
        };
        internal enum FrictionType : short
        {
            Point = 0,
            Forward = 1,
        };
        internal enum ModelStateDestroyedOnlyNeedPointCanDestroyFlagSet : short
        {
            Default = 0,
            MinorDamage = 1,
            MediumDamage = 2,
            MajorDamage = 3,
            Destroyed = 4,
        };
    };
}
