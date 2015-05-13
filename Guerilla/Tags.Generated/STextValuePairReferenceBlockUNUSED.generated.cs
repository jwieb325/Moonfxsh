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
    
    public partial class STextValuePairReferenceBlockUNUSED : GuerillaBlock, IWriteQueueable
    {
        public ValueTypeEnum ValueType;
        public BooleanValueEnum BooleanValue;
        public int IntegerValue;
        public float FpValue;
        public Moonfish.Tags.StringIdent TextValueStringId;
        /// <summary>
        /// This is text string associated with data when it has the value specified above.
        ///The string comes from the screen's string list tag.
        /// </summary>
        public Moonfish.Tags.StringIdent TextLabelStringId;
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
        public override System.Collections.Generic.Queue<Moonfish.Tags.BlamPointer> ReadFields(System.IO.BinaryReader binaryReader)
        {
            System.Collections.Generic.Queue<Moonfish.Tags.BlamPointer> pointerQueue = new System.Collections.Generic.Queue<Moonfish.Tags.BlamPointer>(base.ReadFields(binaryReader));
            this.ValueType = ((ValueTypeEnum)(binaryReader.ReadInt16()));
            this.BooleanValue = ((BooleanValueEnum)(binaryReader.ReadInt16()));
            this.IntegerValue = binaryReader.ReadInt32();
            this.FpValue = binaryReader.ReadSingle();
            this.TextValueStringId = binaryReader.ReadStringID();
            this.TextLabelStringId = binaryReader.ReadStringID();
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
            queueableBinaryWriter.Write(((short)(this.ValueType)));
            queueableBinaryWriter.Write(((short)(this.BooleanValue)));
            queueableBinaryWriter.Write(this.IntegerValue);
            queueableBinaryWriter.Write(this.FpValue);
            queueableBinaryWriter.Write(this.TextValueStringId);
            queueableBinaryWriter.Write(this.TextLabelStringId);
        }
        /// <summary>
        /// this is all obsolete
        /// </summary>
        public enum ValueTypeEnum : short
        {
            IntegerNumber = 0,
            FloatingPointNumber = 1,
            Boolean = 2,
            TextString = 3,
        }
        /// <summary>
        /// Enter the value in the box corresponding to the value type you specified above
        /// </summary>
        public enum BooleanValueEnum : short
        {
            FALSE = 0,
            TRUE = 1,
        }
    }
}
