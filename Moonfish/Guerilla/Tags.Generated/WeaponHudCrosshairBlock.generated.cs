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
    
    public partial class WeaponHudCrosshairBlock : GuerillaBlock, IWriteQueueable
    {
        public CrosshairTypeEnum CrosshairType;
        private byte[] fieldpad = new byte[2];
        public CanUseOnMapTypeEnum CanUseOnMapType;
        private byte[] fieldpad0 = new byte[2];
        private byte[] fieldpad1 = new byte[28];
        [Moonfish.Tags.TagReferenceAttribute("bitm")]
        public Moonfish.Tags.TagReference CrosshairBitmap;
        public WeaponHudCrosshairItemBlock[] CrosshairOverlays = new WeaponHudCrosshairItemBlock[0];
        private byte[] fieldpad2 = new byte[40];
        public override int SerializedSize
        {
            get
            {
                return 92;
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
            this.CrosshairType = ((CrosshairTypeEnum)(binaryReader.ReadInt16()));
            this.fieldpad = binaryReader.ReadBytes(2);
            this.CanUseOnMapType = ((CanUseOnMapTypeEnum)(binaryReader.ReadInt16()));
            this.fieldpad0 = binaryReader.ReadBytes(2);
            this.fieldpad1 = binaryReader.ReadBytes(28);
            this.CrosshairBitmap = binaryReader.ReadTagReference();
            pointerQueue.Enqueue(binaryReader.ReadBlamPointer(108));
            this.fieldpad2 = binaryReader.ReadBytes(40);
            return pointerQueue;
        }
        public override void ReadInstances(System.IO.BinaryReader binaryReader, System.Collections.Generic.Queue<Moonfish.Tags.BlamPointer> pointerQueue)
        {
            base.ReadInstances(binaryReader, pointerQueue);
            this.CrosshairOverlays = base.ReadBlockArrayData<WeaponHudCrosshairItemBlock>(binaryReader, pointerQueue.Dequeue());
        }
        public override void QueueWrites(Moonfish.Guerilla.QueueableBinaryWriter queueableBinaryWriter)
        {
            base.QueueWrites(queueableBinaryWriter);
            queueableBinaryWriter.QueueWrite(this.CrosshairOverlays);
        }
        public override void Write_(Moonfish.Guerilla.QueueableBinaryWriter queueableBinaryWriter)
        {
            base.Write_(queueableBinaryWriter);
            queueableBinaryWriter.Write(((short)(this.CrosshairType)));
            queueableBinaryWriter.Write(this.fieldpad);
            queueableBinaryWriter.Write(((short)(this.CanUseOnMapType)));
            queueableBinaryWriter.Write(this.fieldpad0);
            queueableBinaryWriter.Write(this.fieldpad1);
            queueableBinaryWriter.Write(this.CrosshairBitmap);
            queueableBinaryWriter.WritePointer(this.CrosshairOverlays);
            queueableBinaryWriter.Write(this.fieldpad2);
        }
        /// <summary>
        /// Crosshairs always go in the center of the screen.
        ///Crosshairs can be attached to one of four different states:
        /// </summary>
        public enum CrosshairTypeEnum : short
        {
            /// <summary>
            ///  Aim: Default crosshair. Frame 0 is the default state, frame 1 is the auto-aim state (frame rate ignored)
            /// 
            /// </summary>
            Aim = 0,
            /// <summary>
            ///  Zoom: Zoom overlay. Each zoom level has a corresponding frame (frame rate ignored)
            /// 
            /// </summary>
            Zoom = 1,
            /// <summary>
            ///  Charge: Charging overlay. If you wish to display an animation for charging, put it here.
            /// 
            /// </summary>
            Charge = 2,
            /// <summary>
            ///  Flash: Similar to charging, but for low ammo/batter/heat states
            /// 
            /// </summary>
            ShouldReload = 3,
            /// <summary>
            ///  Reload/Overheat: Similar to charging, but for reloading/overheating
            /// 
            /// </summary>
            FlashHeat = 4,
            FlashInventoryAmmo = 5,
            FlashBattery = 6,
            Reloadoverheat = 7,
            FlashWhenFiringAndNoAmmo = 8,
            FlashWhenThrowingAndNoGrenade = 9,
            LowAmmoAndNoneLeftToReload = 10,
            ShouldReloadSecondaryTrigger = 11,
            FlashSecondaryInventoryAmmo = 12,
            FlashSecondaryReload = 13,
            FlashWhenFiringSecondaryTriggerWithNoAmmo = 14,
            LowSecondaryAmmoAndNoneLeftToReload = 15,
            PrimaryTriggerReady = 16,
            SecondaryTriggerReady = 17,
            FlashWhenFiringWithDepletedBattery = 18,
        }
        public enum CanUseOnMapTypeEnum : short
        {
            Any = 0,
            Solo = 1,
            Multiplayer = 2,
        }
    }
}