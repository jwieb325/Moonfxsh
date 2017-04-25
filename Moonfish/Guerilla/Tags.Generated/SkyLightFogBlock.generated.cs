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
    [TagBlockOriginalNameAttribute("sky_light_fog_block")]
    public partial class SkyLightFogBlock : GuerillaBlock, IWriteQueueable
    {
        public Moonfish.Tags.ColourR8G8B8 Color;
        public float MaximumDensity;
        public float StartDistance;
        public float OpaqueDistance;
        /// <summary>
        /// EMPTY STRING
        /// </summary>
        public Moonfish.Model.Range Cone;
        public float AtmosphericFogInfluence;
        public float SecondaryFogInfluence;
        public float SkyFogInfluence;
        public override int SerializedSize
        {
            get
            {
                return 44;
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
            this.Color = binaryReader.ReadColourR8G8B8();
            this.MaximumDensity = binaryReader.ReadSingle();
            this.StartDistance = binaryReader.ReadSingle();
            this.OpaqueDistance = binaryReader.ReadSingle();
            this.Cone = binaryReader.ReadRange();
            this.AtmosphericFogInfluence = binaryReader.ReadSingle();
            this.SecondaryFogInfluence = binaryReader.ReadSingle();
            this.SkyFogInfluence = binaryReader.ReadSingle();
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
            queueableBinaryWriter.Write(this.Color);
            queueableBinaryWriter.Write(this.MaximumDensity);
            queueableBinaryWriter.Write(this.StartDistance);
            queueableBinaryWriter.Write(this.OpaqueDistance);
            queueableBinaryWriter.Write(this.Cone);
            queueableBinaryWriter.Write(this.AtmosphericFogInfluence);
            queueableBinaryWriter.Write(this.SecondaryFogInfluence);
            queueableBinaryWriter.Write(this.SkyFogInfluence);
        }
    }
}
