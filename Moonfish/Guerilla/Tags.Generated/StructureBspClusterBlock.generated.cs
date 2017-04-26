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
    [TagBlockOriginalNameAttribute("structure_bsp_cluster_block")]
    public partial class StructureBspClusterBlock : GuerillaBlock, IWriteDeferrable
    {
        public GlobalGeometrySectionInfoStructBlock SectionInfo = new GlobalGeometrySectionInfoStructBlock();
        public GlobalGeometryBlockInfoStructBlock GeometryBlockInfo = new GlobalGeometryBlockInfoStructBlock();
        public StructureBspClusterDataBlockNew[] ClusterData = new StructureBspClusterDataBlockNew[0];
        /// <summary>
        /// EMPTY STRING
        /// </summary>
        public Moonfish.Model.Range BoundsX;
        public Moonfish.Model.Range BoundsY;
        public Moonfish.Model.Range BoundsZ;
        public byte ScenarioSkyIndex;
        public byte MediaIndex;
        public byte ScenarioVisibleSkyIndex;
        public byte ScenarioAtmosphericFogIndex;
        public byte PlanarFogDesignator;
        public byte VisibleFogPlaneIndex;
        public Moonfish.Tags.ShortBlockIndex1 BackgroundSound;
        public Moonfish.Tags.ShortBlockIndex1 SoundEnvironment;
        public Moonfish.Tags.ShortBlockIndex1 Weather;
        public short TransitionStructureBSP;
        private byte[] fieldpad = new byte[2];
        private byte[] fieldpad0 = new byte[4];
        public Flags StructureBspClusterFlags;
        private byte[] fieldpad1 = new byte[2];
        public PredictedResourceBlock[] PredictedResources = new PredictedResourceBlock[0];
        public StructureBspClusterPortalIndexBlock[] Portals = new StructureBspClusterPortalIndexBlock[0];
        public int ChecksumFromStructure;
        public StructureBspClusterInstancedGeometryIndexBlock[] InstancedGeometryIndices = new StructureBspClusterInstancedGeometryIndexBlock[0];
        public GlobalGeometrySectionStripIndexBlock[] IndexReorderTable = new GlobalGeometrySectionStripIndexBlock[0];
        [Moonfish.Guerilla.LayoutAttribute(Pack=16)]
        private byte[] CollisionMoppCode;
        public override int SerializedSize
        {
            get
            {
                return 176;
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
            pointerQueue = new System.Collections.Generic.Queue<Moonfish.Tags.BlamPointer>(pointerQueue.Concat(this.SectionInfo.ReadFields(binaryReader)));
            pointerQueue = new System.Collections.Generic.Queue<Moonfish.Tags.BlamPointer>(pointerQueue.Concat(this.GeometryBlockInfo.ReadFields(binaryReader)));
            pointerQueue.Enqueue(binaryReader.ReadBlamPointer(68));
            this.BoundsX = binaryReader.ReadRange();
            this.BoundsY = binaryReader.ReadRange();
            this.BoundsZ = binaryReader.ReadRange();
            this.ScenarioSkyIndex = binaryReader.ReadByte();
            this.MediaIndex = binaryReader.ReadByte();
            this.ScenarioVisibleSkyIndex = binaryReader.ReadByte();
            this.ScenarioAtmosphericFogIndex = binaryReader.ReadByte();
            this.PlanarFogDesignator = binaryReader.ReadByte();
            this.VisibleFogPlaneIndex = binaryReader.ReadByte();
            this.BackgroundSound = binaryReader.ReadShortBlockIndex1();
            this.SoundEnvironment = binaryReader.ReadShortBlockIndex1();
            this.Weather = binaryReader.ReadShortBlockIndex1();
            this.TransitionStructureBSP = binaryReader.ReadInt16();
            this.fieldpad = binaryReader.ReadBytes(2);
            this.fieldpad0 = binaryReader.ReadBytes(4);
            this.StructureBspClusterFlags = ((Flags)(binaryReader.ReadInt16()));
            this.fieldpad1 = binaryReader.ReadBytes(2);
            pointerQueue.Enqueue(binaryReader.ReadBlamPointer(8));
            pointerQueue.Enqueue(binaryReader.ReadBlamPointer(2));
            this.ChecksumFromStructure = binaryReader.ReadInt32();
            pointerQueue.Enqueue(binaryReader.ReadBlamPointer(2));
            pointerQueue.Enqueue(binaryReader.ReadBlamPointer(2));
            pointerQueue.Enqueue(binaryReader.ReadBlamPointer(1));
            return pointerQueue;
        }
        public override void ReadInstances(Moonfish.Guerilla.BlamBinaryReader binaryReader, System.Collections.Generic.Queue<Moonfish.Tags.BlamPointer> pointerQueue)
        {
            base.ReadInstances(binaryReader, pointerQueue);
            this.SectionInfo.ReadInstances(binaryReader, pointerQueue);
            this.GeometryBlockInfo.ReadInstances(binaryReader, pointerQueue);
            this.ClusterData = base.ReadBlockArrayData<StructureBspClusterDataBlockNew>(binaryReader, pointerQueue.Dequeue());
            this.PredictedResources = base.ReadBlockArrayData<PredictedResourceBlock>(binaryReader, pointerQueue.Dequeue());
            this.Portals = base.ReadBlockArrayData<StructureBspClusterPortalIndexBlock>(binaryReader, pointerQueue.Dequeue());
            this.InstancedGeometryIndices = base.ReadBlockArrayData<StructureBspClusterInstancedGeometryIndexBlock>(binaryReader, pointerQueue.Dequeue());
            this.IndexReorderTable = base.ReadBlockArrayData<GlobalGeometrySectionStripIndexBlock>(binaryReader, pointerQueue.Dequeue());
            this.CollisionMoppCode = base.ReadDataByteArray(binaryReader, pointerQueue.Dequeue());
        }
        public override void DeferReferences(Moonfish.Guerilla.LinearBinaryWriter writer)
        {
            base.DeferReferences(writer);
            this.SectionInfo.DeferReferences(writer);
            this.SectionInfo.DeferReferences(writer);
            this.GeometryBlockInfo.DeferReferences(writer);
            this.GeometryBlockInfo.DeferReferences(writer);
            writer.Defer(this.ClusterData);
            writer.Defer(this.PredictedResources);
            writer.Defer(this.Portals);
            writer.Defer(this.InstancedGeometryIndices);
            writer.Defer(this.IndexReorderTable);
            writer.Defer(this.CollisionMoppCode, 16);
        }
        public override void Write(Moonfish.Guerilla.LinearBinaryWriter writer)
        {
            base.Write(writer);
            this.SectionInfo.Write(writer);
            this.GeometryBlockInfo.Write(writer);
            writer.WritePointer(this.ClusterData);
            writer.Write(this.BoundsX);
            writer.Write(this.BoundsY);
            writer.Write(this.BoundsZ);
            writer.Write(this.ScenarioSkyIndex);
            writer.Write(this.MediaIndex);
            writer.Write(this.ScenarioVisibleSkyIndex);
            writer.Write(this.ScenarioAtmosphericFogIndex);
            writer.Write(this.PlanarFogDesignator);
            writer.Write(this.VisibleFogPlaneIndex);
            writer.Write(this.BackgroundSound);
            writer.Write(this.SoundEnvironment);
            writer.Write(this.Weather);
            writer.Write(this.TransitionStructureBSP);
            writer.Write(this.fieldpad);
            writer.Write(this.fieldpad0);
            writer.Write(((short)(this.StructureBspClusterFlags)));
            writer.Write(this.fieldpad1);
            writer.WritePointer(this.PredictedResources);
            writer.WritePointer(this.Portals);
            writer.Write(this.ChecksumFromStructure);
            writer.WritePointer(this.InstancedGeometryIndices);
            writer.WritePointer(this.IndexReorderTable);
            writer.WritePointer(this.CollisionMoppCode);
        }
        [System.FlagsAttribute()]
        public enum Flags : short
        {
            None = 0,
            OneWayPortal = 1,
            DoorPortal = 2,
            PostprocessedGeometry = 4,
            IsTheSky = 8,
        }
    }
}
