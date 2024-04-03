// УП Практическая работа 1.6
// Задание 2. Дан файл numsTask2.txt со словами расположенными в столбик.
// Из заданных слов составьте одну длинную строку (разделить каждое слово пробелом)

namespace YTT_6_2
{
    internal class Program
    {
        public static async Task Main(string[] args)
        {
            string path = "numsTask2.txt";

            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                Console.Write("Строка, разделенная пробелами: ");
                while ((line = await reader.ReadLineAsync()) != null)
                {
                    Console.Write($"{line} ");
                }
            }
        }
    }
}