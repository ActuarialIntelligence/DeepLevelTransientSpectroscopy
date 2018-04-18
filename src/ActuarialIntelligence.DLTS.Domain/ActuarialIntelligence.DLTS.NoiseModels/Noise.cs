using ActuarialIntelligence.DLTS.Infrastructure;
using ActuarialIntelligence.DLTS.NoiseModels.DIstributions;
using System;
using System.Collections.Generic;

namespace ActuarialIntelligence.DLTS.NoiseModels
{
    public static class Noise
    {

        public static IList<Point<double, double>> EmulateNoiseOverNPeriods(int periods, double mean, double variance)
        {
            var noisePoints = new List<Point<double, double>>();
            var rand = new Random();
            for (int i=0; i<periods; i++)
            {
                var time = DateTime.Now;
                var minusPlus = Math.Pow((-1), i);
                var randVal = Math.Round(rand.NextDouble(),2);
                var randomValue = variance*randVal + mean* minusPlus;
                noisePoints.Add(new Point<double, double>(i, 
                    NormalDistribution.NormalDistributionValueAt(randomValue, mean, variance)));

                while(DateTime.Now<time.AddMilliseconds(10))
                {
                    Console.WriteLine("{0}..{1}..{2}", i,DateTime.Now, time.AddMilliseconds(200));
                }
                
            }
            return noisePoints;
        }

    }

}
