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
    [TagBlockOriginalNameAttribute("barrel_firing_effect_block")]
    public partial class BarrelFiringEffectBlock : GuerillaBlock, IWriteDeferrable
    {
        public short ShotCountLowerBound;
        public short ShotCountUpperBound;
        [Moonfish.Tags.TagReferenceAttribute("null")]
        public Moonfish.Tags.TagReference FiringEffect;
        [Moonfish.Tags.TagReferenceAttribute("null")]
        public Moonfish.Tags.TagReference MisfireEffect;
        [Moonfish.Tags.TagReferenceAttribute("null")]
        public Moonfish.Tags.TagReference EmptyEffect;
        [Moonfish.Tags.TagReferenceAttribute("jpt!")]
        public Moonfish.Tags.TagReference FiringDamage;
        [Moonfish.Tags.TagReferenceAttribute("jpt!")]
        public Moonfish.Tags.TagReference MisfireDamage;
        [Moonfish.Tags.TagReferenceAttribute("jpt!")]
        public Moonfish.Tags.TagReference EmptyDamage;
        public override int SerializedSize
        {
            get
            {
                return 52;
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
            this.ShotCountLowerBound = binaryReader.ReadInt16();
            this.ShotCountUpperBound = binaryReader.ReadInt16();
            this.FiringEffect = binaryReader.ReadTagReference();
            this.MisfireEffect = binaryReader.ReadTagReference();
            this.EmptyEffect = binaryReader.ReadTagReference();
            this.FiringDamage = binaryReader.ReadTagReference();
            this.MisfireDamage = binaryReader.ReadTagReference();
            this.EmptyDamage = binaryReader.ReadTagReference();
            return pointerQueue;
        }
        public override void ReadInstances(Moonfish.Guerilla.BlamBinaryReader binaryReader, System.Collections.Generic.Queue<Moonfish.Tags.BlamPointer> pointerQueue)
        {
            base.ReadInstances(binaryReader, pointerQueue);
        }
        public override void DeferReferences(Moonfish.Guerilla.LinearBinaryWriter writer)
        {
            base.DeferReferences(writer);
        }
        public override void Write(Moonfish.Guerilla.LinearBinaryWriter writer)
        {
            base.Write(writer);
            writer.Write(this.ShotCountLowerBound);
            writer.Write(this.ShotCountUpperBound);
            writer.Write(this.FiringEffect);
            writer.Write(this.MisfireEffect);
            writer.Write(this.EmptyEffect);
            writer.Write(this.FiringDamage);
            writer.Write(this.MisfireDamage);
            writer.Write(this.EmptyDamage);
        }
    }
}
