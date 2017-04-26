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
    [TagBlockOriginalNameAttribute("render_model_section_data_block")]
    public partial class RenderModelSectionDataBlock : GuerillaBlock, IWriteDeferrable
    {
        public GlobalGeometrySectionStructBlock Section = new GlobalGeometrySectionStructBlock();
        public GlobalGeometryPointDataStructBlock PointData = new GlobalGeometryPointDataStructBlock();
        public RenderModelNodeMapBlock[] NodeMap = new RenderModelNodeMapBlock[0];
        private byte[] fieldpad = new byte[4];
        public override int SerializedSize
        {
            get
            {
                return 112;
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
            pointerQueue = new System.Collections.Generic.Queue<Moonfish.Tags.BlamPointer>(pointerQueue.Concat(this.Section.ReadFields(binaryReader)));
            pointerQueue = new System.Collections.Generic.Queue<Moonfish.Tags.BlamPointer>(pointerQueue.Concat(this.PointData.ReadFields(binaryReader)));
            pointerQueue.Enqueue(binaryReader.ReadBlamPointer(1));
            this.fieldpad = binaryReader.ReadBytes(4);
            return pointerQueue;
        }
        public override void ReadInstances(Moonfish.Guerilla.BlamBinaryReader binaryReader, System.Collections.Generic.Queue<Moonfish.Tags.BlamPointer> pointerQueue)
        {
            base.ReadInstances(binaryReader, pointerQueue);
            this.Section.ReadInstances(binaryReader, pointerQueue);
            this.PointData.ReadInstances(binaryReader, pointerQueue);
            this.NodeMap = base.ReadBlockArrayData<RenderModelNodeMapBlock>(binaryReader, pointerQueue.Dequeue());
        }
        public override void DeferReferences(Moonfish.Guerilla.LinearBinaryWriter writer)
        {
            base.DeferReferences(writer);
            this.Section.DeferReferences(writer);
            this.Section.DeferReferences(writer);
            this.PointData.DeferReferences(writer);
            this.PointData.DeferReferences(writer);
            writer.Defer(this.NodeMap);
        }
        public override void Write(Moonfish.Guerilla.LinearBinaryWriter writer)
        {
            base.Write(writer);
            this.Section.Write(writer);
            this.PointData.Write(writer);
            writer.WritePointer(this.NodeMap);
            writer.Write(this.fieldpad);
        }
    }
}
