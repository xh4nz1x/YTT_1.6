// УП Практическая работа 1.6
// Задание 3. Дано число.
// Определите будет ли это число четным и кратным 10

namespace YTT_6_3
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Введите число: ");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number % 2 == 0 & number % 10 == 0)
            {
                Console.WriteLine($"Число {number} является четным и кратным 10");
            }
        }
    }
}