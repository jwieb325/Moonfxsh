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
    [TagClassAttribute("*ehi")]
    [TagBlockOriginalNameAttribute("scenario_vehicles_resource_block")]
    public partial class ScenarioVehiclesResourceBlock : GuerillaBlock, IWriteDeferrable
    {
        public ScenarioObjectNamesBlock[] Names = new ScenarioObjectNamesBlock[0];
        public DontUseMeScenarioEnvironmentObjectBlock[] DontUseMeScenarioEnvironmentObjectBlock = new DontUseMeScenarioEnvironmentObjectBlock[0];
        public ScenarioStructureBspReferenceBlock[] StructureReferences = new ScenarioStructureBspReferenceBlock[0];
        public ScenarioVehiclePaletteBlock[] Palette = new ScenarioVehiclePaletteBlock[0];
        public ScenarioVehicleBlock[] Objects = new ScenarioVehicleBlock[0];
        public int NextObjectIDSalt;
        public GScenarioEditorFolderBlock[] EditorFolders = new GScenarioEditorFolderBlock[0];
        public override int SerializedSize
        {
            get
            {
                return 52;
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
            pointerQueue.Enqueue(binaryReader.ReadBlamPointer(36));
            pointerQueue.Enqueue(binaryReader.ReadBlamPointer(64));
            pointerQueue.Enqueue(binaryReader.ReadBlamPointer(68));
            pointerQueue.Enqueue(binaryReader.ReadBlamPointer(40));
            pointerQueue.Enqueue(binaryReader.ReadBlamPointer(88));
            this.NextObjectIDSalt = binaryReader.ReadInt32();
            pointerQueue.Enqueue(binaryReader.ReadBlamPointer(260));
            return pointerQueue;
        }
        public override void ReadInstances(Moonfish.Guerilla.BlamBinaryReader binaryReader, System.Collections.Generic.Queue<Moonfish.Tags.BlamPointer> pointerQueue)
        {
            base.ReadInstances(binaryReader, pointerQueue);
            this.Names = base.ReadBlockArrayData<ScenarioObjectNamesBlock>(binaryReader, pointerQueue.Dequeue());
            this.DontUseMeScenarioEnvironmentObjectBlock = base.ReadBlockArrayData<DontUseMeScenarioEnvironmentObjectBlock>(binaryReader, pointerQueue.Dequeue());
            this.StructureReferences = base.ReadBlockArrayData<ScenarioStructureBspReferenceBlock>(binaryReader, pointerQueue.Dequeue());
            this.Palette = base.ReadBlockArrayData<ScenarioVehiclePaletteBlock>(binaryReader, pointerQueue.Dequeue());
            this.Objects = base.ReadBlockArrayData<ScenarioVehicleBlock>(binaryReader, pointerQueue.Dequeue());
            this.EditorFolders = base.ReadBlockArrayData<GScenarioEditorFolderBlock>(binaryReader, pointerQueue.Dequeue());
        }
        public override void DeferReferences(Moonfish.Guerilla.LinearBinaryWriter writer)
        {
            base.DeferReferences(writer);
            writer.Defer(this.Names);
            writer.Defer(this.DontUseMeScenarioEnvironmentObjectBlock);
            writer.Defer(this.StructureReferences);
            writer.Defer(this.Palette);
            writer.Defer(this.Objects);
            writer.Defer(this.EditorFolders);
        }
        public override void Write(Moonfish.Guerilla.LinearBinaryWriter writer)
        {
            base.Write(writer);
            writer.WritePointer(this.Names);
            writer.WritePointer(this.DontUseMeScenarioEnvironmentObjectBlock);
            writer.WritePointer(this.StructureReferences);
            writer.WritePointer(this.Palette);
            writer.WritePointer(this.Objects);
            writer.Write(this.NextObjectIDSalt);
            writer.WritePointer(this.EditorFolders);
        }
    }
}
namespace Moonfish.Tags
{
    
    public partial struct TagClass
    {
        public static TagClass Ehi = ((TagClass)("*ehi"));
    }
}
