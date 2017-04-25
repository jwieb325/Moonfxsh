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
    [TagClassAttribute("ai**")]
    [TagBlockOriginalNameAttribute("scenario_ai_resource_block")]
    public partial class ScenarioAiResourceBlock : GuerillaBlock, IWriteQueueable
    {
        public StylePaletteBlock[] StylePalette = new StylePaletteBlock[0];
        public SquadGroupsBlock[] SquadGroups = new SquadGroupsBlock[0];
        public SquadsBlock[] Squads = new SquadsBlock[0];
        public ZoneBlock[] Zones = new ZoneBlock[0];
        public CharacterPaletteBlock[] CharacterPalette = new CharacterPaletteBlock[0];
        public AiAnimationReferenceBlock[] AIAnimationReferences = new AiAnimationReferenceBlock[0];
        public AiScriptReferenceBlock[] AIScriptReferences = new AiScriptReferenceBlock[0];
        public AiRecordingReferenceBlock[] AIRecordingReferences = new AiRecordingReferenceBlock[0];
        public AiConversationBlock[] AIConversations = new AiConversationBlock[0];
        public CsScriptDataBlock[] ScriptingData = new CsScriptDataBlock[0];
        public OrdersBlock[] Orders = new OrdersBlock[0];
        public TriggersBlock[] Triggers = new TriggersBlock[0];
        public ScenarioStructureBspReferenceBlock[] BSPPreferences = new ScenarioStructureBspReferenceBlock[0];
        public ScenarioWeaponPaletteBlock[] WeaponReferences = new ScenarioWeaponPaletteBlock[0];
        public ScenarioVehiclePaletteBlock[] VehicleReferences = new ScenarioVehiclePaletteBlock[0];
        public ScenarioVehicleBlock[] VehicleDatumReferences = new ScenarioVehicleBlock[0];
        public AiSceneBlock[] MissionDialogueScenes = new AiSceneBlock[0];
        public FlockDefinitionBlock[] Flocks = new FlockDefinitionBlock[0];
        public ScenarioTriggerVolumeBlock[] TriggerVolumeReferences = new ScenarioTriggerVolumeBlock[0];
        public override int SerializedSize
        {
            get
            {
                return 152;
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
            pointerQueue.Enqueue(binaryReader.ReadBlamPointer(8));
            pointerQueue.Enqueue(binaryReader.ReadBlamPointer(36));
            pointerQueue.Enqueue(binaryReader.ReadBlamPointer(116));
            pointerQueue.Enqueue(binaryReader.ReadBlamPointer(56));
            pointerQueue.Enqueue(binaryReader.ReadBlamPointer(8));
            pointerQueue.Enqueue(binaryReader.ReadBlamPointer(52));
            pointerQueue.Enqueue(binaryReader.ReadBlamPointer(40));
            pointerQueue.Enqueue(binaryReader.ReadBlamPointer(40));
            pointerQueue.Enqueue(binaryReader.ReadBlamPointer(104));
            pointerQueue.Enqueue(binaryReader.ReadBlamPointer(128));
            pointerQueue.Enqueue(binaryReader.ReadBlamPointer(124));
            pointerQueue.Enqueue(binaryReader.ReadBlamPointer(48));
            pointerQueue.Enqueue(binaryReader.ReadBlamPointer(68));
            pointerQueue.Enqueue(binaryReader.ReadBlamPointer(40));
            pointerQueue.Enqueue(binaryReader.ReadBlamPointer(40));
            pointerQueue.Enqueue(binaryReader.ReadBlamPointer(84));
            pointerQueue.Enqueue(binaryReader.ReadBlamPointer(24));
            pointerQueue.Enqueue(binaryReader.ReadBlamPointer(132));
            pointerQueue.Enqueue(binaryReader.ReadBlamPointer(68));
            return pointerQueue;
        }
        public override void ReadInstances(Moonfish.Guerilla.BlamBinaryReader binaryReader, System.Collections.Generic.Queue<Moonfish.Tags.BlamPointer> pointerQueue)
        {
            base.ReadInstances(binaryReader, pointerQueue);
            this.StylePalette = base.ReadBlockArrayData<StylePaletteBlock>(binaryReader, pointerQueue.Dequeue());
            this.SquadGroups = base.ReadBlockArrayData<SquadGroupsBlock>(binaryReader, pointerQueue.Dequeue());
            this.Squads = base.ReadBlockArrayData<SquadsBlock>(binaryReader, pointerQueue.Dequeue());
            this.Zones = base.ReadBlockArrayData<ZoneBlock>(binaryReader, pointerQueue.Dequeue());
            this.CharacterPalette = base.ReadBlockArrayData<CharacterPaletteBlock>(binaryReader, pointerQueue.Dequeue());
            this.AIAnimationReferences = base.ReadBlockArrayData<AiAnimationReferenceBlock>(binaryReader, pointerQueue.Dequeue());
            this.AIScriptReferences = base.ReadBlockArrayData<AiScriptReferenceBlock>(binaryReader, pointerQueue.Dequeue());
            this.AIRecordingReferences = base.ReadBlockArrayData<AiRecordingReferenceBlock>(binaryReader, pointerQueue.Dequeue());
            this.AIConversations = base.ReadBlockArrayData<AiConversationBlock>(binaryReader, pointerQueue.Dequeue());
            this.ScriptingData = base.ReadBlockArrayData<CsScriptDataBlock>(binaryReader, pointerQueue.Dequeue());
            this.Orders = base.ReadBlockArrayData<OrdersBlock>(binaryReader, pointerQueue.Dequeue());
            this.Triggers = base.ReadBlockArrayData<TriggersBlock>(binaryReader, pointerQueue.Dequeue());
            this.BSPPreferences = base.ReadBlockArrayData<ScenarioStructureBspReferenceBlock>(binaryReader, pointerQueue.Dequeue());
            this.WeaponReferences = base.ReadBlockArrayData<ScenarioWeaponPaletteBlock>(binaryReader, pointerQueue.Dequeue());
            this.VehicleReferences = base.ReadBlockArrayData<ScenarioVehiclePaletteBlock>(binaryReader, pointerQueue.Dequeue());
            this.VehicleDatumReferences = base.ReadBlockArrayData<ScenarioVehicleBlock>(binaryReader, pointerQueue.Dequeue());
            this.MissionDialogueScenes = base.ReadBlockArrayData<AiSceneBlock>(binaryReader, pointerQueue.Dequeue());
            this.Flocks = base.ReadBlockArrayData<FlockDefinitionBlock>(binaryReader, pointerQueue.Dequeue());
            this.TriggerVolumeReferences = base.ReadBlockArrayData<ScenarioTriggerVolumeBlock>(binaryReader, pointerQueue.Dequeue());
        }
        public override void Defer(Moonfish.Guerilla.QueueableBlamBinaryWriter queueableBinaryWriter)
        {
            base.Defer(queueableBinaryWriter);
            queueableBinaryWriter.Defer(this.StylePalette);
            queueableBinaryWriter.Defer(this.SquadGroups);
            queueableBinaryWriter.Defer(this.Squads);
            queueableBinaryWriter.Defer(this.Zones);
            queueableBinaryWriter.Defer(this.CharacterPalette);
            queueableBinaryWriter.Defer(this.AIAnimationReferences);
            queueableBinaryWriter.Defer(this.AIScriptReferences);
            queueableBinaryWriter.Defer(this.AIRecordingReferences);
            queueableBinaryWriter.Defer(this.AIConversations);
            queueableBinaryWriter.Defer(this.ScriptingData);
            queueableBinaryWriter.Defer(this.Orders);
            queueableBinaryWriter.Defer(this.Triggers);
            queueableBinaryWriter.Defer(this.BSPPreferences);
            queueableBinaryWriter.Defer(this.WeaponReferences);
            queueableBinaryWriter.Defer(this.VehicleReferences);
            queueableBinaryWriter.Defer(this.VehicleDatumReferences);
            queueableBinaryWriter.Defer(this.MissionDialogueScenes);
            queueableBinaryWriter.Defer(this.Flocks);
            queueableBinaryWriter.Defer(this.TriggerVolumeReferences);
        }
        public override void Write(Moonfish.Guerilla.QueueableBlamBinaryWriter queueableBinaryWriter)
        {
            base.Write(queueableBinaryWriter);
            queueableBinaryWriter.WritePointer(this.StylePalette);
            queueableBinaryWriter.WritePointer(this.SquadGroups);
            queueableBinaryWriter.WritePointer(this.Squads);
            queueableBinaryWriter.WritePointer(this.Zones);
            queueableBinaryWriter.WritePointer(this.CharacterPalette);
            queueableBinaryWriter.WritePointer(this.AIAnimationReferences);
            queueableBinaryWriter.WritePointer(this.AIScriptReferences);
            queueableBinaryWriter.WritePointer(this.AIRecordingReferences);
            queueableBinaryWriter.WritePointer(this.AIConversations);
            queueableBinaryWriter.WritePointer(this.ScriptingData);
            queueableBinaryWriter.WritePointer(this.Orders);
            queueableBinaryWriter.WritePointer(this.Triggers);
            queueableBinaryWriter.WritePointer(this.BSPPreferences);
            queueableBinaryWriter.WritePointer(this.WeaponReferences);
            queueableBinaryWriter.WritePointer(this.VehicleReferences);
            queueableBinaryWriter.WritePointer(this.VehicleDatumReferences);
            queueableBinaryWriter.WritePointer(this.MissionDialogueScenes);
            queueableBinaryWriter.WritePointer(this.Flocks);
            queueableBinaryWriter.WritePointer(this.TriggerVolumeReferences);
        }
    }
}
namespace Moonfish.Tags
{
    
    public partial struct TagClass
    {
        public static TagClass Ai = ((TagClass)("ai**"));
    }
}
