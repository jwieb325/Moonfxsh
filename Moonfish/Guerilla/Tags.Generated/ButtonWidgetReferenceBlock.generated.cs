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
    [TagBlockOriginalNameAttribute("button_widget_reference_block")]
    public partial class ButtonWidgetReferenceBlock : GuerillaBlock, IWriteQueueable
    {
        public TextFlags ButtonWidgetReferenceTextFlags;
        public AnimationIndexEnum AnimationIndex;
        public short IntroAnimationDelayMilliseconds;
        private byte[] fieldpad = new byte[2];
        public CustomFontEnum CustomFont;
        public OpenTK.Vector4 TextColor;
        public OpenTK.Vector2 Bounds;
        [Moonfish.Tags.TagReferenceAttribute("bitm")]
        public Moonfish.Tags.TagReference Bitmap;
        public Moonfish.Tags.Point BitmapOffset;
        public Moonfish.Tags.StringIdent StringId;
        public short RenderDepthBias;
        public short MouseRegionTopOffset;
        public ButtonFlags ButtonWidgetReferenceButtonFlags;
        public override int SerializedSize
        {
            get
            {
                return 60;
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
            this.ButtonWidgetReferenceTextFlags = ((TextFlags)(binaryReader.ReadInt32()));
            this.AnimationIndex = ((AnimationIndexEnum)(binaryReader.ReadInt16()));
            this.IntroAnimationDelayMilliseconds = binaryReader.ReadInt16();
            this.fieldpad = binaryReader.ReadBytes(2);
            this.CustomFont = ((CustomFontEnum)(binaryReader.ReadInt16()));
            this.TextColor = binaryReader.ReadVector4();
            this.Bounds = binaryReader.ReadVector2();
            this.Bitmap = binaryReader.ReadTagReference();
            this.BitmapOffset = binaryReader.ReadPoint();
            this.StringId = binaryReader.ReadStringIdent();
            this.RenderDepthBias = binaryReader.ReadInt16();
            this.MouseRegionTopOffset = binaryReader.ReadInt16();
            this.ButtonWidgetReferenceButtonFlags = ((ButtonFlags)(binaryReader.ReadInt32()));
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
            queueableBinaryWriter.Write(((int)(this.ButtonWidgetReferenceTextFlags)));
            queueableBinaryWriter.Write(((short)(this.AnimationIndex)));
            queueableBinaryWriter.Write(this.IntroAnimationDelayMilliseconds);
            queueableBinaryWriter.Write(this.fieldpad);
            queueableBinaryWriter.Write(((short)(this.CustomFont)));
            queueableBinaryWriter.Write(this.TextColor);
            queueableBinaryWriter.Write(this.Bounds);
            queueableBinaryWriter.Write(this.Bitmap);
            queueableBinaryWriter.Write(this.BitmapOffset);
            queueableBinaryWriter.Write(this.StringId);
            queueableBinaryWriter.Write(this.RenderDepthBias);
            queueableBinaryWriter.Write(this.MouseRegionTopOffset);
            queueableBinaryWriter.Write(((int)(this.ButtonWidgetReferenceButtonFlags)));
        }
        /// <summary>
        /// If the pane contains buttons, define them here
        /// </summary>
        [System.FlagsAttribute()]
        public enum TextFlags : int
        {
            None = 0,
            LeftJustifyText = 1,
            RightJustifyText = 2,
            PulsatingText = 4,
            CalloutText = 8,
            Small31CharBuffer = 16,
        }
        public enum AnimationIndexEnum : short
        {
            NONE = 0,
            _00 = 1,
            _01 = 2,
            _02 = 3,
            _03 = 4,
            _04 = 5,
            _05 = 6,
            _06 = 7,
            _07 = 8,
            _08 = 9,
            _09 = 10,
            _10 = 11,
            _11 = 12,
            _12 = 13,
            _13 = 14,
            _14 = 15,
            _15 = 16,
            _16 = 17,
            _17 = 18,
            _18 = 19,
            _19 = 20,
            _20 = 21,
            _21 = 22,
            _22 = 23,
            _23 = 24,
            _24 = 25,
            _25 = 26,
            _26 = 27,
            _27 = 28,
            _28 = 29,
            _29 = 30,
            _30 = 31,
            _31 = 32,
            _32 = 33,
            _33 = 34,
            _34 = 35,
            _35 = 36,
            _36 = 37,
            _37 = 38,
            _38 = 39,
            _39 = 40,
            _40 = 41,
            _41 = 42,
            _42 = 43,
            _43 = 44,
            _44 = 45,
            _45 = 46,
            _46 = 47,
            _47 = 48,
            _48 = 49,
            _49 = 50,
            _50 = 51,
            _51 = 52,
            _52 = 53,
            _53 = 54,
            _54 = 55,
            _55 = 56,
            _56 = 57,
            _57 = 58,
            _58 = 59,
            _59 = 60,
            _60 = 61,
            _61 = 62,
            _62 = 63,
            _63 = 64,
        }
        public enum CustomFontEnum : short
        {
            Terminal = 0,
            BodyText = 1,
            Title = 2,
            SuperLargeFont = 3,
            LargeBodyText = 4,
            SplitScreenHudMessage = 5,
            FullScreenHudMessage = 6,
            EnglishBodyText = 7,
            HUDNumberText = 8,
            SubtitleFont = 9,
            MainMenuFont = 10,
            TextChatFont = 11,
        }
        [System.FlagsAttribute()]
        public enum ButtonFlags : int
        {
            None = 0,
            DOESNTTabVertically = 1,
            DOESNTTabHorizontally = 2,
        }
    }
}
