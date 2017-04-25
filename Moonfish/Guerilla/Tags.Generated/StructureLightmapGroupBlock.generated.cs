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
    [TagBlockOriginalNameAttribute("structure_lightmap_group_block")]
    public partial class StructureLightmapGroupBlock : GuerillaBlock, IWriteQueueable
    {
        public TypeEnum Type;
        public Flags StructureLightmapGroupFlags;
        public int StructureChecksum;
        public StructureLightmapPaletteColorBlock[] SectionPalette = new StructureLightmapPaletteColorBlock[0];
        public StructureLightmapPaletteColorBlock[] WritablePalettes = new StructureLightmapPaletteColorBlock[0];
        [Moonfish.Tags.TagReferenceAttribute("bitm")]
        public Moonfish.Tags.TagReference BitmapGroup;
        public LightmapGeometrySectionBlock[] Clusters = new LightmapGeometrySectionBlock[0];
        public LightmapGeometryRenderInfoBlock[] ClusterRenderInfo = new LightmapGeometryRenderInfoBlock[0];
        public LightmapGeometrySectionBlock[] PoopDefinitions = new LightmapGeometrySectionBlock[0];
        public StructureLightmapLightingEnvironmentBlock[] LightingEnvironments = new StructureLightmapLightingEnvironmentBlock[0];
        public LightmapVertexBufferBucketBlock[] GeometryBuckets = new LightmapVertexBufferBucketBlock[0];
        public LightmapGeometryRenderInfoBlock[] InstanceRenderInfo = new LightmapGeometryRenderInfoBlock[0];
        public LightmapInstanceBucketReferenceBlock[] InstanceBucketRefs = new LightmapInstanceBucketReferenceBlock[0];
        public LightmapSceneryObjectInfoBlock[] SceneryObjectInfo = new LightmapSceneryObjectInfoBlock[0];
        public LightmapInstanceBucketReferenceBlock[] SceneryObjectBucketRefs = new LightmapInstanceBucketReferenceBlock[0];
        public override int SerializedSize
        {
            get
            {
                return 104;
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
            this.Type = ((TypeEnum)(binaryReader.ReadInt16()));
            this.StructureLightmapGroupFlags = ((Flags)(binaryReader.ReadInt16()));
            this.StructureChecksum = binaryReader.ReadInt32();
            pointerQueue.Enqueue(binaryReader.ReadBlamPointer(1024));
            pointerQueue.Enqueue(binaryReader.ReadBlamPointer(1024));
            this.BitmapGroup = binaryReader.ReadTagReference();
            pointerQueue.Enqueue(binaryReader.ReadBlamPointer(84));
            pointerQueue.Enqueue(binaryReader.ReadBlamPointer(4));
            pointerQueue.Enqueue(binaryReader.ReadBlamPointer(84));
            pointerQueue.Enqueue(binaryReader.ReadBlamPointer(220));
            pointerQueue.Enqueue(binaryReader.ReadBlamPointer(56));
            pointerQueue.Enqueue(binaryReader.ReadBlamPointer(4));
            pointerQueue.Enqueue(binaryReader.ReadBlamPointer(12));
            pointerQueue.Enqueue(binaryReader.ReadBlamPointer(12));
            pointerQueue.Enqueue(binaryReader.ReadBlamPointer(12));
            return pointerQueue;
        }
        public override void ReadInstances(Moonfish.Guerilla.BlamBinaryReader binaryReader, System.Collections.Generic.Queue<Moonfish.Tags.BlamPointer> pointerQueue)
        {
            base.ReadInstances(binaryReader, pointerQueue);
            this.SectionPalette = base.ReadBlockArrayData<StructureLightmapPaletteColorBlock>(binaryReader, pointerQueue.Dequeue());
            this.WritablePalettes = base.ReadBlockArrayData<StructureLightmapPaletteColorBlock>(binaryReader, pointerQueue.Dequeue());
            this.Clusters = base.ReadBlockArrayData<LightmapGeometrySectionBlock>(binaryReader, pointerQueue.Dequeue());
            this.ClusterRenderInfo = base.ReadBlockArrayData<LightmapGeometryRenderInfoBlock>(binaryReader, pointerQueue.Dequeue());
            this.PoopDefinitions = base.ReadBlockArrayData<LightmapGeometrySectionBlock>(binaryReader, pointerQueue.Dequeue());
            this.LightingEnvironments = base.ReadBlockArrayData<StructureLightmapLightingEnvironmentBlock>(binaryReader, pointerQueue.Dequeue());
            this.GeometryBuckets = base.ReadBlockArrayData<LightmapVertexBufferBucketBlock>(binaryReader, pointerQueue.Dequeue());
            this.InstanceRenderInfo = base.ReadBlockArrayData<LightmapGeometryRenderInfoBlock>(binaryReader, pointerQueue.Dequeue());
            this.InstanceBucketRefs = base.ReadBlockArrayData<LightmapInstanceBucketReferenceBlock>(binaryReader, pointerQueue.Dequeue());
            this.SceneryObjectInfo = base.ReadBlockArrayData<LightmapSceneryObjectInfoBlock>(binaryReader, pointerQueue.Dequeue());
            this.SceneryObjectBucketRefs = base.ReadBlockArrayData<LightmapInstanceBucketReferenceBlock>(binaryReader, pointerQueue.Dequeue());
        }
        public override void Defer(Moonfish.Guerilla.QueueableBlamBinaryWriter queueableBinaryWriter)
        {
            base.Defer(queueableBinaryWriter);
            queueableBinaryWriter.Defer(this.SectionPalette);
            queueableBinaryWriter.Defer(this.WritablePalettes);
            queueableBinaryWriter.Defer(this.Clusters);
            queueableBinaryWriter.Defer(this.ClusterRenderInfo);
            queueableBinaryWriter.Defer(this.PoopDefinitions);
            queueableBinaryWriter.Defer(this.LightingEnvironments);
            queueableBinaryWriter.Defer(this.GeometryBuckets);
            queueableBinaryWriter.Defer(this.InstanceRenderInfo);
            queueableBinaryWriter.Defer(this.InstanceBucketRefs);
            queueableBinaryWriter.Defer(this.SceneryObjectInfo);
            queueableBinaryWriter.Defer(this.SceneryObjectBucketRefs);
        }
        public override void Write(Moonfish.Guerilla.QueueableBlamBinaryWriter queueableBinaryWriter)
        {
            base.Write(queueableBinaryWriter);
            queueableBinaryWriter.Write(((short)(this.Type)));
            queueableBinaryWriter.Write(((short)(this.StructureLightmapGroupFlags)));
            queueableBinaryWriter.Write(this.StructureChecksum);
            queueableBinaryWriter.WritePointer(this.SectionPalette);
            queueableBinaryWriter.WritePointer(this.WritablePalettes);
            queueableBinaryWriter.Write(this.BitmapGroup);
            queueableBinaryWriter.WritePointer(this.Clusters);
            queueableBinaryWriter.WritePointer(this.ClusterRenderInfo);
            queueableBinaryWriter.WritePointer(this.PoopDefinitions);
            queueableBinaryWriter.WritePointer(this.LightingEnvironments);
            queueableBinaryWriter.WritePointer(this.GeometryBuckets);
            queueableBinaryWriter.WritePointer(this.InstanceRenderInfo);
            queueableBinaryWriter.WritePointer(this.InstanceBucketRefs);
            queueableBinaryWriter.WritePointer(this.SceneryObjectInfo);
            queueableBinaryWriter.WritePointer(this.SceneryObjectBucketRefs);
        }
        public enum TypeEnum : short
        {
            Normal = 0,
        }
        [System.FlagsAttribute()]
        public enum Flags : short
        {
            None = 0,
            Unused = 1,
        }
    }
}
