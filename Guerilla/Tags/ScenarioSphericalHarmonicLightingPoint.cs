// ReSharper disable All
using Moonfish.Model;
using Moonfish.Tags.BlamExtension;
using Moonfish.Tags;
using OpenTK;
using System;
using System.IO;

namespace Moonfish.Guerilla.Tags
{
    public  partial class ScenarioSphericalHarmonicLightingPoint : ScenarioSphericalHarmonicLightingPointBase
    {
        public  ScenarioSphericalHarmonicLightingPoint(BinaryReader binaryReader): base(binaryReader)
        {
            
        }
    };
    [LayoutAttribute(Size = 12, Alignment = 4)]
    public class ScenarioSphericalHarmonicLightingPointBase  : IGuerilla
    {
        internal OpenTK.Vector3 position;
        internal  ScenarioSphericalHarmonicLightingPointBase(BinaryReader binaryReader)
        {
            position = binaryReader.ReadVector3();
        }
        public int Write(System.IO.BinaryWriter binaryWriter, Int32 nextAddress)
        {
            using(binaryWriter.BaseStream.Pin())
            {
                binaryWriter.Write(position);
                return nextAddress = (int)binaryWriter.BaseStream.Position;
            }
        }
    };
}
