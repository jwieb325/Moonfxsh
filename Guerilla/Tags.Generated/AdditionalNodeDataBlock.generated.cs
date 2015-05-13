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
    
    public partial class AdditionalNodeDataBlock : GuerillaBlock, IWriteQueueable
    {
        public Moonfish.Tags.StringIdent NodeName;
        public OpenTK.Quaternion DefaultRotation;
        public OpenTK.Vector3 DefaultTranslation;
        public float DefaultScale;
        public OpenTK.Vector3 MinBounds;
        public OpenTK.Vector3 MaxBounds;
        public override int SerializedSize
        {
            get
            {
                return 60;
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
            this.NodeName = binaryReader.ReadStringID();
            this.DefaultRotation = binaryReader.ReadQuaternion();
            this.DefaultTranslation = binaryReader.ReadVector3();
            this.DefaultScale = binaryReader.ReadSingle();
            this.MinBounds = binaryReader.ReadVector3();
            this.MaxBounds = binaryReader.ReadVector3();
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
            queueableBinaryWriter.Write(this.NodeName);
            queueableBinaryWriter.Write(this.DefaultRotation);
            queueableBinaryWriter.Write(this.DefaultTranslation);
            queueableBinaryWriter.Write(this.DefaultScale);
            queueableBinaryWriter.Write(this.MinBounds);
            queueableBinaryWriter.Write(this.MaxBounds);
        }
    }
}
