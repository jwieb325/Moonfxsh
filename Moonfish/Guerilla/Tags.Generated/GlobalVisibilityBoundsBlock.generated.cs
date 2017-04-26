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
    [TagBlockOriginalNameAttribute("global_visibility_bounds_block")]
    public partial class GlobalVisibilityBoundsBlock : GuerillaBlock, IWriteDeferrable
    {
        public float PositionX;
        public float PositionY;
        public float PositionZ;
        public float Radius;
        public byte Node0;
        private byte[] fieldpad = new byte[3];
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
            this.PositionX = binaryReader.ReadSingle();
            this.PositionY = binaryReader.ReadSingle();
            this.PositionZ = binaryReader.ReadSingle();
            this.Radius = binaryReader.ReadSingle();
            this.Node0 = binaryReader.ReadByte();
            this.fieldpad = binaryReader.ReadBytes(3);
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
            writer.Write(this.PositionX);
            writer.Write(this.PositionY);
            writer.Write(this.PositionZ);
            writer.Write(this.Radius);
            writer.Write(this.Node0);
            writer.Write(this.fieldpad);
        }
    }
}
