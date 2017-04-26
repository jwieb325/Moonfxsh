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
    [TagBlockOriginalNameAttribute("player_representation_block")]
    public partial class PlayerRepresentationBlock : GuerillaBlock, IWriteDeferrable
    {
        [Moonfish.Tags.TagReferenceAttribute("mode")]
        public Moonfish.Tags.TagReference FirstPersonHands;
        [Moonfish.Tags.TagReferenceAttribute("mode")]
        public Moonfish.Tags.TagReference FirstPersonBody;
        private byte[] fieldpad = new byte[40];
        private byte[] fieldpad0 = new byte[120];
        [Moonfish.Tags.TagReferenceAttribute("unit")]
        public Moonfish.Tags.TagReference ThirdPersonUnit;
        public Moonfish.Tags.StringIdent ThirdPersonVariant;
        public override int SerializedSize
        {
            get
            {
                return 188;
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
            this.FirstPersonHands = binaryReader.ReadTagReference();
            this.FirstPersonBody = binaryReader.ReadTagReference();
            this.fieldpad = binaryReader.ReadBytes(40);
            this.fieldpad0 = binaryReader.ReadBytes(120);
            this.ThirdPersonUnit = binaryReader.ReadTagReference();
            this.ThirdPersonVariant = binaryReader.ReadStringIdent();
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
            writer.Write(this.FirstPersonHands);
            writer.Write(this.FirstPersonBody);
            writer.Write(this.fieldpad);
            writer.Write(this.fieldpad0);
            writer.Write(this.ThirdPersonUnit);
            writer.Write(this.ThirdPersonVariant);
        }
    }
}
