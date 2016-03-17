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
    
    [TagClassAttribute("bsdt")]
    public partial class BreakableSurfaceBlock : GuerillaBlock, IWriteQueueable
    {
        public float MaximumVitality;
        [Moonfish.Tags.TagReferenceAttribute("effe")]
        public Moonfish.Tags.TagReference Effect;
        [Moonfish.Tags.TagReferenceAttribute("snd!")]
        public Moonfish.Tags.TagReference Sound;
        public ParticleSystemDefinitionBlockNew[] ParticleEffects = new ParticleSystemDefinitionBlockNew[0];
        public float ParticleDensity;
        public override int SerializedSize
        {
            get
            {
                return 32;
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
            this.MaximumVitality = binaryReader.ReadSingle();
            this.Effect = binaryReader.ReadTagReference();
            this.Sound = binaryReader.ReadTagReference();
            pointerQueue.Enqueue(binaryReader.ReadBlamPointer(56));
            this.ParticleDensity = binaryReader.ReadSingle();
            return pointerQueue;
        }
        public override void ReadInstances(System.IO.BinaryReader binaryReader, System.Collections.Generic.Queue<Moonfish.Tags.BlamPointer> pointerQueue)
        {
            base.ReadInstances(binaryReader, pointerQueue);
            this.ParticleEffects = base.ReadBlockArrayData<ParticleSystemDefinitionBlockNew>(binaryReader, pointerQueue.Dequeue());
        }
        public override void QueueWrites(Moonfish.Guerilla.QueueableBinaryWriter queueableBinaryWriter)
        {
            base.QueueWrites(queueableBinaryWriter);
            queueableBinaryWriter.QueueWrite(this.ParticleEffects);
        }
        public override void Write_(Moonfish.Guerilla.QueueableBinaryWriter queueableBinaryWriter)
        {
            base.Write_(queueableBinaryWriter);
            queueableBinaryWriter.Write(this.MaximumVitality);
            queueableBinaryWriter.Write(this.Effect);
            queueableBinaryWriter.Write(this.Sound);
            queueableBinaryWriter.WritePointer(this.ParticleEffects);
            queueableBinaryWriter.Write(this.ParticleDensity);
        }
    }
}
namespace Moonfish.Tags
{
    
    public partial struct TagClass
    {
        public static TagClass Bsdt = ((TagClass)("bsdt"));
    }
}