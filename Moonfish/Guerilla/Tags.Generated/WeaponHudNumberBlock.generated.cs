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
    [TagBlockOriginalNameAttribute("weapon_hud_number_block")]
    public partial class WeaponHudNumberBlock : GuerillaBlock, IWriteQueueable
    {
        public StateAttachedToEnum StateAttachedTo;
        private byte[] fieldpad = new byte[2];
        public CanUseOnMapTypeEnum CanUseOnMapType;
        private byte[] fieldpad0 = new byte[2];
        private byte[] fieldpad1 = new byte[28];
        public Moonfish.Tags.Point AnchorOffset;
        public float WidthScale;
        public float HeightScale;
        public ScalingFlags WeaponHudNumberScalingFlags;
        private byte[] fieldpad2 = new byte[2];
        private byte[] fieldpad3 = new byte[20];
        public Moonfish.Tags.ColourA1R1G1B1 DefaultColor;
        public Moonfish.Tags.ColourA1R1G1B1 FlashingColor;
        public float FlashPeriod;
        public float FlashDelay;
        public short NumberOfFlashes;
        public FlashFlags WeaponHudNumberFlashFlags;
        public float FlashLength;
        public Moonfish.Tags.ColourA1R1G1B1 DisabledColor;
        private byte[] fieldpad4 = new byte[4];
        public byte MaximumNumberOfDigits;
        public Flags WeaponHudNumberFlags;
        public byte NumberOfFractionalDigits;
        private byte[] fieldpad5 = new byte[1];
        private byte[] fieldpad6 = new byte[12];
        public WeaponSpecificFlags WeaponHudNumberWeaponSpecificFlags;
        private byte[] fieldpad7 = new byte[2];
        private byte[] fieldpad8 = new byte[36];
        public override int SerializedSize
        {
            get
            {
                return 160;
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
            this.StateAttachedTo = ((StateAttachedToEnum)(binaryReader.ReadInt16()));
            this.fieldpad = binaryReader.ReadBytes(2);
            this.CanUseOnMapType = ((CanUseOnMapTypeEnum)(binaryReader.ReadInt16()));
            this.fieldpad0 = binaryReader.ReadBytes(2);
            this.fieldpad1 = binaryReader.ReadBytes(28);
            this.AnchorOffset = binaryReader.ReadPoint();
            this.WidthScale = binaryReader.ReadSingle();
            this.HeightScale = binaryReader.ReadSingle();
            this.WeaponHudNumberScalingFlags = ((ScalingFlags)(binaryReader.ReadInt16()));
            this.fieldpad2 = binaryReader.ReadBytes(2);
            this.fieldpad3 = binaryReader.ReadBytes(20);
            this.DefaultColor = binaryReader.ReadColourA1R1G1B1();
            this.FlashingColor = binaryReader.ReadColourA1R1G1B1();
            this.FlashPeriod = binaryReader.ReadSingle();
            this.FlashDelay = binaryReader.ReadSingle();
            this.NumberOfFlashes = binaryReader.ReadInt16();
            this.WeaponHudNumberFlashFlags = ((FlashFlags)(binaryReader.ReadInt16()));
            this.FlashLength = binaryReader.ReadSingle();
            this.DisabledColor = binaryReader.ReadColourA1R1G1B1();
            this.fieldpad4 = binaryReader.ReadBytes(4);
            this.MaximumNumberOfDigits = binaryReader.ReadByte();
            this.WeaponHudNumberFlags = ((Flags)(binaryReader.ReadByte()));
            this.NumberOfFractionalDigits = binaryReader.ReadByte();
            this.fieldpad5 = binaryReader.ReadBytes(1);
            this.fieldpad6 = binaryReader.ReadBytes(12);
            this.WeaponHudNumberWeaponSpecificFlags = ((WeaponSpecificFlags)(binaryReader.ReadInt16()));
            this.fieldpad7 = binaryReader.ReadBytes(2);
            this.fieldpad8 = binaryReader.ReadBytes(36);
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
            queueableBinaryWriter.Write(((short)(this.StateAttachedTo)));
            queueableBinaryWriter.Write(this.fieldpad);
            queueableBinaryWriter.Write(((short)(this.CanUseOnMapType)));
            queueableBinaryWriter.Write(this.fieldpad0);
            queueableBinaryWriter.Write(this.fieldpad1);
            queueableBinaryWriter.Write(this.AnchorOffset);
            queueableBinaryWriter.Write(this.WidthScale);
            queueableBinaryWriter.Write(this.HeightScale);
            queueableBinaryWriter.Write(((short)(this.WeaponHudNumberScalingFlags)));
            queueableBinaryWriter.Write(this.fieldpad2);
            queueableBinaryWriter.Write(this.fieldpad3);
            queueableBinaryWriter.Write(this.DefaultColor);
            queueableBinaryWriter.Write(this.FlashingColor);
            queueableBinaryWriter.Write(this.FlashPeriod);
            queueableBinaryWriter.Write(this.FlashDelay);
            queueableBinaryWriter.Write(this.NumberOfFlashes);
            queueableBinaryWriter.Write(((short)(this.WeaponHudNumberFlashFlags)));
            queueableBinaryWriter.Write(this.FlashLength);
            queueableBinaryWriter.Write(this.DisabledColor);
            queueableBinaryWriter.Write(this.fieldpad4);
            queueableBinaryWriter.Write(this.MaximumNumberOfDigits);
            queueableBinaryWriter.Write(((byte)(this.WeaponHudNumberFlags)));
            queueableBinaryWriter.Write(this.NumberOfFractionalDigits);
            queueableBinaryWriter.Write(this.fieldpad5);
            queueableBinaryWriter.Write(this.fieldpad6);
            queueableBinaryWriter.Write(((short)(this.WeaponHudNumberWeaponSpecificFlags)));
            queueableBinaryWriter.Write(this.fieldpad7);
            queueableBinaryWriter.Write(this.fieldpad8);
        }
        public enum StateAttachedToEnum : short
        {
            InventoryAmmo = 0,
            LoadedAmmo = 1,
            Heat = 2,
            Age = 3,
            SecondaryWeaponInventoryAmmo = 4,
            SecondaryWeaponLoadedAmmo = 5,
            DistanceToTarget = 6,
            ElevationToTarget = 7,
        }
        public enum CanUseOnMapTypeEnum : short
        {
            Any = 0,
            Solo = 1,
            Multiplayer = 2,
        }
        [System.FlagsAttribute()]
        public enum ScalingFlags : short
        {
            None = 0,
            DontScaleOffset = 1,
            DontScaleSize = 2,
        }
        [System.FlagsAttribute()]
        public enum FlashFlags : short
        {
            None = 0,
            ReverseDefaultflashingColors = 1,
        }
        [System.FlagsAttribute()]
        public enum Flags : byte
        {
            None = 0,
            ShowLeadingZeros = 1,
            OnlyShowWhenZoomed = 2,
            DrawATrailingM = 4,
        }
        [System.FlagsAttribute()]
        public enum WeaponSpecificFlags : short
        {
            None = 0,
            DivideNumberByClipSize = 1,
        }
    }
}
