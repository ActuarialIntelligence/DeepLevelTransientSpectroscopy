using System;

namespace ActuarialIntelligence.DLTS.Domain.Matrix
{
    public class GivensRotationMatrix
    {

        double r = 0;
        double c = 0, s = 0, s_0 = 0;

        public GivensRotationMatrix()
        {

        }

        public void AssignCS(double a, double b)
        {
            r = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
            c = (a / r);
            s = -1 * (b / r);
            s_0 = (b / r);
        }

        public _nMatrix ReturnGivensMatrix(double a, double b, int position, int n)
        {
            AssignCS(a, b);
            var identityMatrix = new nIdentityMatrix();
            var matrix = identityMatrix.ReturnNIdentityMatrix(n);
            //matrix.SetValueAt(position, position, c);
            //matrix.SetValueAt(position + 1, position, s_0);
            //matrix.SetValueAt(position + 1, position + 1, c);
            //matrix.SetValueAt(position, position + 1, s);
            return matrix;
        }
    }
}
