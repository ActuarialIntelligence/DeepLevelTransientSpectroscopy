using ActuarialIntelligence.DLTS.Domain;
using ActuarialIntelligence.DLTS.NoiseModels;

namespace ActuarialIntelligence.DLTS.EXE
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = Noise.EmulateNoiseOverNPeriods(300, 9, 64);
            var strResult = Noise.GetPointsAsString();
            var quadrature = Quadrature.GetQuadratureMatrix(21, 0.01, 0.01);
        }
    }
}
