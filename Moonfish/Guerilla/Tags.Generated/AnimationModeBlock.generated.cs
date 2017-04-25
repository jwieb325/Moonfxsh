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
    [TagBlockOriginalNameAttribute("animation_mode_block")]
    public partial class AnimationModeBlock : GuerillaBlock, IWriteQueueable
    {
        public Moonfish.Tags.StringIdent Label;
        public WeaponClassBlock[] WeaponClassAABBCC = new WeaponClassBlock[0];
        public AnimationIkBlock[] ModeIkAABBCC = new AnimationIkBlock[0];
        public override int SerializedSize
        {
            get
            {
                return 20;
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
            this.Label = binaryReader.ReadStringIdent();
            pointerQueue.Enqueue(binaryReader.ReadBlamPointer(20));
            pointerQueue.Enqueue(binaryReader.ReadBlamPointer(8));
            return pointerQueue;
        }
        public override void ReadInstances(Moonfish.Guerilla.BlamBinaryReader binaryReader, System.Collections.Generic.Queue<Moonfish.Tags.BlamPointer> pointerQueue)
        {
            base.ReadInstances(binaryReader, pointerQueue);
            this.WeaponClassAABBCC = base.ReadBlockArrayData<WeaponClassBlock>(binaryReader, pointerQueue.Dequeue());
            this.ModeIkAABBCC = base.ReadBlockArrayData<AnimationIkBlock>(binaryReader, pointerQueue.Dequeue());
        }
        public override void Defer(Moonfish.Guerilla.QueueableBlamBinaryWriter queueableBinaryWriter)
        {
            base.Defer(queueableBinaryWriter);
            queueableBinaryWriter.Defer(this.WeaponClassAABBCC);
            queueableBinaryWriter.Defer(this.ModeIkAABBCC);
        }
        public override void Write(Moonfish.Guerilla.QueueableBlamBinaryWriter queueableBinaryWriter)
        {
            base.Write(queueableBinaryWriter);
            queueableBinaryWriter.Write(this.Label);
            queueableBinaryWriter.WritePointer(this.WeaponClassAABBCC);
            queueableBinaryWriter.WritePointer(this.ModeIkAABBCC);
        }
    }
}
