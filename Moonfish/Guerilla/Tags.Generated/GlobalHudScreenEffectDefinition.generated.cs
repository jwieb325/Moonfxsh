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
    [TagBlockOriginalNameAttribute("global_hud_screen_effect_definition")]
    public partial class GlobalHudScreenEffectDefinition : GuerillaBlock, IWriteQueueable
    {
        private byte[] fieldpad = new byte[4];
        public Flags GlobalHudScreenEffectDefinitionFlags;
        private byte[] fieldpad0 = new byte[2];
        private byte[] fieldpad1 = new byte[16];
        [Moonfish.Tags.TagReferenceAttribute("bitm")]
        public Moonfish.Tags.TagReference Mask;
        [Moonfish.Tags.TagReferenceAttribute("bitm")]
        public Moonfish.Tags.TagReference Mask0;
        private byte[] fieldpad2 = new byte[8];
        private byte[] fieldpad3 = new byte[20];
        private byte[] fieldpad4 = new byte[24];
        private byte[] fieldpad5 = new byte[8];
        private byte[] fieldpad6 = new byte[24];
        private byte[] fieldpad7 = new byte[20];
        private byte[] fieldpad8 = new byte[24];
        public ScreenEffectFlags GlobalHudScreenEffectDefinitionScreenEffectFlags;
        private byte[] fieldpad9 = new byte[32];
        [Moonfish.Tags.TagReferenceAttribute("egor")]
        public Moonfish.Tags.TagReference ScreenEffect;
        private byte[] fieldpad10 = new byte[32];
        public GlobalHudScreenEffectDefinitionScreenEffectFlags0 GlobalHudScreenEffectDefinitionGlobalHudScreenEffectDefinitionScreenEffectFlags0;
        private byte[] fieldpad11 = new byte[32];
        [Moonfish.Tags.TagReferenceAttribute("egor")]
        public Moonfish.Tags.TagReference ScreenEffect0;
        private byte[] fieldpad12 = new byte[32];
        public override int SerializedSize
        {
            get
            {
                return 320;
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
            this.fieldpad = binaryReader.ReadBytes(4);
            this.GlobalHudScreenEffectDefinitionFlags = ((Flags)(binaryReader.ReadInt16()));
            this.fieldpad0 = binaryReader.ReadBytes(2);
            this.fieldpad1 = binaryReader.ReadBytes(16);
            this.Mask = binaryReader.ReadTagReference();
            this.Mask0 = binaryReader.ReadTagReference();
            this.fieldpad2 = binaryReader.ReadBytes(8);
            this.fieldpad3 = binaryReader.ReadBytes(20);
            this.fieldpad4 = binaryReader.ReadBytes(24);
            this.fieldpad5 = binaryReader.ReadBytes(8);
            this.fieldpad6 = binaryReader.ReadBytes(24);
            this.fieldpad7 = binaryReader.ReadBytes(20);
            this.fieldpad8 = binaryReader.ReadBytes(24);
            this.GlobalHudScreenEffectDefinitionScreenEffectFlags = ((ScreenEffectFlags)(binaryReader.ReadInt32()));
            this.fieldpad9 = binaryReader.ReadBytes(32);
            this.ScreenEffect = binaryReader.ReadTagReference();
            this.fieldpad10 = binaryReader.ReadBytes(32);
            this.GlobalHudScreenEffectDefinitionGlobalHudScreenEffectDefinitionScreenEffectFlags0 = ((GlobalHudScreenEffectDefinitionScreenEffectFlags0)(binaryReader.ReadInt32()));
            this.fieldpad11 = binaryReader.ReadBytes(32);
            this.ScreenEffect0 = binaryReader.ReadTagReference();
            this.fieldpad12 = binaryReader.ReadBytes(32);
            return pointerQueue;
        }
        public override void ReadInstances(Moonfish.Guerilla.BlamBinaryReader binaryReader, System.Collections.Generic.Queue<Moonfish.Tags.BlamPointer> pointerQueue)
        {
            base.ReadInstances(binaryReader, pointerQueue);
        }
        public override void Defer(Moonfish.Guerilla.QueueableBlamBinaryWriter queueableBinaryWriter)
        {
            base.Defer(queueableBinaryWriter);
        }
        public override void Write(Moonfish.Guerilla.QueueableBlamBinaryWriter queueableBinaryWriter)
        {
            base.Write(queueableBinaryWriter);
            queueableBinaryWriter.Write(this.fieldpad);
            queueableBinaryWriter.Write(((short)(this.GlobalHudScreenEffectDefinitionFlags)));
            queueableBinaryWriter.Write(this.fieldpad0);
            queueableBinaryWriter.Write(this.fieldpad1);
            queueableBinaryWriter.Write(this.Mask);
            queueableBinaryWriter.Write(this.Mask0);
            queueableBinaryWriter.Write(this.fieldpad2);
            queueableBinaryWriter.Write(this.fieldpad3);
            queueableBinaryWriter.Write(this.fieldpad4);
            queueableBinaryWriter.Write(this.fieldpad5);
            queueableBinaryWriter.Write(this.fieldpad6);
            queueableBinaryWriter.Write(this.fieldpad7);
            queueableBinaryWriter.Write(this.fieldpad8);
            queueableBinaryWriter.Write(((int)(this.GlobalHudScreenEffectDefinitionScreenEffectFlags)));
            queueableBinaryWriter.Write(this.fieldpad9);
            queueableBinaryWriter.Write(this.ScreenEffect);
            queueableBinaryWriter.Write(this.fieldpad10);
            queueableBinaryWriter.Write(((int)(this.GlobalHudScreenEffectDefinitionGlobalHudScreenEffectDefinitionScreenEffectFlags0)));
            queueableBinaryWriter.Write(this.fieldpad11);
            queueableBinaryWriter.Write(this.ScreenEffect0);
            queueableBinaryWriter.Write(this.fieldpad12);
        }
        /// <summary>
        /// Mask bitmap overlay. Use either a 2D bitmap or an interface bitmap.
        /// </summary>
        [System.FlagsAttribute()]
        public enum Flags : short
        {
            None = 0,
            OnlyWhenZoomed = 1,
            MirrorHorizontally = 2,
            MirrorVertically = 4,
            UseNewHotness = 8,
        }
        [System.FlagsAttribute()]
        public enum ScreenEffectFlags : int
        {
            None = 0,
            OnlyWhenZoomed = 1,
        }
        [System.FlagsAttribute()]
        public enum GlobalHudScreenEffectDefinitionScreenEffectFlags0 : int
        {
            None = 0,
            OnlyWhenZoomed = 1,
        }
    }
}
