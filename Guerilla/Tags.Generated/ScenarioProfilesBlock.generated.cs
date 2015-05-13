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
    
    public partial class ScenarioProfilesBlock : GuerillaBlock, IWriteQueueable
    {
        public Moonfish.Tags.String32 Name;
        public float StartingHealthDamage;
        public float StartingShieldDamage;
        [Moonfish.Tags.TagReferenceAttribute("weap")]
        public Moonfish.Tags.TagReference PrimaryWeapon;
        public short RoundsLoaded;
        public short RoundsTotal;
        [Moonfish.Tags.TagReferenceAttribute("weap")]
        public Moonfish.Tags.TagReference SecondaryWeapon;
        public short RoundsLoaded0;
        public short RoundsTotal0;
        public byte StartingFragmentationGrenadeCount;
        public byte StartingPlasmaGrenadeCount;
        public byte StartingunknownGrenadeCount;
        public byte StartingunknownGrenadeCount0;
        public override int SerializedSize
        {
            get
            {
                return 68;
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
            this.Name = binaryReader.ReadString32();
            this.StartingHealthDamage = binaryReader.ReadSingle();
            this.StartingShieldDamage = binaryReader.ReadSingle();
            this.PrimaryWeapon = binaryReader.ReadTagReference();
            this.RoundsLoaded = binaryReader.ReadInt16();
            this.RoundsTotal = binaryReader.ReadInt16();
            this.SecondaryWeapon = binaryReader.ReadTagReference();
            this.RoundsLoaded0 = binaryReader.ReadInt16();
            this.RoundsTotal0 = binaryReader.ReadInt16();
            this.StartingFragmentationGrenadeCount = binaryReader.ReadByte();
            this.StartingPlasmaGrenadeCount = binaryReader.ReadByte();
            this.StartingunknownGrenadeCount = binaryReader.ReadByte();
            this.StartingunknownGrenadeCount0 = binaryReader.ReadByte();
            return pointerQueue;
        }
        public override void ReadInstances(System.IO.BinaryReader binaryReader, System.Collections.Generic.Queue<Moonfish.Tags.BlamPointer> pointerQueue)
        {
            base.ReadInstances(binaryReader, pointerQueue);
        }
        public override void QueueWrites(Moonfish.Guerilla.QueueableBinaryWriter queueableBinaryWriter)
        {
            base.QueueWrites(queueableBinaryWriter);
        }
        public override void Write_(Moonfish.Guerilla.QueueableBinaryWriter queueableBinaryWriter)
        {
            base.Write_(queueableBinaryWriter);
            queueableBinaryWriter.Write(this.Name);
            queueableBinaryWriter.Write(this.StartingHealthDamage);
            queueableBinaryWriter.Write(this.StartingShieldDamage);
            queueableBinaryWriter.Write(this.PrimaryWeapon);
            queueableBinaryWriter.Write(this.RoundsLoaded);
            queueableBinaryWriter.Write(this.RoundsTotal);
            queueableBinaryWriter.Write(this.SecondaryWeapon);
            queueableBinaryWriter.Write(this.RoundsLoaded0);
            queueableBinaryWriter.Write(this.RoundsTotal0);
            queueableBinaryWriter.Write(this.StartingFragmentationGrenadeCount);
            queueableBinaryWriter.Write(this.StartingPlasmaGrenadeCount);
            queueableBinaryWriter.Write(this.StartingunknownGrenadeCount);
            queueableBinaryWriter.Write(this.StartingunknownGrenadeCount0);
        }
    }
}