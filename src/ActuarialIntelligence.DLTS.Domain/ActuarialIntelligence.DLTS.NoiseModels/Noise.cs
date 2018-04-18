using ActuarialIntelligence.DLTS.Infrastructure;
using ActuarialIntelligence.DLTS.NoiseModels.DIstributions;
using System;
using System.Collections.Generic;
using System.Threading;

namespace ActuarialIntelligence.DLTS.NoiseModels
{
    public static class Noise
    {

        public static IList<Point<double, double>> EmulateNoiseOverNPeriods(int periods, double mean, double variance)
        {
            var noisePoints = new List<Point<double, double>>();
           
            for(int i=0; i<periods; i++)
            {
                var time = DateTime.Now;
                var rand = new Random();
                var minusPlus = rand.Next(-1, 1);
                var randomValue = rand.NextDouble() + mean* minusPlus;
                noisePoints.Add(new Point<double, double>(i, 
                    NormalDistribution.NormalDistributionValueAt(randomValue, mean, variance)));

                //We distinctly dislike the C# Timer Class
                while(DateTime.Now<time.AddMilliseconds(200))
                {
                    Console.WriteLine("{0}..{1}..{2}", i,DateTime.Now, time.AddMilliseconds(200));
                }
                
            }
            return noisePoints;
        }

    }

}
