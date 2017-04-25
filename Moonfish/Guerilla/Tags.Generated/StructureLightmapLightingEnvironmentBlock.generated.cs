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
    [TagBlockOriginalNameAttribute("structure_lightmap_lighting_environment_block")]
    public partial class StructureLightmapLightingEnvironmentBlock : GuerillaBlock, IWriteQueueable
    {
        public OpenTK.Vector3 SamplePoint;
        public RedCoefficientsBlock[] RedCoefficients00 = new RedCoefficientsBlock[9];
        public GreenCoefficientsBlock[] GreenCoefficients00 = new GreenCoefficientsBlock[9];
        public BlueCoefficientsBlock[] BlueCoefficients00 = new BlueCoefficientsBlock[9];
        public OpenTK.Vector3 MeanIncomingLightDirection;
        public OpenTK.Vector3 IncomingLightIntensity;
        public int SpecularBitmapIndex;
        public OpenTK.Vector3 RotationAxis;
        public float RotationSpeed;
        public OpenTK.Vector3 BumpDirection;
        public Moonfish.Tags.ColourR8G8B8 ColorTint;
        public ProceduralOverideEnum ProceduralOveride;
        public Flags StructureLightmapLightingEnvironmentFlags;
        public OpenTK.Vector3 ProceduralParam0;
        public OpenTK.Vector3 ProceduralParam1xyz;
        public float ProceduralParam1w;
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
            this.SamplePoint = binaryReader.ReadVector3();
            int i;
            for (i = 0; (i < 9); i = (i + 1))
            {
                this.RedCoefficients00[i] = new RedCoefficientsBlock();
                pointerQueue = new System.Collections.Generic.Queue<Moonfish.Tags.BlamPointer>(pointerQueue.Concat(this.RedCoefficients00[i].ReadFields(binaryReader)));
            }
            for (i = 0; (i < 9); i = (i + 1))
            {
                this.GreenCoefficients00[i] = new GreenCoefficientsBlock();
                pointerQueue = new System.Collections.Generic.Queue<Moonfish.Tags.BlamPointer>(pointerQueue.Concat(this.GreenCoefficients00[i].ReadFields(binaryReader)));
            }
            for (i = 0; (i < 9); i = (i + 1))
            {
                this.BlueCoefficients00[i] = new BlueCoefficientsBlock();
                pointerQueue = new System.Collections.Generic.Queue<Moonfish.Tags.BlamPointer>(pointerQueue.Concat(this.BlueCoefficients00[i].ReadFields(binaryReader)));
            }
            this.MeanIncomingLightDirection = binaryReader.ReadVector3();
            this.IncomingLightIntensity = binaryReader.ReadVector3();
            this.SpecularBitmapIndex = binaryReader.ReadInt32();
            this.RotationAxis = binaryReader.ReadVector3();
            this.RotationSpeed = binaryReader.ReadSingle();
            this.BumpDirection = binaryReader.ReadVector3();
            this.ColorTint = binaryReader.ReadColourR8G8B8();
            this.ProceduralOveride = ((ProceduralOverideEnum)(binaryReader.ReadInt16()));
            this.StructureLightmapLightingEnvironmentFlags = ((Flags)(binaryReader.ReadInt16()));
            this.ProceduralParam0 = binaryReader.ReadVector3();
            this.ProceduralParam1xyz = binaryReader.ReadVector3();
            this.ProceduralParam1w = binaryReader.ReadSingle();
            return pointerQueue;
        }
        public override void ReadInstances(Moonfish.Guerilla.BlamBinaryReader binaryReader, System.Collections.Generic.Queue<Moonfish.Tags.BlamPointer> pointerQueue)
        {
            base.ReadInstances(binaryReader, pointerQueue);
            int i;
            for (i = 0; (i < 9); i = (i + 1))
            {
                this.RedCoefficients00[i].ReadInstances(binaryReader, pointerQueue);
            }
            for (i = 0; (i < 9); i = (i + 1))
            {
                this.GreenCoefficients00[i].ReadInstances(binaryReader, pointerQueue);
            }
            for (i = 0; (i < 9); i = (i + 1))
            {
                this.BlueCoefficients00[i].ReadInstances(binaryReader, pointerQueue);
            }
        }
        public override void Defer(Moonfish.Guerilla.QueueableBlamBinaryWriter queueableBinaryWriter)
        {
            base.Defer(queueableBinaryWriter);
            int i;
            for (i = 0; (i < 9); i = (i + 1))
            {
                this.RedCoefficients00[i].Defer(queueableBinaryWriter);
            }
            for (i = 0; (i < 9); i = (i + 1))
            {
                this.GreenCoefficients00[i].Defer(queueableBinaryWriter);
            }
            for (i = 0; (i < 9); i = (i + 1))
            {
                this.BlueCoefficients00[i].Defer(queueableBinaryWriter);
            }
        }
        public override void Write(Moonfish.Guerilla.QueueableBlamBinaryWriter queueableBinaryWriter)
        {
            base.Write(queueableBinaryWriter);
            queueableBinaryWriter.Write(this.SamplePoint);
            int i;
            for (i = 0; (i < 9); i = (i + 1))
            {
                this.RedCoefficients00[i].Write(queueableBinaryWriter);
            }
            for (i = 0; (i < 9); i = (i + 1))
            {
                this.GreenCoefficients00[i].Write(queueableBinaryWriter);
            }
            for (i = 0; (i < 9); i = (i + 1))
            {
                this.BlueCoefficients00[i].Write(queueableBinaryWriter);
            }
            queueableBinaryWriter.Write(this.MeanIncomingLightDirection);
            queueableBinaryWriter.Write(this.IncomingLightIntensity);
            queueableBinaryWriter.Write(this.SpecularBitmapIndex);
            queueableBinaryWriter.Write(this.RotationAxis);
            queueableBinaryWriter.Write(this.RotationSpeed);
            queueableBinaryWriter.Write(this.BumpDirection);
            queueableBinaryWriter.Write(this.ColorTint);
            queueableBinaryWriter.Write(((short)(this.ProceduralOveride)));
            queueableBinaryWriter.Write(((short)(this.StructureLightmapLightingEnvironmentFlags)));
            queueableBinaryWriter.Write(this.ProceduralParam0);
            queueableBinaryWriter.Write(this.ProceduralParam1xyz);
            queueableBinaryWriter.Write(this.ProceduralParam1w);
        }
        [JetBrains.Annotations.UsedImplicitlyAttribute(ImplicitUseTargetFlags.WithMembers)]
        public class RedCoefficientsBlock : GuerillaBlock, IWriteQueueable
        {
            public float RedCoefficient;
            public override int SerializedSize
            {
                get
                {
                    return 4;
                }
            }
            public override int Alignment
            {
                get
                {
                    return 1;
                }
            }
            public override System.Collections.Generic.Queue<Moonfish.Tags.BlamPointer> ReadFields(Moonfish.Guerilla.BlamBinaryReader binaryReader)
            {
                System.Collections.Generic.Queue<Moonfish.Tags.BlamPointer> pointerQueue = new System.Collections.Generic.Queue<Moonfish.Tags.BlamPointer>(base.ReadFields(binaryReader));
                this.RedCoefficient = binaryReader.ReadSingle();
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
                queueableBinaryWriter.Write(this.RedCoefficient);
            }
        }
        [JetBrains.Annotations.UsedImplicitlyAttribute(ImplicitUseTargetFlags.WithMembers)]
        public class GreenCoefficientsBlock : GuerillaBlock, IWriteQueueable
        {
            public float GreenCoefficient;
            public override int SerializedSize
            {
                get
                {
                    return 4;
                }
            }
            public override int Alignment
            {
                get
                {
                    return 1;
                }
            }
            public override System.Collections.Generic.Queue<Moonfish.Tags.BlamPointer> ReadFields(Moonfish.Guerilla.BlamBinaryReader binaryReader)
            {
                System.Collections.Generic.Queue<Moonfish.Tags.BlamPointer> pointerQueue = new System.Collections.Generic.Queue<Moonfish.Tags.BlamPointer>(base.ReadFields(binaryReader));
                this.GreenCoefficient = binaryReader.ReadSingle();
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
                queueableBinaryWriter.Write(this.GreenCoefficient);
            }
        }
        [JetBrains.Annotations.UsedImplicitlyAttribute(ImplicitUseTargetFlags.WithMembers)]
        public class BlueCoefficientsBlock : GuerillaBlock, IWriteQueueable
        {
            public float BlueCoefficient;
            public override int SerializedSize
            {
                get
                {
                    return 4;
                }
            }
            public override int Alignment
            {
                get
                {
                    return 1;
                }
            }
            public override System.Collections.Generic.Queue<Moonfish.Tags.BlamPointer> ReadFields(Moonfish.Guerilla.BlamBinaryReader binaryReader)
            {
                System.Collections.Generic.Queue<Moonfish.Tags.BlamPointer> pointerQueue = new System.Collections.Generic.Queue<Moonfish.Tags.BlamPointer>(base.ReadFields(binaryReader));
                this.BlueCoefficient = binaryReader.ReadSingle();
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
                queueableBinaryWriter.Write(this.BlueCoefficient);
            }
        }
        public enum ProceduralOverideEnum : short
        {
            NoOveride = 0,
            CIEClearSky = 1,
            CIEPartlyCloudy = 2,
            CIECloudy = 3,
            DirectionalLight = 4,
            ConeLight = 5,
            SphereLight = 6,
            HemisphereLight = 7,
        }
        [System.FlagsAttribute()]
        public enum Flags : short
        {
            None = 0,
            LeaveMeAlonePlease = 1,
        }
    }
}
