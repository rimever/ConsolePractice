using System;
using System.Linq;
using System.Threading;

namespace ProgressConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("進捗を表示します。");
            var top = Console.CursorTop;
            var left = Console.CursorLeft;
            foreach (var value in Enumerable.Range(1,100))
            {
                Console.SetCursorPosition(left, top);
                Console.Write(value + "%");
                Thread.Sleep(100);
            }
            Console.WriteLine("完了");
        }
    }
}
