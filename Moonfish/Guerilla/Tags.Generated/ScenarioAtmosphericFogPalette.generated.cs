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
    [TagBlockOriginalNameAttribute("scenario_atmospheric_fog_palette")]
    public partial class ScenarioAtmosphericFogPalette : GuerillaBlock, IWriteQueueable
    {
        public Moonfish.Tags.StringIdent Name;
        /// <summary>
        /// EMPTY STRING
        /// </summary>
        public Moonfish.Tags.ColourR8G8B8 Color;
        public float SpreadDistance;
        private byte[] fieldpad = new byte[4];
        public float MaximumDensity;
        public float StartDistance;
        public float OpaqueDistance;
        /// <summary>
        /// EMPTY STRING
        /// </summary>
        public Moonfish.Tags.ColourR8G8B8 Color0;
        private byte[] fieldpad0 = new byte[4];
        public float MaximumDensity0;
        public float StartDistance0;
        public float OpaqueDistance0;
        private byte[] fieldpad1 = new byte[4];
        /// <summary>
        /// Planar fog, if present, is interpolated toward these values.
        /// </summary>
        public Moonfish.Tags.ColourR8G8B8 PlanarColor;
        public float PlanarMaxDensity;
        public float PlanarOverrideAmount;
        public float PlanarMinDistanceBias;
        private byte[] fieldpad2 = new byte[44];
        /// <summary>
        /// EMPTY STRING
        /// </summary>
        public Moonfish.Tags.ColourR8G8B8 PatchyColor;
        private byte[] fieldpad3 = new byte[12];
        public OpenTK.Vector2 PatchyDensity;
        public Moonfish.Model.Range PatchyDistance;
        private byte[] fieldpad4 = new byte[32];
        [Moonfish.Tags.TagReferenceAttribute("fpch")]
        public Moonfish.Tags.TagReference PatchyFog;
        public ScenarioAtmosphericFogMixerBlock[] Mixers = new ScenarioAtmosphericFogMixerBlock[0];
        /// <summary>
        /// EMPTY STRING
        /// </summary>
        public float Amount;
        public float Threshold;
        public float Brightness;
        public float GammaPower;
        public CameraImmersionFlags ScenarioAtmosphericFogPaletteCameraImmersionFlags;
        private byte[] fieldpad5 = new byte[2];
        public override int SerializedSize
        {
            get
            {
                return 244;
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
            this.Name = binaryReader.ReadStringIdent();
            this.Color = binaryReader.ReadColourR8G8B8();
            this.SpreadDistance = binaryReader.ReadSingle();
            this.fieldpad = binaryReader.ReadBytes(4);
            this.MaximumDensity = binaryReader.ReadSingle();
            this.StartDistance = binaryReader.ReadSingle();
            this.OpaqueDistance = binaryReader.ReadSingle();
            this.Color0 = binaryReader.ReadColourR8G8B8();
            this.fieldpad0 = binaryReader.ReadBytes(4);
            this.MaximumDensity0 = binaryReader.ReadSingle();
            this.StartDistance0 = binaryReader.ReadSingle();
            this.OpaqueDistance0 = binaryReader.ReadSingle();
            this.fieldpad1 = binaryReader.ReadBytes(4);
            this.PlanarColor = binaryReader.ReadColourR8G8B8();
            this.PlanarMaxDensity = binaryReader.ReadSingle();
            this.PlanarOverrideAmount = binaryReader.ReadSingle();
            this.PlanarMinDistanceBias = binaryReader.ReadSingle();
            this.fieldpad2 = binaryReader.ReadBytes(44);
            this.PatchyColor = binaryReader.ReadColourR8G8B8();
            this.fieldpad3 = binaryReader.ReadBytes(12);
            this.PatchyDensity = binaryReader.ReadVector2();
            this.PatchyDistance = binaryReader.ReadRange();
            this.fieldpad4 = binaryReader.ReadBytes(32);
            this.PatchyFog = binaryReader.ReadTagReference();
            pointerQueue.Enqueue(binaryReader.ReadBlamPointer(16));
            this.Amount = binaryReader.ReadSingle();
            this.Threshold = binaryReader.ReadSingle();
            this.Brightness = binaryReader.ReadSingle();
            this.GammaPower = binaryReader.ReadSingle();
            this.ScenarioAtmosphericFogPaletteCameraImmersionFlags = ((CameraImmersionFlags)(binaryReader.ReadInt16()));
            this.fieldpad5 = binaryReader.ReadBytes(2);
            return pointerQueue;
        }
        public override void ReadInstances(Moonfish.Guerilla.BlamBinaryReader binaryReader, System.Collections.Generic.Queue<Moonfish.Tags.BlamPointer> pointerQueue)
        {
            base.ReadInstances(binaryReader, pointerQueue);
            this.Mixers = base.ReadBlockArrayData<ScenarioAtmosphericFogMixerBlock>(binaryReader, pointerQueue.Dequeue());
        }
        public override void Defer(Moonfish.Guerilla.QueueableBlamBinaryWriter queueableBinaryWriter)
        {
            base.Defer(queueableBinaryWriter);
            queueableBinaryWriter.Defer(this.Mixers);
        }
        public override void Write(Moonfish.Guerilla.QueueableBlamBinaryWriter queueableBinaryWriter)
        {
            base.Write(queueableBinaryWriter);
            queueableBinaryWriter.Write(this.Name);
            queueableBinaryWriter.Write(this.Color);
            queueableBinaryWriter.Write(this.SpreadDistance);
            queueableBinaryWriter.Write(this.fieldpad);
            queueableBinaryWriter.Write(this.MaximumDensity);
            queueableBinaryWriter.Write(this.StartDistance);
            queueableBinaryWriter.Write(this.OpaqueDistance);
            queueableBinaryWriter.Write(this.Color0);
            queueableBinaryWriter.Write(this.fieldpad0);
            queueableBinaryWriter.Write(this.MaximumDensity0);
            queueableBinaryWriter.Write(this.StartDistance0);
            queueableBinaryWriter.Write(this.OpaqueDistance0);
            queueableBinaryWriter.Write(this.fieldpad1);
            queueableBinaryWriter.Write(this.PlanarColor);
            queueableBinaryWriter.Write(this.PlanarMaxDensity);
            queueableBinaryWriter.Write(this.PlanarOverrideAmount);
            queueableBinaryWriter.Write(this.PlanarMinDistanceBias);
            queueableBinaryWriter.Write(this.fieldpad2);
            queueableBinaryWriter.Write(this.PatchyColor);
            queueableBinaryWriter.Write(this.fieldpad3);
            queueableBinaryWriter.Write(this.PatchyDensity);
            queueableBinaryWriter.Write(this.PatchyDistance);
            queueableBinaryWriter.Write(this.fieldpad4);
            queueableBinaryWriter.Write(this.PatchyFog);
            queueableBinaryWriter.WritePointer(this.Mixers);
            queueableBinaryWriter.Write(this.Amount);
            queueableBinaryWriter.Write(this.Threshold);
            queueableBinaryWriter.Write(this.Brightness);
            queueableBinaryWriter.Write(this.GammaPower);
            queueableBinaryWriter.Write(((short)(this.ScenarioAtmosphericFogPaletteCameraImmersionFlags)));
            queueableBinaryWriter.Write(this.fieldpad5);
        }
        /// <summary>
        /// EMPTY STRING
        /// </summary>
        [System.FlagsAttribute()]
        public enum CameraImmersionFlags : short
        {
            None = 0,
            DisableAtmosphericFog = 1,
            DisableSecondaryFog = 2,
            DisablePlanarFog = 4,
            InvertPlanarFogPriorities = 8,
            DisableWater = 16,
        }
    }
}
