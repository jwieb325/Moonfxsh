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
    
    [TagClassAttribute("goof")]
    public partial class MultiplayerVariantSettingsInterfaceDefinitionBlock : GuerillaBlock, IWriteQueueable
    {
        [Moonfish.Tags.TagReferenceAttribute("wgit")]
        public Moonfish.Tags.TagReference TagReference;
        [Moonfish.Tags.TagReferenceAttribute("wgit")]
        public Moonfish.Tags.TagReference TagReference0;
        [Moonfish.Tags.TagReferenceAttribute("wgit")]
        public Moonfish.Tags.TagReference TagReference1;
        public VariantSettingEditReferenceBlock[] GameEngineSettings = new VariantSettingEditReferenceBlock[0];
        [Moonfish.Tags.TagReferenceAttribute("unic")]
        public Moonfish.Tags.TagReference DefaultVariantStrings;
        public GDefaultVariantsBlock[] DefaultVariants = new GDefaultVariantsBlock[0];
        public CreateNewVariantStructBlock CreateNewVariantStruct = new CreateNewVariantStructBlock();
        public CreateNewVariantStructBlock CreateNewVariantStruct0 = new CreateNewVariantStructBlock();
        public CreateNewVariantStructBlock CreateNewVariantStruct1 = new CreateNewVariantStructBlock();
        public CreateNewVariantStructBlock CreateNewVariantStruct2 = new CreateNewVariantStructBlock();
        public CreateNewVariantStructBlock CreateNewVariantStruct3 = new CreateNewVariantStructBlock();
        public CreateNewVariantStructBlock CreateNewVariantStruct4 = new CreateNewVariantStructBlock();
        public CreateNewVariantStructBlock CreateNewVariantStruct5 = new CreateNewVariantStructBlock();
        public CreateNewVariantStructBlock CreateNewVariantStruct6 = new CreateNewVariantStructBlock();
        public CreateNewVariantStructBlock CreateNewVariantStruct7 = new CreateNewVariantStructBlock();
        public UnusedCreateNewVariantsBlock[] UnusedCreateNewVariants00 = new UnusedCreateNewVariantsBlock[7];
        public override int SerializedSize
        {
            get
            {
                return 368;
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
            this.TagReference = binaryReader.ReadTagReference();
            this.TagReference0 = binaryReader.ReadTagReference();
            this.TagReference1 = binaryReader.ReadTagReference();
            pointerQueue.Enqueue(binaryReader.ReadBlamPointer(24));
            this.DefaultVariantStrings = binaryReader.ReadTagReference();
            pointerQueue.Enqueue(binaryReader.ReadBlamPointer(20));
            pointerQueue = new System.Collections.Generic.Queue<Moonfish.Tags.BlamPointer>(pointerQueue.Concat(this.CreateNewVariantStruct.ReadFields(binaryReader)));
            pointerQueue = new System.Collections.Generic.Queue<Moonfish.Tags.BlamPointer>(pointerQueue.Concat(this.CreateNewVariantStruct0.ReadFields(binaryReader)));
            pointerQueue = new System.Collections.Generic.Queue<Moonfish.Tags.BlamPointer>(pointerQueue.Concat(this.CreateNewVariantStruct1.ReadFields(binaryReader)));
            pointerQueue = new System.Collections.Generic.Queue<Moonfish.Tags.BlamPointer>(pointerQueue.Concat(this.CreateNewVariantStruct2.ReadFields(binaryReader)));
            pointerQueue = new System.Collections.Generic.Queue<Moonfish.Tags.BlamPointer>(pointerQueue.Concat(this.CreateNewVariantStruct3.ReadFields(binaryReader)));
            pointerQueue = new System.Collections.Generic.Queue<Moonfish.Tags.BlamPointer>(pointerQueue.Concat(this.CreateNewVariantStruct4.ReadFields(binaryReader)));
            pointerQueue = new System.Collections.Generic.Queue<Moonfish.Tags.BlamPointer>(pointerQueue.Concat(this.CreateNewVariantStruct5.ReadFields(binaryReader)));
            pointerQueue = new System.Collections.Generic.Queue<Moonfish.Tags.BlamPointer>(pointerQueue.Concat(this.CreateNewVariantStruct6.ReadFields(binaryReader)));
            pointerQueue = new System.Collections.Generic.Queue<Moonfish.Tags.BlamPointer>(pointerQueue.Concat(this.CreateNewVariantStruct7.ReadFields(binaryReader)));
            int i;
            for (i = 0; (i < 7); i = (i + 1))
            {
                this.UnusedCreateNewVariants00[i] = new UnusedCreateNewVariantsBlock();
                pointerQueue = new System.Collections.Generic.Queue<Moonfish.Tags.BlamPointer>(pointerQueue.Concat(this.UnusedCreateNewVariants00[i].ReadFields(binaryReader)));
            }
            return pointerQueue;
        }
        public override void ReadInstances(System.IO.BinaryReader binaryReader, System.Collections.Generic.Queue<Moonfish.Tags.BlamPointer> pointerQueue)
        {
            base.ReadInstances(binaryReader, pointerQueue);
            this.GameEngineSettings = base.ReadBlockArrayData<VariantSettingEditReferenceBlock>(binaryReader, pointerQueue.Dequeue());
            this.DefaultVariants = base.ReadBlockArrayData<GDefaultVariantsBlock>(binaryReader, pointerQueue.Dequeue());
            this.CreateNewVariantStruct.ReadInstances(binaryReader, pointerQueue);
            this.CreateNewVariantStruct0.ReadInstances(binaryReader, pointerQueue);
            this.CreateNewVariantStruct1.ReadInstances(binaryReader, pointerQueue);
            this.CreateNewVariantStruct2.ReadInstances(binaryReader, pointerQueue);
            this.CreateNewVariantStruct3.ReadInstances(binaryReader, pointerQueue);
            this.CreateNewVariantStruct4.ReadInstances(binaryReader, pointerQueue);
            this.CreateNewVariantStruct5.ReadInstances(binaryReader, pointerQueue);
            this.CreateNewVariantStruct6.ReadInstances(binaryReader, pointerQueue);
            this.CreateNewVariantStruct7.ReadInstances(binaryReader, pointerQueue);
            int i;
            for (i = 0; (i < 7); i = (i + 1))
            {
                this.UnusedCreateNewVariants00[i].ReadInstances(binaryReader, pointerQueue);
            }
        }
        public override void QueueWrites(Moonfish.Guerilla.QueueableBinaryWriter queueableBinaryWriter)
        {
            base.QueueWrites(queueableBinaryWriter);
            queueableBinaryWriter.QueueWrite(this.GameEngineSettings);
            queueableBinaryWriter.QueueWrite(this.DefaultVariants);
            this.CreateNewVariantStruct.QueueWrites(queueableBinaryWriter);
            this.CreateNewVariantStruct0.QueueWrites(queueableBinaryWriter);
            this.CreateNewVariantStruct1.QueueWrites(queueableBinaryWriter);
            this.CreateNewVariantStruct2.QueueWrites(queueableBinaryWriter);
            this.CreateNewVariantStruct3.QueueWrites(queueableBinaryWriter);
            this.CreateNewVariantStruct4.QueueWrites(queueableBinaryWriter);
            this.CreateNewVariantStruct5.QueueWrites(queueableBinaryWriter);
            this.CreateNewVariantStruct6.QueueWrites(queueableBinaryWriter);
            this.CreateNewVariantStruct7.QueueWrites(queueableBinaryWriter);
            int i;
            for (i = 0; (i < 7); i = (i + 1))
            {
                this.UnusedCreateNewVariants00[i].QueueWrites(queueableBinaryWriter);
            }
        }
        public override void Write_(Moonfish.Guerilla.QueueableBinaryWriter queueableBinaryWriter)
        {
            base.Write_(queueableBinaryWriter);
            queueableBinaryWriter.Write(this.TagReference);
            queueableBinaryWriter.Write(this.TagReference0);
            queueableBinaryWriter.Write(this.TagReference1);
            queueableBinaryWriter.WritePointer(this.GameEngineSettings);
            queueableBinaryWriter.Write(this.DefaultVariantStrings);
            queueableBinaryWriter.WritePointer(this.DefaultVariants);
            this.CreateNewVariantStruct.Write_(queueableBinaryWriter);
            this.CreateNewVariantStruct0.Write_(queueableBinaryWriter);
            this.CreateNewVariantStruct1.Write_(queueableBinaryWriter);
            this.CreateNewVariantStruct2.Write_(queueableBinaryWriter);
            this.CreateNewVariantStruct3.Write_(queueableBinaryWriter);
            this.CreateNewVariantStruct4.Write_(queueableBinaryWriter);
            this.CreateNewVariantStruct5.Write_(queueableBinaryWriter);
            this.CreateNewVariantStruct6.Write_(queueableBinaryWriter);
            this.CreateNewVariantStruct7.Write_(queueableBinaryWriter);
            int i;
            for (i = 0; (i < 7); i = (i + 1))
            {
                this.UnusedCreateNewVariants00[i].Write_(queueableBinaryWriter);
            }
        }
        public class UnusedCreateNewVariantsBlock : GuerillaBlock, IWriteQueueable
        {
            public CreateNewVariantStructBlock CreateNewVariantStruct = new CreateNewVariantStructBlock();
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
                    return 1;
                }
            }
            public override System.Collections.Generic.Queue<Moonfish.Tags.BlamPointer> ReadFields(System.IO.BinaryReader binaryReader)
            {
                System.Collections.Generic.Queue<Moonfish.Tags.BlamPointer> pointerQueue = new System.Collections.Generic.Queue<Moonfish.Tags.BlamPointer>(base.ReadFields(binaryReader));
                pointerQueue = new System.Collections.Generic.Queue<Moonfish.Tags.BlamPointer>(pointerQueue.Concat(this.CreateNewVariantStruct.ReadFields(binaryReader)));
                return pointerQueue;
            }
            public override void ReadInstances(System.IO.BinaryReader binaryReader, System.Collections.Generic.Queue<Moonfish.Tags.BlamPointer> pointerQueue)
            {
                base.ReadInstances(binaryReader, pointerQueue);
                this.CreateNewVariantStruct.ReadInstances(binaryReader, pointerQueue);
            }
            public override void QueueWrites(Moonfish.Guerilla.QueueableBinaryWriter queueableBinaryWriter)
            {
                base.QueueWrites(queueableBinaryWriter);
                this.CreateNewVariantStruct.QueueWrites(queueableBinaryWriter);
            }
            public override void Write_(Moonfish.Guerilla.QueueableBinaryWriter queueableBinaryWriter)
            {
                base.Write_(queueableBinaryWriter);
                this.CreateNewVariantStruct.Write_(queueableBinaryWriter);
            }
        }
    }
}
namespace Moonfish.Tags
{
    
    public partial struct TagClass
    {
        public static TagClass Goof = ((TagClass)("goof"));
    }
}
