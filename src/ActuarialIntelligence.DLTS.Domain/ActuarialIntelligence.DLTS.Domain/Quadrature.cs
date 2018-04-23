using ActuarialIntelligence.DLTS.Domain.Matrix;
using System;
using System.Collections.Generic;

namespace ActuarialIntelligence.DLTS.Domain
{
    public static class Quadrature
    {
        public static _mnMatrix GetQuadratureMatrix(int steps, double ds, double dt)
        {
            var rows = new List<_nVector>();
            for(int t = 1; t <= steps; t++)
            {
                var doubleList = new List<double>();
                for(int r = 0; r < steps; r++)
                {
                    var temp = ds * Math.Pow(Math.E, (-1) * (ds * r) * (dt * t)); // At a specific time constant.
                    doubleList.Add(temp);
                }
                rows.Add(new _nVector(doubleList));
            }
            var matrix = new _mnMatrix(rows,steps,steps);
            return matrix;
        }
    }
}
