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
    [TagBlockOriginalNameAttribute("shader_template_property_block")]
    public partial class ShaderTemplatePropertyBlock : GuerillaBlock, IWriteQueueable
    {
        public PropertyEnum Property;
        private byte[] fieldpad = new byte[2];
        public Moonfish.Tags.StringIdent ParameterName;
        public override int SerializedSize
        {
            get
            {
                return 8;
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
            this.Property = ((PropertyEnum)(binaryReader.ReadInt16()));
            this.fieldpad = binaryReader.ReadBytes(2);
            this.ParameterName = binaryReader.ReadStringIdent();
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
            queueableBinaryWriter.Write(((short)(this.Property)));
            queueableBinaryWriter.Write(this.fieldpad);
            queueableBinaryWriter.Write(this.ParameterName);
        }
        public enum PropertyEnum : short
        {
            Unused = 0,
            DiffuseMap = 1,
            LightmapEmissiveMap = 2,
            LightmapEmissiveColor = 3,
            LightmapEmissivePower = 4,
            LightmapResolutionScale = 5,
            LightmapHalfLife = 6,
            LightmapDiffuseScale = 7,
            LightmapAlphaTestMap = 8,
            LightmapTranslucentMap = 9,
            LightmapTranslucentColor = 10,
            LightmapTranslucentAlpha = 11,
            ActiveCamoMap = 12,
            LightmapFoliageScale = 13,
        }
    }
}
