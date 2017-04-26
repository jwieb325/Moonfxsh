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
    [TagClassAttribute("slit")]
    [TagBlockOriginalNameAttribute("shader_light_response_block")]
    public partial class ShaderLightResponseBlock : GuerillaBlock, IWriteDeferrable
    {
        public ShaderTemplateCategoryBlock[] Categories = new ShaderTemplateCategoryBlock[0];
        public ShaderTemplateLevelOfDetailBlock[] ShaderLODs = new ShaderTemplateLevelOfDetailBlock[0];
        private byte[] fieldpad = new byte[2];
        private byte[] fieldpad0 = new byte[2];
        public override int SerializedSize
        {
            get
            {
                return 20;
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
            pointerQueue.Enqueue(binaryReader.ReadBlamPointer(12));
            pointerQueue.Enqueue(binaryReader.ReadBlamPointer(12));
            this.fieldpad = binaryReader.ReadBytes(2);
            this.fieldpad0 = binaryReader.ReadBytes(2);
            return pointerQueue;
        }
        public override void ReadInstances(Moonfish.Guerilla.BlamBinaryReader binaryReader, System.Collections.Generic.Queue<Moonfish.Tags.BlamPointer> pointerQueue)
        {
            base.ReadInstances(binaryReader, pointerQueue);
            this.Categories = base.ReadBlockArrayData<ShaderTemplateCategoryBlock>(binaryReader, pointerQueue.Dequeue());
            this.ShaderLODs = base.ReadBlockArrayData<ShaderTemplateLevelOfDetailBlock>(binaryReader, pointerQueue.Dequeue());
        }
        public override void DeferReferences(Moonfish.Guerilla.LinearBinaryWriter writer)
        {
            base.DeferReferences(writer);
            writer.Defer(this.Categories);
            writer.Defer(this.ShaderLODs);
        }
        public override void Write(Moonfish.Guerilla.LinearBinaryWriter writer)
        {
            base.Write(writer);
            writer.WritePointer(this.Categories);
            writer.WritePointer(this.ShaderLODs);
            writer.Write(this.fieldpad);
            writer.Write(this.fieldpad0);
        }
    }
}
namespace Moonfish.Tags
{
    
    public partial struct TagClass
    {
        public static TagClass Slit = ((TagClass)("slit"));
    }
}
