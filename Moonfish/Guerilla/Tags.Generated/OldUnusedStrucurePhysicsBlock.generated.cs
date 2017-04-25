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
    [TagBlockOriginalNameAttribute("old_unused_strucure_physics_block")]
    public partial class OldUnusedStrucurePhysicsBlock : GuerillaBlock, IWriteQueueable
    {
        public byte[] moppCode;
        public OldUnusedObjectIdentifiersBlock[] EvironmentObjectIdentifiers = new OldUnusedObjectIdentifiersBlock[0];
        private byte[] fieldpad = new byte[4];
        public OpenTK.Vector3 MoppBoundsMin;
        public OpenTK.Vector3 MoppBoundsMax;
        public override int SerializedSize
        {
            get
            {
                return 44;
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
            pointerQueue.Enqueue(binaryReader.ReadBlamPointer(1));
            pointerQueue.Enqueue(binaryReader.ReadBlamPointer(8));
            this.fieldpad = binaryReader.ReadBytes(4);
            this.MoppBoundsMin = binaryReader.ReadVector3();
            this.MoppBoundsMax = binaryReader.ReadVector3();
            return pointerQueue;
        }
        public override void ReadInstances(Moonfish.Guerilla.BlamBinaryReader binaryReader, System.Collections.Generic.Queue<Moonfish.Tags.BlamPointer> pointerQueue)
        {
            base.ReadInstances(binaryReader, pointerQueue);
            this.moppCode = base.ReadDataByteArray(binaryReader, pointerQueue.Dequeue());
            this.EvironmentObjectIdentifiers = base.ReadBlockArrayData<OldUnusedObjectIdentifiersBlock>(binaryReader, pointerQueue.Dequeue());
        }
        public override void Defer(Moonfish.Guerilla.QueueableBlamBinaryWriter queueableBinaryWriter)
        {
            base.Defer(queueableBinaryWriter);
            queueableBinaryWriter.Defer(this.moppCode);
            queueableBinaryWriter.Defer(this.EvironmentObjectIdentifiers);
        }
        public override void Write(Moonfish.Guerilla.QueueableBlamBinaryWriter queueableBinaryWriter)
        {
            base.Write(queueableBinaryWriter);
            queueableBinaryWriter.WritePointer(this.moppCode);
            queueableBinaryWriter.WritePointer(this.EvironmentObjectIdentifiers);
            queueableBinaryWriter.Write(this.fieldpad);
            queueableBinaryWriter.Write(this.MoppBoundsMin);
            queueableBinaryWriter.Write(this.MoppBoundsMax);
        }
    }
}
