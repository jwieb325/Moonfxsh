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
    
    [TagClassAttribute("PRTM")]
    public partial class ParticleModelBlock : GuerillaBlock, IWriteQueueable
    {
        public Flags ParticleModelFlags;
        public OrientationEnum Orientation;
        private byte[] fieldpad = new byte[16];
        [Moonfish.Tags.TagReferenceAttribute("shad")]
        public Moonfish.Tags.TagReference Shader;
        public ParticlePropertyScalarStructNewBlock ScaleX = new ParticlePropertyScalarStructNewBlock();
        public ParticlePropertyScalarStructNewBlock ScaleY = new ParticlePropertyScalarStructNewBlock();
        public ParticlePropertyScalarStructNewBlock ScaleZ = new ParticlePropertyScalarStructNewBlock();
        public ParticlePropertyScalarStructNewBlock Rotation = new ParticlePropertyScalarStructNewBlock();
        /// <summary>
        /// collision occurs when particle physics has collision, death spawned when particle dies
        /// </summary>
        [Moonfish.Tags.TagReferenceAttribute("null")]
        public Moonfish.Tags.TagReference CollisionEffect;
        [Moonfish.Tags.TagReferenceAttribute("null")]
        public Moonfish.Tags.TagReference DeathEffect;
        public EffectLocationsBlock[] Locations = new EffectLocationsBlock[0];
        public ParticleSystemDefinitionBlockNew[] AttachedParticleSystems = new ParticleSystemDefinitionBlockNew[0];
        public ParticleModelsBlock[] Models = new ParticleModelsBlock[0];
        public ParticleModelVerticesBlock[] RawVertices = new ParticleModelVerticesBlock[0];
        public ParticleModelIndicesBlock[] Indices = new ParticleModelIndicesBlock[0];
        public CachedDataBlock[] CachedData = new CachedDataBlock[0];
        public GlobalGeometryBlockInfoStructBlock GeometrySectionInfo = new GlobalGeometryBlockInfoStructBlock();
        private byte[] fieldpad0 = new byte[16];
        private byte[] fieldpad1 = new byte[8];
        public override int SerializedSize
        {
            get
            {
                return 220;
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
            this.ParticleModelFlags = ((Flags)(binaryReader.ReadInt32()));
            this.Orientation = ((OrientationEnum)(binaryReader.ReadInt32()));
            this.fieldpad = binaryReader.ReadBytes(16);
            this.Shader = binaryReader.ReadTagReference();
            pointerQueue = new System.Collections.Generic.Queue<Moonfish.Tags.BlamPointer>(pointerQueue.Concat(this.ScaleX.ReadFields(binaryReader)));
            pointerQueue = new System.Collections.Generic.Queue<Moonfish.Tags.BlamPointer>(pointerQueue.Concat(this.ScaleY.ReadFields(binaryReader)));
            pointerQueue = new System.Collections.Generic.Queue<Moonfish.Tags.BlamPointer>(pointerQueue.Concat(this.ScaleZ.ReadFields(binaryReader)));
            pointerQueue = new System.Collections.Generic.Queue<Moonfish.Tags.BlamPointer>(pointerQueue.Concat(this.Rotation.ReadFields(binaryReader)));
            this.CollisionEffect = binaryReader.ReadTagReference();
            this.DeathEffect = binaryReader.ReadTagReference();
            pointerQueue.Enqueue(binaryReader.ReadBlamPointer(4));
            pointerQueue.Enqueue(binaryReader.ReadBlamPointer(56));
            pointerQueue.Enqueue(binaryReader.ReadBlamPointer(8));
            pointerQueue.Enqueue(binaryReader.ReadBlamPointer(56));
            pointerQueue.Enqueue(binaryReader.ReadBlamPointer(2));
            pointerQueue.Enqueue(binaryReader.ReadBlamPointer(32));
            pointerQueue = new System.Collections.Generic.Queue<Moonfish.Tags.BlamPointer>(pointerQueue.Concat(this.GeometrySectionInfo.ReadFields(binaryReader)));
            this.fieldpad0 = binaryReader.ReadBytes(16);
            this.fieldpad1 = binaryReader.ReadBytes(8);
            return pointerQueue;
        }
        public override void ReadInstances(System.IO.BinaryReader binaryReader, System.Collections.Generic.Queue<Moonfish.Tags.BlamPointer> pointerQueue)
        {
            base.ReadInstances(binaryReader, pointerQueue);
            this.ScaleX.ReadInstances(binaryReader, pointerQueue);
            this.ScaleY.ReadInstances(binaryReader, pointerQueue);
            this.ScaleZ.ReadInstances(binaryReader, pointerQueue);
            this.Rotation.ReadInstances(binaryReader, pointerQueue);
            this.Locations = base.ReadBlockArrayData<EffectLocationsBlock>(binaryReader, pointerQueue.Dequeue());
            this.AttachedParticleSystems = base.ReadBlockArrayData<ParticleSystemDefinitionBlockNew>(binaryReader, pointerQueue.Dequeue());
            this.Models = base.ReadBlockArrayData<ParticleModelsBlock>(binaryReader, pointerQueue.Dequeue());
            this.RawVertices = base.ReadBlockArrayData<ParticleModelVerticesBlock>(binaryReader, pointerQueue.Dequeue());
            this.Indices = base.ReadBlockArrayData<ParticleModelIndicesBlock>(binaryReader, pointerQueue.Dequeue());
            this.CachedData = base.ReadBlockArrayData<CachedDataBlock>(binaryReader, pointerQueue.Dequeue());
            this.GeometrySectionInfo.ReadInstances(binaryReader, pointerQueue);
        }
        public override void QueueWrites(Moonfish.Guerilla.QueueableBinaryWriter queueableBinaryWriter)
        {
            base.QueueWrites(queueableBinaryWriter);
            this.ScaleX.QueueWrites(queueableBinaryWriter);
            this.ScaleY.QueueWrites(queueableBinaryWriter);
            this.ScaleZ.QueueWrites(queueableBinaryWriter);
            this.Rotation.QueueWrites(queueableBinaryWriter);
            queueableBinaryWriter.QueueWrite(this.Locations);
            queueableBinaryWriter.QueueWrite(this.AttachedParticleSystems);
            queueableBinaryWriter.QueueWrite(this.Models);
            queueableBinaryWriter.QueueWrite(this.RawVertices);
            queueableBinaryWriter.QueueWrite(this.Indices);
            queueableBinaryWriter.QueueWrite(this.CachedData);
            this.GeometrySectionInfo.QueueWrites(queueableBinaryWriter);
        }
        public override void Write_(Moonfish.Guerilla.QueueableBinaryWriter queueableBinaryWriter)
        {
            base.Write_(queueableBinaryWriter);
            queueableBinaryWriter.Write(((int)(this.ParticleModelFlags)));
            queueableBinaryWriter.Write(((int)(this.Orientation)));
            queueableBinaryWriter.Write(this.fieldpad);
            queueableBinaryWriter.Write(this.Shader);
            this.ScaleX.Write_(queueableBinaryWriter);
            this.ScaleY.Write_(queueableBinaryWriter);
            this.ScaleZ.Write_(queueableBinaryWriter);
            this.Rotation.Write_(queueableBinaryWriter);
            queueableBinaryWriter.Write(this.CollisionEffect);
            queueableBinaryWriter.Write(this.DeathEffect);
            queueableBinaryWriter.WritePointer(this.Locations);
            queueableBinaryWriter.WritePointer(this.AttachedParticleSystems);
            queueableBinaryWriter.WritePointer(this.Models);
            queueableBinaryWriter.WritePointer(this.RawVertices);
            queueableBinaryWriter.WritePointer(this.Indices);
            queueableBinaryWriter.WritePointer(this.CachedData);
            this.GeometrySectionInfo.Write_(queueableBinaryWriter);
            queueableBinaryWriter.Write(this.fieldpad0);
            queueableBinaryWriter.Write(this.fieldpad1);
        }
        [System.FlagsAttribute()]
        public enum Flags : int
        {
            None = 0,
            Spins = 1,
            RandomUMirror = 2,
            RandomVMirror = 4,
            FrameAnimationOneShot = 8,
            SelectRandomSequence = 16,
            DisableFrameBlending = 32,
            CanAnimateBackwards = 64,
            ReceiveLightmapLighting = 128,
            TintFromDiffuseTexture = 256,
            DiesAtRest = 512,
            DiesOnStructureCollision = 1024,
            DiesInMedia = 2048,
            DiesInAir = 4096,
            BitmapAuthoredVertically = 8192,
            HasSweetener = 16384,
        }
        public enum OrientationEnum : int
        {
            ScreenFacing = 0,
            ParallelToDirection = 1,
            PerpendicularToDirection = 2,
            Vertical = 3,
            Horizontal = 4,
        }
    }
}
namespace Moonfish.Tags
{
    
    public partial struct TagClass
    {
        public static TagClass PRTM = ((TagClass)("PRTM"));
    }
}
