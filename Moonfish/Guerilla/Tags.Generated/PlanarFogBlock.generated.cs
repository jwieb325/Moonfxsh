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
    
    [TagClassAttribute("fog ")]
    public partial class PlanarFogBlock : GuerillaBlock, IWriteQueueable
    {
        public Flags PlanarFogFlags;
        public short Priority;
        public Moonfish.Tags.StringIdent GlobalMaterialName;
        private byte[] fieldpad = new byte[2];
        private byte[] fieldpad0 = new byte[2];
        public float MaximumDensity;
        public float OpaqueDistance;
        public float OpaqueDepth;
        public Moonfish.Model.Range AtmosphericplanarDepth;
        public float EyeOffsetScale;
        public Moonfish.Tags.ColourR8G8B8 Color;
        public PlanarFogPatchyFogBlock[] PatchyFog = new PlanarFogPatchyFogBlock[0];
        [Moonfish.Tags.TagReferenceAttribute("lsnd")]
        public Moonfish.Tags.TagReference BackgroundSound;
        [Moonfish.Tags.TagReferenceAttribute("snde")]
        public Moonfish.Tags.TagReference SoundEnvironment;
        public float EnvironmentDampingFactor;
        public float BackgroundSoundGain;
        [Moonfish.Tags.TagReferenceAttribute("snd!")]
        public Moonfish.Tags.TagReference EnterSound;
        [Moonfish.Tags.TagReferenceAttribute("snd!")]
        public Moonfish.Tags.TagReference ExitSound;
        public override int SerializedSize
        {
            get
            {
                return 96;
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
            this.PlanarFogFlags = ((Flags)(binaryReader.ReadInt16()));
            this.Priority = binaryReader.ReadInt16();
            this.GlobalMaterialName = binaryReader.ReadStringID();
            this.fieldpad = binaryReader.ReadBytes(2);
            this.fieldpad0 = binaryReader.ReadBytes(2);
            this.MaximumDensity = binaryReader.ReadSingle();
            this.OpaqueDistance = binaryReader.ReadSingle();
            this.OpaqueDepth = binaryReader.ReadSingle();
            this.AtmosphericplanarDepth = binaryReader.ReadRange();
            this.EyeOffsetScale = binaryReader.ReadSingle();
            this.Color = binaryReader.ReadColorR8G8B8();
            pointerQueue.Enqueue(binaryReader.ReadBlamPointer(52));
            this.BackgroundSound = binaryReader.ReadTagReference();
            this.SoundEnvironment = binaryReader.ReadTagReference();
            this.EnvironmentDampingFactor = binaryReader.ReadSingle();
            this.BackgroundSoundGain = binaryReader.ReadSingle();
            this.EnterSound = binaryReader.ReadTagReference();
            this.ExitSound = binaryReader.ReadTagReference();
            return pointerQueue;
        }
        public override void ReadInstances(System.IO.BinaryReader binaryReader, System.Collections.Generic.Queue<Moonfish.Tags.BlamPointer> pointerQueue)
        {
            base.ReadInstances(binaryReader, pointerQueue);
            this.PatchyFog = base.ReadBlockArrayData<PlanarFogPatchyFogBlock>(binaryReader, pointerQueue.Dequeue());
        }
        public override void QueueWrites(Moonfish.Guerilla.QueueableBinaryWriter queueableBinaryWriter)
        {
            base.QueueWrites(queueableBinaryWriter);
            queueableBinaryWriter.QueueWrite(this.PatchyFog);
        }
        public override void Write_(Moonfish.Guerilla.QueueableBinaryWriter queueableBinaryWriter)
        {
            base.Write_(queueableBinaryWriter);
            queueableBinaryWriter.Write(((short)(this.PlanarFogFlags)));
            queueableBinaryWriter.Write(this.Priority);
            queueableBinaryWriter.Write(this.GlobalMaterialName);
            queueableBinaryWriter.Write(this.fieldpad);
            queueableBinaryWriter.Write(this.fieldpad0);
            queueableBinaryWriter.Write(this.MaximumDensity);
            queueableBinaryWriter.Write(this.OpaqueDistance);
            queueableBinaryWriter.Write(this.OpaqueDepth);
            queueableBinaryWriter.Write(this.AtmosphericplanarDepth);
            queueableBinaryWriter.Write(this.EyeOffsetScale);
            queueableBinaryWriter.Write(this.Color);
            queueableBinaryWriter.WritePointer(this.PatchyFog);
            queueableBinaryWriter.Write(this.BackgroundSound);
            queueableBinaryWriter.Write(this.SoundEnvironment);
            queueableBinaryWriter.Write(this.EnvironmentDampingFactor);
            queueableBinaryWriter.Write(this.BackgroundSoundGain);
            queueableBinaryWriter.Write(this.EnterSound);
            queueableBinaryWriter.Write(this.ExitSound);
        }
        /// <summary>
        /// Please don't use these flags unless you know what you're doing! Come talk to Bernie first.
        /// </summary>
        [System.FlagsAttribute()]
        public enum Flags : short
        {
            None = 0,
            RenderOnlySubmergedGeometry = 1,
            ExtendInfinitelyWhileVisible = 2,
            DontFloodfill = 4,
            AggressiveFloodfill = 8,
            DoNotRender = 16,
            DoNotRenderUnlessSubmerged = 32,
        }
    }
}
namespace Moonfish.Tags
{
    
    public partial struct TagClass
    {
        public static TagClass Fog = ((TagClass)("fog "));
    }
}
