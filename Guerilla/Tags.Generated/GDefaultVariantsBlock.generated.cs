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
    
    public partial class GDefaultVariantsBlock : GuerillaBlock, IWriteQueueable
    {
        public Moonfish.Tags.StringIdent VariantName;
        public VariantTypeEnum VariantType;
        public GDefaultVariantSettingsBlock[] Settings = new GDefaultVariantSettingsBlock[0];
        public byte DescriptionIndex;
        private byte[] fieldpad = new byte[3];
        public override int SerializedSize
        {
            get
            {
                return 20;
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
            this.VariantName = binaryReader.ReadStringID();
            this.VariantType = ((VariantTypeEnum)(binaryReader.ReadInt32()));
            pointerQueue.Enqueue(binaryReader.ReadBlamPointer(8));
            this.DescriptionIndex = binaryReader.ReadByte();
            this.fieldpad = binaryReader.ReadBytes(3);
            return pointerQueue;
        }
        public override void ReadInstances(System.IO.BinaryReader binaryReader, System.Collections.Generic.Queue<Moonfish.Tags.BlamPointer> pointerQueue)
        {
            base.ReadInstances(binaryReader, pointerQueue);
            this.Settings = base.ReadBlockArrayData<GDefaultVariantSettingsBlock>(binaryReader, pointerQueue.Dequeue());
        }
        public override void QueueWrites(Moonfish.Guerilla.QueueableBinaryWriter queueableBinaryWriter)
        {
            base.QueueWrites(queueableBinaryWriter);
            queueableBinaryWriter.QueueWrite(this.Settings);
        }
        public override void Write_(Moonfish.Guerilla.QueueableBinaryWriter queueableBinaryWriter)
        {
            base.Write_(queueableBinaryWriter);
            queueableBinaryWriter.Write(this.VariantName);
            queueableBinaryWriter.Write(((int)(this.VariantType)));
            queueableBinaryWriter.WritePointer(this.Settings);
            queueableBinaryWriter.Write(this.DescriptionIndex);
            queueableBinaryWriter.Write(this.fieldpad);
        }
        public enum VariantTypeEnum : int
        {
            Slayer = 0,
            Oddball = 1,
            Juggernaut = 2,
            King = 3,
            Ctf = 4,
            Invasion = 5,
            Territories = 6,
        }
    }
}
