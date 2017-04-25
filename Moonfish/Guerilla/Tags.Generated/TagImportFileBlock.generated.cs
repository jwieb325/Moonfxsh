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
    [TagBlockOriginalNameAttribute("tag_import_file_block")]
    public partial class TagImportFileBlock : GuerillaBlock, IWriteQueueable
    {
        public Moonfish.Tags.String256 Path;
        public Moonfish.Tags.String32 ModificationDate;
        private byte[] fieldskip = new byte[8];
        private byte[] fieldpad = new byte[88];
        public int Checksum;
        public int Size;
        public byte[] ZippedData;
        private byte[] fieldpad0 = new byte[128];
        public override int SerializedSize
        {
            get
            {
                return 528;
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
            this.Path = binaryReader.ReadString256();
            this.ModificationDate = binaryReader.ReadString32();
            this.fieldskip = binaryReader.ReadBytes(8);
            this.fieldpad = binaryReader.ReadBytes(88);
            this.Checksum = binaryReader.ReadInt32();
            this.Size = binaryReader.ReadInt32();
            pointerQueue.Enqueue(binaryReader.ReadBlamPointer(1));
            this.fieldpad0 = binaryReader.ReadBytes(128);
            return pointerQueue;
        }
        public override void ReadInstances(Moonfish.Guerilla.BlamBinaryReader binaryReader, System.Collections.Generic.Queue<Moonfish.Tags.BlamPointer> pointerQueue)
        {
            base.ReadInstances(binaryReader, pointerQueue);
            this.ZippedData = base.ReadDataByteArray(binaryReader, pointerQueue.Dequeue());
        }
        public override void Defer(Moonfish.Guerilla.QueueableBlamBinaryWriter queueableBinaryWriter)
        {
            base.Defer(queueableBinaryWriter);
            queueableBinaryWriter.Defer(this.ZippedData);
        }
        public override void Write(Moonfish.Guerilla.QueueableBlamBinaryWriter queueableBinaryWriter)
        {
            base.Write(queueableBinaryWriter);
            queueableBinaryWriter.Write(this.Path);
            queueableBinaryWriter.Write(this.ModificationDate);
            queueableBinaryWriter.Write(this.fieldskip);
            queueableBinaryWriter.Write(this.fieldpad);
            queueableBinaryWriter.Write(this.Checksum);
            queueableBinaryWriter.Write(this.Size);
            queueableBinaryWriter.WritePointer(this.ZippedData);
            queueableBinaryWriter.Write(this.fieldpad0);
        }
    }
}
