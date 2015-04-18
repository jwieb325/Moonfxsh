// ReSharper disable All
using Moonfish.Model;
using Moonfish.Tags.BlamExtension;
using Moonfish.Tags;
using OpenTK;
using System;
using System.IO;

namespace Moonfish.Guerilla.Tags
{
    public  partial class SoundEncodedDialogueSectionBlock : SoundEncodedDialogueSectionBlockBase
    {
        public  SoundEncodedDialogueSectionBlock(BinaryReader binaryReader): base(binaryReader)
        {
            
        }
    };
    [LayoutAttribute(Size = 16, Alignment = 4)]
    public class SoundEncodedDialogueSectionBlockBase  : IGuerilla
    {
        internal byte[] encodedData;
        internal SoundPermutationDialogueInfoBlock[] soundDialogueInfo;
        internal  SoundEncodedDialogueSectionBlockBase(BinaryReader binaryReader)
        {
            encodedData = Guerilla.ReadData(binaryReader);
            soundDialogueInfo = Guerilla.ReadBlockArray<SoundPermutationDialogueInfoBlock>(binaryReader);
        }
        public int Write(System.IO.BinaryWriter binaryWriter, Int32 nextAddress)
        {
            using(binaryWriter.BaseStream.Pin())
            {
                nextAddress = Guerilla.WriteData(binaryWriter, encodedData, nextAddress);
                nextAddress = Guerilla.WriteBlockArray<SoundPermutationDialogueInfoBlock>(binaryWriter, soundDialogueInfo, nextAddress);
                return nextAddress;
            }
        }
    };
}
