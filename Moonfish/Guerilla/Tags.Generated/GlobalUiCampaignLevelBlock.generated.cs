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
    [TagBlockOriginalNameAttribute("global_ui_campaign_level_block")]
    public partial class GlobalUiCampaignLevelBlock : GuerillaBlock, IWriteDeferrable
    {
        public int CampaignID;
        public int MapID;
        [Moonfish.Tags.TagReferenceAttribute("bitm")]
        public Moonfish.Tags.TagReference Bitmap;
        private byte[] fieldskip = new byte[576];
        private byte[] fieldskip0 = new byte[2304];
        public override int SerializedSize
        {
            get
            {
                return 2896;
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
            this.CampaignID = binaryReader.ReadInt32();
            this.MapID = binaryReader.ReadInt32();
            this.Bitmap = binaryReader.ReadTagReference();
            this.fieldskip = binaryReader.ReadBytes(576);
            this.fieldskip0 = binaryReader.ReadBytes(2304);
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
            writer.Write(this.CampaignID);
            writer.Write(this.MapID);
            writer.Write(this.Bitmap);
            writer.Write(this.fieldskip);
            writer.Write(this.fieldskip0);
        }
    }
}
