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
    [TagBlockOriginalNameAttribute("scenario_machine_struct_v3_block")]
    public partial class ScenarioMachineStructV3Block : GuerillaBlock, IWriteDeferrable
    {
        public Flags ScenarioMachineStructV3Flags;
        public PathfindingObjectIndexListBlock[] PathfindingReferences = new PathfindingObjectIndexListBlock[0];
        public override int SerializedSize
        {
            get
            {
                return 12;
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
            this.ScenarioMachineStructV3Flags = ((Flags)(binaryReader.ReadInt32()));
            pointerQueue.Enqueue(binaryReader.ReadBlamPointer(4));
            return pointerQueue;
        }
        public override void ReadInstances(Moonfish.Guerilla.BlamBinaryReader binaryReader, System.Collections.Generic.Queue<Moonfish.Tags.BlamPointer> pointerQueue)
        {
            base.ReadInstances(binaryReader, pointerQueue);
            this.PathfindingReferences = base.ReadBlockArrayData<PathfindingObjectIndexListBlock>(binaryReader, pointerQueue.Dequeue());
        }
        public override void DeferReferences(Moonfish.Guerilla.LinearBinaryWriter writer)
        {
            base.DeferReferences(writer);
            writer.Defer(this.PathfindingReferences);
        }
        public override void Write(Moonfish.Guerilla.LinearBinaryWriter writer)
        {
            base.Write(writer);
            writer.Write(((int)(this.ScenarioMachineStructV3Flags)));
            writer.WritePointer(this.PathfindingReferences);
        }
        [System.FlagsAttribute()]
        public enum Flags : int
        {
            None = 0,
            DoesNotOperateAutomatically = 1,
            OneSided = 2,
            NeverAppearsLocked = 4,
            OpenedByMeleeAttack = 8,
            OneSidedForPlayer = 16,
            DoesNotCloseAutomatically = 32,
        }
    }
}
