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
    
    public partial class PlatformSoundFilterLfoBlock : GuerillaBlock, IWriteQueueable
    {
        public SoundPlaybackParameterDefinitionBlock Delay = new SoundPlaybackParameterDefinitionBlock();
        public SoundPlaybackParameterDefinitionBlock Frequency = new SoundPlaybackParameterDefinitionBlock();
        public SoundPlaybackParameterDefinitionBlock CutoffModulation = new SoundPlaybackParameterDefinitionBlock();
        public SoundPlaybackParameterDefinitionBlock GainModulation = new SoundPlaybackParameterDefinitionBlock();
        public override int SerializedSize
        {
            get
            {
                return 64;
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
            pointerQueue = new System.Collections.Generic.Queue<Moonfish.Tags.BlamPointer>(pointerQueue.Concat(this.Delay.ReadFields(binaryReader)));
            pointerQueue = new System.Collections.Generic.Queue<Moonfish.Tags.BlamPointer>(pointerQueue.Concat(this.Frequency.ReadFields(binaryReader)));
            pointerQueue = new System.Collections.Generic.Queue<Moonfish.Tags.BlamPointer>(pointerQueue.Concat(this.CutoffModulation.ReadFields(binaryReader)));
            pointerQueue = new System.Collections.Generic.Queue<Moonfish.Tags.BlamPointer>(pointerQueue.Concat(this.GainModulation.ReadFields(binaryReader)));
            return pointerQueue;
        }
        public override void ReadInstances(System.IO.BinaryReader binaryReader, System.Collections.Generic.Queue<Moonfish.Tags.BlamPointer> pointerQueue)
        {
            base.ReadInstances(binaryReader, pointerQueue);
            this.Delay.ReadInstances(binaryReader, pointerQueue);
            this.Frequency.ReadInstances(binaryReader, pointerQueue);
            this.CutoffModulation.ReadInstances(binaryReader, pointerQueue);
            this.GainModulation.ReadInstances(binaryReader, pointerQueue);
        }
        public override void QueueWrites(Moonfish.Guerilla.QueueableBinaryWriter queueableBinaryWriter)
        {
            base.QueueWrites(queueableBinaryWriter);
            this.Delay.QueueWrites(queueableBinaryWriter);
            this.Frequency.QueueWrites(queueableBinaryWriter);
            this.CutoffModulation.QueueWrites(queueableBinaryWriter);
            this.GainModulation.QueueWrites(queueableBinaryWriter);
        }
        public override void Write_(Moonfish.Guerilla.QueueableBinaryWriter queueableBinaryWriter)
        {
            base.Write_(queueableBinaryWriter);
            this.Delay.Write_(queueableBinaryWriter);
            this.Frequency.Write_(queueableBinaryWriter);
            this.CutoffModulation.Write_(queueableBinaryWriter);
            this.GainModulation.Write_(queueableBinaryWriter);
        }
    }
}