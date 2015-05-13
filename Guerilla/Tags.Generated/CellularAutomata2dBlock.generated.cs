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
    
    [TagClassAttribute("whip")]
    public partial class CellularAutomata2dBlock : GuerillaBlock, IWriteQueueable
    {
        public short UpdatesPerSecond;
        private byte[] fieldpad = new byte[2];
        public float DeadCellPenalty;
        public float LiveCellBonus;
        private byte[] fieldpad0 = new byte[80];
        public short Width;
        public short Height;
        public float CellWidth;
        public float Height0;
        public OpenTK.Vector2 Velocity;
        private byte[] fieldpad1 = new byte[28];
        public Moonfish.Tags.StringIdent Marker;
        public InterpolationFlags CellularAutomata2dInterpolationFlags;
        public Moonfish.Tags.ColourR8G8B8 BaseColor;
        public Moonfish.Tags.ColourR8G8B8 PeakColor;
        private byte[] fieldpad2 = new byte[76];
        public short Width0;
        public short Height1;
        public float CellWidth0;
        public OpenTK.Vector2 Velocity0;
        private byte[] fieldpad3 = new byte[48];
        public Moonfish.Tags.StringIdent Marker0;
        public short TextureWidth;
        private byte[] fieldpad4 = new byte[2];
        private byte[] fieldpad5 = new byte[48];
        [Moonfish.Tags.TagReferenceAttribute("bitm")]
        public Moonfish.Tags.TagReference Texture;
        private byte[] fieldpad6 = new byte[160];
        public RulesBlock[] Rules = new RulesBlock[0];
        public override int SerializedSize
        {
            get
            {
                return 544;
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
            this.UpdatesPerSecond = binaryReader.ReadInt16();
            this.fieldpad = binaryReader.ReadBytes(2);
            this.DeadCellPenalty = binaryReader.ReadSingle();
            this.LiveCellBonus = binaryReader.ReadSingle();
            this.fieldpad0 = binaryReader.ReadBytes(80);
            this.Width = binaryReader.ReadInt16();
            this.Height = binaryReader.ReadInt16();
            this.CellWidth = binaryReader.ReadSingle();
            this.Height0 = binaryReader.ReadSingle();
            this.Velocity = binaryReader.ReadVector2();
            this.fieldpad1 = binaryReader.ReadBytes(28);
            this.Marker = binaryReader.ReadStringID();
            this.CellularAutomata2dInterpolationFlags = ((InterpolationFlags)(binaryReader.ReadInt32()));
            this.BaseColor = binaryReader.ReadColorR8G8B8();
            this.PeakColor = binaryReader.ReadColorR8G8B8();
            this.fieldpad2 = binaryReader.ReadBytes(76);
            this.Width0 = binaryReader.ReadInt16();
            this.Height1 = binaryReader.ReadInt16();
            this.CellWidth0 = binaryReader.ReadSingle();
            this.Velocity0 = binaryReader.ReadVector2();
            this.fieldpad3 = binaryReader.ReadBytes(48);
            this.Marker0 = binaryReader.ReadStringID();
            this.TextureWidth = binaryReader.ReadInt16();
            this.fieldpad4 = binaryReader.ReadBytes(2);
            this.fieldpad5 = binaryReader.ReadBytes(48);
            this.Texture = binaryReader.ReadTagReference();
            this.fieldpad6 = binaryReader.ReadBytes(160);
            pointerQueue.Enqueue(binaryReader.ReadBlamPointer(84));
            return pointerQueue;
        }
        public override void ReadInstances(System.IO.BinaryReader binaryReader, System.Collections.Generic.Queue<Moonfish.Tags.BlamPointer> pointerQueue)
        {
            base.ReadInstances(binaryReader, pointerQueue);
            this.Rules = base.ReadBlockArrayData<RulesBlock>(binaryReader, pointerQueue.Dequeue());
        }
        public override void QueueWrites(Moonfish.Guerilla.QueueableBinaryWriter queueableBinaryWriter)
        {
            base.QueueWrites(queueableBinaryWriter);
            queueableBinaryWriter.QueueWrite(this.Rules);
        }
        public override void Write_(Moonfish.Guerilla.QueueableBinaryWriter queueableBinaryWriter)
        {
            base.Write_(queueableBinaryWriter);
            queueableBinaryWriter.Write(this.UpdatesPerSecond);
            queueableBinaryWriter.Write(this.fieldpad);
            queueableBinaryWriter.Write(this.DeadCellPenalty);
            queueableBinaryWriter.Write(this.LiveCellBonus);
            queueableBinaryWriter.Write(this.fieldpad0);
            queueableBinaryWriter.Write(this.Width);
            queueableBinaryWriter.Write(this.Height);
            queueableBinaryWriter.Write(this.CellWidth);
            queueableBinaryWriter.Write(this.Height0);
            queueableBinaryWriter.Write(this.Velocity);
            queueableBinaryWriter.Write(this.fieldpad1);
            queueableBinaryWriter.Write(this.Marker);
            queueableBinaryWriter.Write(((int)(this.CellularAutomata2dInterpolationFlags)));
            queueableBinaryWriter.Write(this.BaseColor);
            queueableBinaryWriter.Write(this.PeakColor);
            queueableBinaryWriter.Write(this.fieldpad2);
            queueableBinaryWriter.Write(this.Width0);
            queueableBinaryWriter.Write(this.Height1);
            queueableBinaryWriter.Write(this.CellWidth0);
            queueableBinaryWriter.Write(this.Velocity0);
            queueableBinaryWriter.Write(this.fieldpad3);
            queueableBinaryWriter.Write(this.Marker0);
            queueableBinaryWriter.Write(this.TextureWidth);
            queueableBinaryWriter.Write(this.fieldpad4);
            queueableBinaryWriter.Write(this.fieldpad5);
            queueableBinaryWriter.Write(this.Texture);
            queueableBinaryWriter.Write(this.fieldpad6);
            queueableBinaryWriter.WritePointer(this.Rules);
        }
        [System.FlagsAttribute()]
        public enum InterpolationFlags : int
        {
            None = 0,
            BlendInHsvblendsColorsInHsvRatherThanRgbSpace = 1,
            moreColorsblendsColorsThroughMoreHuesgoesTheLongWayAroundTheColorWheel = 2,
        }
    }
}
namespace Moonfish.Tags
{
    
    public partial struct TagClass
    {
        public static TagClass Whip = ((TagClass)("whip"));
    }
}
