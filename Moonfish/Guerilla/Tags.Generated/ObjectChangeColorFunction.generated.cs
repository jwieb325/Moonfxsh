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
    [TagBlockOriginalNameAttribute("object_change_color_function")]
    public partial class ObjectChangeColorFunction : GuerillaBlock, IWriteDeferrable
    {
        private byte[] fieldpad = new byte[4];
        public ScaleFlags ObjectChangeColorFunctionScaleFlags;
        public Moonfish.Tags.ColourR8G8B8 ColorLowerBound;
        public Moonfish.Tags.ColourR8G8B8 ColorUpperBound;
        public Moonfish.Tags.StringIdent DarkenBy;
        public Moonfish.Tags.StringIdent ScaleBy;
        public override int SerializedSize
        {
            get
            {
                return 40;
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
            this.fieldpad = binaryReader.ReadBytes(4);
            this.ObjectChangeColorFunctionScaleFlags = ((ScaleFlags)(binaryReader.ReadInt32()));
            this.ColorLowerBound = binaryReader.ReadColourR8G8B8();
            this.ColorUpperBound = binaryReader.ReadColourR8G8B8();
            this.DarkenBy = binaryReader.ReadStringIdent();
            this.ScaleBy = binaryReader.ReadStringIdent();
            return pointerQueue;
        }
        public override void ReadInstances(Moonfish.Guerilla.BlamBinaryReader binaryReader, System.Collections.Generic.Queue<Moonfish.Tags.BlamPointer> pointerQueue)
        {
            base.ReadInstances(binaryReader, pointerQueue);
        }
        public override void DeferReferences(Moonfish.Guerilla.LinearBinaryWriter writer)
        {
            base.DeferReferences(writer);
        }
        public override void Write(Moonfish.Guerilla.LinearBinaryWriter writer)
        {
            base.Write(writer);
            writer.Write(this.fieldpad);
            writer.Write(((int)(this.ObjectChangeColorFunctionScaleFlags)));
            writer.Write(this.ColorLowerBound);
            writer.Write(this.ColorUpperBound);
            writer.Write(this.DarkenBy);
            writer.Write(this.ScaleBy);
        }
        [System.FlagsAttribute()]
        public enum ScaleFlags : int
        {
            None = 0,
            BlendInHsvblendsColorsInHsvRatherThanRgbSpace = 1,
            moreColorsblendsColorsThroughMoreHuesgoesTheLongWayAroundTheColorWheel = 2,
        }
    }
}
