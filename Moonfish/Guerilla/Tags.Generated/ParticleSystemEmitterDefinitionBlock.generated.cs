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
    
    public partial class ParticleSystemEmitterDefinitionBlock : GuerillaBlock, IWriteQueueable
    {
        [Moonfish.Tags.TagReferenceAttribute("pmov")]
        public Moonfish.Tags.TagReference ParticlePhysics;
        public ParticlePropertyScalarStructNewBlock ParticleEmissionRate = new ParticlePropertyScalarStructNewBlock();
        public ParticlePropertyScalarStructNewBlock ParticleLifespan = new ParticlePropertyScalarStructNewBlock();
        public ParticlePropertyScalarStructNewBlock ParticleVelocity = new ParticlePropertyScalarStructNewBlock();
        public ParticlePropertyScalarStructNewBlock ParticleAngularVelocity = new ParticlePropertyScalarStructNewBlock();
        public ParticlePropertyScalarStructNewBlock ParticleSize = new ParticlePropertyScalarStructNewBlock();
        public ParticlePropertyColorStructNewBlock ParticleTint = new ParticlePropertyColorStructNewBlock();
        public ParticlePropertyScalarStructNewBlock ParticleAlpha = new ParticlePropertyScalarStructNewBlock();
        public EmissionShapeEnum EmissionShape;
        public ParticlePropertyScalarStructNewBlock EmissionRadius = new ParticlePropertyScalarStructNewBlock();
        public ParticlePropertyScalarStructNewBlock EmissionAngle = new ParticlePropertyScalarStructNewBlock();
        public OpenTK.Vector3 TranslationalOffset;
        public OpenTK.Vector2 RelativeDirection;
        private byte[] fieldpad = new byte[8];
        public override int SerializedSize
        {
            get
            {
                return 184;
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
            this.ParticlePhysics = binaryReader.ReadTagReference();
            pointerQueue = new System.Collections.Generic.Queue<Moonfish.Tags.BlamPointer>(pointerQueue.Concat(this.ParticleEmissionRate.ReadFields(binaryReader)));
            pointerQueue = new System.Collections.Generic.Queue<Moonfish.Tags.BlamPointer>(pointerQueue.Concat(this.ParticleLifespan.ReadFields(binaryReader)));
            pointerQueue = new System.Collections.Generic.Queue<Moonfish.Tags.BlamPointer>(pointerQueue.Concat(this.ParticleVelocity.ReadFields(binaryReader)));
            pointerQueue = new System.Collections.Generic.Queue<Moonfish.Tags.BlamPointer>(pointerQueue.Concat(this.ParticleAngularVelocity.ReadFields(binaryReader)));
            pointerQueue = new System.Collections.Generic.Queue<Moonfish.Tags.BlamPointer>(pointerQueue.Concat(this.ParticleSize.ReadFields(binaryReader)));
            pointerQueue = new System.Collections.Generic.Queue<Moonfish.Tags.BlamPointer>(pointerQueue.Concat(this.ParticleTint.ReadFields(binaryReader)));
            pointerQueue = new System.Collections.Generic.Queue<Moonfish.Tags.BlamPointer>(pointerQueue.Concat(this.ParticleAlpha.ReadFields(binaryReader)));
            this.EmissionShape = ((EmissionShapeEnum)(binaryReader.ReadInt32()));
            pointerQueue = new System.Collections.Generic.Queue<Moonfish.Tags.BlamPointer>(pointerQueue.Concat(this.EmissionRadius.ReadFields(binaryReader)));
            pointerQueue = new System.Collections.Generic.Queue<Moonfish.Tags.BlamPointer>(pointerQueue.Concat(this.EmissionAngle.ReadFields(binaryReader)));
            this.TranslationalOffset = binaryReader.ReadVector3();
            this.RelativeDirection = binaryReader.ReadVector2();
            this.fieldpad = binaryReader.ReadBytes(8);
            return pointerQueue;
        }
        public override void ReadInstances(System.IO.BinaryReader binaryReader, System.Collections.Generic.Queue<Moonfish.Tags.BlamPointer> pointerQueue)
        {
            base.ReadInstances(binaryReader, pointerQueue);
            this.ParticleEmissionRate.ReadInstances(binaryReader, pointerQueue);
            this.ParticleLifespan.ReadInstances(binaryReader, pointerQueue);
            this.ParticleVelocity.ReadInstances(binaryReader, pointerQueue);
            this.ParticleAngularVelocity.ReadInstances(binaryReader, pointerQueue);
            this.ParticleSize.ReadInstances(binaryReader, pointerQueue);
            this.ParticleTint.ReadInstances(binaryReader, pointerQueue);
            this.ParticleAlpha.ReadInstances(binaryReader, pointerQueue);
            this.EmissionRadius.ReadInstances(binaryReader, pointerQueue);
            this.EmissionAngle.ReadInstances(binaryReader, pointerQueue);
        }
        public override void QueueWrites(Moonfish.Guerilla.QueueableBinaryWriter queueableBinaryWriter)
        {
            base.QueueWrites(queueableBinaryWriter);
            this.ParticleEmissionRate.QueueWrites(queueableBinaryWriter);
            this.ParticleLifespan.QueueWrites(queueableBinaryWriter);
            this.ParticleVelocity.QueueWrites(queueableBinaryWriter);
            this.ParticleAngularVelocity.QueueWrites(queueableBinaryWriter);
            this.ParticleSize.QueueWrites(queueableBinaryWriter);
            this.ParticleTint.QueueWrites(queueableBinaryWriter);
            this.ParticleAlpha.QueueWrites(queueableBinaryWriter);
            this.EmissionRadius.QueueWrites(queueableBinaryWriter);
            this.EmissionAngle.QueueWrites(queueableBinaryWriter);
        }
        public override void Write_(Moonfish.Guerilla.QueueableBinaryWriter queueableBinaryWriter)
        {
            base.Write_(queueableBinaryWriter);
            queueableBinaryWriter.Write(this.ParticlePhysics);
            this.ParticleEmissionRate.Write_(queueableBinaryWriter);
            this.ParticleLifespan.Write_(queueableBinaryWriter);
            this.ParticleVelocity.Write_(queueableBinaryWriter);
            this.ParticleAngularVelocity.Write_(queueableBinaryWriter);
            this.ParticleSize.Write_(queueableBinaryWriter);
            this.ParticleTint.Write_(queueableBinaryWriter);
            this.ParticleAlpha.Write_(queueableBinaryWriter);
            queueableBinaryWriter.Write(((int)(this.EmissionShape)));
            this.EmissionRadius.Write_(queueableBinaryWriter);
            this.EmissionAngle.Write_(queueableBinaryWriter);
            queueableBinaryWriter.Write(this.TranslationalOffset);
            queueableBinaryWriter.Write(this.RelativeDirection);
            queueableBinaryWriter.Write(this.fieldpad);
        }
        public enum EmissionShapeEnum : int
        {
            Sprayer = 0,
            Disc = 1,
            Globe = 2,
            Implode = 3,
            Tube = 4,
            Halo = 5,
            ImpactContour = 6,
            ImpactArea = 7,
            Debris = 8,
            Line = 9,
        }
    }
}