// УП Практическая работа 1.6
// Задание 6. Дан массив со случайным количеством дробных чисел.
// Из элементов исходного массива постройте два новых.
// В первый должны входить только положительные элементы, а во второй только отрицательные элементы

namespace YTT_6_6
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Random random = new Random();
            int randomCount = random.Next(1, 100);
            double[] array = new double[randomCount];
            int countPositive = 0, countNegative = 0, iP = 0, iN = 0;
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Math.Round((random.NextDouble() * (100 - (-100)) + (-100)), 2);
                if (array[i] < 0)
                {
                    countNegative++;
                }
                else if (array[i] >= 0)
                {
                    countPositive++;
                }
            }

            double[] arrayPositive = new double[countPositive];
            double[] arrayNegative = new double[countNegative];
            
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                {
                    arrayNegative[iN] = array[i];
                    iN++;
                }
                else if (array[i] >= 0)
                {
                    arrayPositive[iP] = array[i];
                    iP++;
                }
            }
            Console.Write("Массив с положительными элементами: ");
            for (int i = 0; i < arrayPositive.Length; i++)
            {
                Console.Write($"{arrayPositive[i]} ");
            }
            Console.Write("\nМассив с отрицательными элементами: ");
            for (int i = 0; i < arrayNegative.Length; i++)
            {
                Console.Write($"{arrayNegative[i]} ");
            }
        }
    }
}