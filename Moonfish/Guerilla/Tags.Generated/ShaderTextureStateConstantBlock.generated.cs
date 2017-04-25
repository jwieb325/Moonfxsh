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
    [TagBlockOriginalNameAttribute("shader_texture_state_constant_block")]
    public partial class ShaderTextureStateConstantBlock : GuerillaBlock, IWriteQueueable
    {
        public Moonfish.Tags.StringIdent SourceParameter;
        private byte[] fieldpad = new byte[2];
        public ConstantEnum Constant;
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
            this.SourceParameter = binaryReader.ReadStringIdent();
            this.fieldpad = binaryReader.ReadBytes(2);
            this.Constant = ((ConstantEnum)(binaryReader.ReadInt16()));
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
            queueableBinaryWriter.Write(this.SourceParameter);
            queueableBinaryWriter.Write(this.fieldpad);
            queueableBinaryWriter.Write(((short)(this.Constant)));
        }
        public enum ConstantEnum : short
        {
            MipmapBiasvalue = 0,
            ColorkeyColor = 1,
            BorderColor = 2,
            BorderAlphavalue = 3,
            BumpenvMat00 = 4,
            BumpenvMat01 = 5,
            BumpenvMat10 = 6,
            BumpenvMat11 = 7,
            BumpenvLumScalevalue = 8,
            BumpenvLumOffsetvalue = 9,
        }
    }
}
