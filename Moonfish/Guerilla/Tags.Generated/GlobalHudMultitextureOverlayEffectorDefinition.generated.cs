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
    [TagBlockOriginalNameAttribute("global_hud_multitexture_overlay_effector_definition")]
    public partial class GlobalHudMultitextureOverlayEffectorDefinition : GuerillaBlock, IWriteQueueable
    {
        private byte[] fieldpad = new byte[64];
        public DestinationTypeEnum DestinationType;
        public DestinationEnum Destination;
        public SourceEnum Source;
        private byte[] fieldpad0 = new byte[2];
        /// <summary>
        /// When the source is at the lower inbound, the destination ends up the lower outbound and vice-versa applies for the upper values.
        /// </summary>
        public Moonfish.Model.Range InBounds;
        public Moonfish.Model.Range OutBounds;
        private byte[] fieldpad1 = new byte[64];
        /// <summary>
        /// If destination is tint, these values are used instead of the out bounds.
        /// </summary>
        public Moonfish.Tags.ColourR8G8B8 TintColorLowerBound;
        public Moonfish.Tags.ColourR8G8B8 TintColorUpperBound;
        public PeriodicFunctionEnum PeriodicFunction;
        private byte[] fieldpad2 = new byte[2];
        public float FunctionPeriod;
        public float FunctionPhase;
        private byte[] fieldpad3 = new byte[32];
        public override int SerializedSize
        {
            get
            {
                return 220;
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
            this.fieldpad = binaryReader.ReadBytes(64);
            this.DestinationType = ((DestinationTypeEnum)(binaryReader.ReadInt16()));
            this.Destination = ((DestinationEnum)(binaryReader.ReadInt16()));
            this.Source = ((SourceEnum)(binaryReader.ReadInt16()));
            this.fieldpad0 = binaryReader.ReadBytes(2);
            this.InBounds = binaryReader.ReadRange();
            this.OutBounds = binaryReader.ReadRange();
            this.fieldpad1 = binaryReader.ReadBytes(64);
            this.TintColorLowerBound = binaryReader.ReadColourR8G8B8();
            this.TintColorUpperBound = binaryReader.ReadColourR8G8B8();
            this.PeriodicFunction = ((PeriodicFunctionEnum)(binaryReader.ReadInt16()));
            this.fieldpad2 = binaryReader.ReadBytes(2);
            this.FunctionPeriod = binaryReader.ReadSingle();
            this.FunctionPhase = binaryReader.ReadSingle();
            this.fieldpad3 = binaryReader.ReadBytes(32);
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
            queueableBinaryWriter.Write(this.fieldpad);
            queueableBinaryWriter.Write(((short)(this.DestinationType)));
            queueableBinaryWriter.Write(((short)(this.Destination)));
            queueableBinaryWriter.Write(((short)(this.Source)));
            queueableBinaryWriter.Write(this.fieldpad0);
            queueableBinaryWriter.Write(this.InBounds);
            queueableBinaryWriter.Write(this.OutBounds);
            queueableBinaryWriter.Write(this.fieldpad1);
            queueableBinaryWriter.Write(this.TintColorLowerBound);
            queueableBinaryWriter.Write(this.TintColorUpperBound);
            queueableBinaryWriter.Write(((short)(this.PeriodicFunction)));
            queueableBinaryWriter.Write(this.fieldpad2);
            queueableBinaryWriter.Write(this.FunctionPeriod);
            queueableBinaryWriter.Write(this.FunctionPhase);
            queueableBinaryWriter.Write(this.fieldpad3);
        }
        /// <summary>
        /// These describe the relationship that causes the effect.
        /// </summary>
        public enum DestinationTypeEnum : short
        {
            /// <summary>
            ///  destination type is the type of variable you want to be effected
            /// 
            /// </summary>
            Tint01 = 0,
            /// <summary>
            ///  destination tells which texture map (or geometry offset) to apply it to
            /// 
            /// </summary>
            HorizontalOffset = 1,
            /// <summary>
            ///  source says which value to look at when computing the effect
            /// </summary>
            VerticalOffset = 2,
            Fade01 = 3,
        }
        public enum DestinationEnum : short
        {
            GeometryOffset = 0,
            PrimaryMap = 1,
            SecondaryMap = 2,
            TertiaryMap = 3,
        }
        public enum SourceEnum : short
        {
            PlayerPitch = 0,
            PlayerPitchTangent = 1,
            PlayerYaw = 2,
            WeaponRoundsloaded = 3,
            WeaponRoundsinventory = 4,
            WeaponHeat = 5,
            ExplicitusesLowBound = 6,
            WeaponZoomLevel = 7,
        }
        /// <summary>
        /// If you use a periodic function as the source, this lets you tweak it.
        /// </summary>
        public enum PeriodicFunctionEnum : short
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
    }
}
