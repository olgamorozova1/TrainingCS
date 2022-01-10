/*
 * Class represents a diagonal matrix where elements which are not main diagonal is 0 
 * 
 */
namespace Tasks.Task4
{
    internal class DiagonalMatrix<T> : SquareMatrix<T>
    {
        public event MatrixElementChangeHandler MatrixElementChangeEvent;
        public DiagonalMatrix(int demention) : base(demention)
        {
        }

        public T this[int a, int b]
        {
            get
            {
                    int index = matrixDimension * a + b;
                    ValidateIndex(a, b, index);
                    return matrix[index];
            }
            set
            {
                int index = matrixDimension * a + b;
                ValidateIndex(a, b, index);
                T oldValue = matrix[index];
                if (a == b)
                {
                    matrix[index] = value;
                }
                else matrix[index] = default(T);
                if (!oldValue.Equals(value))
                {
                    MatrixElementChangeEvent?.Invoke(a, b, oldValue);
                }
            }
        }
    }
}
