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
    
    public partial class LoopingSoundDetailBlock : GuerillaBlock, IWriteQueueable
    {
        public Moonfish.Tags.StringIdent Name;
        [Moonfish.Tags.TagReferenceAttribute("snd!")]
        public Moonfish.Tags.TagReference Sound;
        public Moonfish.Model.Range RandomPeriodBounds;
        public float FieldReal;
        public Flags LoopingSoundDetailFlags;
        /// <summary>
        /// if the sound specified above is not stereo it will be randomly spatialized according to the following constraints. if both lower and upper bounds are zero for any of the following fields, the sound's position will be randomly selected from all possible directions or distances.
        /// </summary>
        public Moonfish.Model.Range YawBounds;
        public Moonfish.Model.Range PitchBounds;
        public Moonfish.Model.Range DistanceBounds;
        public override int SerializedSize
        {
            get
            {
                return 52;
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
            this.Sound = binaryReader.ReadTagReference();
            this.RandomPeriodBounds = binaryReader.ReadRange();
            this.FieldReal = binaryReader.ReadSingle();
            this.LoopingSoundDetailFlags = ((Flags)(binaryReader.ReadInt32()));
            this.YawBounds = binaryReader.ReadRange();
            this.PitchBounds = binaryReader.ReadRange();
            this.DistanceBounds = binaryReader.ReadRange();
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
            queueableBinaryWriter.Write(this.Sound);
            queueableBinaryWriter.Write(this.RandomPeriodBounds);
            queueableBinaryWriter.Write(this.FieldReal);
            queueableBinaryWriter.Write(((int)(this.LoopingSoundDetailFlags)));
            queueableBinaryWriter.Write(this.YawBounds);
            queueableBinaryWriter.Write(this.PitchBounds);
            queueableBinaryWriter.Write(this.DistanceBounds);
        }
        [System.FlagsAttribute()]
        public enum Flags : int
        {
            None = 0,
            DontPlayWithAlternate = 1,
            DontPlayWithoutAlternate = 2,
            StartImmediatelyWithLoop = 4,
        }
    }
}