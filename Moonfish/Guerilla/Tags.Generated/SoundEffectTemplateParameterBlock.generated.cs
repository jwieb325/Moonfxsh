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
    
    public partial class SoundEffectTemplateParameterBlock : GuerillaBlock, IWriteQueueable
    {
        public Moonfish.Tags.StringIdent Name;
        public TypeEnum Type;
        public Flags SoundEffectTemplateParameterFlags;
        public int HardwareOffset;
        public int DefaultEnumIntegerValue;
        public float DefaultScalarValue;
        public MappingFunctionBlock DefaultFunction = new MappingFunctionBlock();
        public float MinimumScalarValue;
        public float MaximumScalarValue;
        public override int SerializedSize
        {
            get
            {
                return 36;
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
            this.Name = binaryReader.ReadStringID();
            this.Type = ((TypeEnum)(binaryReader.ReadInt16()));
            this.SoundEffectTemplateParameterFlags = ((Flags)(binaryReader.ReadInt16()));
            this.HardwareOffset = binaryReader.ReadInt32();
            this.DefaultEnumIntegerValue = binaryReader.ReadInt32();
            this.DefaultScalarValue = binaryReader.ReadSingle();
            pointerQueue = new System.Collections.Generic.Queue<Moonfish.Tags.BlamPointer>(pointerQueue.Concat(this.DefaultFunction.ReadFields(binaryReader)));
            this.MinimumScalarValue = binaryReader.ReadSingle();
            this.MaximumScalarValue = binaryReader.ReadSingle();
            return pointerQueue;
        }
        public override void ReadInstances(System.IO.BinaryReader binaryReader, System.Collections.Generic.Queue<Moonfish.Tags.BlamPointer> pointerQueue)
        {
            base.ReadInstances(binaryReader, pointerQueue);
            this.DefaultFunction.ReadInstances(binaryReader, pointerQueue);
        }
        public override void QueueWrites(Moonfish.Guerilla.QueueableBinaryWriter queueableBinaryWriter)
        {
            base.QueueWrites(queueableBinaryWriter);
            this.DefaultFunction.QueueWrites(queueableBinaryWriter);
        }
        public override void Write_(Moonfish.Guerilla.QueueableBinaryWriter queueableBinaryWriter)
        {
            base.Write_(queueableBinaryWriter);
            queueableBinaryWriter.Write(this.Name);
            queueableBinaryWriter.Write(((short)(this.Type)));
            queueableBinaryWriter.Write(((short)(this.SoundEffectTemplateParameterFlags)));
            queueableBinaryWriter.Write(this.HardwareOffset);
            queueableBinaryWriter.Write(this.DefaultEnumIntegerValue);
            queueableBinaryWriter.Write(this.DefaultScalarValue);
            this.DefaultFunction.Write_(queueableBinaryWriter);
            queueableBinaryWriter.Write(this.MinimumScalarValue);
            queueableBinaryWriter.Write(this.MaximumScalarValue);
        }
        public enum TypeEnum : short
        {
            Integer = 0,
            Real = 1,
            FilterType = 2,
        }
        [System.FlagsAttribute()]
        public enum Flags : short
        {
            None = 0,
            ExposeAsFunction = 1,
        }
    }
}