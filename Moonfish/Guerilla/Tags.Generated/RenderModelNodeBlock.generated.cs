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
    
    public partial class RenderModelNodeBlock : GuerillaBlock, IWriteQueueable
    {
        public Moonfish.Tags.StringIdent Name;
        public Moonfish.Tags.ShortBlockIndex1 ParentNode;
        public Moonfish.Tags.ShortBlockIndex1 FirstChildNode;
        public Moonfish.Tags.ShortBlockIndex1 NextSiblingNode;
        public short ImportNodeIndex;
        public OpenTK.Vector3 DefaultTranslation;
        public OpenTK.Quaternion DefaultRotation;
        public OpenTK.Vector3 InverseForward;
        public OpenTK.Vector3 InverseLeft;
        public OpenTK.Vector3 InverseUp;
        public OpenTK.Vector3 InversePosition;
        public float InverseScale;
        public float DistanceFromParent;
        public override int SerializedSize
        {
            get
            {
                return 96;
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
            this.ParentNode = binaryReader.ReadShortBlockIndex1();
            this.FirstChildNode = binaryReader.ReadShortBlockIndex1();
            this.NextSiblingNode = binaryReader.ReadShortBlockIndex1();
            this.ImportNodeIndex = binaryReader.ReadInt16();
            this.DefaultTranslation = binaryReader.ReadVector3();
            this.DefaultRotation = binaryReader.ReadQuaternion();
            this.InverseForward = binaryReader.ReadVector3();
            this.InverseLeft = binaryReader.ReadVector3();
            this.InverseUp = binaryReader.ReadVector3();
            this.InversePosition = binaryReader.ReadVector3();
            this.InverseScale = binaryReader.ReadSingle();
            this.DistanceFromParent = binaryReader.ReadSingle();
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
            queueableBinaryWriter.Write(this.ParentNode);
            queueableBinaryWriter.Write(this.FirstChildNode);
            queueableBinaryWriter.Write(this.NextSiblingNode);
            queueableBinaryWriter.Write(this.ImportNodeIndex);
            queueableBinaryWriter.Write(this.DefaultTranslation);
            queueableBinaryWriter.Write(this.DefaultRotation);
            queueableBinaryWriter.Write(this.InverseForward);
            queueableBinaryWriter.Write(this.InverseLeft);
            queueableBinaryWriter.Write(this.InverseUp);
            queueableBinaryWriter.Write(this.InversePosition);
            queueableBinaryWriter.Write(this.InverseScale);
            queueableBinaryWriter.Write(this.DistanceFromParent);
        }
    }
}