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
    
    public partial class ErrorReportsBlock : GuerillaBlock, IWriteQueueable
    {
        public TypeEnum Type;
        public Flags ErrorReportsFlags;
        public byte[] Text;
        public Moonfish.Tags.String32 SourceFilename;
        public int SourceLineNumber;
        public ErrorReportVerticesBlock[] Vertices = new ErrorReportVerticesBlock[0];
        public ErrorReportVectorsBlock[] Vectors = new ErrorReportVectorsBlock[0];
        public ErrorReportLinesBlock[] Lines = new ErrorReportLinesBlock[0];
        public ErrorReportTrianglesBlock[] Triangles = new ErrorReportTrianglesBlock[0];
        public ErrorReportQuadsBlock[] Quads = new ErrorReportQuadsBlock[0];
        public ErrorReportCommentsBlock[] Comments = new ErrorReportCommentsBlock[0];
        private byte[] fieldpad = new byte[380];
        public int ReportKey;
        public int NodeIndex;
        public Moonfish.Model.Range BoundsX;
        public Moonfish.Model.Range BoundsY;
        public Moonfish.Model.Range BoundsZ;
        public OpenTK.Vector4 Color;
        private byte[] fieldpad0 = new byte[84];
        public override int SerializedSize
        {
            get
            {
                return 608;
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
            this.Type = ((TypeEnum)(binaryReader.ReadInt16()));
            this.ErrorReportsFlags = ((Flags)(binaryReader.ReadInt16()));
            pointerQueue.Enqueue(binaryReader.ReadBlamPointer(1));
            this.SourceFilename = binaryReader.ReadString32();
            this.SourceLineNumber = binaryReader.ReadInt32();
            pointerQueue.Enqueue(binaryReader.ReadBlamPointer(52));
            pointerQueue.Enqueue(binaryReader.ReadBlamPointer(64));
            pointerQueue.Enqueue(binaryReader.ReadBlamPointer(80));
            pointerQueue.Enqueue(binaryReader.ReadBlamPointer(112));
            pointerQueue.Enqueue(binaryReader.ReadBlamPointer(144));
            pointerQueue.Enqueue(binaryReader.ReadBlamPointer(56));
            this.fieldpad = binaryReader.ReadBytes(380);
            this.ReportKey = binaryReader.ReadInt32();
            this.NodeIndex = binaryReader.ReadInt32();
            this.BoundsX = binaryReader.ReadRange();
            this.BoundsY = binaryReader.ReadRange();
            this.BoundsZ = binaryReader.ReadRange();
            this.Color = binaryReader.ReadVector4();
            this.fieldpad0 = binaryReader.ReadBytes(84);
            return pointerQueue;
        }
        public override void ReadInstances(System.IO.BinaryReader binaryReader, System.Collections.Generic.Queue<Moonfish.Tags.BlamPointer> pointerQueue)
        {
            base.ReadInstances(binaryReader, pointerQueue);
            this.Text = base.ReadDataByteArray(binaryReader, pointerQueue.Dequeue());
            this.Vertices = base.ReadBlockArrayData<ErrorReportVerticesBlock>(binaryReader, pointerQueue.Dequeue());
            this.Vectors = base.ReadBlockArrayData<ErrorReportVectorsBlock>(binaryReader, pointerQueue.Dequeue());
            this.Lines = base.ReadBlockArrayData<ErrorReportLinesBlock>(binaryReader, pointerQueue.Dequeue());
            this.Triangles = base.ReadBlockArrayData<ErrorReportTrianglesBlock>(binaryReader, pointerQueue.Dequeue());
            this.Quads = base.ReadBlockArrayData<ErrorReportQuadsBlock>(binaryReader, pointerQueue.Dequeue());
            this.Comments = base.ReadBlockArrayData<ErrorReportCommentsBlock>(binaryReader, pointerQueue.Dequeue());
        }
        public override void QueueWrites(Moonfish.Guerilla.QueueableBinaryWriter queueableBinaryWriter)
        {
            base.QueueWrites(queueableBinaryWriter);
            queueableBinaryWriter.QueueWrite(this.Text);
            queueableBinaryWriter.QueueWrite(this.Vertices);
            queueableBinaryWriter.QueueWrite(this.Vectors);
            queueableBinaryWriter.QueueWrite(this.Lines);
            queueableBinaryWriter.QueueWrite(this.Triangles);
            queueableBinaryWriter.QueueWrite(this.Quads);
            queueableBinaryWriter.QueueWrite(this.Comments);
        }
        public override void Write_(Moonfish.Guerilla.QueueableBinaryWriter queueableBinaryWriter)
        {
            base.Write_(queueableBinaryWriter);
            queueableBinaryWriter.Write(((short)(this.Type)));
            queueableBinaryWriter.Write(((short)(this.ErrorReportsFlags)));
            queueableBinaryWriter.WritePointer(this.Text);
            queueableBinaryWriter.Write(this.SourceFilename);
            queueableBinaryWriter.Write(this.SourceLineNumber);
            queueableBinaryWriter.WritePointer(this.Vertices);
            queueableBinaryWriter.WritePointer(this.Vectors);
            queueableBinaryWriter.WritePointer(this.Lines);
            queueableBinaryWriter.WritePointer(this.Triangles);
            queueableBinaryWriter.WritePointer(this.Quads);
            queueableBinaryWriter.WritePointer(this.Comments);
            queueableBinaryWriter.Write(this.fieldpad);
            queueableBinaryWriter.Write(this.ReportKey);
            queueableBinaryWriter.Write(this.NodeIndex);
            queueableBinaryWriter.Write(this.BoundsX);
            queueableBinaryWriter.Write(this.BoundsY);
            queueableBinaryWriter.Write(this.BoundsZ);
            queueableBinaryWriter.Write(this.Color);
            queueableBinaryWriter.Write(this.fieldpad0);
        }
        public enum TypeEnum : short
        {
            Silent = 0,
            Comment = 1,
            Warning = 2,
            Error = 3,
        }
        [System.FlagsAttribute()]
        public enum Flags : short
        {
            None = 0,
            Rendered = 1,
            TangentSpace = 2,
            Noncritical = 4,
            LightmapLight = 8,
            ReportKeyIsValid = 16,
        }
    }
}
