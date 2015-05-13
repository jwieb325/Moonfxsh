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
    
    public partial class SoundGestaltPitchRangesBlock : GuerillaBlock, IWriteQueueable
    {
        public Moonfish.Tags.ShortBlockIndex1 Name;
        public Moonfish.Tags.ShortBlockIndex1 Parameters;
        public short EncodedPermutationData;
        public short FirstRuntimePermutationFlagIndex;
        public Moonfish.Tags.ShortBlockIndex1 FirstPermutation;
        public short PermutationCount;
        public override int SerializedSize
        {
            get
            {
                return 12;
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
            this.Name = binaryReader.ReadShortBlockIndex1();
            this.Parameters = binaryReader.ReadShortBlockIndex1();
            this.EncodedPermutationData = binaryReader.ReadInt16();
            this.FirstRuntimePermutationFlagIndex = binaryReader.ReadInt16();
            this.FirstPermutation = binaryReader.ReadShortBlockIndex1();
            this.PermutationCount = binaryReader.ReadInt16();
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
            queueableBinaryWriter.Write(this.Parameters);
            queueableBinaryWriter.Write(this.EncodedPermutationData);
            queueableBinaryWriter.Write(this.FirstRuntimePermutationFlagIndex);
            queueableBinaryWriter.Write(this.FirstPermutation);
            queueableBinaryWriter.Write(this.PermutationCount);
        }
    }
}
