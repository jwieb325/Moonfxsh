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
    [TagBlockOriginalNameAttribute("scenario_light_struct_block")]
    public partial class ScenarioLightStructBlock : GuerillaBlock, IWriteQueueable
    {
        public TypeEnum Type;
        public Flags ScenarioLightStructFlags;
        public LightmapTypeEnum LightmapType;
        public LightmapFlags ScenarioLightStructLightmapFlags;
        public float LightmapHalfLife;
        public float LightmapLightScale;
        public OpenTK.Vector3 TargetPoint;
        public float Width;
        public float HeightScale;
        public float FieldOfView;
        public float FalloffDistance;
        public float CutoffDistance;
        public override int SerializedSize
        {
            get
            {
                return 48;
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
            this.Type = ((TypeEnum)(binaryReader.ReadInt16()));
            this.ScenarioLightStructFlags = ((Flags)(binaryReader.ReadInt16()));
            this.LightmapType = ((LightmapTypeEnum)(binaryReader.ReadInt16()));
            this.ScenarioLightStructLightmapFlags = ((LightmapFlags)(binaryReader.ReadInt16()));
            this.LightmapHalfLife = binaryReader.ReadSingle();
            this.LightmapLightScale = binaryReader.ReadSingle();
            this.TargetPoint = binaryReader.ReadVector3();
            this.Width = binaryReader.ReadSingle();
            this.HeightScale = binaryReader.ReadSingle();
            this.FieldOfView = binaryReader.ReadSingle();
            this.FalloffDistance = binaryReader.ReadSingle();
            this.CutoffDistance = binaryReader.ReadSingle();
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
            queueableBinaryWriter.Write(((short)(this.Type)));
            queueableBinaryWriter.Write(((short)(this.ScenarioLightStructFlags)));
            queueableBinaryWriter.Write(((short)(this.LightmapType)));
            queueableBinaryWriter.Write(((short)(this.ScenarioLightStructLightmapFlags)));
            queueableBinaryWriter.Write(this.LightmapHalfLife);
            queueableBinaryWriter.Write(this.LightmapLightScale);
            queueableBinaryWriter.Write(this.TargetPoint);
            queueableBinaryWriter.Write(this.Width);
            queueableBinaryWriter.Write(this.HeightScale);
            queueableBinaryWriter.Write(this.FieldOfView);
            queueableBinaryWriter.Write(this.FalloffDistance);
            queueableBinaryWriter.Write(this.CutoffDistance);
        }
        public enum TypeEnum : short
        {
            Sphere = 0,
            Orthogonal = 1,
            Projective = 2,
            Pyramid = 3,
        }
        [System.FlagsAttribute()]
        public enum Flags : short
        {
            None = 0,
            CustomGeometry = 1,
            Unused = 2,
            CinematicOnly = 4,
        }
        public enum LightmapTypeEnum : short
        {
            UseLightTagSetting = 0,
            DynamicOnly = 1,
            DynamicWithLightmaps = 2,
            LightmapsOnly = 3,
        }
        [System.FlagsAttribute()]
        public enum LightmapFlags : short
        {
            None = 0,
            Unused = 1,
        }
    }
}
