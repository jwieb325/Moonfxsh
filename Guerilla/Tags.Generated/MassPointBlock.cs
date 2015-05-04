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
    public partial class MassPointBlock : MassPointBlockBase
    {
        public MassPointBlock() : base()
        {
        }
    };
    [LayoutAttribute(Size = 128, Alignment = 4)]
    public class MassPointBlockBase : GuerillaBlock
    {
        internal Moonfish.Tags.String32 name;
        internal Moonfish.Tags.ShortBlockIndex1 poweredMassPoint;
        internal short modelNode;
        internal Flags flags;
        internal float relativeMass;
        internal float mass;
        internal float relativeDensity;
        internal float density;
        internal OpenTK.Vector3 position;
        internal OpenTK.Vector3 forward;
        internal OpenTK.Vector3 up;
        internal FrictionType frictionType;
        internal byte[] invalidName_;
        internal float frictionParallelScale;
        internal float frictionPerpendicularScale;
        internal float radius;
        internal byte[] invalidName_0;
        public override int SerializedSize { get { return 128; } }
        public override int Alignment { get { return 4; } }
        public MassPointBlockBase() : base()
        {
        }
        public override Queue<BlamPointer> ReadFields(BinaryReader binaryReader)
        {
            var blamPointers = new Queue<BlamPointer>(base.ReadFields(binaryReader));
            name = binaryReader.ReadString32();
            poweredMassPoint = binaryReader.ReadShortBlockIndex1();
            modelNode = binaryReader.ReadInt16();
            flags = (Flags)binaryReader.ReadInt32();
            relativeMass = binaryReader.ReadSingle();
            mass = binaryReader.ReadSingle();
            relativeDensity = binaryReader.ReadSingle();
            density = binaryReader.ReadSingle();
            position = binaryReader.ReadVector3();
            forward = binaryReader.ReadVector3();
            up = binaryReader.ReadVector3();
            frictionType = (FrictionType)binaryReader.ReadInt16();
            invalidName_ = binaryReader.ReadBytes(2);
            frictionParallelScale = binaryReader.ReadSingle();
            frictionPerpendicularScale = binaryReader.ReadSingle();
            radius = binaryReader.ReadSingle();
            invalidName_0 = binaryReader.ReadBytes(20);
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
        }
        public override int Write(BinaryWriter binaryWriter, int nextAddress)
        {
            base.Write(binaryWriter, nextAddress);
using(binaryWriter.BaseStream.Pin())
            {
                binaryWriter.Write(name);
                binaryWriter.Write(poweredMassPoint);
                binaryWriter.Write(modelNode);
                binaryWriter.Write((Int32)flags);
                binaryWriter.Write(relativeMass);
                binaryWriter.Write(mass);
                binaryWriter.Write(relativeDensity);
                binaryWriter.Write(density);
                binaryWriter.Write(position);
                binaryWriter.Write(forward);
                binaryWriter.Write(up);
                binaryWriter.Write((Int16)frictionType);
                binaryWriter.Write(invalidName_, 0, 2);
                binaryWriter.Write(frictionParallelScale);
                binaryWriter.Write(frictionPerpendicularScale);
                binaryWriter.Write(radius);
                binaryWriter.Write(invalidName_0, 0, 20);
                return nextAddress;
            }
        }
        [FlagsAttribute]
        internal enum Flags : int
        {
            Metallic = 1,
        };
        internal enum FrictionType : short
        {
            Point = 0,
            Forward = 1,
            Left = 2,
            Up = 3,
        };
    };
}
