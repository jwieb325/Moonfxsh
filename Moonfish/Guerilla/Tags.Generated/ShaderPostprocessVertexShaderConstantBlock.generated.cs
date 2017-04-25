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
    [TagBlockOriginalNameAttribute("shader_postprocess_vertex_shader_constant_block")]
    public partial class ShaderPostprocessVertexShaderConstantBlock : GuerillaBlock, IWriteQueueable
    {
        public byte RegisterIndex;
        public byte RegisterBank;
        public float Data;
        public float Data0;
        public float Data1;
        public float Data2;
        public override int SerializedSize
        {
            get
            {
                return 18;
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
            this.RegisterIndex = binaryReader.ReadByte();
            this.RegisterBank = binaryReader.ReadByte();
            this.Data = binaryReader.ReadSingle();
            this.Data0 = binaryReader.ReadSingle();
            this.Data1 = binaryReader.ReadSingle();
            this.Data2 = binaryReader.ReadSingle();
            return pointerQueue;
        }
        public override void ReadInstances(Moonfish.Guerilla.BlamBinaryReader binaryReader, System.Collections.Generic.Queue<Moonfish.Tags.BlamPointer> pointerQueue)
        {
            base.ReadInstances(binaryReader, pointerQueue);
        }
        public override void Defer(Moonfish.Guerilla.QueueableBlamBinaryWriter queueableBinaryWriter)
        {
            base.Defer(queueableBinaryWriter);
        }
        public override void Write(Moonfish.Guerilla.QueueableBlamBinaryWriter queueableBinaryWriter)
        {
            base.Write(queueableBinaryWriter);
            queueableBinaryWriter.Write(this.RegisterIndex);
            queueableBinaryWriter.Write(this.RegisterBank);
            queueableBinaryWriter.Write(this.Data);
            queueableBinaryWriter.Write(this.Data0);
            queueableBinaryWriter.Write(this.Data1);
            queueableBinaryWriter.Write(this.Data2);
        }
    }
}
