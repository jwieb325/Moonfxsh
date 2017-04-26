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
    [TagBlockOriginalNameAttribute("shader_gpu_state_struct_block")]
    public partial class ShaderGpuStateStructBlock : GuerillaBlock, IWriteDeferrable
    {
        public RenderStateBlock[] RenderStates = new RenderStateBlock[0];
        public TextureStageStateBlock[] TextureStageStates = new TextureStageStateBlock[0];
        public RenderStateParameterBlock[] RenderStateParameters = new RenderStateParameterBlock[0];
        public TextureStageStateParameterBlock[] TextureStageParameters = new TextureStageStateParameterBlock[0];
        public TextureBlock[] Textures = new TextureBlock[0];
        public VertexShaderConstantBlock[] VnConstants = new VertexShaderConstantBlock[0];
        public VertexShaderConstantBlock[] CnConstants = new VertexShaderConstantBlock[0];
        public override int SerializedSize
        {
            get
            {
                return 56;
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
            pointerQueue.Enqueue(binaryReader.ReadBlamPointer(5));
            pointerQueue.Enqueue(binaryReader.ReadBlamPointer(6));
            pointerQueue.Enqueue(binaryReader.ReadBlamPointer(3));
            pointerQueue.Enqueue(binaryReader.ReadBlamPointer(4));
            pointerQueue.Enqueue(binaryReader.ReadBlamPointer(4));
            pointerQueue.Enqueue(binaryReader.ReadBlamPointer(4));
            pointerQueue.Enqueue(binaryReader.ReadBlamPointer(4));
            return pointerQueue;
        }
        public override void ReadInstances(Moonfish.Guerilla.BlamBinaryReader binaryReader, System.Collections.Generic.Queue<Moonfish.Tags.BlamPointer> pointerQueue)
        {
            base.ReadInstances(binaryReader, pointerQueue);
            this.RenderStates = base.ReadBlockArrayData<RenderStateBlock>(binaryReader, pointerQueue.Dequeue());
            this.TextureStageStates = base.ReadBlockArrayData<TextureStageStateBlock>(binaryReader, pointerQueue.Dequeue());
            this.RenderStateParameters = base.ReadBlockArrayData<RenderStateParameterBlock>(binaryReader, pointerQueue.Dequeue());
            this.TextureStageParameters = base.ReadBlockArrayData<TextureStageStateParameterBlock>(binaryReader, pointerQueue.Dequeue());
            this.Textures = base.ReadBlockArrayData<TextureBlock>(binaryReader, pointerQueue.Dequeue());
            this.VnConstants = base.ReadBlockArrayData<VertexShaderConstantBlock>(binaryReader, pointerQueue.Dequeue());
            this.CnConstants = base.ReadBlockArrayData<VertexShaderConstantBlock>(binaryReader, pointerQueue.Dequeue());
        }
        public override void DeferReferences(Moonfish.Guerilla.LinearBinaryWriter writer)
        {
            base.DeferReferences(writer);
            writer.Defer(this.RenderStates);
            writer.Defer(this.TextureStageStates);
            writer.Defer(this.RenderStateParameters);
            writer.Defer(this.TextureStageParameters);
            writer.Defer(this.Textures);
            writer.Defer(this.VnConstants);
            writer.Defer(this.CnConstants);
        }
        public override void Write(Moonfish.Guerilla.LinearBinaryWriter writer)
        {
            base.Write(writer);
            writer.WritePointer(this.RenderStates);
            writer.WritePointer(this.TextureStageStates);
            writer.WritePointer(this.RenderStateParameters);
            writer.WritePointer(this.TextureStageParameters);
            writer.WritePointer(this.Textures);
            writer.WritePointer(this.VnConstants);
            writer.WritePointer(this.CnConstants);
        }
    }
}
