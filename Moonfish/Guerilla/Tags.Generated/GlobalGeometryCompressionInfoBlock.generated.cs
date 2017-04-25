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
    [TagBlockOriginalNameAttribute("global_geometry_compression_info_block")]
    public partial class GlobalGeometryCompressionInfoBlock : GuerillaBlock, IWriteQueueable
    {
        public Moonfish.Model.Range PositionBoundsX;
        public Moonfish.Model.Range PositionBoundsY;
        public Moonfish.Model.Range PositionBoundsZ;
        public Moonfish.Model.Range TexcoordBoundsX;
        public Moonfish.Model.Range TexcoordBoundsY;
        public Moonfish.Model.Range SecondaryTexcoordBoundsX;
        public Moonfish.Model.Range SecondaryTexcoordBoundsY;
        public override int SerializedSize
        {
            get
            {
                return 56;
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
            this.PositionBoundsX = binaryReader.ReadRange();
            this.PositionBoundsY = binaryReader.ReadRange();
            this.PositionBoundsZ = binaryReader.ReadRange();
            this.TexcoordBoundsX = binaryReader.ReadRange();
            this.TexcoordBoundsY = binaryReader.ReadRange();
            this.SecondaryTexcoordBoundsX = binaryReader.ReadRange();
            this.SecondaryTexcoordBoundsY = binaryReader.ReadRange();
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
            queueableBinaryWriter.Write(this.PositionBoundsX);
            queueableBinaryWriter.Write(this.PositionBoundsY);
            queueableBinaryWriter.Write(this.PositionBoundsZ);
            queueableBinaryWriter.Write(this.TexcoordBoundsX);
            queueableBinaryWriter.Write(this.TexcoordBoundsY);
            queueableBinaryWriter.Write(this.SecondaryTexcoordBoundsX);
            queueableBinaryWriter.Write(this.SecondaryTexcoordBoundsY);
        }
    }
}
