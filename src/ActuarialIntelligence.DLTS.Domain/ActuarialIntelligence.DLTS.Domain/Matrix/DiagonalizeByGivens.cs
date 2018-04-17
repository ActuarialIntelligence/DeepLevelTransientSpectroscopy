namespace ActuarialIntelligence.DLTS.Domain.Matrix
{
    public class DiagonalizeByGivens
    {
        private _nMatrix matrix;
        public DiagonalizeByGivens(_nMatrix matrix)
        {
            this.matrix = matrix;
        }

        public _nMatrix GetDiagonalizedMatrix(int n)
        {
            var givens = new GivensRotationMatrix();
            double a = 0, b = 0;
            _nMatrix res = null;
            for (int i = 0; i < n - 1; i++)
            {
                a = matrix.GetValueAt(i + 1, i + 1);
                b = matrix.GetValueAt(i + 1, i + 2);
                var givensMatrix = givens.ReturnGivensMatrix(a, b, i + 1, n);
                res = matrix.MultiplyByAnotherMatrix(givensMatrix);
            }
            return res;
        }
    }
}
