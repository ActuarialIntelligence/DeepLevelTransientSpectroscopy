using ActuarialIntelligence.DLTS.NoiseModels;

namespace ActuarialIntelligence.DLTS.EXE
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = Noise.EmulateNoiseOverNPeriods(300, 1.5, 0.01);
        }
    }
}
