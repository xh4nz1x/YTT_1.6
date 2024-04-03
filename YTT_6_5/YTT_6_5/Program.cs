// УП Практическая работа 1.6
// Задание 5. Дана прямоугольная матрица a, имеющей n строк и m столбцов.
// Исходная матрица состоит из нулей и единиц.
// Добавьте к матрице еще один столбец, каждый элемент которого делает количество единиц в каждой строке четным

namespace YTT_6_5
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Введите количество строк: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите количество столбцов: ");
            int m = Convert.ToInt32(Console.ReadLine());
            Random random = new Random();
            int[,] matrixOriginal = new int[n, m];
            int[,] matrixModified = new int[n, m + 1];
            Console.WriteLine("\nИсходная матрица:");
            for (int i = 0; i < matrixOriginal.GetLength(0); i++)
            {
                int oneCount = 0;
                for (int j = 0; j < matrixOriginal.GetLength(1); j++)
                {
                    matrixOriginal[i, j] = random.Next(0, 2);
                    matrixModified[i, j] = matrixOriginal[i, j];
                    Console.Write($"{matrixOriginal[i, j]} ");
                    if (matrixOriginal[i, j] == 1)
                    {
                        oneCount++;
                    }
                }
                if (oneCount % 2 == 1)
                {
                    matrixModified[i, m] = 1;
                }
                else if (oneCount % 2 == 0)
                {
                    matrixModified[i, m] = 0;
                }
                Console.WriteLine();
            }

            Console.WriteLine("\nИзмененная матрица:");
            for (int i = 0; i < matrixModified.GetLength(0); i++)
            {
                for (int j = 0; j < matrixModified.GetLength(1); j++)
                {
                    
                    Console.Write($"{matrixModified[i, j]} ");
                }
                Console.WriteLine();
            }
        }
    }
}