//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
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
    
    public partial class ConstraintBodiesStructBlock : GuerillaBlock, IWriteQueueable
    {
        public Moonfish.Tags.StringIdent Name;
        public Moonfish.Tags.ShortBlockIndex1 NodeA;
        public Moonfish.Tags.ShortBlockIndex1 NodeB;
        public float AScale;
        public OpenTK.Vector3 AForward;
        public OpenTK.Vector3 ALeft;
        public OpenTK.Vector3 AUp;
        public OpenTK.Vector3 APosition;
        public float BScale;
        public OpenTK.Vector3 BForward;
        public OpenTK.Vector3 BLeft;
        public OpenTK.Vector3 BUp;
        public OpenTK.Vector3 BPosition;
        public Moonfish.Tags.ShortBlockIndex1 EdgeIndex;
        private byte[] fieldpad = new byte[2];
        public override int SerializedSize
        {
            get
            {
                return 116;
            }
        }
        public override int Alignment
        {
            get
            {
                return 4;
            }
        }
        public override System.Collections.Generic.Queue<Moonfish.Tags.BlamPointer> ReadFields(System.IO.BinaryReader binaryReader)
        {
            System.Collections.Generic.Queue<Moonfish.Tags.BlamPointer> pointerQueue = new System.Collections.Generic.Queue<Moonfish.Tags.BlamPointer>(base.ReadFields(binaryReader));
            this.Name = binaryReader.ReadStringID();
            this.NodeA = binaryReader.ReadShortBlockIndex1();
            this.NodeB = binaryReader.ReadShortBlockIndex1();
            this.AScale = binaryReader.ReadSingle();
            this.AForward = binaryReader.ReadVector3();
            this.ALeft = binaryReader.ReadVector3();
            this.AUp = binaryReader.ReadVector3();
            this.APosition = binaryReader.ReadVector3();
            this.BScale = binaryReader.ReadSingle();
            this.BForward = binaryReader.ReadVector3();
            this.BLeft = binaryReader.ReadVector3();
            this.BUp = binaryReader.ReadVector3();
            this.BPosition = binaryReader.ReadVector3();
            this.EdgeIndex = binaryReader.ReadShortBlockIndex1();
            this.fieldpad = binaryReader.ReadBytes(2);
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
            queueableBinaryWriter.Write(this.Name);
            queueableBinaryWriter.Write(this.NodeA);
            queueableBinaryWriter.Write(this.NodeB);
            queueableBinaryWriter.Write(this.AScale);
            queueableBinaryWriter.Write(this.AForward);
            queueableBinaryWriter.Write(this.ALeft);
            queueableBinaryWriter.Write(this.AUp);
            queueableBinaryWriter.Write(this.APosition);
            queueableBinaryWriter.Write(this.BScale);
            queueableBinaryWriter.Write(this.BForward);
            queueableBinaryWriter.Write(this.BLeft);
            queueableBinaryWriter.Write(this.BUp);
            queueableBinaryWriter.Write(this.BPosition);
            queueableBinaryWriter.Write(this.EdgeIndex);
            queueableBinaryWriter.Write(this.fieldpad);
        }
    }
}