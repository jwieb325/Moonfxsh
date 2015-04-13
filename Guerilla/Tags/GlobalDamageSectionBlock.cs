// ReSharper disable All
using Moonfish.Model;
using Moonfish.Tags.BlamExtension;
using Moonfish.Tags;
using OpenTK;
using System;
using System.IO;

namespace Moonfish.Guerilla.Tags
{
    public  partial class GlobalDamageSectionBlock : GlobalDamageSectionBlockBase
    {
        public  GlobalDamageSectionBlock(BinaryReader binaryReader): base(binaryReader)
        {
            
        }
    };
    [LayoutAttribute(Size = 56, Alignment = 4)]
    public class GlobalDamageSectionBlockBase  : IGuerilla
    {
        internal Moonfish.Tags.StringID name;
        internal Flags flags;
        /// <summary>
        /// percentage of total object vitality
        /// </summary>
        internal float vitalityPercentage01;
        internal InstantaneousDamageRepsonseBlock[] instantResponses;
        internal GNullBlock[] gNullBlock;
        internal GNullBlock[] gNullBlock0;
        internal float stunTimeSeconds;
        internal float rechargeTimeSeconds;
        internal byte[] invalidName_;
        internal Moonfish.Tags.StringID resurrectionRestoredRegionName;
        internal byte[] invalidName_0;
        internal  GlobalDamageSectionBlockBase(BinaryReader binaryReader)
        {
            name = binaryReader.ReadStringID();
            flags = (Flags)binaryReader.ReadInt32();
            vitalityPercentage01 = binaryReader.ReadSingle();
            instantResponses = Guerilla.ReadBlockArray<InstantaneousDamageRepsonseBlock>(binaryReader);
            gNullBlock = Guerilla.ReadBlockArray<GNullBlock>(binaryReader);
            gNullBlock0 = Guerilla.ReadBlockArray<GNullBlock>(binaryReader);
            stunTimeSeconds = binaryReader.ReadSingle();
            rechargeTimeSeconds = binaryReader.ReadSingle();
            invalidName_ = binaryReader.ReadBytes(4);
            resurrectionRestoredRegionName = binaryReader.ReadStringID();
            invalidName_0 = binaryReader.ReadBytes(4);
        }
        public int Write(System.IO.BinaryWriter binaryWriter, Int32 nextAddress)
        {
            using(binaryWriter.BaseStream.Pin())
            {
                binaryWriter.Write(name);
                binaryWriter.Write((Int32)flags);
                binaryWriter.Write(vitalityPercentage01);
                Guerilla.WriteBlockArray<InstantaneousDamageRepsonseBlock>(binaryWriter, instantResponses, nextAddress);
                Guerilla.WriteBlockArray<GNullBlock>(binaryWriter, gNullBlock, nextAddress);
                Guerilla.WriteBlockArray<GNullBlock>(binaryWriter, gNullBlock0, nextAddress);
                binaryWriter.Write(stunTimeSeconds);
                binaryWriter.Write(rechargeTimeSeconds);
                binaryWriter.Write(invalidName_, 0, 4);
                binaryWriter.Write(resurrectionRestoredRegionName);
                binaryWriter.Write(invalidName_0, 0, 4);
                return nextAddress = (int)binaryWriter.BaseStream.Position;
            }
        }
        [FlagsAttribute]
        internal enum Flags : int
        {
            AbsorbsBodyDamage = 1,
            TakesFullDmgWhenObjectDies = 2,
            CannotDieWithRiders = 4,
            TakesFullDmgWhenObjDstryd = 8,
            RestoredOnRessurection = 16,
            Unused = 32,
            Unused0 = 64,
            Heatshottable = 128,
            IgnoresShields = 256,
        };
    };
}
