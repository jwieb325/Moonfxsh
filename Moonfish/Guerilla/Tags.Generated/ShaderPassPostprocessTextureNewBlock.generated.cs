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
    
    public partial class ShaderPassPostprocessTextureNewBlock : GuerillaBlock, IWriteQueueable
    {
        public byte BitmapParameterIndex;
        public byte BitmapExternIndex;
        public byte TextureStageIndex;
        public byte Flags;
        public override int SerializedSize
        {
            get
            {
                return 4;
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
            this.BitmapParameterIndex = binaryReader.ReadByte();
            this.BitmapExternIndex = binaryReader.ReadByte();
            this.TextureStageIndex = binaryReader.ReadByte();
            this.Flags = binaryReader.ReadByte();
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
            queueableBinaryWriter.Write(this.BitmapParameterIndex);
            queueableBinaryWriter.Write(this.BitmapExternIndex);
            queueableBinaryWriter.Write(this.TextureStageIndex);
            queueableBinaryWriter.Write(this.Flags);
        }
    }
}