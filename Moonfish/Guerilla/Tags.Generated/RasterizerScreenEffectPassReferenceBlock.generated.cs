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
    [TagBlockOriginalNameAttribute("rasterizer_screen_effect_pass_reference_block")]
    public partial class RasterizerScreenEffectPassReferenceBlock : GuerillaBlock, IWriteDeferrable
    {
        private byte[] Explanation;
        /// <summary>
        /// Used to control which shader pass implementations are used depending on whether the primary and/or secondary external inputs are greater than zero. An implementation of -1 will not draw anything.
        /// </summary>
        public short LayerPassIndex;
        private byte[] fieldpad = new byte[2];
        public byte Primary0AndSecondary0;
        public byte Primary0AndSecondary00;
        public byte Primary0AndSecondary01;
        public byte Primary0AndSecondary02;
        private byte[] fieldpad0 = new byte[64];
        public Stage0ModeEnum Stage0Mode;
        public Stage1ModeEnum Stage1Mode;
        public Stage2ModeEnum Stage2Mode;
        public Stage3ModeEnum Stage3Mode;
        public RasterizerScreenEffectTexcoordGenerationAdvancedControlBlock[] AdvancedControl = new RasterizerScreenEffectTexcoordGenerationAdvancedControlBlock[0];
        public TargetEnum Target;
        private byte[] fieldpad1 = new byte[2];
        private byte[] fieldpad2 = new byte[64];
        public RasterizerScreenEffectConvolutionBlock[] Convolution = new RasterizerScreenEffectConvolutionBlock[0];
        public override int SerializedSize
        {
            get
            {
                return 172;
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
            pointerQueue.Enqueue(binaryReader.ReadBlamPointer(1));
            this.LayerPassIndex = binaryReader.ReadInt16();
            this.fieldpad = binaryReader.ReadBytes(2);
            this.Primary0AndSecondary0 = binaryReader.ReadByte();
            this.Primary0AndSecondary00 = binaryReader.ReadByte();
            this.Primary0AndSecondary01 = binaryReader.ReadByte();
            this.Primary0AndSecondary02 = binaryReader.ReadByte();
            this.fieldpad0 = binaryReader.ReadBytes(64);
            this.Stage0Mode = ((Stage0ModeEnum)(binaryReader.ReadInt16()));
            this.Stage1Mode = ((Stage1ModeEnum)(binaryReader.ReadInt16()));
            this.Stage2Mode = ((Stage2ModeEnum)(binaryReader.ReadInt16()));
            this.Stage3Mode = ((Stage3ModeEnum)(binaryReader.ReadInt16()));
            pointerQueue.Enqueue(binaryReader.ReadBlamPointer(72));
            this.Target = ((TargetEnum)(binaryReader.ReadInt16()));
            this.fieldpad1 = binaryReader.ReadBytes(2);
            this.fieldpad2 = binaryReader.ReadBytes(64);
            pointerQueue.Enqueue(binaryReader.ReadBlamPointer(92));
            return pointerQueue;
        }
        public override void ReadInstances(Moonfish.Guerilla.BlamBinaryReader binaryReader, System.Collections.Generic.Queue<Moonfish.Tags.BlamPointer> pointerQueue)
        {
            base.ReadInstances(binaryReader, pointerQueue);
            this.Explanation = base.ReadDataByteArray(binaryReader, pointerQueue.Dequeue());
            this.AdvancedControl = base.ReadBlockArrayData<RasterizerScreenEffectTexcoordGenerationAdvancedControlBlock>(binaryReader, pointerQueue.Dequeue());
            this.Convolution = base.ReadBlockArrayData<RasterizerScreenEffectConvolutionBlock>(binaryReader, pointerQueue.Dequeue());
        }
        public override void DeferReferences(Moonfish.Guerilla.LinearBinaryWriter writer)
        {
            base.DeferReferences(writer);
            writer.Defer(this.Explanation);
            writer.Defer(this.AdvancedControl);
            writer.Defer(this.Convolution);
        }
        public override void Write(Moonfish.Guerilla.LinearBinaryWriter writer)
        {
            base.Write(writer);
            writer.WritePointer(this.Explanation);
            writer.Write(this.LayerPassIndex);
            writer.Write(this.fieldpad);
            writer.Write(this.Primary0AndSecondary0);
            writer.Write(this.Primary0AndSecondary00);
            writer.Write(this.Primary0AndSecondary01);
            writer.Write(this.Primary0AndSecondary02);
            writer.Write(this.fieldpad0);
            writer.Write(((short)(this.Stage0Mode)));
            writer.Write(((short)(this.Stage1Mode)));
            writer.Write(((short)(this.Stage2Mode)));
            writer.Write(((short)(this.Stage3Mode)));
            writer.WritePointer(this.AdvancedControl);
            writer.Write(((short)(this.Target)));
            writer.Write(this.fieldpad1);
            writer.Write(this.fieldpad2);
            writer.WritePointer(this.Convolution);
        }
        /// <summary>
        /// DEFAULT: Use for mask bitmaps that are mirrored and offset through the texcoords supplied to the screen effect (e.g. through the weapon HUD interface). The shader system must handle scaling.
        /// </summary>
        public enum Stage0ModeEnum : short
        {
            /// <summary>
            ///  VIEWPORT NORMALIZED: Use when copying from texaccum or some other buffer or when applying a texture that is not an interface mask (e.g. another kind of mask, a noise map, etc. which is not mirrored or offset through the weapon HUD interface). Texture coordinates will range from [0,1][0,1] within the viewport, and the shader system must handle scaling if the bitmap is a linear target or an interface bitmap.
            /// 
            /// 
            /// </summary>
            Default = 0,
            /// <summary>
            ///  VIEWPORT RELATIVE: Should not be used! This mode was necessary before we had he ability for the shader system to scale by texture resolution. Texture coordinates will range from [0,viewport_size_x][0,viewport_size_y] within the viewport.
            /// 
            /// 
            /// </summary>
            ViewportNormalized = 1,
            /// <summary>
            ///  FRAMEBUFFER RELATIVE: Use when copying from the framebuffer. Texture coordinates will range from [viewport_bounds.x0,viewport_bounds.x1][viewport_bounds.y0,viewport_bounds.y1] within the viewport. Let the shader system assume normalized [0,1] coordinate range.
            /// 
            /// 
            /// </summary>
            ViewportRelative = 2,
            /// <summary>
            ///  ZERO: Use when doing dependent-z reads. Texture coordinates will be zero before applying offset (in advanced control block). Offset should be {1/(z_max-z_min), 0, -z_min/(z_max-z_min), 0} where z_min and z_max are in world units, and the "xy scaled by z_far" flag should be checked.
            /// </summary>
            FramebufferRelative = 3,
            Zero = 4,
        }
        public enum Stage1ModeEnum : short
        {
            Default = 0,
            ViewportNormalized = 1,
            ViewportRelative = 2,
            FramebufferRelative = 3,
            Zero = 4,
        }
        public enum Stage2ModeEnum : short
        {
            Default = 0,
            ViewportNormalized = 1,
            ViewportRelative = 2,
            FramebufferRelative = 3,
            Zero = 4,
        }
        public enum Stage3ModeEnum : short
        {
            Default = 0,
            ViewportNormalized = 1,
            ViewportRelative = 2,
            FramebufferRelative = 3,
            Zero = 4,
        }
        public enum TargetEnum : short
        {
            Framebuffer = 0,
            Texaccum = 1,
            TexaccumSmall = 2,
            TexaccumTiny = 3,
            CopyFbToTexaccum = 4,
        }
    }
}
