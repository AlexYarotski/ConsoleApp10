namespace ConsoleApp10.Lesson3.Lesson4
{
    internal class Matrix
    {
        public int[,] ArrayMatrix
        { 
            get;
            private set; 
        }

        private int _rowCount;

        public int RowCount
        {
            get { return ArrayMatrix.GetLength(0); }
        }

        private int _columnCount;

        public int ColumnCount
        {
            get { return ArrayMatrix.GetLength(1); }
        }

        public Matrix(int[,] arrayMatrix)
        {
            ArrayMatrix = arrayMatrix;
        }

        public void SumArray(int[,] arrayMatrix1, int[,] arrayMatrix2)
        {
            var sumArray = new int[ArrayMatrix.GetLength(0), arrayMatrix.GetLength(1)];
            Console.WriteLine("Сумма массивов:");
            for (int i = 0; i < ArrayMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < ArrayMatrix.GetLength(1); j++)
                {
                    ArrayMatrix[i,j] =  arrayMatrix1[i,j] + arrayMatrix2[i,j];
                    Console.Write(ArrayMatrix[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        public void MultiplayArray(int[,] arrayMatrix1, int[,] arrayMatrix2)
        {
                var multiplayArray = new int[ArrayMatrix.GetLength(0), arrayMatrix.GetLength(1)];
            Console.WriteLine("Произведение массивов:");
            for (int i = 0; i < ArrayMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < ArrayMatrix.GetLength(1); j++)
                {
                    ArrayMatrix[i, j] = arrayMatrix1[i, j] * arrayMatrix2[i, j];
                    Console.Write(ArrayMatrix[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        }

        public void MultiplayArrayByNumber(int[,] arrayMatrix1, int number)
        {
            var multiplayArrayByNumber = new int[ArrayMatrix.GetLength(0), ArrayMatrix.GetLength(1)];
            Console.WriteLine($"Произведение массива на число {number}:");
            for (int i = 0; i < ArrayMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < ArrayMatrix.GetLength(1); j++)
                {
                    ArrayMatrix[i, j] = arrayMatrix1[i, j] * number;
                    Console.Write(ArrayMatrix[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        public void GetRandomArray()
        {
            Console.WriteLine("Заполняем массив рандомными значениями:");
            Random random = new Random();

            for (int i = 0; i < ArrayMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < ArrayMatrix.GetLength(1); j++)
                {
                    ArrayMatrix[i, j] = random.Next(0, 10);
                    Console.Write(ArrayMatrix[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
