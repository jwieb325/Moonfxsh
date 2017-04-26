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
    [TagBlockOriginalNameAttribute("structure_bsp_sound_cluster_block")]
    public partial class StructureBspSoundClusterBlock : GuerillaBlock, IWriteDeferrable
    {
        private byte[] fieldpad = new byte[2];
        private byte[] fieldpad0 = new byte[2];
        public StructureSoundClusterPortalDesignators[] EnclosingPortalDesignators = new StructureSoundClusterPortalDesignators[0];
        public StructureSoundClusterInteriorClusterIndices[] InteriorClusterIndices = new StructureSoundClusterInteriorClusterIndices[0];
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
            this.fieldpad = binaryReader.ReadBytes(2);
            this.fieldpad0 = binaryReader.ReadBytes(2);
            pointerQueue.Enqueue(binaryReader.ReadBlamPointer(2));
            pointerQueue.Enqueue(binaryReader.ReadBlamPointer(2));
            return pointerQueue;
        }
        public override void ReadInstances(Moonfish.Guerilla.BlamBinaryReader binaryReader, System.Collections.Generic.Queue<Moonfish.Tags.BlamPointer> pointerQueue)
        {
            base.ReadInstances(binaryReader, pointerQueue);
            this.EnclosingPortalDesignators = base.ReadBlockArrayData<StructureSoundClusterPortalDesignators>(binaryReader, pointerQueue.Dequeue());
            this.InteriorClusterIndices = base.ReadBlockArrayData<StructureSoundClusterInteriorClusterIndices>(binaryReader, pointerQueue.Dequeue());
        }
        public override void DeferReferences(Moonfish.Guerilla.LinearBinaryWriter writer)
        {
            base.DeferReferences(writer);
            writer.Defer(this.EnclosingPortalDesignators);
            writer.Defer(this.InteriorClusterIndices);
        }
        public override void Write(Moonfish.Guerilla.LinearBinaryWriter writer)
        {
            base.Write(writer);
            writer.Write(this.fieldpad);
            writer.Write(this.fieldpad0);
            writer.WritePointer(this.EnclosingPortalDesignators);
            writer.WritePointer(this.InteriorClusterIndices);
        }
    }
}
