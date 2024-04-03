// УП Практическая работа 1.6
// Задание 1. Дан файл numsTask1.txt со словами.
// Выведите все слова нечетной длины

namespace YTT_6_1
{
    internal class Program
    {
        public static async Task Main(string[] args)
        {
            string path = "numsTask1.txt";

            using (StreamReader reader = new StreamReader(path))
            {
                string[] line = (await reader.ReadLineAsync()).Split(' ');
                Console.Write("Все слова нечетной длины: ");
                for (int i = 0; i < line.Length; i++)
                {
                    int length = line[i].Length;
                    if (length % 2 == 1)
                    {
                        Console.Write($"{line[i]} ");
                    }
                }
            }
        }
    }
}