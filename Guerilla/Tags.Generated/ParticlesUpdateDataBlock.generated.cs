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
    
    public partial class ParticlesUpdateDataBlock : GuerillaBlock, IWriteQueueable
    {
        public float Velocityx;
        public float Velocityy;
        public float Velocityz;
        private byte[] fieldpad = new byte[12];
        public float Mass;
        public float CreationTimeStamp;
        public override int SerializedSize
        {
            get
            {
                return 32;
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
            this.Velocityx = binaryReader.ReadSingle();
            this.Velocityy = binaryReader.ReadSingle();
            this.Velocityz = binaryReader.ReadSingle();
            this.fieldpad = binaryReader.ReadBytes(12);
            this.Mass = binaryReader.ReadSingle();
            this.CreationTimeStamp = binaryReader.ReadSingle();
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
            queueableBinaryWriter.Write(this.Velocityx);
            queueableBinaryWriter.Write(this.Velocityy);
            queueableBinaryWriter.Write(this.Velocityz);
            queueableBinaryWriter.Write(this.fieldpad);
            queueableBinaryWriter.Write(this.Mass);
            queueableBinaryWriter.Write(this.CreationTimeStamp);
        }
    }
}