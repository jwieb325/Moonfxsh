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
    [TagBlockOriginalNameAttribute("scenario_starting_equipment_block")]
    public partial class ScenarioStartingEquipmentBlock : GuerillaBlock, IWriteQueueable
    {
        public Flags ScenarioStartingEquipmentFlags;
        public GameType1Enum GameType1;
        public GameType2Enum GameType2;
        public GameType3Enum GameType3;
        public GameType4Enum GameType4;
        private byte[] fieldpad = new byte[48];
        [Moonfish.Tags.TagReferenceAttribute("itmc")]
        public Moonfish.Tags.TagReference ItemCollection1;
        [Moonfish.Tags.TagReferenceAttribute("itmc")]
        public Moonfish.Tags.TagReference ItemCollection2;
        [Moonfish.Tags.TagReferenceAttribute("itmc")]
        public Moonfish.Tags.TagReference ItemCollection3;
        [Moonfish.Tags.TagReferenceAttribute("itmc")]
        public Moonfish.Tags.TagReference ItemCollection4;
        [Moonfish.Tags.TagReferenceAttribute("itmc")]
        public Moonfish.Tags.TagReference ItemCollection5;
        [Moonfish.Tags.TagReferenceAttribute("itmc")]
        public Moonfish.Tags.TagReference ItemCollection6;
        private byte[] fieldpad0 = new byte[48];
        public override int SerializedSize
        {
            get
            {
                return 156;
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
            this.ScenarioStartingEquipmentFlags = ((Flags)(binaryReader.ReadInt32()));
            this.GameType1 = ((GameType1Enum)(binaryReader.ReadInt16()));
            this.GameType2 = ((GameType2Enum)(binaryReader.ReadInt16()));
            this.GameType3 = ((GameType3Enum)(binaryReader.ReadInt16()));
            this.GameType4 = ((GameType4Enum)(binaryReader.ReadInt16()));
            this.fieldpad = binaryReader.ReadBytes(48);
            this.ItemCollection1 = binaryReader.ReadTagReference();
            this.ItemCollection2 = binaryReader.ReadTagReference();
            this.ItemCollection3 = binaryReader.ReadTagReference();
            this.ItemCollection4 = binaryReader.ReadTagReference();
            this.ItemCollection5 = binaryReader.ReadTagReference();
            this.ItemCollection6 = binaryReader.ReadTagReference();
            this.fieldpad0 = binaryReader.ReadBytes(48);
            return pointerQueue;
        }
        public override void ReadInstances(Moonfish.Guerilla.BlamBinaryReader binaryReader, System.Collections.Generic.Queue<Moonfish.Tags.BlamPointer> pointerQueue)
        {
            base.ReadInstances(binaryReader, pointerQueue);
        }
        public override void Defer(Moonfish.Guerilla.QueueableBlamBinaryWriter queueableBinaryWriter)
        {
            base.Defer(queueableBinaryWriter);
        }
        public override void Write(Moonfish.Guerilla.QueueableBlamBinaryWriter queueableBinaryWriter)
        {
            base.Write(queueableBinaryWriter);
            queueableBinaryWriter.Write(((int)(this.ScenarioStartingEquipmentFlags)));
            queueableBinaryWriter.Write(((short)(this.GameType1)));
            queueableBinaryWriter.Write(((short)(this.GameType2)));
            queueableBinaryWriter.Write(((short)(this.GameType3)));
            queueableBinaryWriter.Write(((short)(this.GameType4)));
            queueableBinaryWriter.Write(this.fieldpad);
            queueableBinaryWriter.Write(this.ItemCollection1);
            queueableBinaryWriter.Write(this.ItemCollection2);
            queueableBinaryWriter.Write(this.ItemCollection3);
            queueableBinaryWriter.Write(this.ItemCollection4);
            queueableBinaryWriter.Write(this.ItemCollection5);
            queueableBinaryWriter.Write(this.ItemCollection6);
            queueableBinaryWriter.Write(this.fieldpad0);
        }
        [System.FlagsAttribute()]
        public enum Flags : int
        {
            None = 0,
            NoGrenades = 1,
            PlasmaGrenades = 2,
        }
        public enum GameType1Enum : short
        {
            NONE = 0,
            CaptureTheFlag = 1,
            Slayer = 2,
            Oddball = 3,
            KingOfTheHill = 4,
            Race = 5,
            Headhunter = 6,
            Juggernaut = 7,
            Territories = 8,
            Stub = 9,
            Ignored3 = 10,
            Ignored4 = 11,
            AllGameTypes = 12,
            AllExceptCTF = 13,
            AllExceptCTFRace = 14,
        }
        public enum GameType2Enum : short
        {
            NONE = 0,
            CaptureTheFlag = 1,
            Slayer = 2,
            Oddball = 3,
            KingOfTheHill = 4,
            Race = 5,
            Headhunter = 6,
            Juggernaut = 7,
            Territories = 8,
            Stub = 9,
            Ignored3 = 10,
            Ignored4 = 11,
            AllGameTypes = 12,
            AllExceptCTF = 13,
            AllExceptCTFRace = 14,
        }
        public enum GameType3Enum : short
        {
            NONE = 0,
            CaptureTheFlag = 1,
            Slayer = 2,
            Oddball = 3,
            KingOfTheHill = 4,
            Race = 5,
            Headhunter = 6,
            Juggernaut = 7,
            Territories = 8,
            Stub = 9,
            Ignored3 = 10,
            Ignored4 = 11,
            AllGameTypes = 12,
            AllExceptCTF = 13,
            AllExceptCTFRace = 14,
        }
        public enum GameType4Enum : short
        {
            NONE = 0,
            CaptureTheFlag = 1,
            Slayer = 2,
            Oddball = 3,
            KingOfTheHill = 4,
            Race = 5,
            Headhunter = 6,
            Juggernaut = 7,
            Territories = 8,
            Stub = 9,
            Ignored3 = 10,
            Ignored4 = 11,
            AllGameTypes = 12,
            AllExceptCTF = 13,
            AllExceptCTFRace = 14,
        }
    }
}
