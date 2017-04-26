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
    using Moonfish.Guerilla;
    using System.IO;
    using System.Collections.Generic;
    using System.Linq;
    
    [JetBrains.Annotations.UsedImplicitlyAttribute(ImplicitUseTargetFlags.WithMembers)]
    [TagBlockOriginalNameAttribute("simple_platform_sound_playback_struct_block")]
    public partial class SimplePlatformSoundPlaybackStructBlock : GuerillaBlock, IWriteDeferrable
    {
        public PlatformSoundOverrideMixbinsBlock[] PlatformSoundOverrideMixbinsBlock = new PlatformSoundOverrideMixbinsBlock[0];
        public Flags SimplePlatformSoundPlaybackStructFlags;
        private byte[] fieldpad = new byte[8];
        public PlatformSoundFilterBlock[] Filter = new PlatformSoundFilterBlock[0];
        public PlatformSoundPitchLfoBlock[] PitchLfo = new PlatformSoundPitchLfoBlock[0];
        public PlatformSoundFilterLfoBlock[] FilterLfo = new PlatformSoundFilterLfoBlock[0];
        public SoundEffectPlaybackBlock[] SoundEffect = new SoundEffectPlaybackBlock[0];
        public override int SerializedSize
        {
            get
            {
                return 52;
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
            pointerQueue.Enqueue(binaryReader.ReadBlamPointer(8));
            this.SimplePlatformSoundPlaybackStructFlags = ((Flags)(binaryReader.ReadInt32()));
            this.fieldpad = binaryReader.ReadBytes(8);
            pointerQueue.Enqueue(binaryReader.ReadBlamPointer(72));
            pointerQueue.Enqueue(binaryReader.ReadBlamPointer(48));
            pointerQueue.Enqueue(binaryReader.ReadBlamPointer(64));
            pointerQueue.Enqueue(binaryReader.ReadBlamPointer(40));
            return pointerQueue;
        }
        public override void ReadInstances(Moonfish.Guerilla.BlamBinaryReader binaryReader, System.Collections.Generic.Queue<Moonfish.Tags.BlamPointer> pointerQueue)
        {
            base.ReadInstances(binaryReader, pointerQueue);
            this.PlatformSoundOverrideMixbinsBlock = base.ReadBlockArrayData<PlatformSoundOverrideMixbinsBlock>(binaryReader, pointerQueue.Dequeue());
            this.Filter = base.ReadBlockArrayData<PlatformSoundFilterBlock>(binaryReader, pointerQueue.Dequeue());
            this.PitchLfo = base.ReadBlockArrayData<PlatformSoundPitchLfoBlock>(binaryReader, pointerQueue.Dequeue());
            this.FilterLfo = base.ReadBlockArrayData<PlatformSoundFilterLfoBlock>(binaryReader, pointerQueue.Dequeue());
            this.SoundEffect = base.ReadBlockArrayData<SoundEffectPlaybackBlock>(binaryReader, pointerQueue.Dequeue());
        }
        public override void DeferReferences(Moonfish.Guerilla.LinearBinaryWriter writer)
        {
            base.DeferReferences(writer);
            writer.Defer(this.PlatformSoundOverrideMixbinsBlock);
            writer.Defer(this.Filter);
            writer.Defer(this.PitchLfo);
            writer.Defer(this.FilterLfo);
            writer.Defer(this.SoundEffect);
        }
        public override void Write(Moonfish.Guerilla.LinearBinaryWriter writer)
        {
            base.Write(writer);
            writer.WritePointer(this.PlatformSoundOverrideMixbinsBlock);
            writer.Write(((int)(this.SimplePlatformSoundPlaybackStructFlags)));
            writer.Write(this.fieldpad);
            writer.WritePointer(this.Filter);
            writer.WritePointer(this.PitchLfo);
            writer.WritePointer(this.FilterLfo);
            writer.WritePointer(this.SoundEffect);
        }
        [System.FlagsAttribute()]
        public enum Flags : int
        {
            None = 0,
            Use3dRadioHack = 1,
        }
    }
}
