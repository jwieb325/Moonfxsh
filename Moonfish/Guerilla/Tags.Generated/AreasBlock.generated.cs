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
    [TagBlockOriginalNameAttribute("areas_block")]
    public partial class AreasBlock : GuerillaBlock, IWriteQueueable
    {
        public Moonfish.Tags.String32 Name;
        public AreaFlags AreasAreaFlags;
        private byte[] fieldskip = new byte[20];
        private byte[] fieldskip0 = new byte[4];
        private byte[] fieldpad = new byte[64];
        public short ManualReferenceFrame;
        private byte[] fieldpad0 = new byte[2];
        public FlightReferenceBlock[] FlightHints = new FlightReferenceBlock[0];
        public override int SerializedSize
        {
            get
            {
                return 136;
            }
        }
        public override int Alignment
        {
            get
            {
                return 4;
            }
        }
        public override System.Collections.Generic.Queue<Moonfish.Tags.BlamPointer> ReadFields(Moonfish.Guerilla.BlamBinaryReader binaryReader)
        {
            System.Collections.Generic.Queue<Moonfish.Tags.BlamPointer> pointerQueue = new System.Collections.Generic.Queue<Moonfish.Tags.BlamPointer>(base.ReadFields(binaryReader));
            this.Name = binaryReader.ReadString32();
            this.AreasAreaFlags = ((AreaFlags)(binaryReader.ReadInt32()));
            this.fieldskip = binaryReader.ReadBytes(20);
            this.fieldskip0 = binaryReader.ReadBytes(4);
            this.fieldpad = binaryReader.ReadBytes(64);
            this.ManualReferenceFrame = binaryReader.ReadInt16();
            this.fieldpad0 = binaryReader.ReadBytes(2);
            pointerQueue.Enqueue(binaryReader.ReadBlamPointer(4));
            return pointerQueue;
        }
        public override void ReadInstances(Moonfish.Guerilla.BlamBinaryReader binaryReader, System.Collections.Generic.Queue<Moonfish.Tags.BlamPointer> pointerQueue)
        {
            base.ReadInstances(binaryReader, pointerQueue);
            this.FlightHints = base.ReadBlockArrayData<FlightReferenceBlock>(binaryReader, pointerQueue.Dequeue());
        }
        public override void Defer(Moonfish.Guerilla.QueueableBlamBinaryWriter queueableBinaryWriter)
        {
            base.Defer(queueableBinaryWriter);
            queueableBinaryWriter.Defer(this.FlightHints);
        }
        public override void Write(Moonfish.Guerilla.QueueableBlamBinaryWriter queueableBinaryWriter)
        {
            base.Write(queueableBinaryWriter);
            queueableBinaryWriter.Write(this.Name);
            queueableBinaryWriter.Write(((int)(this.AreasAreaFlags)));
            queueableBinaryWriter.Write(this.fieldskip);
            queueableBinaryWriter.Write(this.fieldskip0);
            queueableBinaryWriter.Write(this.fieldpad);
            queueableBinaryWriter.Write(this.ManualReferenceFrame);
            queueableBinaryWriter.Write(this.fieldpad0);
            queueableBinaryWriter.WritePointer(this.FlightHints);
        }
        [System.FlagsAttribute()]
        public enum AreaFlags : int
        {
            None = 0,
            VehicleArea = 1,
            Perch = 2,
            ManualReferenceFrame = 4,
        }
    }
}
