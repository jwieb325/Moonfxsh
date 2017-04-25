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
    [TagBlockOriginalNameAttribute("user_hint_block")]
    public partial class UserHintBlock : GuerillaBlock, IWriteQueueable
    {
        public UserHintPointBlock[] PointGeometry = new UserHintPointBlock[0];
        public UserHintRayBlock[] RayGeometry = new UserHintRayBlock[0];
        public UserHintLineSegmentBlock[] LineSegmentGeometry = new UserHintLineSegmentBlock[0];
        public UserHintParallelogramBlock[] ParallelogramGeometry = new UserHintParallelogramBlock[0];
        public UserHintPolygonBlock[] PolygonGeometry = new UserHintPolygonBlock[0];
        public UserHintJumpBlock[] JumpHints = new UserHintJumpBlock[0];
        public UserHintClimbBlock[] ClimbHints = new UserHintClimbBlock[0];
        public UserHintWellBlock[] WellHints = new UserHintWellBlock[0];
        public UserHintFlightBlock[] FlightHints = new UserHintFlightBlock[0];
        public override int SerializedSize
        {
            get
            {
                return 72;
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
            pointerQueue.Enqueue(binaryReader.ReadBlamPointer(16));
            pointerQueue.Enqueue(binaryReader.ReadBlamPointer(28));
            pointerQueue.Enqueue(binaryReader.ReadBlamPointer(36));
            pointerQueue.Enqueue(binaryReader.ReadBlamPointer(68));
            pointerQueue.Enqueue(binaryReader.ReadBlamPointer(12));
            pointerQueue.Enqueue(binaryReader.ReadBlamPointer(8));
            pointerQueue.Enqueue(binaryReader.ReadBlamPointer(4));
            pointerQueue.Enqueue(binaryReader.ReadBlamPointer(12));
            pointerQueue.Enqueue(binaryReader.ReadBlamPointer(8));
            return pointerQueue;
        }
        public override void ReadInstances(Moonfish.Guerilla.BlamBinaryReader binaryReader, System.Collections.Generic.Queue<Moonfish.Tags.BlamPointer> pointerQueue)
        {
            base.ReadInstances(binaryReader, pointerQueue);
            this.PointGeometry = base.ReadBlockArrayData<UserHintPointBlock>(binaryReader, pointerQueue.Dequeue());
            this.RayGeometry = base.ReadBlockArrayData<UserHintRayBlock>(binaryReader, pointerQueue.Dequeue());
            this.LineSegmentGeometry = base.ReadBlockArrayData<UserHintLineSegmentBlock>(binaryReader, pointerQueue.Dequeue());
            this.ParallelogramGeometry = base.ReadBlockArrayData<UserHintParallelogramBlock>(binaryReader, pointerQueue.Dequeue());
            this.PolygonGeometry = base.ReadBlockArrayData<UserHintPolygonBlock>(binaryReader, pointerQueue.Dequeue());
            this.JumpHints = base.ReadBlockArrayData<UserHintJumpBlock>(binaryReader, pointerQueue.Dequeue());
            this.ClimbHints = base.ReadBlockArrayData<UserHintClimbBlock>(binaryReader, pointerQueue.Dequeue());
            this.WellHints = base.ReadBlockArrayData<UserHintWellBlock>(binaryReader, pointerQueue.Dequeue());
            this.FlightHints = base.ReadBlockArrayData<UserHintFlightBlock>(binaryReader, pointerQueue.Dequeue());
        }
        public override void Defer(Moonfish.Guerilla.QueueableBlamBinaryWriter queueableBinaryWriter)
        {
            base.Defer(queueableBinaryWriter);
            queueableBinaryWriter.Defer(this.PointGeometry);
            queueableBinaryWriter.Defer(this.RayGeometry);
            queueableBinaryWriter.Defer(this.LineSegmentGeometry);
            queueableBinaryWriter.Defer(this.ParallelogramGeometry);
            queueableBinaryWriter.Defer(this.PolygonGeometry);
            queueableBinaryWriter.Defer(this.JumpHints);
            queueableBinaryWriter.Defer(this.ClimbHints);
            queueableBinaryWriter.Defer(this.WellHints);
            queueableBinaryWriter.Defer(this.FlightHints);
        }
        public override void Write(Moonfish.Guerilla.QueueableBlamBinaryWriter queueableBinaryWriter)
        {
            base.Write(queueableBinaryWriter);
            queueableBinaryWriter.WritePointer(this.PointGeometry);
            queueableBinaryWriter.WritePointer(this.RayGeometry);
            queueableBinaryWriter.WritePointer(this.LineSegmentGeometry);
            queueableBinaryWriter.WritePointer(this.ParallelogramGeometry);
            queueableBinaryWriter.WritePointer(this.PolygonGeometry);
            queueableBinaryWriter.WritePointer(this.JumpHints);
            queueableBinaryWriter.WritePointer(this.ClimbHints);
            queueableBinaryWriter.WritePointer(this.WellHints);
            queueableBinaryWriter.WritePointer(this.FlightHints);
        }
    }
}
