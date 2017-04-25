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
    [TagBlockOriginalNameAttribute("spheres_block")]
    public partial class SpheresBlock : GuerillaBlock, IWriteQueueable
    {
        public Moonfish.Tags.StringIdent Name;
        public Moonfish.Tags.ShortBlockIndex1 Material;
        public Flags SpheresFlags;
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
        private byte[] fieldskip2 = new byte[4];
        public short Size0;
        public short Count0;
        private byte[] fieldskip3 = new byte[4];
        private byte[] fieldskip4 = new byte[4];
        public OpenTK.Vector3 RotationI;
        private byte[] fieldskip5 = new byte[4];
        public OpenTK.Vector3 RotationJ;
        private byte[] fieldskip6 = new byte[4];
        public OpenTK.Vector3 RotationK;
        private byte[] fieldskip7 = new byte[4];
        public OpenTK.Vector3 Translation;
        private byte[] fieldskip8 = new byte[4];
        public override int SerializedSize
        {
            get
            {
                return 128;
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
            this.SpheresFlags = ((Flags)(binaryReader.ReadInt16()));
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
            this.fieldskip2 = binaryReader.ReadBytes(4);
            this.Size0 = binaryReader.ReadInt16();
            this.Count0 = binaryReader.ReadInt16();
            this.fieldskip3 = binaryReader.ReadBytes(4);
            this.fieldskip4 = binaryReader.ReadBytes(4);
            this.RotationI = binaryReader.ReadVector3();
            this.fieldskip5 = binaryReader.ReadBytes(4);
            this.RotationJ = binaryReader.ReadVector3();
            this.fieldskip6 = binaryReader.ReadBytes(4);
            this.RotationK = binaryReader.ReadVector3();
            this.fieldskip7 = binaryReader.ReadBytes(4);
            this.Translation = binaryReader.ReadVector3();
            this.fieldskip8 = binaryReader.ReadBytes(4);
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
            queueableBinaryWriter.Write(this.Name);
            queueableBinaryWriter.Write(this.Material);
            queueableBinaryWriter.Write(((short)(this.SpheresFlags)));
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
            queueableBinaryWriter.Write(this.fieldskip2);
            queueableBinaryWriter.Write(this.Size0);
            queueableBinaryWriter.Write(this.Count0);
            queueableBinaryWriter.Write(this.fieldskip3);
            queueableBinaryWriter.Write(this.fieldskip4);
            queueableBinaryWriter.Write(this.RotationI);
            queueableBinaryWriter.Write(this.fieldskip5);
            queueableBinaryWriter.Write(this.RotationJ);
            queueableBinaryWriter.Write(this.fieldskip6);
            queueableBinaryWriter.Write(this.RotationK);
            queueableBinaryWriter.Write(this.fieldskip7);
            queueableBinaryWriter.Write(this.Translation);
            queueableBinaryWriter.Write(this.fieldskip8);
        }
        [System.FlagsAttribute()]
        public enum Flags : short
        {
            None = 0,
            Unused = 1,
        }
    }
}
