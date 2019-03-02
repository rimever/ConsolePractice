using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using ShellProgressBar;

namespace TryShellProgressBar
{
    class Program
    {
        static void Main(string[] args)
        {
            const int totalTicks = 100;
            var options = new ProgressBarOptions
            {
                ProgressCharacter = '─',
                ProgressBarOnBottom = true
            };
            using (var progressBar = new ProgressBar(totalTicks, "Initial message", options))
            {
                foreach (var percent in Enumerable.Range(1,totalTicks))
                {
                    Thread.Sleep(100);
                    progressBar.Tick($"{percent}%まで処理しています。");
                }
            }

            Console.ReadKey();
        }
    }
}
