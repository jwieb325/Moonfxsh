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
    [TagBlockOriginalNameAttribute("damage_constraint_info_block")]
    public partial class DamageConstraintInfoBlock : GuerillaBlock, IWriteQueueable
    {
        public Moonfish.Tags.StringIdent PhysicsModelConstraintName;
        public Moonfish.Tags.StringIdent DamageConstraintName;
        public Moonfish.Tags.StringIdent DamageConstraintGroupName;
        public float GroupProbabilityScale;
        private byte[] fieldpad = new byte[4];
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
            this.PhysicsModelConstraintName = binaryReader.ReadStringIdent();
            this.DamageConstraintName = binaryReader.ReadStringIdent();
            this.DamageConstraintGroupName = binaryReader.ReadStringIdent();
            this.GroupProbabilityScale = binaryReader.ReadSingle();
            this.fieldpad = binaryReader.ReadBytes(4);
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
            queueableBinaryWriter.Write(this.PhysicsModelConstraintName);
            queueableBinaryWriter.Write(this.DamageConstraintName);
            queueableBinaryWriter.Write(this.DamageConstraintGroupName);
            queueableBinaryWriter.Write(this.GroupProbabilityScale);
            queueableBinaryWriter.Write(this.fieldpad);
        }
    }
}
