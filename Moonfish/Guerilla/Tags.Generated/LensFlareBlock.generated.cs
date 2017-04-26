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
    using Moonfish.Guerilla;
    using System.IO;
    using System.Collections.Generic;
    using System.Linq;
    
    [JetBrains.Annotations.UsedImplicitlyAttribute(ImplicitUseTargetFlags.WithMembers)]
    [TagClassAttribute("lens")]
    [TagBlockOriginalNameAttribute("lens_flare_block")]
    public partial class LensFlareBlock : GuerillaBlock, IWriteDeferrable
    {
        public float FalloffAngle;
        public float CutoffAngle;
        private byte[] fieldskip = new byte[4];
        private byte[] fieldskip0 = new byte[4];
        /// <summary>
        /// Occlusion factor affects overall lens flare brightness and can also affect scale. Occlusion never affects rotation.
        /// </summary>
        public float OcclusionRadius;
        public OcclusionOffsetDirectionEnum OcclusionOffsetDirection;
        public OcclusionInnerRadiusScaleEnum OcclusionInnerRadiusScale;
        public float NearFadeDistance;
        public float FarFadeDistance;
        [Moonfish.Tags.TagReferenceAttribute("bitm")]
        public Moonfish.Tags.TagReference Bitmap;
        public Flags LensFlareFlags;
        private byte[] fieldskip1 = new byte[2];
        public RotationFunctionEnum RotationFunction;
        private byte[] fieldpad = new byte[2];
        public float RotationFunctionScale;
        public OpenTK.Vector2 CoronaScale;
        public FalloffFunctionEnum FalloffFunction;
        private byte[] fieldpad0 = new byte[2];
        public LensFlareReflectionBlock[] Reflections = new LensFlareReflectionBlock[0];
        public LensFlareFlags0 LensFlareLensFlareFlags0;
        private byte[] fieldpad1 = new byte[2];
        public LensFlareScalarAnimationBlock[] Brightness = new LensFlareScalarAnimationBlock[0];
        public LensFlareColorAnimationBlock[] Color = new LensFlareColorAnimationBlock[0];
        public LensFlareScalarAnimationBlock[] Rotation = new LensFlareScalarAnimationBlock[0];
        public override int SerializedSize
        {
            get
            {
                return 100;
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
            this.FalloffAngle = binaryReader.ReadSingle();
            this.CutoffAngle = binaryReader.ReadSingle();
            this.fieldskip = binaryReader.ReadBytes(4);
            this.fieldskip0 = binaryReader.ReadBytes(4);
            this.OcclusionRadius = binaryReader.ReadSingle();
            this.OcclusionOffsetDirection = ((OcclusionOffsetDirectionEnum)(binaryReader.ReadInt16()));
            this.OcclusionInnerRadiusScale = ((OcclusionInnerRadiusScaleEnum)(binaryReader.ReadInt16()));
            this.NearFadeDistance = binaryReader.ReadSingle();
            this.FarFadeDistance = binaryReader.ReadSingle();
            this.Bitmap = binaryReader.ReadTagReference();
            this.LensFlareFlags = ((Flags)(binaryReader.ReadInt16()));
            this.fieldskip1 = binaryReader.ReadBytes(2);
            this.RotationFunction = ((RotationFunctionEnum)(binaryReader.ReadInt16()));
            this.fieldpad = binaryReader.ReadBytes(2);
            this.RotationFunctionScale = binaryReader.ReadSingle();
            this.CoronaScale = binaryReader.ReadVector2();
            this.FalloffFunction = ((FalloffFunctionEnum)(binaryReader.ReadInt16()));
            this.fieldpad0 = binaryReader.ReadBytes(2);
            pointerQueue.Enqueue(binaryReader.ReadBlamPointer(48));
            this.LensFlareLensFlareFlags0 = ((LensFlareFlags0)(binaryReader.ReadInt16()));
            this.fieldpad1 = binaryReader.ReadBytes(2);
            pointerQueue.Enqueue(binaryReader.ReadBlamPointer(8));
            pointerQueue.Enqueue(binaryReader.ReadBlamPointer(8));
            pointerQueue.Enqueue(binaryReader.ReadBlamPointer(8));
            return pointerQueue;
        }
        public override void ReadInstances(Moonfish.Guerilla.BlamBinaryReader binaryReader, System.Collections.Generic.Queue<Moonfish.Tags.BlamPointer> pointerQueue)
        {
            base.ReadInstances(binaryReader, pointerQueue);
            this.Reflections = base.ReadBlockArrayData<LensFlareReflectionBlock>(binaryReader, pointerQueue.Dequeue());
            this.Brightness = base.ReadBlockArrayData<LensFlareScalarAnimationBlock>(binaryReader, pointerQueue.Dequeue());
            this.Color = base.ReadBlockArrayData<LensFlareColorAnimationBlock>(binaryReader, pointerQueue.Dequeue());
            this.Rotation = base.ReadBlockArrayData<LensFlareScalarAnimationBlock>(binaryReader, pointerQueue.Dequeue());
        }
        public override void DeferReferences(Moonfish.Guerilla.LinearBinaryWriter writer)
        {
            base.DeferReferences(writer);
            writer.Defer(this.Reflections);
            writer.Defer(this.Brightness);
            writer.Defer(this.Color);
            writer.Defer(this.Rotation);
        }
        public override void Write(Moonfish.Guerilla.LinearBinaryWriter writer)
        {
            base.Write(writer);
            writer.Write(this.FalloffAngle);
            writer.Write(this.CutoffAngle);
            writer.Write(this.fieldskip);
            writer.Write(this.fieldskip0);
            writer.Write(this.OcclusionRadius);
            writer.Write(((short)(this.OcclusionOffsetDirection)));
            writer.Write(((short)(this.OcclusionInnerRadiusScale)));
            writer.Write(this.NearFadeDistance);
            writer.Write(this.FarFadeDistance);
            writer.Write(this.Bitmap);
            writer.Write(((short)(this.LensFlareFlags)));
            writer.Write(this.fieldskip1);
            writer.Write(((short)(this.RotationFunction)));
            writer.Write(this.fieldpad);
            writer.Write(this.RotationFunctionScale);
            writer.Write(this.CoronaScale);
            writer.Write(((short)(this.FalloffFunction)));
            writer.Write(this.fieldpad0);
            writer.WritePointer(this.Reflections);
            writer.Write(((short)(this.LensFlareLensFlareFlags0)));
            writer.Write(this.fieldpad1);
            writer.WritePointer(this.Brightness);
            writer.WritePointer(this.Color);
            writer.WritePointer(this.Rotation);
        }
        public enum OcclusionOffsetDirectionEnum : short
        {
            TowardViewer = 0,
            MarkerForward = 1,
            None = 2,
        }
        public enum OcclusionInnerRadiusScaleEnum : short
        {
            None = 0,
            _12 = 1,
            _14 = 2,
            _18 = 3,
            _116 = 4,
            _132 = 5,
            _164 = 6,
        }
        [System.FlagsAttribute()]
        public enum Flags : short
        {
            None = 0,
            Sun = 1,
            NoOcclusionTest = 2,
            OnlyRenderInFirstPerson = 4,
            OnlyRenderInThirdPerson = 8,
            FadeInMoreQuickly = 16,
            FadeOutMoreQuickly = 32,
            ScaleByMarker = 64,
        }
        public enum RotationFunctionEnum : short
        {
            None = 0,
            RotationA = 1,
            RotationB = 2,
            Rotationtranslation = 3,
            Translation = 4,
        }
        /// <summary>
        /// Only affects lens flares created by effects.
        /// </summary>
        public enum FalloffFunctionEnum : short
        {
            Linear = 0,
            Late = 1,
            VeryLate = 2,
            Early = 3,
            VeryEarly = 4,
            Cosine = 5,
            Zero = 6,
            One = 7,
        }
        [System.FlagsAttribute()]
        public enum LensFlareFlags0 : short
        {
            None = 0,
            Synchronized = 1,
        }
    }
}
namespace Moonfish.Tags
{
    
    public partial struct TagClass
    {
        public static TagClass Lens = ((TagClass)("lens"));
    }
}
