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
    [TagBlockOriginalNameAttribute("inherited_animation_block")]
    public partial class InheritedAnimationBlock : GuerillaBlock, IWriteDeferrable
    {
        [Moonfish.Tags.TagReferenceAttribute("jmad")]
        public Moonfish.Tags.TagReference InheritedGraph;
        public InheritedAnimationNodeMapBlock[] NodeMap = new InheritedAnimationNodeMapBlock[0];
        public InheritedAnimationNodeMapFlagBlock[] NodeMapFlags = new InheritedAnimationNodeMapFlagBlock[0];
        public float RootZOffset;
        public int InheritanceFlags;
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
        public override System.Collections.Generic.Queue<Moonfish.Tags.BlamPointer> ReadFields(Moonfish.Guerilla.BlamBinaryReader binaryReader)
        {
            System.Collections.Generic.Queue<Moonfish.Tags.BlamPointer> pointerQueue = new System.Collections.Generic.Queue<Moonfish.Tags.BlamPointer>(base.ReadFields(binaryReader));
            this.InheritedGraph = binaryReader.ReadTagReference();
            pointerQueue.Enqueue(binaryReader.ReadBlamPointer(2));
            pointerQueue.Enqueue(binaryReader.ReadBlamPointer(4));
            this.RootZOffset = binaryReader.ReadSingle();
            this.InheritanceFlags = binaryReader.ReadInt32();
            return pointerQueue;
        }
        public override void ReadInstances(Moonfish.Guerilla.BlamBinaryReader binaryReader, System.Collections.Generic.Queue<Moonfish.Tags.BlamPointer> pointerQueue)
        {
            base.ReadInstances(binaryReader, pointerQueue);
            this.NodeMap = base.ReadBlockArrayData<InheritedAnimationNodeMapBlock>(binaryReader, pointerQueue.Dequeue());
            this.NodeMapFlags = base.ReadBlockArrayData<InheritedAnimationNodeMapFlagBlock>(binaryReader, pointerQueue.Dequeue());
        }
        public override void DeferReferences(Moonfish.Guerilla.LinearBinaryWriter writer)
        {
            base.DeferReferences(writer);
            writer.Defer(this.NodeMap);
            writer.Defer(this.NodeMapFlags);
        }
        public override void Write(Moonfish.Guerilla.LinearBinaryWriter writer)
        {
            base.Write(writer);
            writer.Write(this.InheritedGraph);
            writer.WritePointer(this.NodeMap);
            writer.WritePointer(this.NodeMapFlags);
            writer.Write(this.RootZOffset);
            writer.Write(this.InheritanceFlags);
        }
    }
}
