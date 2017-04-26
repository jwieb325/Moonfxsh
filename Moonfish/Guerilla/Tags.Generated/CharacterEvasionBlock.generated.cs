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
    [TagBlockOriginalNameAttribute("character_evasion_block")]
    public partial class CharacterEvasionBlock : GuerillaBlock, IWriteDeferrable
    {
        /// <summary>
        /// Danger values can be found in the ai-globals section of the globals tag.
        /// </summary>
        public float EvasionDangerThreshold;
        public float EvasionDelayTimer;
        public float EvasionChance;
        public float EvasionProximityThreshold;
        public float DiveRetreatChance;
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
            this.EvasionDangerThreshold = binaryReader.ReadSingle();
            this.EvasionDelayTimer = binaryReader.ReadSingle();
            this.EvasionChance = binaryReader.ReadSingle();
            this.EvasionProximityThreshold = binaryReader.ReadSingle();
            this.DiveRetreatChance = binaryReader.ReadSingle();
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
            writer.Write(this.EvasionDangerThreshold);
            writer.Write(this.EvasionDelayTimer);
            writer.Write(this.EvasionChance);
            writer.Write(this.EvasionProximityThreshold);
            writer.Write(this.DiveRetreatChance);
        }
    }
}
