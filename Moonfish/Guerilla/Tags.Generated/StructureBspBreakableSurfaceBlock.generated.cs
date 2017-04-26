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
    [TagBlockOriginalNameAttribute("structure_bsp_breakable_surface_block")]
    public partial class StructureBspBreakableSurfaceBlock : GuerillaBlock, IWriteDeferrable
    {
        public Moonfish.Tags.ShortBlockIndex1 InstancedGeometryInstance;
        public short BreakableSurfaceIndex;
        public OpenTK.Vector3 Centroid;
        public float Radius;
        public int CollisionSurfaceIndex;
        public override int SerializedSize
        {
            get
            {
                return 24;
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
            this.InstancedGeometryInstance = binaryReader.ReadShortBlockIndex1();
            this.BreakableSurfaceIndex = binaryReader.ReadInt16();
            this.Centroid = binaryReader.ReadVector3();
            this.Radius = binaryReader.ReadSingle();
            this.CollisionSurfaceIndex = binaryReader.ReadInt32();
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
            writer.Write(this.InstancedGeometryInstance);
            writer.Write(this.BreakableSurfaceIndex);
            writer.Write(this.Centroid);
            writer.Write(this.Radius);
            writer.Write(this.CollisionSurfaceIndex);
        }
    }
}
