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
    [TagBlockOriginalNameAttribute("shader_postprocess_implementation_block")]
    public partial class ShaderPostprocessImplementationBlock : GuerillaBlock, IWriteDeferrable
    {
        public ShaderGpuStateReferenceStructBlock GPUConstantState = new ShaderGpuStateReferenceStructBlock();
        public ShaderGpuStateReferenceStructBlock GPUVolatileState = new ShaderGpuStateReferenceStructBlock();
        public TagBlockIndexStructBlock BitmapParameters = new TagBlockIndexStructBlock();
        public TagBlockIndexStructBlock BitmapTransforms = new TagBlockIndexStructBlock();
        public TagBlockIndexStructBlock ValueParameters = new TagBlockIndexStructBlock();
        public TagBlockIndexStructBlock ColorParameters = new TagBlockIndexStructBlock();
        public TagBlockIndexStructBlock BitmapTransformOverlays = new TagBlockIndexStructBlock();
        public TagBlockIndexStructBlock ValueOverlays = new TagBlockIndexStructBlock();
        public TagBlockIndexStructBlock ColorOverlays = new TagBlockIndexStructBlock();
        public TagBlockIndexStructBlock VertexShaderConstants = new TagBlockIndexStructBlock();
        public override int SerializedSize
        {
            get
            {
                return 44;
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
            pointerQueue = new System.Collections.Generic.Queue<Moonfish.Tags.BlamPointer>(pointerQueue.Concat(this.GPUConstantState.ReadFields(binaryReader)));
            pointerQueue = new System.Collections.Generic.Queue<Moonfish.Tags.BlamPointer>(pointerQueue.Concat(this.GPUVolatileState.ReadFields(binaryReader)));
            pointerQueue = new System.Collections.Generic.Queue<Moonfish.Tags.BlamPointer>(pointerQueue.Concat(this.BitmapParameters.ReadFields(binaryReader)));
            pointerQueue = new System.Collections.Generic.Queue<Moonfish.Tags.BlamPointer>(pointerQueue.Concat(this.BitmapTransforms.ReadFields(binaryReader)));
            pointerQueue = new System.Collections.Generic.Queue<Moonfish.Tags.BlamPointer>(pointerQueue.Concat(this.ValueParameters.ReadFields(binaryReader)));
            pointerQueue = new System.Collections.Generic.Queue<Moonfish.Tags.BlamPointer>(pointerQueue.Concat(this.ColorParameters.ReadFields(binaryReader)));
            pointerQueue = new System.Collections.Generic.Queue<Moonfish.Tags.BlamPointer>(pointerQueue.Concat(this.BitmapTransformOverlays.ReadFields(binaryReader)));
            pointerQueue = new System.Collections.Generic.Queue<Moonfish.Tags.BlamPointer>(pointerQueue.Concat(this.ValueOverlays.ReadFields(binaryReader)));
            pointerQueue = new System.Collections.Generic.Queue<Moonfish.Tags.BlamPointer>(pointerQueue.Concat(this.ColorOverlays.ReadFields(binaryReader)));
            pointerQueue = new System.Collections.Generic.Queue<Moonfish.Tags.BlamPointer>(pointerQueue.Concat(this.VertexShaderConstants.ReadFields(binaryReader)));
            return pointerQueue;
        }
        public override void ReadInstances(Moonfish.Guerilla.BlamBinaryReader binaryReader, System.Collections.Generic.Queue<Moonfish.Tags.BlamPointer> pointerQueue)
        {
            base.ReadInstances(binaryReader, pointerQueue);
            this.GPUConstantState.ReadInstances(binaryReader, pointerQueue);
            this.GPUVolatileState.ReadInstances(binaryReader, pointerQueue);
            this.BitmapParameters.ReadInstances(binaryReader, pointerQueue);
            this.BitmapTransforms.ReadInstances(binaryReader, pointerQueue);
            this.ValueParameters.ReadInstances(binaryReader, pointerQueue);
            this.ColorParameters.ReadInstances(binaryReader, pointerQueue);
            this.BitmapTransformOverlays.ReadInstances(binaryReader, pointerQueue);
            this.ValueOverlays.ReadInstances(binaryReader, pointerQueue);
            this.ColorOverlays.ReadInstances(binaryReader, pointerQueue);
            this.VertexShaderConstants.ReadInstances(binaryReader, pointerQueue);
        }
        public override void DeferReferences(Moonfish.Guerilla.LinearBinaryWriter writer)
        {
            base.DeferReferences(writer);
            this.GPUConstantState.DeferReferences(writer);
            this.GPUConstantState.DeferReferences(writer);
            this.GPUVolatileState.DeferReferences(writer);
            this.GPUVolatileState.DeferReferences(writer);
            this.BitmapParameters.DeferReferences(writer);
            this.BitmapParameters.DeferReferences(writer);
            this.BitmapTransforms.DeferReferences(writer);
            this.BitmapTransforms.DeferReferences(writer);
            this.ValueParameters.DeferReferences(writer);
            this.ValueParameters.DeferReferences(writer);
            this.ColorParameters.DeferReferences(writer);
            this.ColorParameters.DeferReferences(writer);
            this.BitmapTransformOverlays.DeferReferences(writer);
            this.BitmapTransformOverlays.DeferReferences(writer);
            this.ValueOverlays.DeferReferences(writer);
            this.ValueOverlays.DeferReferences(writer);
            this.ColorOverlays.DeferReferences(writer);
            this.ColorOverlays.DeferReferences(writer);
            this.VertexShaderConstants.DeferReferences(writer);
            this.VertexShaderConstants.DeferReferences(writer);
        }
        public override void Write(Moonfish.Guerilla.LinearBinaryWriter writer)
        {
            base.Write(writer);
            this.GPUConstantState.Write(writer);
            this.GPUVolatileState.Write(writer);
            this.BitmapParameters.Write(writer);
            this.BitmapTransforms.Write(writer);
            this.ValueParameters.Write(writer);
            this.ColorParameters.Write(writer);
            this.BitmapTransformOverlays.Write(writer);
            this.ValueOverlays.Write(writer);
            this.ColorOverlays.Write(writer);
            this.VertexShaderConstants.Write(writer);
        }
    }
}
