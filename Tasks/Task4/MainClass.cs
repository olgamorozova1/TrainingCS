
namespace Tasks.Task4
{
    internal class MainClass
    {
        //public static void Main()
        //{
        //    int dimension = 3;
        //    SquareMatrix<int> matrix = new SquareMatrix<int>(3);
        //    matrix.MatrixElementChangeEvent += ShowMessage;
        //    matrix.MatrixElementChangeEvent += (int indexA, int indexB, int oldValue) => Console.WriteLine("Event happened - lambda expr");
        //    matrix.MatrixElementChangeEvent += delegate (int indexA, int indexB, int oldValue) { Console.WriteLine("Event happened -  anonymous method"); };
        //    for (int i = 0; i < dimension; i++)
        //        for (int j = 0; j < dimension; j++)
        //        {
        //            {
        //                Random random = new Random();
        //                matrix[i, j] = random.Next(0, 10);
        //            }
        //        }
        //    DiagonalMatrix<int> diagonalMatrix = new DiagonalMatrix<int>(dimension);
        //    diagonalMatrix.MatrixElementChangeEvent += ShowMessage;
        //    diagonalMatrix.MatrixElementChangeEvent += (int indexA, int indexB, int oldValue) => Console.WriteLine("Event happened - lambda expr");
        //    diagonalMatrix.MatrixElementChangeEvent += delegate (int indexA, int indexB, int oldValue) { Console.WriteLine("Event happened -  anonymous method"); };
        //    for (int i = 0; i < dimension; i++)
        //        for (int j = 0; j < dimension; j++)
        //        {
        //            {
        //                Random random = new Random();
        //                diagonalMatrix[i, j] = random.Next(0, 10);
        //            }
        //        }
        //}

        public static void ShowMessage(int indexA, int indexB, int oldValue)
        {
            Console.WriteLine($"Value {oldValue} with index [{indexA}, {indexB}] has changed");
        }
    }
}
