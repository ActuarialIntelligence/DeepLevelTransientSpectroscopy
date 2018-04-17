using System;

namespace ActuarialIntelligence.DLTS.NoiseModels.DIstributions
{
    public static class NormalDistribution
    {
        public static double NormalDistributionValueAt(double x,double mean, double variance)
        {
            var firstTerm = (1 / Math.Sqrt(2 * Math.PI * variance));
            var secondTerm = Math.Pow(Math.E, ((-1) * Math.Pow((x - mean), 2)) / (2 * variance));
            var result = firstTerm * secondTerm;
            return result;
        }
    }
}
