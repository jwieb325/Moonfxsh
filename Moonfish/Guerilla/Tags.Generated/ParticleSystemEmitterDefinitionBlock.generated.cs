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
    [TagBlockOriginalNameAttribute("particle_system_emitter_definition_block")]
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
        public override System.Collections.Generic.Queue<Moonfish.Tags.BlamPointer> ReadFields(Moonfish.Guerilla.BlamBinaryReader binaryReader)
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
        public override void ReadInstances(Moonfish.Guerilla.BlamBinaryReader binaryReader, System.Collections.Generic.Queue<Moonfish.Tags.BlamPointer> pointerQueue)
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
        public override void Defer(Moonfish.Guerilla.QueueableBlamBinaryWriter queueableBinaryWriter)
        {
            base.Defer(queueableBinaryWriter);
            this.ParticleEmissionRate.Defer(queueableBinaryWriter);
            this.ParticleLifespan.Defer(queueableBinaryWriter);
            this.ParticleVelocity.Defer(queueableBinaryWriter);
            this.ParticleAngularVelocity.Defer(queueableBinaryWriter);
            this.ParticleSize.Defer(queueableBinaryWriter);
            this.ParticleTint.Defer(queueableBinaryWriter);
            this.ParticleAlpha.Defer(queueableBinaryWriter);
            this.EmissionRadius.Defer(queueableBinaryWriter);
            this.EmissionAngle.Defer(queueableBinaryWriter);
        }
        public override void Write(Moonfish.Guerilla.QueueableBlamBinaryWriter queueableBinaryWriter)
        {
            base.Write(queueableBinaryWriter);
            queueableBinaryWriter.Write(this.ParticlePhysics);
            this.ParticleEmissionRate.Write(queueableBinaryWriter);
            this.ParticleLifespan.Write(queueableBinaryWriter);
            this.ParticleVelocity.Write(queueableBinaryWriter);
            this.ParticleAngularVelocity.Write(queueableBinaryWriter);
            this.ParticleSize.Write(queueableBinaryWriter);
            this.ParticleTint.Write(queueableBinaryWriter);
            this.ParticleAlpha.Write(queueableBinaryWriter);
            queueableBinaryWriter.Write(((int)(this.EmissionShape)));
            this.EmissionRadius.Write(queueableBinaryWriter);
            this.EmissionAngle.Write(queueableBinaryWriter);
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
