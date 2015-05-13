//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Moonfish.Guerilla.Tags
{
    using Moonfish.Tags;
    using Moonfish.Model;
    using System.IO;
    using System.Collections.Generic;
    using System.Linq;
    
    public partial class VehiclePhantomShapeBlock : GuerillaBlock, IWriteQueueable
    {
        private byte[] fieldskip = new byte[4];
        public short Size;
        public short Count;
        private byte[] fieldskip0 = new byte[4];
        private byte[] fieldskip1 = new byte[4];
        public int ChildShapesSize;
        public int ChildShapesCapacity;
        public ChildShapesStorageBlock[] ChildShapesStorage00 = new ChildShapesStorageBlock[4];
        public int MultisphereCount;
        public Flags VehiclePhantomShapeFlags;
        private byte[] fieldpad = new byte[8];
        public float X0;
        public float X1;
        public float Y0;
        public float Y1;
        public float Z0;
        public float Z1;
        public MultispheresBlock[] Multispheres00 = new MultispheresBlock[4];
        public override int SerializedSize
        {
            get
            {
                return 672;
            }
        }
        public override int Alignment
        {
            get
            {
                return 16;
            }
        }
        public override System.Collections.Generic.Queue<Moonfish.Tags.BlamPointer> ReadFields(System.IO.BinaryReader binaryReader)
        {
            System.Collections.Generic.Queue<Moonfish.Tags.BlamPointer> pointerQueue = new System.Collections.Generic.Queue<Moonfish.Tags.BlamPointer>(base.ReadFields(binaryReader));
            this.fieldskip = binaryReader.ReadBytes(4);
            this.Size = binaryReader.ReadInt16();
            this.Count = binaryReader.ReadInt16();
            this.fieldskip0 = binaryReader.ReadBytes(4);
            this.fieldskip1 = binaryReader.ReadBytes(4);
            this.ChildShapesSize = binaryReader.ReadInt32();
            this.ChildShapesCapacity = binaryReader.ReadInt32();
            int i;
            for (i = 0; (i < 4); i = (i + 1))
            {
                this.ChildShapesStorage00[i] = new ChildShapesStorageBlock();
                pointerQueue = new System.Collections.Generic.Queue<Moonfish.Tags.BlamPointer>(pointerQueue.Concat(this.ChildShapesStorage00[i].ReadFields(binaryReader)));
            }
            this.MultisphereCount = binaryReader.ReadInt32();
            this.VehiclePhantomShapeFlags = ((Flags)(binaryReader.ReadInt32()));
            this.fieldpad = binaryReader.ReadBytes(8);
            this.X0 = binaryReader.ReadSingle();
            this.X1 = binaryReader.ReadSingle();
            this.Y0 = binaryReader.ReadSingle();
            this.Y1 = binaryReader.ReadSingle();
            this.Z0 = binaryReader.ReadSingle();
            this.Z1 = binaryReader.ReadSingle();
            for (i = 0; (i < 4); i = (i + 1))
            {
                this.Multispheres00[i] = new MultispheresBlock();
                pointerQueue = new System.Collections.Generic.Queue<Moonfish.Tags.BlamPointer>(pointerQueue.Concat(this.Multispheres00[i].ReadFields(binaryReader)));
            }
            return pointerQueue;
        }
        public override void ReadInstances(System.IO.BinaryReader binaryReader, System.Collections.Generic.Queue<Moonfish.Tags.BlamPointer> pointerQueue)
        {
            base.ReadInstances(binaryReader, pointerQueue);
            int i;
            for (i = 0; (i < 4); i = (i + 1))
            {
                this.ChildShapesStorage00[i].ReadInstances(binaryReader, pointerQueue);
            }
            for (i = 0; (i < 4); i = (i + 1))
            {
                this.Multispheres00[i].ReadInstances(binaryReader, pointerQueue);
            }
        }
        public override void QueueWrites(Moonfish.Guerilla.QueueableBinaryWriter queueableBinaryWriter)
        {
            base.QueueWrites(queueableBinaryWriter);
            int i;
            for (i = 0; (i < 4); i = (i + 1))
            {
                this.ChildShapesStorage00[i].QueueWrites(queueableBinaryWriter);
            }
            for (i = 0; (i < 4); i = (i + 1))
            {
                this.Multispheres00[i].QueueWrites(queueableBinaryWriter);
            }
        }
        public override void Write_(Moonfish.Guerilla.QueueableBinaryWriter queueableBinaryWriter)
        {
            base.Write_(queueableBinaryWriter);
            queueableBinaryWriter.Write(this.fieldskip);
            queueableBinaryWriter.Write(this.Size);
            queueableBinaryWriter.Write(this.Count);
            queueableBinaryWriter.Write(this.fieldskip0);
            queueableBinaryWriter.Write(this.fieldskip1);
            queueableBinaryWriter.Write(this.ChildShapesSize);
            queueableBinaryWriter.Write(this.ChildShapesCapacity);
            int i;
            for (i = 0; (i < 4); i = (i + 1))
            {
                this.ChildShapesStorage00[i].Write_(queueableBinaryWriter);
            }
            queueableBinaryWriter.Write(this.MultisphereCount);
            queueableBinaryWriter.Write(((int)(this.VehiclePhantomShapeFlags)));
            queueableBinaryWriter.Write(this.fieldpad);
            queueableBinaryWriter.Write(this.X0);
            queueableBinaryWriter.Write(this.X1);
            queueableBinaryWriter.Write(this.Y0);
            queueableBinaryWriter.Write(this.Y1);
            queueableBinaryWriter.Write(this.Z0);
            queueableBinaryWriter.Write(this.Z1);
            for (i = 0; (i < 4); i = (i + 1))
            {
                this.Multispheres00[i].Write_(queueableBinaryWriter);
            }
        }
        public class ChildShapesStorageBlock : GuerillaBlock, IWriteQueueable
        {
            public ShapeTypeEnum ShapeType;
            public Moonfish.Tags.ShortBlockIndex2 Shape;
            public int CollisionFilter;
            public override int SerializedSize
            {
                get
                {
                    return 8;
                }
            }
            public override int Alignment
            {
                get
                {
                    return 1;
                }
            }
            public override System.Collections.Generic.Queue<Moonfish.Tags.BlamPointer> ReadFields(System.IO.BinaryReader binaryReader)
            {
                System.Collections.Generic.Queue<Moonfish.Tags.BlamPointer> pointerQueue = new System.Collections.Generic.Queue<Moonfish.Tags.BlamPointer>(base.ReadFields(binaryReader));
                this.ShapeType = ((ShapeTypeEnum)(binaryReader.ReadInt16()));
                this.Shape = binaryReader.ReadShortBlockIndex2();
                this.CollisionFilter = binaryReader.ReadInt32();
                return pointerQueue;
            }
            public override void ReadInstances(System.IO.BinaryReader binaryReader, System.Collections.Generic.Queue<Moonfish.Tags.BlamPointer> pointerQueue)
            {
                base.ReadInstances(binaryReader, pointerQueue);
            }
            public override void QueueWrites(Moonfish.Guerilla.QueueableBinaryWriter queueableBinaryWriter)
            {
                base.QueueWrites(queueableBinaryWriter);
            }
            public override void Write_(Moonfish.Guerilla.QueueableBinaryWriter queueableBinaryWriter)
            {
                base.Write_(queueableBinaryWriter);
                queueableBinaryWriter.Write(((short)(this.ShapeType)));
                queueableBinaryWriter.Write(this.Shape);
                queueableBinaryWriter.Write(this.CollisionFilter);
            }
            public enum ShapeTypeEnum : short
            {
                Sphere = 0,
                Pill = 1,
                Box = 2,
                Triangle = 3,
                Polyhedron = 4,
                MultiSphere = 5,
                Unused0 = 6,
                Unused1 = 7,
                Unused2 = 8,
                Unused3 = 9,
                Unused4 = 10,
                Unused5 = 11,
                Unused6 = 12,
                Unused7 = 13,
                List = 14,
                Mopp = 15,
            }
        }
        [System.FlagsAttribute()]
        public enum Flags : int
        {
            None = 0,
            HasAabbPhantom = 1,
        }
        public class MultispheresBlock : GuerillaBlock, IWriteQueueable
        {
            private byte[] fieldskip = new byte[4];
            public short Size;
            public short Count;
            private byte[] fieldskip0 = new byte[4];
            public int NumSpheres;
            public FourVectorsStorageBlock[] FourVectorsStorage00 = new FourVectorsStorageBlock[8];
            public override int SerializedSize
            {
                get
                {
                    return 144;
                }
            }
            public override int Alignment
            {
                get
                {
                    return 1;
                }
            }
            public override System.Collections.Generic.Queue<Moonfish.Tags.BlamPointer> ReadFields(System.IO.BinaryReader binaryReader)
            {
                System.Collections.Generic.Queue<Moonfish.Tags.BlamPointer> pointerQueue = new System.Collections.Generic.Queue<Moonfish.Tags.BlamPointer>(base.ReadFields(binaryReader));
                this.fieldskip = binaryReader.ReadBytes(4);
                this.Size = binaryReader.ReadInt16();
                this.Count = binaryReader.ReadInt16();
                this.fieldskip0 = binaryReader.ReadBytes(4);
                this.NumSpheres = binaryReader.ReadInt32();
                int i;
                for (i = 0; (i < 8); i = (i + 1))
                {
                    this.FourVectorsStorage00[i] = new FourVectorsStorageBlock();
                    pointerQueue = new System.Collections.Generic.Queue<Moonfish.Tags.BlamPointer>(pointerQueue.Concat(this.FourVectorsStorage00[i].ReadFields(binaryReader)));
                }
                return pointerQueue;
            }
            public override void ReadInstances(System.IO.BinaryReader binaryReader, System.Collections.Generic.Queue<Moonfish.Tags.BlamPointer> pointerQueue)
            {
                base.ReadInstances(binaryReader, pointerQueue);
                int i;
                for (i = 0; (i < 8); i = (i + 1))
                {
                    this.FourVectorsStorage00[i].ReadInstances(binaryReader, pointerQueue);
                }
            }
            public override void QueueWrites(Moonfish.Guerilla.QueueableBinaryWriter queueableBinaryWriter)
            {
                base.QueueWrites(queueableBinaryWriter);
                int i;
                for (i = 0; (i < 8); i = (i + 1))
                {
                    this.FourVectorsStorage00[i].QueueWrites(queueableBinaryWriter);
                }
            }
            public override void Write_(Moonfish.Guerilla.QueueableBinaryWriter queueableBinaryWriter)
            {
                base.Write_(queueableBinaryWriter);
                queueableBinaryWriter.Write(this.fieldskip);
                queueableBinaryWriter.Write(this.Size);
                queueableBinaryWriter.Write(this.Count);
                queueableBinaryWriter.Write(this.fieldskip0);
                queueableBinaryWriter.Write(this.NumSpheres);
                int i;
                for (i = 0; (i < 8); i = (i + 1))
                {
                    this.FourVectorsStorage00[i].Write_(queueableBinaryWriter);
                }
            }
            public class FourVectorsStorageBlock : GuerillaBlock, IWriteQueueable
            {
                public OpenTK.Vector3 Sphere;
                private byte[] fieldskip = new byte[4];
                public override int SerializedSize
                {
                    get
                    {
                        return 16;
                    }
                }
                public override int Alignment
                {
                    get
                    {
                        return 1;
                    }
                }
                public override System.Collections.Generic.Queue<Moonfish.Tags.BlamPointer> ReadFields(System.IO.BinaryReader binaryReader)
                {
                    System.Collections.Generic.Queue<Moonfish.Tags.BlamPointer> pointerQueue = new System.Collections.Generic.Queue<Moonfish.Tags.BlamPointer>(base.ReadFields(binaryReader));
                    this.Sphere = binaryReader.ReadVector3();
                    this.fieldskip = binaryReader.ReadBytes(4);
                    return pointerQueue;
                }
                public override void ReadInstances(System.IO.BinaryReader binaryReader, System.Collections.Generic.Queue<Moonfish.Tags.BlamPointer> pointerQueue)
                {
                    base.ReadInstances(binaryReader, pointerQueue);
                }
                public override void QueueWrites(Moonfish.Guerilla.QueueableBinaryWriter queueableBinaryWriter)
                {
                    base.QueueWrites(queueableBinaryWriter);
                }
                public override void Write_(Moonfish.Guerilla.QueueableBinaryWriter queueableBinaryWriter)
                {
                    base.Write_(queueableBinaryWriter);
                    queueableBinaryWriter.Write(this.Sphere);
                    queueableBinaryWriter.Write(this.fieldskip);
                }
            }
        }
    }
}
