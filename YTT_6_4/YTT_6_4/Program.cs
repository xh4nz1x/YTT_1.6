// УП Практическая работа 1.6
// Задание 4. Вводятся положительные числа.
// Определите сумму чисел, делящихся на положительное число a нацело.
// При вводе отрицательного числа закончите работу

namespace YTT_6_4
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Введите положительное число a: ");
            int a = Convert.ToInt32(Console.ReadLine());
            int sum = 0, num = 0;
            Console.WriteLine("Вводите положительные числа:");
            while (num >= 0)
            {
                num = Convert.ToInt32(Console.ReadLine());
                if (num < 0)
                {
                    break;
                }
                else
                {
                    if (num % a == 0)
                    {
                        sum += num;
                    }
                }
            }
            Console.WriteLine($"Сумма чисел, делящихся нацело, на число: {sum}");
        }
    }
}