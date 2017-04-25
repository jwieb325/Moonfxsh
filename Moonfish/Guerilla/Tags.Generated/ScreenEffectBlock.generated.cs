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
    [TagClassAttribute("egor")]
    [TagBlockOriginalNameAttribute("screen_effect_block")]
    public partial class ScreenEffectBlock : GuerillaBlock, IWriteQueueable
    {
        /// <summary>
        /// A screen effect is essentially a collection of pass references, each one corresponding to a shader pass reference from the template. Note that only shader passes in the TRANSPARENT layer are considered during screen effect rendering.
        /// </summary>
        private byte[] fieldpad = new byte[64];
        [Moonfish.Tags.TagReferenceAttribute("shad")]
        public Moonfish.Tags.TagReference Shader;
        private byte[] fieldpad0 = new byte[64];
        public RasterizerScreenEffectPassReferenceBlock[] PassReferences = new RasterizerScreenEffectPassReferenceBlock[0];
        public override int SerializedSize
        {
            get
            {
                return 144;
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
            this.fieldpad = binaryReader.ReadBytes(64);
            this.Shader = binaryReader.ReadTagReference();
            this.fieldpad0 = binaryReader.ReadBytes(64);
            pointerQueue.Enqueue(binaryReader.ReadBlamPointer(172));
            return pointerQueue;
        }
        public override void ReadInstances(Moonfish.Guerilla.BlamBinaryReader binaryReader, System.Collections.Generic.Queue<Moonfish.Tags.BlamPointer> pointerQueue)
        {
            base.ReadInstances(binaryReader, pointerQueue);
            this.PassReferences = base.ReadBlockArrayData<RasterizerScreenEffectPassReferenceBlock>(binaryReader, pointerQueue.Dequeue());
        }
        public override void Defer(Moonfish.Guerilla.QueueableBlamBinaryWriter queueableBinaryWriter)
        {
            base.Defer(queueableBinaryWriter);
            queueableBinaryWriter.Defer(this.PassReferences);
        }
        public override void Write(Moonfish.Guerilla.QueueableBlamBinaryWriter queueableBinaryWriter)
        {
            base.Write(queueableBinaryWriter);
            queueableBinaryWriter.Write(this.fieldpad);
            queueableBinaryWriter.Write(this.Shader);
            queueableBinaryWriter.Write(this.fieldpad0);
            queueableBinaryWriter.WritePointer(this.PassReferences);
        }
    }
}
namespace Moonfish.Tags
{
    
    public partial struct TagClass
    {
        public static TagClass Egor = ((TagClass)("egor"));
    }
}
