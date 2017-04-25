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
    [TagBlockOriginalNameAttribute("scenario_function_block")]
    public partial class ScenarioFunctionBlock : GuerillaBlock, IWriteQueueable
    {
        public Flags ScenarioFunctionFlags;
        public Moonfish.Tags.String32 Name;
        public float Period;
        public Moonfish.Tags.ShortBlockIndex1 ScalePeriodBy;
        public FunctionEnum Function;
        public Moonfish.Tags.ShortBlockIndex1 ScaleFunctionBy;
        public WobbleFunctionEnum WobbleFunction;
        public float WobblePeriod;
        public float WobbleMagnitude;
        public float SquareWaveThreshold;
        public short StepCount;
        public MapToEnum MapTo;
        public short SawtoothCount;
        private byte[] fieldpad = new byte[2];
        public Moonfish.Tags.ShortBlockIndex1 ScaleResultBy;
        public BoundsModeEnum BoundsMode;
        public OpenTK.Vector2 Bounds;
        private byte[] fieldpad0 = new byte[4];
        private byte[] fieldpad1 = new byte[2];
        public Moonfish.Tags.ShortBlockIndex1 TurnOffWith;
        private byte[] fieldpad2 = new byte[16];
        private byte[] fieldpad3 = new byte[16];
        public override int SerializedSize
        {
            get
            {
                return 120;
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
            this.ScenarioFunctionFlags = ((Flags)(binaryReader.ReadInt32()));
            this.Name = binaryReader.ReadString32();
            this.Period = binaryReader.ReadSingle();
            this.ScalePeriodBy = binaryReader.ReadShortBlockIndex1();
            this.Function = ((FunctionEnum)(binaryReader.ReadInt16()));
            this.ScaleFunctionBy = binaryReader.ReadShortBlockIndex1();
            this.WobbleFunction = ((WobbleFunctionEnum)(binaryReader.ReadInt16()));
            this.WobblePeriod = binaryReader.ReadSingle();
            this.WobbleMagnitude = binaryReader.ReadSingle();
            this.SquareWaveThreshold = binaryReader.ReadSingle();
            this.StepCount = binaryReader.ReadInt16();
            this.MapTo = ((MapToEnum)(binaryReader.ReadInt16()));
            this.SawtoothCount = binaryReader.ReadInt16();
            this.fieldpad = binaryReader.ReadBytes(2);
            this.ScaleResultBy = binaryReader.ReadShortBlockIndex1();
            this.BoundsMode = ((BoundsModeEnum)(binaryReader.ReadInt16()));
            this.Bounds = binaryReader.ReadVector2();
            this.fieldpad0 = binaryReader.ReadBytes(4);
            this.fieldpad1 = binaryReader.ReadBytes(2);
            this.TurnOffWith = binaryReader.ReadShortBlockIndex1();
            this.fieldpad2 = binaryReader.ReadBytes(16);
            this.fieldpad3 = binaryReader.ReadBytes(16);
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
            queueableBinaryWriter.Write(((int)(this.ScenarioFunctionFlags)));
            queueableBinaryWriter.Write(this.Name);
            queueableBinaryWriter.Write(this.Period);
            queueableBinaryWriter.Write(this.ScalePeriodBy);
            queueableBinaryWriter.Write(((short)(this.Function)));
            queueableBinaryWriter.Write(this.ScaleFunctionBy);
            queueableBinaryWriter.Write(((short)(this.WobbleFunction)));
            queueableBinaryWriter.Write(this.WobblePeriod);
            queueableBinaryWriter.Write(this.WobbleMagnitude);
            queueableBinaryWriter.Write(this.SquareWaveThreshold);
            queueableBinaryWriter.Write(this.StepCount);
            queueableBinaryWriter.Write(((short)(this.MapTo)));
            queueableBinaryWriter.Write(this.SawtoothCount);
            queueableBinaryWriter.Write(this.fieldpad);
            queueableBinaryWriter.Write(this.ScaleResultBy);
            queueableBinaryWriter.Write(((short)(this.BoundsMode)));
            queueableBinaryWriter.Write(this.Bounds);
            queueableBinaryWriter.Write(this.fieldpad0);
            queueableBinaryWriter.Write(this.fieldpad1);
            queueableBinaryWriter.Write(this.TurnOffWith);
            queueableBinaryWriter.Write(this.fieldpad2);
            queueableBinaryWriter.Write(this.fieldpad3);
        }
        [System.FlagsAttribute()]
        public enum Flags : int
        {
            None = 0,
            ScriptedLevelScriptWillSetThisValueOtherSettingsHereWillBeIgnored = 1,
            InvertResultOfFunctionIs1MinusActualResult = 2,
            Additive = 4,
            AlwaysActiveFunctionDoesNotDeactivateWhenAtOrBelowLowerBound = 8,
        }
        public enum FunctionEnum : short
        {
            One = 0,
            Zero = 1,
            Cosine = 2,
            CosinevariablePeriod = 3,
            DiagonalWave = 4,
            DiagonalWavevariablePeriod = 5,
            Slide = 6,
            SlidevariablePeriod = 7,
            Noise = 8,
            Jitter = 9,
            Wander = 10,
            Spark = 11,
        }
        public enum WobbleFunctionEnum : short
        {
            One = 0,
            Zero = 1,
            Cosine = 2,
            CosinevariablePeriod = 3,
            DiagonalWave = 4,
            DiagonalWavevariablePeriod = 5,
            Slide = 6,
            SlidevariablePeriod = 7,
            Noise = 8,
            Jitter = 9,
            Wander = 10,
            Spark = 11,
        }
        public enum MapToEnum : short
        {
            Linear = 0,
            Early = 1,
            VeryEarly = 2,
            Late = 3,
            VeryLate = 4,
            Cosine = 5,
            One = 6,
            Zero = 7,
        }
        public enum BoundsModeEnum : short
        {
            Clip = 0,
            ClipAndNormalize = 1,
            ScaleToFit = 2,
        }
    }
}
