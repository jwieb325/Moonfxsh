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
    [TagBlockOriginalNameAttribute("object_function_block")]
    public partial class ObjectFunctionBlock : GuerillaBlock, IWriteQueueable
    {
        public Flags ObjectFunctionFlags;
        public Moonfish.Tags.StringIdent ImportName;
        public Moonfish.Tags.StringIdent ExportName;
        public Moonfish.Tags.StringIdent TurnOffWith;
        public float MinValue;
        public MappingFunctionBlock DefaultFunction = new MappingFunctionBlock();
        public Moonfish.Tags.StringIdent ScaleBy;
        public override int SerializedSize
        {
            get
            {
                return 32;
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
            this.ObjectFunctionFlags = ((Flags)(binaryReader.ReadInt32()));
            this.ImportName = binaryReader.ReadStringIdent();
            this.ExportName = binaryReader.ReadStringIdent();
            this.TurnOffWith = binaryReader.ReadStringIdent();
            this.MinValue = binaryReader.ReadSingle();
            pointerQueue = new System.Collections.Generic.Queue<Moonfish.Tags.BlamPointer>(pointerQueue.Concat(this.DefaultFunction.ReadFields(binaryReader)));
            this.ScaleBy = binaryReader.ReadStringIdent();
            return pointerQueue;
        }
        public override void ReadInstances(Moonfish.Guerilla.BlamBinaryReader binaryReader, System.Collections.Generic.Queue<Moonfish.Tags.BlamPointer> pointerQueue)
        {
            base.ReadInstances(binaryReader, pointerQueue);
            this.DefaultFunction.ReadInstances(binaryReader, pointerQueue);
        }
        public override void Defer(Moonfish.Guerilla.QueueableBlamBinaryWriter queueableBinaryWriter)
        {
            base.Defer(queueableBinaryWriter);
            this.DefaultFunction.Defer(queueableBinaryWriter);
        }
        public override void Write(Moonfish.Guerilla.QueueableBlamBinaryWriter queueableBinaryWriter)
        {
            base.Write(queueableBinaryWriter);
            queueableBinaryWriter.Write(((int)(this.ObjectFunctionFlags)));
            queueableBinaryWriter.Write(this.ImportName);
            queueableBinaryWriter.Write(this.ExportName);
            queueableBinaryWriter.Write(this.TurnOffWith);
            queueableBinaryWriter.Write(this.MinValue);
            this.DefaultFunction.Write(queueableBinaryWriter);
            queueableBinaryWriter.Write(this.ScaleBy);
        }
        [System.FlagsAttribute()]
        public enum Flags : int
        {
            None = 0,
            InvertresultOfFunctionIsOneMinusActualResult = 1,
            MappingDoesNotControlsActivetheCurveMappingCanMakeTheFunctionActiveinactive = 2,
            AlwaysActivefunctionDoesNotDeactivateWhenAtOrBelowLowerBound = 4,
            RandomTimeOffsetfunctionOffsetsPeriodicFunctionInputByRandomValueBetween0And1 = 8,
        }
    }
}
