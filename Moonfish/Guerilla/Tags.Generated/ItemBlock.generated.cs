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
    [TagClassAttribute("item")]
    [TagBlockOriginalNameAttribute("item_block")]
    public partial class ItemBlock : ObjectBlock, IWriteDeferrable
    {
        public ItemFlags ItemItemFlags;
        public short OLDMessageIndex;
        public short SortOrder;
        public float MultiplayerOngroundScale;
        public float CampaignOngroundScale;
        /// <summary>
        /// everything you need to display stuff
        /// </summary>
        public Moonfish.Tags.StringIdent PickupMessage;
        public Moonfish.Tags.StringIdent SwapMessage;
        public Moonfish.Tags.StringIdent PickupOrDualMsg;
        public Moonfish.Tags.StringIdent SwapOrDualMsg;
        public Moonfish.Tags.StringIdent DualonlyMsg;
        public Moonfish.Tags.StringIdent PickedUpMsg;
        public Moonfish.Tags.StringIdent SingluarQuantityMsg;
        public Moonfish.Tags.StringIdent PluralQuantityMsg;
        public Moonfish.Tags.StringIdent SwitchtoMsg;
        public Moonfish.Tags.StringIdent SwitchtoFromAiMsg;
        [Moonfish.Tags.TagReferenceAttribute("foot")]
        public Moonfish.Tags.TagReference UNUSED;
        [Moonfish.Tags.TagReferenceAttribute("snd!")]
        public Moonfish.Tags.TagReference CollisionSound;
        public PredictedBitmapsBlock[] PredictedBitmaps = new PredictedBitmapsBlock[0];
        [Moonfish.Tags.TagReferenceAttribute("jpt!")]
        public Moonfish.Tags.TagReference DetonationDamageEffect;
        public Moonfish.Model.Range DetonationDelay;
        [Moonfish.Tags.TagReferenceAttribute("effe")]
        public Moonfish.Tags.TagReference DetonatingEffect;
        [Moonfish.Tags.TagReferenceAttribute("effe")]
        public Moonfish.Tags.TagReference DetonationEffect;
        public override int SerializedSize
        {
            get
            {
                return 300;
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
            this.ItemItemFlags = ((ItemFlags)(binaryReader.ReadInt32()));
            this.OLDMessageIndex = binaryReader.ReadInt16();
            this.SortOrder = binaryReader.ReadInt16();
            this.MultiplayerOngroundScale = binaryReader.ReadSingle();
            this.CampaignOngroundScale = binaryReader.ReadSingle();
            this.PickupMessage = binaryReader.ReadStringIdent();
            this.SwapMessage = binaryReader.ReadStringIdent();
            this.PickupOrDualMsg = binaryReader.ReadStringIdent();
            this.SwapOrDualMsg = binaryReader.ReadStringIdent();
            this.DualonlyMsg = binaryReader.ReadStringIdent();
            this.PickedUpMsg = binaryReader.ReadStringIdent();
            this.SingluarQuantityMsg = binaryReader.ReadStringIdent();
            this.PluralQuantityMsg = binaryReader.ReadStringIdent();
            this.SwitchtoMsg = binaryReader.ReadStringIdent();
            this.SwitchtoFromAiMsg = binaryReader.ReadStringIdent();
            this.UNUSED = binaryReader.ReadTagReference();
            this.CollisionSound = binaryReader.ReadTagReference();
            pointerQueue.Enqueue(binaryReader.ReadBlamPointer(8));
            this.DetonationDamageEffect = binaryReader.ReadTagReference();
            this.DetonationDelay = binaryReader.ReadRange();
            this.DetonatingEffect = binaryReader.ReadTagReference();
            this.DetonationEffect = binaryReader.ReadTagReference();
            return pointerQueue;
        }
        public override void ReadInstances(Moonfish.Guerilla.BlamBinaryReader binaryReader, System.Collections.Generic.Queue<Moonfish.Tags.BlamPointer> pointerQueue)
        {
            base.ReadInstances(binaryReader, pointerQueue);
            this.PredictedBitmaps = base.ReadBlockArrayData<PredictedBitmapsBlock>(binaryReader, pointerQueue.Dequeue());
        }
        public override void DeferReferences(Moonfish.Guerilla.LinearBinaryWriter writer)
        {
            base.DeferReferences(writer);
            writer.Defer(this.PredictedBitmaps);
        }
        public override void Write(Moonfish.Guerilla.LinearBinaryWriter writer)
        {
            base.Write(writer);
            writer.Write(((int)(this.ItemItemFlags)));
            writer.Write(this.OLDMessageIndex);
            writer.Write(this.SortOrder);
            writer.Write(this.MultiplayerOngroundScale);
            writer.Write(this.CampaignOngroundScale);
            writer.Write(this.PickupMessage);
            writer.Write(this.SwapMessage);
            writer.Write(this.PickupOrDualMsg);
            writer.Write(this.SwapOrDualMsg);
            writer.Write(this.DualonlyMsg);
            writer.Write(this.PickedUpMsg);
            writer.Write(this.SingluarQuantityMsg);
            writer.Write(this.PluralQuantityMsg);
            writer.Write(this.SwitchtoMsg);
            writer.Write(this.SwitchtoFromAiMsg);
            writer.Write(this.UNUSED);
            writer.Write(this.CollisionSound);
            writer.WritePointer(this.PredictedBitmaps);
            writer.Write(this.DetonationDamageEffect);
            writer.Write(this.DetonationDelay);
            writer.Write(this.DetonatingEffect);
            writer.Write(this.DetonationEffect);
        }
        [System.FlagsAttribute()]
        public enum ItemFlags : int
        {
            None = 0,
            AlwaysMaintainsZUp = 1,
            DestroyedByExplosions = 2,
            UnaffectedByGravity = 4,
        }
    }
}
namespace Moonfish.Tags
{
    
    public partial struct TagClass
    {
        public static TagClass Item = ((TagClass)("item"));
    }
}
