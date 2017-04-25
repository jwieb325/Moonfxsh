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
    [TagClassAttribute("wigl")]
    [TagBlockOriginalNameAttribute("user_interface_shared_globals_definition_block")]
    public partial class UserInterfaceSharedGlobalsDefinitionBlock : GuerillaBlock, IWriteQueueable
    {
        private byte[] fieldpad = new byte[2];
        private byte[] fieldpad0 = new byte[2];
        private byte[] fieldpad1 = new byte[16];
        private byte[] fieldpad2 = new byte[8];
        private byte[] fieldpad3 = new byte[8];
        private byte[] fieldpad4 = new byte[16];
        private byte[] fieldpad5 = new byte[8];
        private byte[] fieldpad6 = new byte[8];
        /// <summary>
        /// miscellaneous rendering globals, more below...
        /// </summary>
        public float OverlayedScreenAlphaMod;
        public short IncTextUpdatePeriod;
        public short IncTextBlockCharacter;
        public float CalloutTextScale;
        public OpenTK.Vector4 ProgressBarColor;
        public float NearClipPlaneDistance;
        public float ProjectionPlaneDistance;
        public float FarClipPlaneDistance;
        /// <summary>
        /// This is the color of the overlayed ui effect; the alpha component is the maximum opacity
        /// </summary>
        public OpenTK.Vector4 OverlayedInterfaceColor;
        private byte[] fieldpad7 = new byte[12];
        public UiErrorCategoryBlock[] Errors = new UiErrorCategoryBlock[0];
        /// <summary>
        /// This is the sound that plays as you tab through items
        /// </summary>
        [Moonfish.Tags.TagReferenceAttribute("snd!")]
        public Moonfish.Tags.TagReference SoundTag;
        /// <summary>
        /// This is the sound that plays when an item is selected
        /// </summary>
        [Moonfish.Tags.TagReferenceAttribute("snd!")]
        public Moonfish.Tags.TagReference SoundTag0;
        /// <summary>
        /// This is the sound that plays to alert the user that something went wrong
        /// </summary>
        [Moonfish.Tags.TagReferenceAttribute("snd!")]
        public Moonfish.Tags.TagReference SoundTag1;
        /// <summary>
        /// This is the sound that plays when advancing to a new screen
        /// </summary>
        [Moonfish.Tags.TagReferenceAttribute("snd!")]
        public Moonfish.Tags.TagReference SoundTag2;
        /// <summary>
        /// This is the sound that plays when retreating to a previous screen
        /// </summary>
        [Moonfish.Tags.TagReferenceAttribute("snd!")]
        public Moonfish.Tags.TagReference SoundTag3;
        /// <summary>
        /// This is the sound that plays when advancing past the initial login screen
        /// </summary>
        [Moonfish.Tags.TagReferenceAttribute("snd!")]
        public Moonfish.Tags.TagReference SoundTag4;
        /// <summary>
        /// This is the sound that plays when cursoring in the vkeyboard
        /// </summary>
        [Moonfish.Tags.TagReferenceAttribute("snd!")]
        public Moonfish.Tags.TagReference SoundTag5;
        /// <summary>
        /// This is the sound that plays when selecting buttons in the vkeyboard
        /// </summary>
        [Moonfish.Tags.TagReferenceAttribute("snd!")]
        public Moonfish.Tags.TagReference SoundTag6;
        /// <summary>
        /// This is the sound that plays when you receive an online notification
        /// </summary>
        [Moonfish.Tags.TagReferenceAttribute("snd!")]
        public Moonfish.Tags.TagReference SoundTag7;
        /// <summary>
        /// This is the sound that plays when tabbing thru views in a tabbed view pane (eg, online menu)
        /// </summary>
        [Moonfish.Tags.TagReferenceAttribute("snd!")]
        public Moonfish.Tags.TagReference SoundTag8;
        /// <summary>
        /// This is the sound that plays as the countdown timer progresses
        /// </summary>
        [Moonfish.Tags.TagReferenceAttribute("snd!")]
        public Moonfish.Tags.TagReference SoundTag9;
        [Moonfish.Tags.TagReferenceAttribute("snd!")]
        public Moonfish.Tags.TagReference TagReference;
        /// <summary>
        /// This is the sound that plays as matchmaking enters the final stage
        /// </summary>
        [Moonfish.Tags.TagReferenceAttribute("snd!")]
        public Moonfish.Tags.TagReference SoundTag10;
        [Moonfish.Tags.TagReferenceAttribute("snd!")]
        public Moonfish.Tags.TagReference TagReference0;
        [Moonfish.Tags.TagReferenceAttribute("snd!")]
        public Moonfish.Tags.TagReference TagReference1;
        [Moonfish.Tags.TagReferenceAttribute("snd!")]
        public Moonfish.Tags.TagReference TagReference2;
        /// <summary>
        /// Sprite sequences for global ui bitmaps, as follows:
        ///1) vkeyboard cursor
        /// </summary>
        [Moonfish.Tags.TagReferenceAttribute("bitm")]
        public Moonfish.Tags.TagReference GlobalBitmapsTag;
        /// <summary>
        /// Global UI Text goes here
        /// </summary>
        [Moonfish.Tags.TagReferenceAttribute("unic")]
        public Moonfish.Tags.TagReference UnicodeStringListTag;
        public AnimationReferenceBlock[] ScreenAnimations = new AnimationReferenceBlock[0];
        public ShapeGroupReferenceBlock[] ShapeGroups = new ShapeGroupReferenceBlock[0];
        public PersistentBackgroundAnimationBlock[] Animations = new PersistentBackgroundAnimationBlock[0];
        public ListSkinReferenceBlock[] ListItemSkins = new ListSkinReferenceBlock[0];
        /// <summary>
        /// These are for specific purposes as noted
        /// </summary>
        [Moonfish.Tags.TagReferenceAttribute("unic")]
        public Moonfish.Tags.TagReference ButtonKeyTypeStrings;
        [Moonfish.Tags.TagReferenceAttribute("unic")]
        public Moonfish.Tags.TagReference GameTypeStrings;
        [Moonfish.Tags.TagReferenceAttribute("null")]
        public Moonfish.Tags.TagReference TagReference3;
        public SkillToRankMappingBlock[] SkillMappings = new SkillToRankMappingBlock[0];
        public FullScreenHeaderTextFontEnum FullScreenHeaderTextFont;
        public LargeDialogHeaderTextFontEnum LargeDialogHeaderTextFont;
        public HalfDialogHeaderTextFontEnum HalfDialogHeaderTextFont;
        public QtrDialogHeaderTextFontEnum QtrDialogHeaderTextFont;
        public OpenTK.Vector4 DefaultTextColor;
        public OpenTK.Vector2 FullScreenHeaderTextBounds;
        public OpenTK.Vector2 FullScreenButtonKeyTextBounds;
        public OpenTK.Vector2 LargeDialogHeaderTextBounds;
        public OpenTK.Vector2 LargeDialogButtonKeyTextBounds;
        public OpenTK.Vector2 HalfDialogHeaderTextBounds;
        public OpenTK.Vector2 HalfDialogButtonKeyTextBounds;
        public OpenTK.Vector2 QtrDialogHeaderTextBounds;
        public OpenTK.Vector2 QtrDialogButtonKeyTextBounds;
        /// <summary>
        /// Looping sound that plays while the main menu is active
        /// </summary>
        [Moonfish.Tags.TagReferenceAttribute("lsnd")]
        public Moonfish.Tags.TagReference MainMenuMusic;
        public int MusicFadeTime;
        public override int SerializedSize
        {
            get
            {
                return 452;
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
            this.fieldpad = binaryReader.ReadBytes(2);
            this.fieldpad0 = binaryReader.ReadBytes(2);
            this.fieldpad1 = binaryReader.ReadBytes(16);
            this.fieldpad2 = binaryReader.ReadBytes(8);
            this.fieldpad3 = binaryReader.ReadBytes(8);
            this.fieldpad4 = binaryReader.ReadBytes(16);
            this.fieldpad5 = binaryReader.ReadBytes(8);
            this.fieldpad6 = binaryReader.ReadBytes(8);
            this.OverlayedScreenAlphaMod = binaryReader.ReadSingle();
            this.IncTextUpdatePeriod = binaryReader.ReadInt16();
            this.IncTextBlockCharacter = binaryReader.ReadInt16();
            this.CalloutTextScale = binaryReader.ReadSingle();
            this.ProgressBarColor = binaryReader.ReadVector4();
            this.NearClipPlaneDistance = binaryReader.ReadSingle();
            this.ProjectionPlaneDistance = binaryReader.ReadSingle();
            this.FarClipPlaneDistance = binaryReader.ReadSingle();
            this.OverlayedInterfaceColor = binaryReader.ReadVector4();
            this.fieldpad7 = binaryReader.ReadBytes(12);
            pointerQueue.Enqueue(binaryReader.ReadBlamPointer(40));
            this.SoundTag = binaryReader.ReadTagReference();
            this.SoundTag0 = binaryReader.ReadTagReference();
            this.SoundTag1 = binaryReader.ReadTagReference();
            this.SoundTag2 = binaryReader.ReadTagReference();
            this.SoundTag3 = binaryReader.ReadTagReference();
            this.SoundTag4 = binaryReader.ReadTagReference();
            this.SoundTag5 = binaryReader.ReadTagReference();
            this.SoundTag6 = binaryReader.ReadTagReference();
            this.SoundTag7 = binaryReader.ReadTagReference();
            this.SoundTag8 = binaryReader.ReadTagReference();
            this.SoundTag9 = binaryReader.ReadTagReference();
            this.TagReference = binaryReader.ReadTagReference();
            this.SoundTag10 = binaryReader.ReadTagReference();
            this.TagReference0 = binaryReader.ReadTagReference();
            this.TagReference1 = binaryReader.ReadTagReference();
            this.TagReference2 = binaryReader.ReadTagReference();
            this.GlobalBitmapsTag = binaryReader.ReadTagReference();
            this.UnicodeStringListTag = binaryReader.ReadTagReference();
            pointerQueue.Enqueue(binaryReader.ReadBlamPointer(44));
            pointerQueue.Enqueue(binaryReader.ReadBlamPointer(24));
            pointerQueue.Enqueue(binaryReader.ReadBlamPointer(16));
            pointerQueue.Enqueue(binaryReader.ReadBlamPointer(8));
            this.ButtonKeyTypeStrings = binaryReader.ReadTagReference();
            this.GameTypeStrings = binaryReader.ReadTagReference();
            this.TagReference3 = binaryReader.ReadTagReference();
            pointerQueue.Enqueue(binaryReader.ReadBlamPointer(4));
            this.FullScreenHeaderTextFont = ((FullScreenHeaderTextFontEnum)(binaryReader.ReadInt16()));
            this.LargeDialogHeaderTextFont = ((LargeDialogHeaderTextFontEnum)(binaryReader.ReadInt16()));
            this.HalfDialogHeaderTextFont = ((HalfDialogHeaderTextFontEnum)(binaryReader.ReadInt16()));
            this.QtrDialogHeaderTextFont = ((QtrDialogHeaderTextFontEnum)(binaryReader.ReadInt16()));
            this.DefaultTextColor = binaryReader.ReadVector4();
            this.FullScreenHeaderTextBounds = binaryReader.ReadVector2();
            this.FullScreenButtonKeyTextBounds = binaryReader.ReadVector2();
            this.LargeDialogHeaderTextBounds = binaryReader.ReadVector2();
            this.LargeDialogButtonKeyTextBounds = binaryReader.ReadVector2();
            this.HalfDialogHeaderTextBounds = binaryReader.ReadVector2();
            this.HalfDialogButtonKeyTextBounds = binaryReader.ReadVector2();
            this.QtrDialogHeaderTextBounds = binaryReader.ReadVector2();
            this.QtrDialogButtonKeyTextBounds = binaryReader.ReadVector2();
            this.MainMenuMusic = binaryReader.ReadTagReference();
            this.MusicFadeTime = binaryReader.ReadInt32();
            return pointerQueue;
        }
        public override void ReadInstances(Moonfish.Guerilla.BlamBinaryReader binaryReader, System.Collections.Generic.Queue<Moonfish.Tags.BlamPointer> pointerQueue)
        {
            base.ReadInstances(binaryReader, pointerQueue);
            this.Errors = base.ReadBlockArrayData<UiErrorCategoryBlock>(binaryReader, pointerQueue.Dequeue());
            this.ScreenAnimations = base.ReadBlockArrayData<AnimationReferenceBlock>(binaryReader, pointerQueue.Dequeue());
            this.ShapeGroups = base.ReadBlockArrayData<ShapeGroupReferenceBlock>(binaryReader, pointerQueue.Dequeue());
            this.Animations = base.ReadBlockArrayData<PersistentBackgroundAnimationBlock>(binaryReader, pointerQueue.Dequeue());
            this.ListItemSkins = base.ReadBlockArrayData<ListSkinReferenceBlock>(binaryReader, pointerQueue.Dequeue());
            this.SkillMappings = base.ReadBlockArrayData<SkillToRankMappingBlock>(binaryReader, pointerQueue.Dequeue());
        }
        public override void Defer(Moonfish.Guerilla.QueueableBlamBinaryWriter queueableBinaryWriter)
        {
            base.Defer(queueableBinaryWriter);
            queueableBinaryWriter.Defer(this.Errors);
            queueableBinaryWriter.Defer(this.ScreenAnimations);
            queueableBinaryWriter.Defer(this.ShapeGroups);
            queueableBinaryWriter.Defer(this.Animations);
            queueableBinaryWriter.Defer(this.ListItemSkins);
            queueableBinaryWriter.Defer(this.SkillMappings);
        }
        public override void Write(Moonfish.Guerilla.QueueableBlamBinaryWriter queueableBinaryWriter)
        {
            base.Write(queueableBinaryWriter);
            queueableBinaryWriter.Write(this.fieldpad);
            queueableBinaryWriter.Write(this.fieldpad0);
            queueableBinaryWriter.Write(this.fieldpad1);
            queueableBinaryWriter.Write(this.fieldpad2);
            queueableBinaryWriter.Write(this.fieldpad3);
            queueableBinaryWriter.Write(this.fieldpad4);
            queueableBinaryWriter.Write(this.fieldpad5);
            queueableBinaryWriter.Write(this.fieldpad6);
            queueableBinaryWriter.Write(this.OverlayedScreenAlphaMod);
            queueableBinaryWriter.Write(this.IncTextUpdatePeriod);
            queueableBinaryWriter.Write(this.IncTextBlockCharacter);
            queueableBinaryWriter.Write(this.CalloutTextScale);
            queueableBinaryWriter.Write(this.ProgressBarColor);
            queueableBinaryWriter.Write(this.NearClipPlaneDistance);
            queueableBinaryWriter.Write(this.ProjectionPlaneDistance);
            queueableBinaryWriter.Write(this.FarClipPlaneDistance);
            queueableBinaryWriter.Write(this.OverlayedInterfaceColor);
            queueableBinaryWriter.Write(this.fieldpad7);
            queueableBinaryWriter.WritePointer(this.Errors);
            queueableBinaryWriter.Write(this.SoundTag);
            queueableBinaryWriter.Write(this.SoundTag0);
            queueableBinaryWriter.Write(this.SoundTag1);
            queueableBinaryWriter.Write(this.SoundTag2);
            queueableBinaryWriter.Write(this.SoundTag3);
            queueableBinaryWriter.Write(this.SoundTag4);
            queueableBinaryWriter.Write(this.SoundTag5);
            queueableBinaryWriter.Write(this.SoundTag6);
            queueableBinaryWriter.Write(this.SoundTag7);
            queueableBinaryWriter.Write(this.SoundTag8);
            queueableBinaryWriter.Write(this.SoundTag9);
            queueableBinaryWriter.Write(this.TagReference);
            queueableBinaryWriter.Write(this.SoundTag10);
            queueableBinaryWriter.Write(this.TagReference0);
            queueableBinaryWriter.Write(this.TagReference1);
            queueableBinaryWriter.Write(this.TagReference2);
            queueableBinaryWriter.Write(this.GlobalBitmapsTag);
            queueableBinaryWriter.Write(this.UnicodeStringListTag);
            queueableBinaryWriter.WritePointer(this.ScreenAnimations);
            queueableBinaryWriter.WritePointer(this.ShapeGroups);
            queueableBinaryWriter.WritePointer(this.Animations);
            queueableBinaryWriter.WritePointer(this.ListItemSkins);
            queueableBinaryWriter.Write(this.ButtonKeyTypeStrings);
            queueableBinaryWriter.Write(this.GameTypeStrings);
            queueableBinaryWriter.Write(this.TagReference3);
            queueableBinaryWriter.WritePointer(this.SkillMappings);
            queueableBinaryWriter.Write(((short)(this.FullScreenHeaderTextFont)));
            queueableBinaryWriter.Write(((short)(this.LargeDialogHeaderTextFont)));
            queueableBinaryWriter.Write(((short)(this.HalfDialogHeaderTextFont)));
            queueableBinaryWriter.Write(((short)(this.QtrDialogHeaderTextFont)));
            queueableBinaryWriter.Write(this.DefaultTextColor);
            queueableBinaryWriter.Write(this.FullScreenHeaderTextBounds);
            queueableBinaryWriter.Write(this.FullScreenButtonKeyTextBounds);
            queueableBinaryWriter.Write(this.LargeDialogHeaderTextBounds);
            queueableBinaryWriter.Write(this.LargeDialogButtonKeyTextBounds);
            queueableBinaryWriter.Write(this.HalfDialogHeaderTextBounds);
            queueableBinaryWriter.Write(this.HalfDialogButtonKeyTextBounds);
            queueableBinaryWriter.Write(this.QtrDialogHeaderTextBounds);
            queueableBinaryWriter.Write(this.QtrDialogButtonKeyTextBounds);
            queueableBinaryWriter.Write(this.MainMenuMusic);
            queueableBinaryWriter.Write(this.MusicFadeTime);
        }
        /// <summary>
        /// Various settings for different sized UI windows
        /// </summary>
        public enum FullScreenHeaderTextFontEnum : short
        {
            Terminal = 0,
            BodyText = 1,
            Title = 2,
            SuperLargeFont = 3,
            LargeBodyText = 4,
            SplitScreenHudMessage = 5,
            FullScreenHudMessage = 6,
            EnglishBodyText = 7,
            HUDNumberText = 8,
            SubtitleFont = 9,
            MainMenuFont = 10,
            TextChatFont = 11,
        }
        public enum LargeDialogHeaderTextFontEnum : short
        {
            Terminal = 0,
            BodyText = 1,
            Title = 2,
            SuperLargeFont = 3,
            LargeBodyText = 4,
            SplitScreenHudMessage = 5,
            FullScreenHudMessage = 6,
            EnglishBodyText = 7,
            HUDNumberText = 8,
            SubtitleFont = 9,
            MainMenuFont = 10,
            TextChatFont = 11,
        }
        public enum HalfDialogHeaderTextFontEnum : short
        {
            Terminal = 0,
            BodyText = 1,
            Title = 2,
            SuperLargeFont = 3,
            LargeBodyText = 4,
            SplitScreenHudMessage = 5,
            FullScreenHudMessage = 6,
            EnglishBodyText = 7,
            HUDNumberText = 8,
            SubtitleFont = 9,
            MainMenuFont = 10,
            TextChatFont = 11,
        }
        public enum QtrDialogHeaderTextFontEnum : short
        {
            Terminal = 0,
            BodyText = 1,
            Title = 2,
            SuperLargeFont = 3,
            LargeBodyText = 4,
            SplitScreenHudMessage = 5,
            FullScreenHudMessage = 6,
            EnglishBodyText = 7,
            HUDNumberText = 8,
            SubtitleFont = 9,
            MainMenuFont = 10,
            TextChatFont = 11,
        }
    }
}
namespace Moonfish.Tags
{
    
    public partial struct TagClass
    {
        public static TagClass Wigl = ((TagClass)("wigl"));
    }
}
