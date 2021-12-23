/*
 * Class represents a square matrix.
 * Matrix size should be > 0.
 * 
 */
namespace Tasks.Task4
{
    internal class SquareMatrix<T>
    {
        protected int matrixDimension;
        protected T[] matrix;
        protected int maxIndex;
        public delegate void MatrixElementChangeHandler(int indexA, int indexB, T oldValue);
        public event MatrixElementChangeHandler MatrixElementChangeEvent;

        public SquareMatrix(int dimension)
        {
            if (dimension > 0 ) {
                this.matrixDimension = dimension;
                maxIndex = dimension * dimension;
                matrix = new T[maxIndex];
            }
            else
            {
                throw new Exception("Metrix demension should be > 0");
            }
            
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
                matrix[index] = value;
                if (!oldValue.Equals(value))
                {
                    MatrixElementChangeEvent?.Invoke(a, b, oldValue);
                }
            }
        }

        protected void ValidateIndex (int a, int b, int index)
        {
            if (a < 0 || b < 0 || index >= maxIndex)
            {
                throw new IndexOutOfRangeException("Index is out of range");
            }
        }
    }
}
