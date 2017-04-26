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
    [TagBlockOriginalNameAttribute("damage_seat_info_block")]
    public partial class DamageSeatInfoBlock : GuerillaBlock, IWriteDeferrable
    {
        public Moonfish.Tags.StringIdent SeatLabel;
        public float DirectDamageScale;
        public float DamageTransferFalloffRadius;
        public float MaximumTransferDamageScale;
        public float MinimumTransferDamageScale;
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
            this.SeatLabel = binaryReader.ReadStringIdent();
            this.DirectDamageScale = binaryReader.ReadSingle();
            this.DamageTransferFalloffRadius = binaryReader.ReadSingle();
            this.MaximumTransferDamageScale = binaryReader.ReadSingle();
            this.MinimumTransferDamageScale = binaryReader.ReadSingle();
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
            writer.Write(this.SeatLabel);
            writer.Write(this.DirectDamageScale);
            writer.Write(this.DamageTransferFalloffRadius);
            writer.Write(this.MaximumTransferDamageScale);
            writer.Write(this.MinimumTransferDamageScale);
        }
    }
}
