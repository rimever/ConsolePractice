using System;

namespace ConsoleDotNetCore
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleColor[] Colors = (ConsoleColor[])Enum.GetValues(typeof(ConsoleColor));

            foreach (ConsoleColor foregroundColor in Colors)
            {
                Console.ForegroundColor = foregroundColor;
                Console.Write(foregroundColor);
            }
            Console.ResetColor();
            Console.WriteLine();
        }
    }
}
