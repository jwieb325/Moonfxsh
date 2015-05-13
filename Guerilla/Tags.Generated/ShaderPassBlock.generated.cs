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
    
    [TagClassAttribute("spas")]
    public partial class ShaderPassBlock : GuerillaBlock, IWriteQueueable
    {
        public byte[] Documentation;
        public ShaderPassParameterBlock[] Parameters = new ShaderPassParameterBlock[0];
        private byte[] fieldpad = new byte[2];
        private byte[] fieldpad0 = new byte[2];
        public ShaderPassImplementationBlock[] Implementations = new ShaderPassImplementationBlock[0];
        public ShaderPassPostprocessDefinitionNewBlock[] PostprocessDefinition = new ShaderPassPostprocessDefinitionNewBlock[0];
        public override int SerializedSize
        {
            get
            {
                return 36;
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
            pointerQueue.Enqueue(binaryReader.ReadBlamPointer(1));
            pointerQueue.Enqueue(binaryReader.ReadBlamPointer(44));
            this.fieldpad = binaryReader.ReadBytes(2);
            this.fieldpad0 = binaryReader.ReadBytes(2);
            pointerQueue.Enqueue(binaryReader.ReadBlamPointer(116));
            pointerQueue.Enqueue(binaryReader.ReadBlamPointer(88));
            return pointerQueue;
        }
        public override void ReadInstances(System.IO.BinaryReader binaryReader, System.Collections.Generic.Queue<Moonfish.Tags.BlamPointer> pointerQueue)
        {
            base.ReadInstances(binaryReader, pointerQueue);
            this.Documentation = base.ReadDataByteArray(binaryReader, pointerQueue.Dequeue());
            this.Parameters = base.ReadBlockArrayData<ShaderPassParameterBlock>(binaryReader, pointerQueue.Dequeue());
            this.Implementations = base.ReadBlockArrayData<ShaderPassImplementationBlock>(binaryReader, pointerQueue.Dequeue());
            this.PostprocessDefinition = base.ReadBlockArrayData<ShaderPassPostprocessDefinitionNewBlock>(binaryReader, pointerQueue.Dequeue());
        }
        public override void QueueWrites(Moonfish.Guerilla.QueueableBinaryWriter queueableBinaryWriter)
        {
            base.QueueWrites(queueableBinaryWriter);
            queueableBinaryWriter.QueueWrite(this.Documentation);
            queueableBinaryWriter.QueueWrite(this.Parameters);
            queueableBinaryWriter.QueueWrite(this.Implementations);
            queueableBinaryWriter.QueueWrite(this.PostprocessDefinition);
        }
        public override void Write_(Moonfish.Guerilla.QueueableBinaryWriter queueableBinaryWriter)
        {
            base.Write_(queueableBinaryWriter);
            queueableBinaryWriter.WritePointer(this.Documentation);
            queueableBinaryWriter.WritePointer(this.Parameters);
            queueableBinaryWriter.Write(this.fieldpad);
            queueableBinaryWriter.Write(this.fieldpad0);
            queueableBinaryWriter.WritePointer(this.Implementations);
            queueableBinaryWriter.WritePointer(this.PostprocessDefinition);
        }
    }
}
namespace Moonfish.Tags
{
    
    public partial struct TagClass
    {
        public static TagClass Spas = ((TagClass)("spas"));
    }
}