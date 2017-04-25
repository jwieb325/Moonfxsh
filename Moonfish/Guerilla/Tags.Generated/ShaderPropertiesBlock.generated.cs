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
    [TagBlockOriginalNameAttribute("shader_properties_block")]
    public partial class ShaderPropertiesBlock : GuerillaBlock, IWriteQueueable
    {
        [Moonfish.Tags.TagReferenceAttribute("bitm")]
        public Moonfish.Tags.TagReference DiffuseMap;
        [Moonfish.Tags.TagReferenceAttribute("bitm")]
        public Moonfish.Tags.TagReference LightmapEmissiveMap;
        public Moonfish.Tags.ColourR8G8B8 LightmapEmissiveColor;
        public float LightmapEmissivePower;
        public float LightmapResolutionScale;
        public float LightmapHalfLife;
        public float LightmapDiffuseScale;
        [Moonfish.Tags.TagReferenceAttribute("bitm")]
        public Moonfish.Tags.TagReference AlphaTestMap;
        [Moonfish.Tags.TagReferenceAttribute("bitm")]
        public Moonfish.Tags.TagReference TranslucentMap;
        public Moonfish.Tags.ColourR8G8B8 LightmapTransparentColor;
        public float LightmapTransparentAlpha;
        public float LightmapFoliageScale;
        public override int SerializedSize
        {
            get
            {
                return 80;
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
            this.DiffuseMap = binaryReader.ReadTagReference();
            this.LightmapEmissiveMap = binaryReader.ReadTagReference();
            this.LightmapEmissiveColor = binaryReader.ReadColourR8G8B8();
            this.LightmapEmissivePower = binaryReader.ReadSingle();
            this.LightmapResolutionScale = binaryReader.ReadSingle();
            this.LightmapHalfLife = binaryReader.ReadSingle();
            this.LightmapDiffuseScale = binaryReader.ReadSingle();
            this.AlphaTestMap = binaryReader.ReadTagReference();
            this.TranslucentMap = binaryReader.ReadTagReference();
            this.LightmapTransparentColor = binaryReader.ReadColourR8G8B8();
            this.LightmapTransparentAlpha = binaryReader.ReadSingle();
            this.LightmapFoliageScale = binaryReader.ReadSingle();
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
            queueableBinaryWriter.Write(this.DiffuseMap);
            queueableBinaryWriter.Write(this.LightmapEmissiveMap);
            queueableBinaryWriter.Write(this.LightmapEmissiveColor);
            queueableBinaryWriter.Write(this.LightmapEmissivePower);
            queueableBinaryWriter.Write(this.LightmapResolutionScale);
            queueableBinaryWriter.Write(this.LightmapHalfLife);
            queueableBinaryWriter.Write(this.LightmapDiffuseScale);
            queueableBinaryWriter.Write(this.AlphaTestMap);
            queueableBinaryWriter.Write(this.TranslucentMap);
            queueableBinaryWriter.Write(this.LightmapTransparentColor);
            queueableBinaryWriter.Write(this.LightmapTransparentAlpha);
            queueableBinaryWriter.Write(this.LightmapFoliageScale);
        }
    }
}
