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
    [TagClassAttribute("cont")]
    [TagBlockOriginalNameAttribute("contrail_block")]
    public partial class ContrailBlock : GuerillaBlock, IWriteQueueable
    {
        public Flags ContrailFlags;
        public ScaleFlags ContrailScaleFlags;
        public float PointGenerationRate;
        public Moonfish.Model.Range PointVelocity;
        public float PointVelocityConeAngle;
        public float InheritedVelocityFraction;
        public RenderTypeEnum RenderType;
        private byte[] fieldpad = new byte[2];
        public float TextureRepeatsU;
        public float TextureRepeatsV;
        public float TextureAnimationU;
        public float TextureAnimationV;
        public float AnimationRate;
        [Moonfish.Tags.TagReferenceAttribute("bitm")]
        public Moonfish.Tags.TagReference Bitmap;
        public short FirstSequenceIndex;
        public short SequenceCount;
        private byte[] fieldpad0 = new byte[40];
        public ShaderFlags ContrailShaderFlags;
        public FramebufferBlendFunctionEnum FramebufferBlendFunction;
        public FramebufferFadeModeEnum FramebufferFadeMode;
        public MapFlags ContrailMapFlags;
        private byte[] fieldpad1 = new byte[28];
        /// <summary>
        /// Optional multitextured second map
        /// </summary>
        [Moonfish.Tags.TagReferenceAttribute("bitm")]
        public Moonfish.Tags.TagReference Bitmap0;
        public AnchorEnum Anchor;
        public ContrailFlags0 ContrailContrailFlags0;
        private byte[] fieldpad2 = new byte[2];
        public UanimationFunctionEnum UanimationFunction;
        public float UanimationPeriod;
        public float UanimationPhase;
        public float UanimationScale;
        private byte[] fieldpad3 = new byte[2];
        public VanimationFunctionEnum VanimationFunction;
        public float VanimationPeriod;
        public float VanimationPhase;
        public float VanimationScale;
        private byte[] fieldpad4 = new byte[2];
        public RotationanimationFunctionEnum RotationanimationFunction;
        public float RotationanimationPeriod;
        public float RotationanimationPhase;
        public float RotationanimationScale;
        public OpenTK.Vector2 RotationanimationCenter;
        private byte[] fieldpad5 = new byte[4];
        public float ZspriteRadiusScale;
        private byte[] fieldpad6 = new byte[20];
        public ContrailPointStatesBlock[] PointStates = new ContrailPointStatesBlock[0];
        public override int SerializedSize
        {
            get
            {
                return 240;
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
            this.ContrailFlags = ((Flags)(binaryReader.ReadInt16()));
            this.ContrailScaleFlags = ((ScaleFlags)(binaryReader.ReadInt16()));
            this.PointGenerationRate = binaryReader.ReadSingle();
            this.PointVelocity = binaryReader.ReadRange();
            this.PointVelocityConeAngle = binaryReader.ReadSingle();
            this.InheritedVelocityFraction = binaryReader.ReadSingle();
            this.RenderType = ((RenderTypeEnum)(binaryReader.ReadInt16()));
            this.fieldpad = binaryReader.ReadBytes(2);
            this.TextureRepeatsU = binaryReader.ReadSingle();
            this.TextureRepeatsV = binaryReader.ReadSingle();
            this.TextureAnimationU = binaryReader.ReadSingle();
            this.TextureAnimationV = binaryReader.ReadSingle();
            this.AnimationRate = binaryReader.ReadSingle();
            this.Bitmap = binaryReader.ReadTagReference();
            this.FirstSequenceIndex = binaryReader.ReadInt16();
            this.SequenceCount = binaryReader.ReadInt16();
            this.fieldpad0 = binaryReader.ReadBytes(40);
            this.ContrailShaderFlags = ((ShaderFlags)(binaryReader.ReadInt16()));
            this.FramebufferBlendFunction = ((FramebufferBlendFunctionEnum)(binaryReader.ReadInt16()));
            this.FramebufferFadeMode = ((FramebufferFadeModeEnum)(binaryReader.ReadInt16()));
            this.ContrailMapFlags = ((MapFlags)(binaryReader.ReadInt16()));
            this.fieldpad1 = binaryReader.ReadBytes(28);
            this.Bitmap0 = binaryReader.ReadTagReference();
            this.Anchor = ((AnchorEnum)(binaryReader.ReadInt16()));
            this.ContrailContrailFlags0 = ((ContrailFlags0)(binaryReader.ReadInt16()));
            this.fieldpad2 = binaryReader.ReadBytes(2);
            this.UanimationFunction = ((UanimationFunctionEnum)(binaryReader.ReadInt16()));
            this.UanimationPeriod = binaryReader.ReadSingle();
            this.UanimationPhase = binaryReader.ReadSingle();
            this.UanimationScale = binaryReader.ReadSingle();
            this.fieldpad3 = binaryReader.ReadBytes(2);
            this.VanimationFunction = ((VanimationFunctionEnum)(binaryReader.ReadInt16()));
            this.VanimationPeriod = binaryReader.ReadSingle();
            this.VanimationPhase = binaryReader.ReadSingle();
            this.VanimationScale = binaryReader.ReadSingle();
            this.fieldpad4 = binaryReader.ReadBytes(2);
            this.RotationanimationFunction = ((RotationanimationFunctionEnum)(binaryReader.ReadInt16()));
            this.RotationanimationPeriod = binaryReader.ReadSingle();
            this.RotationanimationPhase = binaryReader.ReadSingle();
            this.RotationanimationScale = binaryReader.ReadSingle();
            this.RotationanimationCenter = binaryReader.ReadVector2();
            this.fieldpad5 = binaryReader.ReadBytes(4);
            this.ZspriteRadiusScale = binaryReader.ReadSingle();
            this.fieldpad6 = binaryReader.ReadBytes(20);
            pointerQueue.Enqueue(binaryReader.ReadBlamPointer(64));
            return pointerQueue;
        }
        public override void ReadInstances(Moonfish.Guerilla.BlamBinaryReader binaryReader, System.Collections.Generic.Queue<Moonfish.Tags.BlamPointer> pointerQueue)
        {
            base.ReadInstances(binaryReader, pointerQueue);
            this.PointStates = base.ReadBlockArrayData<ContrailPointStatesBlock>(binaryReader, pointerQueue.Dequeue());
        }
        public override void Defer(Moonfish.Guerilla.QueueableBlamBinaryWriter queueableBinaryWriter)
        {
            base.Defer(queueableBinaryWriter);
            queueableBinaryWriter.Defer(this.PointStates);
        }
        public override void Write(Moonfish.Guerilla.QueueableBlamBinaryWriter queueableBinaryWriter)
        {
            base.Write(queueableBinaryWriter);
            queueableBinaryWriter.Write(((short)(this.ContrailFlags)));
            queueableBinaryWriter.Write(((short)(this.ContrailScaleFlags)));
            queueableBinaryWriter.Write(this.PointGenerationRate);
            queueableBinaryWriter.Write(this.PointVelocity);
            queueableBinaryWriter.Write(this.PointVelocityConeAngle);
            queueableBinaryWriter.Write(this.InheritedVelocityFraction);
            queueableBinaryWriter.Write(((short)(this.RenderType)));
            queueableBinaryWriter.Write(this.fieldpad);
            queueableBinaryWriter.Write(this.TextureRepeatsU);
            queueableBinaryWriter.Write(this.TextureRepeatsV);
            queueableBinaryWriter.Write(this.TextureAnimationU);
            queueableBinaryWriter.Write(this.TextureAnimationV);
            queueableBinaryWriter.Write(this.AnimationRate);
            queueableBinaryWriter.Write(this.Bitmap);
            queueableBinaryWriter.Write(this.FirstSequenceIndex);
            queueableBinaryWriter.Write(this.SequenceCount);
            queueableBinaryWriter.Write(this.fieldpad0);
            queueableBinaryWriter.Write(((short)(this.ContrailShaderFlags)));
            queueableBinaryWriter.Write(((short)(this.FramebufferBlendFunction)));
            queueableBinaryWriter.Write(((short)(this.FramebufferFadeMode)));
            queueableBinaryWriter.Write(((short)(this.ContrailMapFlags)));
            queueableBinaryWriter.Write(this.fieldpad1);
            queueableBinaryWriter.Write(this.Bitmap0);
            queueableBinaryWriter.Write(((short)(this.Anchor)));
            queueableBinaryWriter.Write(((short)(this.ContrailContrailFlags0)));
            queueableBinaryWriter.Write(this.fieldpad2);
            queueableBinaryWriter.Write(((short)(this.UanimationFunction)));
            queueableBinaryWriter.Write(this.UanimationPeriod);
            queueableBinaryWriter.Write(this.UanimationPhase);
            queueableBinaryWriter.Write(this.UanimationScale);
            queueableBinaryWriter.Write(this.fieldpad3);
            queueableBinaryWriter.Write(((short)(this.VanimationFunction)));
            queueableBinaryWriter.Write(this.VanimationPeriod);
            queueableBinaryWriter.Write(this.VanimationPhase);
            queueableBinaryWriter.Write(this.VanimationScale);
            queueableBinaryWriter.Write(this.fieldpad4);
            queueableBinaryWriter.Write(((short)(this.RotationanimationFunction)));
            queueableBinaryWriter.Write(this.RotationanimationPeriod);
            queueableBinaryWriter.Write(this.RotationanimationPhase);
            queueableBinaryWriter.Write(this.RotationanimationScale);
            queueableBinaryWriter.Write(this.RotationanimationCenter);
            queueableBinaryWriter.Write(this.fieldpad5);
            queueableBinaryWriter.Write(this.ZspriteRadiusScale);
            queueableBinaryWriter.Write(this.fieldpad6);
            queueableBinaryWriter.WritePointer(this.PointStates);
        }
        [System.FlagsAttribute()]
        public enum Flags : short
        {
            None = 0,
            FirstPointUnfaded = 1,
            LastPointUnfaded = 2,
            PointsStartPinnedToMedia = 4,
            PointsStartPinnedToGround = 8,
            PointsAlwaysPinnedToMedia = 16,
            PointsAlwaysPinnedToGround = 32,
            EdgeEffectFadesSlowly = 64,
            DonttInheritObjectChangeColor = 128,
        }
        [System.FlagsAttribute()]
        public enum ScaleFlags : short
        {
            None = 0,
            PointGenerationRate = 1,
            PointVelocity = 2,
            PointVelocityDelta = 4,
            PointVelocityConeAngle = 8,
            InheritedVelocityFraction = 16,
            SequenceAnimationRate = 32,
            TextureScaleU = 64,
            TextureScaleV = 128,
            TextureAnimationU = 256,
            TextureAnimationV = 512,
        }
        public enum RenderTypeEnum : short
        {
            VerticalOrientation = 0,
            HorizontalOrientation = 1,
            MediaMapped = 2,
            GroundMapped = 3,
            ViewerFacing = 4,
            DoublemarkerLinked = 5,
        }
        [System.FlagsAttribute()]
        public enum ShaderFlags : short
        {
            None = 0,
            SortBias = 1,
            NonlinearTint = 2,
            DontOverdrawFpWeapon = 4,
        }
        public enum FramebufferBlendFunctionEnum : short
        {
            AlphaBlend = 0,
            Multiply = 1,
            DoubleMultiply = 2,
            Add = 3,
            Subtract = 4,
            ComponentMin = 5,
            ComponentMax = 6,
            AlphamultiplyAdd = 7,
            ConstantColorBlend = 8,
            InverseConstantColorBlend = 9,
            None = 10,
        }
        public enum FramebufferFadeModeEnum : short
        {
            None = 0,
            FadeWhenPerpendicular = 1,
            FadeWhenParallel = 2,
        }
        [System.FlagsAttribute()]
        public enum MapFlags : short
        {
            None = 0,
            Unfiltered = 1,
        }
        public enum AnchorEnum : short
        {
            WithPrimary = 0,
            WithScreenSpace = 1,
            Zsprite = 2,
        }
        [System.FlagsAttribute()]
        public enum ContrailFlags0 : short
        {
            None = 0,
            Unfiltered = 1,
        }
        public enum UanimationFunctionEnum : short
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
        public enum VanimationFunctionEnum : short
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
        public enum RotationanimationFunctionEnum : short
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
namespace Moonfish.Tags
{
    
    public partial struct TagClass
    {
        public static TagClass Cont = ((TagClass)("cont"));
    }
}
