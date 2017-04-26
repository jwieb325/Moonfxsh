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
    [TagBlockOriginalNameAttribute("player_block_reference_block")]
    public partial class PlayerBlockReferenceBlock : GuerillaBlock, IWriteDeferrable
    {
        private byte[] fieldpad = new byte[4];
        [Moonfish.Tags.TagReferenceAttribute("skin")]
        public Moonfish.Tags.TagReference Skin;
        public Moonfish.Tags.Point Bottomleft;
        public TableOrderEnum TableOrder;
        public byte MaximumPlayerCount;
        public byte RowCount;
        public byte ColumnCount;
        public short RowHeight;
        public short ColumnWidth;
        public override int SerializedSize
        {
            get
            {
                return 24;
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
            this.fieldpad = binaryReader.ReadBytes(4);
            this.Skin = binaryReader.ReadTagReference();
            this.Bottomleft = binaryReader.ReadPoint();
            this.TableOrder = ((TableOrderEnum)(binaryReader.ReadByte()));
            this.MaximumPlayerCount = binaryReader.ReadByte();
            this.RowCount = binaryReader.ReadByte();
            this.ColumnCount = binaryReader.ReadByte();
            this.RowHeight = binaryReader.ReadInt16();
            this.ColumnWidth = binaryReader.ReadInt16();
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
            writer.Write(this.fieldpad);
            writer.Write(this.Skin);
            writer.Write(this.Bottomleft);
            writer.Write(((byte)(this.TableOrder)));
            writer.Write(this.MaximumPlayerCount);
            writer.Write(this.RowCount);
            writer.Write(this.ColumnCount);
            writer.Write(this.RowHeight);
            writer.Write(this.ColumnWidth);
        }
        public enum TableOrderEnum : byte
        {
            RowMajor = 0,
            ColumnMajor = 1,
        }
    }
}
