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
    [TagClassAttribute("jmad")]
    [TagBlockOriginalNameAttribute("model_animation_graph_block")]
    public partial class ModelAnimationGraphBlock : GuerillaBlock, IWriteDeferrable
    {
        public AnimationGraphResourcesStructBlock Resources = new AnimationGraphResourcesStructBlock();
        public AnimationGraphContentsStructBlock Content = new AnimationGraphContentsStructBlock();
        public ModelAnimationRuntimeDataStructBlock RunTimeData = new ModelAnimationRuntimeDataStructBlock();
        private byte[] LastImportResults;
        public AdditionalNodeDataBlock[] AdditionalNodeData = new AdditionalNodeDataBlock[0];
        public MoonfishXboxAnimationRawBlock[] XboxAnimationDataBlock = new MoonfishXboxAnimationRawBlock[0];
        public MoonfishXboxAnimationUnknownBlock[] XboxUnknownAnimationBlock = new MoonfishXboxAnimationUnknownBlock[0];
        public override int SerializedSize
        {
            get
            {
                return 188;
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
            pointerQueue = new System.Collections.Generic.Queue<Moonfish.Tags.BlamPointer>(pointerQueue.Concat(this.Resources.ReadFields(binaryReader)));
            pointerQueue = new System.Collections.Generic.Queue<Moonfish.Tags.BlamPointer>(pointerQueue.Concat(this.Content.ReadFields(binaryReader)));
            pointerQueue = new System.Collections.Generic.Queue<Moonfish.Tags.BlamPointer>(pointerQueue.Concat(this.RunTimeData.ReadFields(binaryReader)));
            pointerQueue.Enqueue(binaryReader.ReadBlamPointer(1));
            pointerQueue.Enqueue(binaryReader.ReadBlamPointer(60));
            pointerQueue.Enqueue(binaryReader.ReadBlamPointer(20));
            pointerQueue.Enqueue(binaryReader.ReadBlamPointer(24));
            return pointerQueue;
        }
        public override void ReadInstances(Moonfish.Guerilla.BlamBinaryReader binaryReader, System.Collections.Generic.Queue<Moonfish.Tags.BlamPointer> pointerQueue)
        {
            base.ReadInstances(binaryReader, pointerQueue);
            this.Resources.ReadInstances(binaryReader, pointerQueue);
            this.Content.ReadInstances(binaryReader, pointerQueue);
            this.RunTimeData.ReadInstances(binaryReader, pointerQueue);
            this.LastImportResults = base.ReadDataByteArray(binaryReader, pointerQueue.Dequeue());
            this.AdditionalNodeData = base.ReadBlockArrayData<AdditionalNodeDataBlock>(binaryReader, pointerQueue.Dequeue());
            this.XboxAnimationDataBlock = base.ReadBlockArrayData<MoonfishXboxAnimationRawBlock>(binaryReader, pointerQueue.Dequeue());
            this.XboxUnknownAnimationBlock = base.ReadBlockArrayData<MoonfishXboxAnimationUnknownBlock>(binaryReader, pointerQueue.Dequeue());
        }
        public override void DeferReferences(Moonfish.Guerilla.LinearBinaryWriter writer)
        {
            base.DeferReferences(writer);
            this.Resources.DeferReferences(writer);
            this.Resources.DeferReferences(writer);
            this.Content.DeferReferences(writer);
            this.Content.DeferReferences(writer);
            this.RunTimeData.DeferReferences(writer);
            this.RunTimeData.DeferReferences(writer);
            writer.Defer(this.LastImportResults);
            writer.Defer(this.AdditionalNodeData);
            writer.Defer(this.XboxAnimationDataBlock);
            writer.Defer(this.XboxUnknownAnimationBlock);
        }
        public override void Write(Moonfish.Guerilla.LinearBinaryWriter writer)
        {
            base.Write(writer);
            this.Resources.Write(writer);
            this.Content.Write(writer);
            this.RunTimeData.Write(writer);
            writer.WritePointer(this.LastImportResults);
            writer.WritePointer(this.AdditionalNodeData);
            writer.WritePointer(this.XboxAnimationDataBlock);
            writer.WritePointer(this.XboxUnknownAnimationBlock);
        }
    }
}
namespace Moonfish.Tags
{
    
    public partial struct TagClass
    {
        public static TagClass Jmad = ((TagClass)("jmad"));
    }
}
