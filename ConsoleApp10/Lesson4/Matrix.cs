namespace ConsoleApp10.Lesson3.Lesson4
{
    internal class Matrix
    {
        public int[,] ArrayMatrix
        { 
            get;
            private set; 
        }

        public int RowCount
        {
           get => ArrayMatrix.GetLength(0);
        } 

        public int ColumnCount
        {
           get => ArrayMatrix.GetLength(1);
        } 

        public Matrix(int[,] arrayMatrix)
        {
            ArrayMatrix = arrayMatrix;
        }

        public void SumArray(int[,] arrayMatrix)
        {
            var sumArray = new int[ArrayMatrix.GetLength(0), arrayMatrix.GetLength(1)];
            Console.WriteLine("Сумма массивов:");
            for (int i = 0; i < RowCount; i++)
            {
                for (int j = 0; j < ColumnCount; j++)
                {
                    sumArray[i,j] =  arrayMatrix[i,j] + ArrayMatrix[i,j];
                    Console.Write(sumArray[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        public void MultiplayArray(int[,] arrayMatrix)
        {
            if (arrayMatrix.GetLength(0) != ArrayMatrix.GetLength(1))
            { 
                Console.WriteLine("Матрицы перемножать нельзя");
            }
            else
            {
                var multiplayArray = new int[ArrayMatrix.GetLength(0), arrayMatrix.GetLength(1)];
                Console.WriteLine("Произведение массивов:");
                for (int i = 0; i < ArrayMatrix.GetLength(0); i++)
                {
                    for (int j = 0; j < ArrayMatrix.GetLength(1); j++)
                    {
                        for (int k = 0; k < ArrayMatrix.GetLength(0); k++)
                        {
                            multiplayArray[i, j] = ArrayMatrix[i, j] * arrayMatrix[i, j];
                            Console.Write(multiplayArray[i, j] + " ");

                        }
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
        }

        public void MultiplayArrayByNumber(int number)
        {
            var multiplayArrayByNumber = new int[ArrayMatrix.GetLength(0), ArrayMatrix.GetLength(1)];
            Console.WriteLine($"Произведение массива на число {number}:");
            for (int i = 0; i < ArrayMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < ArrayMatrix.GetLength(1); j++)
                {
                    multiplayArrayByNumber[i, j] = ArrayMatrix[i, j] * number;
                    Console.Write(multiplayArrayByNumber[i, j] + " ");
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
