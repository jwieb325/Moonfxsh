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
    
    [TagClassAttribute("wgtz")]
    public partial class UserInterfaceGlobalsDefinitionBlock : GuerillaBlock, IWriteQueueable
    {
        /// <summary>
        /// This is a reference to the ui shared globals tag
        /// </summary>
        [Moonfish.Tags.TagReferenceAttribute("wigl")]
        public Moonfish.Tags.TagReference SharedGlobals;
        public UserInterfaceWidgetReferenceBlock[] ScreenWidgets = new UserInterfaceWidgetReferenceBlock[0];
        /// <summary>
        /// This blob defines the ui for setting multiplayer game variant parameters
        /// </summary>
        [Moonfish.Tags.TagReferenceAttribute("goof")]
        public Moonfish.Tags.TagReference MpVariantSettingsUi;
        /// <summary>
        /// This is for the loc game hopper strings
        /// </summary>
        [Moonfish.Tags.TagReferenceAttribute("unic")]
        public Moonfish.Tags.TagReference GameHopperDescriptions;
        public override int SerializedSize
        {
            get
            {
                return 32;
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
            this.SharedGlobals = binaryReader.ReadTagReference();
            pointerQueue.Enqueue(binaryReader.ReadBlamPointer(8));
            this.MpVariantSettingsUi = binaryReader.ReadTagReference();
            this.GameHopperDescriptions = binaryReader.ReadTagReference();
            return pointerQueue;
        }
        public override void ReadInstances(System.IO.BinaryReader binaryReader, System.Collections.Generic.Queue<Moonfish.Tags.BlamPointer> pointerQueue)
        {
            base.ReadInstances(binaryReader, pointerQueue);
            this.ScreenWidgets = base.ReadBlockArrayData<UserInterfaceWidgetReferenceBlock>(binaryReader, pointerQueue.Dequeue());
        }
        public override void QueueWrites(Moonfish.Guerilla.QueueableBinaryWriter queueableBinaryWriter)
        {
            base.QueueWrites(queueableBinaryWriter);
            queueableBinaryWriter.QueueWrite(this.ScreenWidgets);
        }
        public override void Write_(Moonfish.Guerilla.QueueableBinaryWriter queueableBinaryWriter)
        {
            base.Write_(queueableBinaryWriter);
            queueableBinaryWriter.Write(this.SharedGlobals);
            queueableBinaryWriter.WritePointer(this.ScreenWidgets);
            queueableBinaryWriter.Write(this.MpVariantSettingsUi);
            queueableBinaryWriter.Write(this.GameHopperDescriptions);
        }
    }
}
namespace Moonfish.Tags
{
    
    public partial struct TagClass
    {
        public static TagClass Wgtz = ((TagClass)("wgtz"));
    }
}
