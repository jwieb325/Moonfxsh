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
    
    public partial class ScenarioSoundSceneryBlock : GuerillaBlock, IWriteQueueable
    {
        public Moonfish.Tags.ShortBlockIndex1 Type;
        public Moonfish.Tags.ShortBlockIndex1 Name;
        public ScenarioObjectDatumStructBlock ObjectData = new ScenarioObjectDatumStructBlock();
        public SoundSceneryDatumStructBlock SoundScenery = new SoundSceneryDatumStructBlock();
        public override int SerializedSize
        {
            get
            {
                return 80;
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
            this.Type = binaryReader.ReadShortBlockIndex1();
            this.Name = binaryReader.ReadShortBlockIndex1();
            pointerQueue = new System.Collections.Generic.Queue<Moonfish.Tags.BlamPointer>(pointerQueue.Concat(this.ObjectData.ReadFields(binaryReader)));
            pointerQueue = new System.Collections.Generic.Queue<Moonfish.Tags.BlamPointer>(pointerQueue.Concat(this.SoundScenery.ReadFields(binaryReader)));
            return pointerQueue;
        }
        public override void ReadInstances(System.IO.BinaryReader binaryReader, System.Collections.Generic.Queue<Moonfish.Tags.BlamPointer> pointerQueue)
        {
            base.ReadInstances(binaryReader, pointerQueue);
            this.ObjectData.ReadInstances(binaryReader, pointerQueue);
            this.SoundScenery.ReadInstances(binaryReader, pointerQueue);
        }
        public override void QueueWrites(Moonfish.Guerilla.QueueableBinaryWriter queueableBinaryWriter)
        {
            base.QueueWrites(queueableBinaryWriter);
            this.ObjectData.QueueWrites(queueableBinaryWriter);
            this.SoundScenery.QueueWrites(queueableBinaryWriter);
        }
        public override void Write_(Moonfish.Guerilla.QueueableBinaryWriter queueableBinaryWriter)
        {
            base.Write_(queueableBinaryWriter);
            queueableBinaryWriter.Write(this.Type);
            queueableBinaryWriter.Write(this.Name);
            this.ObjectData.Write_(queueableBinaryWriter);
            this.SoundScenery.Write_(queueableBinaryWriter);
        }
    }
}