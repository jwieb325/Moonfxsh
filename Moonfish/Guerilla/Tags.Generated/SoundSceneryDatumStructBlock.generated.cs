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
    [TagBlockOriginalNameAttribute("sound_scenery_datum_struct_block")]
    public partial class SoundSceneryDatumStructBlock : GuerillaBlock, IWriteDeferrable
    {
        public VolumeTypeEnum VolumeType;
        public float Height;
        public Moonfish.Model.Range OverrideDistanceBounds;
        public Moonfish.Model.Range OverrideConeAngleBounds;
        public float OverrideOuterConeGain;
        public override int SerializedSize
        {
            get
            {
                return 28;
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
            this.VolumeType = ((VolumeTypeEnum)(binaryReader.ReadInt32()));
            this.Height = binaryReader.ReadSingle();
            this.OverrideDistanceBounds = binaryReader.ReadRange();
            this.OverrideConeAngleBounds = binaryReader.ReadRange();
            this.OverrideOuterConeGain = binaryReader.ReadSingle();
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
            writer.Write(((int)(this.VolumeType)));
            writer.Write(this.Height);
            writer.Write(this.OverrideDistanceBounds);
            writer.Write(this.OverrideConeAngleBounds);
            writer.Write(this.OverrideOuterConeGain);
        }
        public enum VolumeTypeEnum : int
        {
            Sphere = 0,
            VerticalCylinder = 1,
        }
    }
}
