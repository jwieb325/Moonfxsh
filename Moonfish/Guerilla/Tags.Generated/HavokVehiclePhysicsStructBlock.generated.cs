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
    [TagBlockOriginalNameAttribute("havok_vehicle_physics_struct_block")]
    public partial class HavokVehiclePhysicsStructBlock : GuerillaBlock, IWriteDeferrable
    {
        public Flags HavokVehiclePhysicsStructFlags;
        public float GroundFriction;
        public float GroundDepth;
        public float GroundDampFactor;
        public float GroundMovingFriction;
        public float GroundMaximumSlope0;
        public float GroundMaximumSlope1;
        private byte[] fieldpad = new byte[16];
        public float AntiGravityBankLift;
        public float SteeringBankReactionScale;
        public float GravityScale;
        public float Radius;
        public AntiGravityPointDefinitionBlock[] AntiGravityPoints = new AntiGravityPointDefinitionBlock[0];
        public FrictionPointDefinitionBlock[] FrictionPoints = new FrictionPointDefinitionBlock[0];
        [Moonfish.Guerilla.LayoutAttribute(Pack=16)]
        public VehiclePhantomShapeBlock[] shapePhantomShape = new VehiclePhantomShapeBlock[0];
        public override int SerializedSize
        {
            get
            {
                return 84;
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
            this.HavokVehiclePhysicsStructFlags = ((Flags)(binaryReader.ReadInt32()));
            this.GroundFriction = binaryReader.ReadSingle();
            this.GroundDepth = binaryReader.ReadSingle();
            this.GroundDampFactor = binaryReader.ReadSingle();
            this.GroundMovingFriction = binaryReader.ReadSingle();
            this.GroundMaximumSlope0 = binaryReader.ReadSingle();
            this.GroundMaximumSlope1 = binaryReader.ReadSingle();
            this.fieldpad = binaryReader.ReadBytes(16);
            this.AntiGravityBankLift = binaryReader.ReadSingle();
            this.SteeringBankReactionScale = binaryReader.ReadSingle();
            this.GravityScale = binaryReader.ReadSingle();
            this.Radius = binaryReader.ReadSingle();
            pointerQueue.Enqueue(binaryReader.ReadBlamPointer(76));
            pointerQueue.Enqueue(binaryReader.ReadBlamPointer(76));
            pointerQueue.Enqueue(binaryReader.ReadBlamPointer(672));
            return pointerQueue;
        }
        public override void ReadInstances(Moonfish.Guerilla.BlamBinaryReader binaryReader, System.Collections.Generic.Queue<Moonfish.Tags.BlamPointer> pointerQueue)
        {
            base.ReadInstances(binaryReader, pointerQueue);
            this.AntiGravityPoints = base.ReadBlockArrayData<AntiGravityPointDefinitionBlock>(binaryReader, pointerQueue.Dequeue());
            this.FrictionPoints = base.ReadBlockArrayData<FrictionPointDefinitionBlock>(binaryReader, pointerQueue.Dequeue());
            this.shapePhantomShape = base.ReadBlockArrayData<VehiclePhantomShapeBlock>(binaryReader, pointerQueue.Dequeue());
        }
        public override void DeferReferences(Moonfish.Guerilla.LinearBinaryWriter writer)
        {
            base.DeferReferences(writer);
            writer.Defer(this.AntiGravityPoints);
            writer.Defer(this.FrictionPoints);
            writer.Defer(this.shapePhantomShape);
        }
        public override void Write(Moonfish.Guerilla.LinearBinaryWriter writer)
        {
            base.Write(writer);
            writer.Write(((int)(this.HavokVehiclePhysicsStructFlags)));
            writer.Write(this.GroundFriction);
            writer.Write(this.GroundDepth);
            writer.Write(this.GroundDampFactor);
            writer.Write(this.GroundMovingFriction);
            writer.Write(this.GroundMaximumSlope0);
            writer.Write(this.GroundMaximumSlope1);
            writer.Write(this.fieldpad);
            writer.Write(this.AntiGravityBankLift);
            writer.Write(this.SteeringBankReactionScale);
            writer.Write(this.GravityScale);
            writer.Write(this.Radius);
            writer.WritePointer(this.AntiGravityPoints);
            writer.WritePointer(this.FrictionPoints);
            writer.WritePointer(this.shapePhantomShape);
        }
        [System.FlagsAttribute()]
        public enum Flags : int
        {
            None = 0,
            Invalid = 1,
        }
    }
}
