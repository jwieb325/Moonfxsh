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
    
    public partial class CharacterPhysicsGroundStructBlock : GuerillaBlock, IWriteQueueable
    {
        public float MaximumSlopeAngle;
        public float DownhillFalloffAngle;
        public float DownhillCutoffAngle;
        public float UphillFalloffAngle;
        public float UphillCutoffAngle;
        public float DownhillVelocityScale;
        public float UphillVelocityScale;
        private byte[] fieldpad = new byte[20];
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
                return 4;
            }
        }
        public override System.Collections.Generic.Queue<Moonfish.Tags.BlamPointer> ReadFields(System.IO.BinaryReader binaryReader)
        {
            System.Collections.Generic.Queue<Moonfish.Tags.BlamPointer> pointerQueue = new System.Collections.Generic.Queue<Moonfish.Tags.BlamPointer>(base.ReadFields(binaryReader));
            this.MaximumSlopeAngle = binaryReader.ReadSingle();
            this.DownhillFalloffAngle = binaryReader.ReadSingle();
            this.DownhillCutoffAngle = binaryReader.ReadSingle();
            this.UphillFalloffAngle = binaryReader.ReadSingle();
            this.UphillCutoffAngle = binaryReader.ReadSingle();
            this.DownhillVelocityScale = binaryReader.ReadSingle();
            this.UphillVelocityScale = binaryReader.ReadSingle();
            this.fieldpad = binaryReader.ReadBytes(20);
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
            queueableBinaryWriter.Write(this.MaximumSlopeAngle);
            queueableBinaryWriter.Write(this.DownhillFalloffAngle);
            queueableBinaryWriter.Write(this.DownhillCutoffAngle);
            queueableBinaryWriter.Write(this.UphillFalloffAngle);
            queueableBinaryWriter.Write(this.UphillCutoffAngle);
            queueableBinaryWriter.Write(this.DownhillVelocityScale);
            queueableBinaryWriter.Write(this.UphillVelocityScale);
            queueableBinaryWriter.Write(this.fieldpad);
        }
    }
}
