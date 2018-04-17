using ActuarialIntelligence.DLTS.Infrastructure;
using ActuarialIntelligence.DLTS.NoiseModels.DIstributions;
using System;
using System.Collections.Generic;

namespace ActuarialIntelligence.DLTS.NoiseModels
{
    public class Noise
    {
        public void EmulateNoiseOverNPeriods(int periods, double mean, double variance)
        {
            var noisePoints = new List<Point<double, double>>(); 
            for(int i=0; i<periods; i++)
            {
                var rand = new Random();
                var minusPlus = rand.Next(-1, 1);
                var randomValue = rand.NextDouble()*mean* minusPlus;
                noisePoints.Add(new Point<double, double>(i, 
                    NormalDistribution.NormalDistributionValueAt(randomValue, mean, variance)));
            }
        }
    }
}
