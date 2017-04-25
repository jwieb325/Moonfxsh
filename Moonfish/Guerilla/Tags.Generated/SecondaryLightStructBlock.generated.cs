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
    [TagBlockOriginalNameAttribute("secondary_light_struct_block")]
    public partial class SecondaryLightStructBlock : GuerillaBlock, IWriteQueueable
    {
        /// <summary>
        /// EMPTY STRING
        /// </summary>
        public Moonfish.Tags.ColourR8G8B8 MinLightmapColor;
        public Moonfish.Tags.ColourR8G8B8 MaxLightmapColor;
        public Moonfish.Tags.ColourR8G8B8 MinDiffuseSample;
        public Moonfish.Tags.ColourR8G8B8 MaxDiffuseSample;
        public float ZAxisRotation;
        public MappingFunctionBlock Function = new MappingFunctionBlock();
        public override int SerializedSize
        {
            get
            {
                return 60;
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
            this.MinLightmapColor = binaryReader.ReadColourR8G8B8();
            this.MaxLightmapColor = binaryReader.ReadColourR8G8B8();
            this.MinDiffuseSample = binaryReader.ReadColourR8G8B8();
            this.MaxDiffuseSample = binaryReader.ReadColourR8G8B8();
            this.ZAxisRotation = binaryReader.ReadSingle();
            pointerQueue = new System.Collections.Generic.Queue<Moonfish.Tags.BlamPointer>(pointerQueue.Concat(this.Function.ReadFields(binaryReader)));
            return pointerQueue;
        }
        public override void ReadInstances(Moonfish.Guerilla.BlamBinaryReader binaryReader, System.Collections.Generic.Queue<Moonfish.Tags.BlamPointer> pointerQueue)
        {
            base.ReadInstances(binaryReader, pointerQueue);
            this.Function.ReadInstances(binaryReader, pointerQueue);
        }
        public override void Defer(Moonfish.Guerilla.QueueableBlamBinaryWriter queueableBinaryWriter)
        {
            base.Defer(queueableBinaryWriter);
            this.Function.Defer(queueableBinaryWriter);
        }
        public override void Write(Moonfish.Guerilla.QueueableBlamBinaryWriter queueableBinaryWriter)
        {
            base.Write(queueableBinaryWriter);
            queueableBinaryWriter.Write(this.MinLightmapColor);
            queueableBinaryWriter.Write(this.MaxLightmapColor);
            queueableBinaryWriter.Write(this.MinDiffuseSample);
            queueableBinaryWriter.Write(this.MaxDiffuseSample);
            queueableBinaryWriter.Write(this.ZAxisRotation);
            this.Function.Write(queueableBinaryWriter);
        }
    }
}
