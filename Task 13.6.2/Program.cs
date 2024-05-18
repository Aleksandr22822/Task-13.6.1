using System.Diagnostics;

namespace Task_13._6._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var stopWatch = Stopwatch.StartNew();
            int a = 0;
            while (a <= 9)
            {
                string text = File.ReadAllText("C:\\SkillFactory\\Res\\cdev_Text.txt");
                var strings = new LinkedList<string>();
                strings.AddFirst(text);
                a++;
            }
           
            Console.WriteLine($"Среднее время выполнения {stopWatch.Elapsed.TotalMilliseconds / 10}");
        }
    }
}
