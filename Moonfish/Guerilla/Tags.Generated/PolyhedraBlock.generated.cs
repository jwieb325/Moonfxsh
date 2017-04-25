//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Moonfish.Guerilla.Tags
{
    using JetBrains.Annotations;
    using Moonfish.Tags;
    using Moonfish.Model;
    using System.IO;
    using System.Collections.Generic;
    using System.Linq;
    
    [JetBrains.Annotations.UsedImplicitlyAttribute(ImplicitUseTargetFlags.WithMembers)]
    [TagBlockOriginalNameAttribute("polyhedra_block")]
    public partial class PolyhedraBlock : GuerillaBlock, IWriteQueueable
    {
        public Moonfish.Tags.StringIdent Name;
        public Moonfish.Tags.ShortBlockIndex1 Material;
        public Flags PolyhedraFlags;
        public float RelativeMassScale;
        public float Friction;
        public float Restitution;
        public float Volume;
        public float Mass;
        private byte[] fieldskip = new byte[2];
        public Moonfish.Tags.ShortBlockIndex1 Phantom;
        private byte[] fieldskip0 = new byte[4];
        public short Size;
        public short Count;
        private byte[] fieldskip1 = new byte[4];
        public float Radius;
        public OpenTK.Vector3 AabbHalfExtents;
        private byte[] fieldskip2 = new byte[4];
        public OpenTK.Vector3 AabbCenter;
        private byte[] fieldskip3 = new byte[4];
        private byte[] fieldskip4 = new byte[4];
        public int FourVectorsSize;
        public int FourVectorsCapacity;
        public int NumVertices;
        public FourVectorsStorageBlock[] FourVectorsStorage00 = new FourVectorsStorageBlock[3];
        private byte[] fieldskip5 = new byte[4];
        public int PlaneEquationsSize;
        public int PlaneEquationsCapacity;
        private byte[] fieldskip6 = new byte[4];
        public override int SerializedSize
        {
            get
            {
                return 256;
            }
        }
        public override int Alignment
        {
            get
            {
                return 16;
            }
        }
        public override System.Collections.Generic.Queue<Moonfish.Tags.BlamPointer> ReadFields(Moonfish.Guerilla.BlamBinaryReader binaryReader)
        {
            System.Collections.Generic.Queue<Moonfish.Tags.BlamPointer> pointerQueue = new System.Collections.Generic.Queue<Moonfish.Tags.BlamPointer>(base.ReadFields(binaryReader));
            this.Name = binaryReader.ReadStringIdent();
            this.Material = binaryReader.ReadShortBlockIndex1();
            this.PolyhedraFlags = ((Flags)(binaryReader.ReadInt16()));
            this.RelativeMassScale = binaryReader.ReadSingle();
            this.Friction = binaryReader.ReadSingle();
            this.Restitution = binaryReader.ReadSingle();
            this.Volume = binaryReader.ReadSingle();
            this.Mass = binaryReader.ReadSingle();
            this.fieldskip = binaryReader.ReadBytes(2);
            this.Phantom = binaryReader.ReadShortBlockIndex1();
            this.fieldskip0 = binaryReader.ReadBytes(4);
            this.Size = binaryReader.ReadInt16();
            this.Count = binaryReader.ReadInt16();
            this.fieldskip1 = binaryReader.ReadBytes(4);
            this.Radius = binaryReader.ReadSingle();
            this.AabbHalfExtents = binaryReader.ReadVector3();
            this.fieldskip2 = binaryReader.ReadBytes(4);
            this.AabbCenter = binaryReader.ReadVector3();
            this.fieldskip3 = binaryReader.ReadBytes(4);
            this.fieldskip4 = binaryReader.ReadBytes(4);
            this.FourVectorsSize = binaryReader.ReadInt32();
            this.FourVectorsCapacity = binaryReader.ReadInt32();
            this.NumVertices = binaryReader.ReadInt32();
            int i;
            for (i = 0; (i < 3); i = (i + 1))
            {
                this.FourVectorsStorage00[i] = new FourVectorsStorageBlock();
                pointerQueue = new System.Collections.Generic.Queue<Moonfish.Tags.BlamPointer>(pointerQueue.Concat(this.FourVectorsStorage00[i].ReadFields(binaryReader)));
            }
            this.fieldskip5 = binaryReader.ReadBytes(4);
            this.PlaneEquationsSize = binaryReader.ReadInt32();
            this.PlaneEquationsCapacity = binaryReader.ReadInt32();
            this.fieldskip6 = binaryReader.ReadBytes(4);
            return pointerQueue;
        }
        public override void ReadInstances(Moonfish.Guerilla.BlamBinaryReader binaryReader, System.Collections.Generic.Queue<Moonfish.Tags.BlamPointer> pointerQueue)
        {
            base.ReadInstances(binaryReader, pointerQueue);
            int i;
            for (i = 0; (i < 3); i = (i + 1))
            {
                this.FourVectorsStorage00[i].ReadInstances(binaryReader, pointerQueue);
            }
        }
        public override void Defer(Moonfish.Guerilla.QueueableBlamBinaryWriter queueableBinaryWriter)
        {
            base.Defer(queueableBinaryWriter);
            int i;
            for (i = 0; (i < 3); i = (i + 1))
            {
                this.FourVectorsStorage00[i].Defer(queueableBinaryWriter);
            }
        }
        public override void Write(Moonfish.Guerilla.QueueableBlamBinaryWriter queueableBinaryWriter)
        {
            base.Write(queueableBinaryWriter);
            queueableBinaryWriter.Write(this.Name);
            queueableBinaryWriter.Write(this.Material);
            queueableBinaryWriter.Write(((short)(this.PolyhedraFlags)));
            queueableBinaryWriter.Write(this.RelativeMassScale);
            queueableBinaryWriter.Write(this.Friction);
            queueableBinaryWriter.Write(this.Restitution);
            queueableBinaryWriter.Write(this.Volume);
            queueableBinaryWriter.Write(this.Mass);
            queueableBinaryWriter.Write(this.fieldskip);
            queueableBinaryWriter.Write(this.Phantom);
            queueableBinaryWriter.Write(this.fieldskip0);
            queueableBinaryWriter.Write(this.Size);
            queueableBinaryWriter.Write(this.Count);
            queueableBinaryWriter.Write(this.fieldskip1);
            queueableBinaryWriter.Write(this.Radius);
            queueableBinaryWriter.Write(this.AabbHalfExtents);
            queueableBinaryWriter.Write(this.fieldskip2);
            queueableBinaryWriter.Write(this.AabbCenter);
            queueableBinaryWriter.Write(this.fieldskip3);
            queueableBinaryWriter.Write(this.fieldskip4);
            queueableBinaryWriter.Write(this.FourVectorsSize);
            queueableBinaryWriter.Write(this.FourVectorsCapacity);
            queueableBinaryWriter.Write(this.NumVertices);
            int i;
            for (i = 0; (i < 3); i = (i + 1))
            {
                this.FourVectorsStorage00[i].Write(queueableBinaryWriter);
            }
            queueableBinaryWriter.Write(this.fieldskip5);
            queueableBinaryWriter.Write(this.PlaneEquationsSize);
            queueableBinaryWriter.Write(this.PlaneEquationsCapacity);
            queueableBinaryWriter.Write(this.fieldskip6);
        }
        [System.FlagsAttribute()]
        public enum Flags : short
        {
            None = 0,
            Unused = 1,
        }
        [JetBrains.Annotations.UsedImplicitlyAttribute(ImplicitUseTargetFlags.WithMembers)]
        public class FourVectorsStorageBlock : GuerillaBlock, IWriteQueueable
        {
            public OpenTK.Vector3 FourVectorsX;
            private byte[] fieldskip = new byte[4];
            public OpenTK.Vector3 FourVectorsY;
            private byte[] fieldskip0 = new byte[4];
            public OpenTK.Vector3 FourVectorsZ;
            private byte[] fieldskip1 = new byte[4];
            public override int SerializedSize
            {
                get
                {
                    return 48;
                }
            }
            public override int Alignment
            {
                get
                {
                    return 1;
                }
            }
            public override System.Collections.Generic.Queue<Moonfish.Tags.BlamPointer> ReadFields(Moonfish.Guerilla.BlamBinaryReader binaryReader)
            {
                System.Collections.Generic.Queue<Moonfish.Tags.BlamPointer> pointerQueue = new System.Collections.Generic.Queue<Moonfish.Tags.BlamPointer>(base.ReadFields(binaryReader));
                this.FourVectorsX = binaryReader.ReadVector3();
                this.fieldskip = binaryReader.ReadBytes(4);
                this.FourVectorsY = binaryReader.ReadVector3();
                this.fieldskip0 = binaryReader.ReadBytes(4);
                this.FourVectorsZ = binaryReader.ReadVector3();
                this.fieldskip1 = binaryReader.ReadBytes(4);
                return pointerQueue;
            }
            public override void ReadInstances(Moonfish.Guerilla.BlamBinaryReader binaryReader, System.Collections.Generic.Queue<Moonfish.Tags.BlamPointer> pointerQueue)
            {
                base.ReadInstances(binaryReader, pointerQueue);
            }
            public override void Defer(Moonfish.Guerilla.QueueableBlamBinaryWriter queueableBinaryWriter)
            {
                base.Defer(queueableBinaryWriter);
            }
            public override void Write(Moonfish.Guerilla.QueueableBlamBinaryWriter queueableBinaryWriter)
            {
                base.Write(queueableBinaryWriter);
                queueableBinaryWriter.Write(this.FourVectorsX);
                queueableBinaryWriter.Write(this.fieldskip);
                queueableBinaryWriter.Write(this.FourVectorsY);
                queueableBinaryWriter.Write(this.fieldskip0);
                queueableBinaryWriter.Write(this.FourVectorsZ);
                queueableBinaryWriter.Write(this.fieldskip1);
            }
        }
    }
}
