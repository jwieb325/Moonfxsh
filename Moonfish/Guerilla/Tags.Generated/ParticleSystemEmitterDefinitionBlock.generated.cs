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
    [TagBlockOriginalNameAttribute("particle_system_emitter_definition_block")]
    public partial class ParticleSystemEmitterDefinitionBlock : GuerillaBlock, IWriteDeferrable
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
        public override void DeferReferences(Moonfish.Guerilla.LinearBinaryWriter writer)
        {
            base.DeferReferences(writer);
            this.ParticleEmissionRate.DeferReferences(writer);
            this.ParticleEmissionRate.DeferReferences(writer);
            this.ParticleLifespan.DeferReferences(writer);
            this.ParticleLifespan.DeferReferences(writer);
            this.ParticleVelocity.DeferReferences(writer);
            this.ParticleVelocity.DeferReferences(writer);
            this.ParticleAngularVelocity.DeferReferences(writer);
            this.ParticleAngularVelocity.DeferReferences(writer);
            this.ParticleSize.DeferReferences(writer);
            this.ParticleSize.DeferReferences(writer);
            this.ParticleTint.DeferReferences(writer);
            this.ParticleTint.DeferReferences(writer);
            this.ParticleAlpha.DeferReferences(writer);
            this.ParticleAlpha.DeferReferences(writer);
            this.EmissionRadius.DeferReferences(writer);
            this.EmissionRadius.DeferReferences(writer);
            this.EmissionAngle.DeferReferences(writer);
            this.EmissionAngle.DeferReferences(writer);
        }
        public override void Write(Moonfish.Guerilla.LinearBinaryWriter writer)
        {
            base.Write(writer);
            writer.Write(this.ParticlePhysics);
            this.ParticleEmissionRate.Write(writer);
            this.ParticleLifespan.Write(writer);
            this.ParticleVelocity.Write(writer);
            this.ParticleAngularVelocity.Write(writer);
            this.ParticleSize.Write(writer);
            this.ParticleTint.Write(writer);
            this.ParticleAlpha.Write(writer);
            writer.Write(((int)(this.EmissionShape)));
            this.EmissionRadius.Write(writer);
            this.EmissionAngle.Write(writer);
            writer.Write(this.TranslationalOffset);
            writer.Write(this.RelativeDirection);
            writer.Write(this.fieldpad);
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
