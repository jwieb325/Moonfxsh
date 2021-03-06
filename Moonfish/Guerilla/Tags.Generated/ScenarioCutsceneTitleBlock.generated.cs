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
    
    public partial class ScenarioCutsceneTitleBlock : GuerillaBlock, IWriteQueueable
    {
        public Moonfish.Tags.StringIdent Name;
        public OpenTK.Vector2 TextBounds;
        public JustificationEnum Justification;
        public FontEnum Font;
        public Moonfish.Tags.ColourR1G1B1 TextColor;
        public Moonfish.Tags.ColourR1G1B1 ShadowColor;
        public float FadeInTimeseconds;
        public float UpTimeseconds;
        public float FadeOutTimeseconds;
        private byte[] padding = new byte[2];
        public override int SerializedSize
        {
            get
            {
                return 36;
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
            this.Name = binaryReader.ReadStringID();
            this.TextBounds = binaryReader.ReadVector2();
            this.Justification = ((JustificationEnum)(binaryReader.ReadInt16()));
            this.Font = ((FontEnum)(binaryReader.ReadInt16()));
            this.TextColor = binaryReader.ReadColourR1G1B1();
            this.ShadowColor = binaryReader.ReadColourR1G1B1();
            this.FadeInTimeseconds = binaryReader.ReadSingle();
            this.UpTimeseconds = binaryReader.ReadSingle();
            this.FadeOutTimeseconds = binaryReader.ReadSingle();
            this.padding = binaryReader.ReadBytes(2);
            return pointerQueue;
        }
        public override void ReadInstances(System.IO.BinaryReader binaryReader, System.Collections.Generic.Queue<Moonfish.Tags.BlamPointer> pointerQueue)
        {
            base.ReadInstances(binaryReader, pointerQueue);
        }
        public override void QueueWrites(Moonfish.Guerilla.QueueableBinaryWriter queueableBinaryWriter)
        {
            base.QueueWrites(queueableBinaryWriter);
        }
        public override void Write_(Moonfish.Guerilla.QueueableBinaryWriter queueableBinaryWriter)
        {
            base.Write_(queueableBinaryWriter);
            queueableBinaryWriter.Write(this.Name);
            queueableBinaryWriter.Write(this.TextBounds);
            queueableBinaryWriter.Write(((short)(this.Justification)));
            queueableBinaryWriter.Write(((short)(this.Font)));
            queueableBinaryWriter.Write(this.TextColor);
            queueableBinaryWriter.Write(this.ShadowColor);
            queueableBinaryWriter.Write(this.FadeInTimeseconds);
            queueableBinaryWriter.Write(this.UpTimeseconds);
            queueableBinaryWriter.Write(this.FadeOutTimeseconds);
            queueableBinaryWriter.Write(this.padding);
        }
        public enum JustificationEnum : short
        {
            Left = 0,
            Right = 1,
            Center = 2,
            CustomTextEntry = 3,
        }
        public enum FontEnum : short
        {
            TerminalFont = 0,
            BodyTextFont = 1,
            TitleFont = 2,
            SuperLargeFont = 3,
            LargeBodyTextFont = 4,
            SplitScreenHudMessageFont = 5,
            FullScreenHudMessageFont = 6,
            EnglishBodyTextFont = 7,
            HudNumberFont = 8,
            SubtitleFont = 9,
            MainMenuFont = 10,
            TextChatFont = 11,
        }
    }
}
