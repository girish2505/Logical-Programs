using System;
using System.Diagnostics;
using System.Threading;

namespace LogicalPrograms
{
    class Stopwatch
    {
        public static void readinput()
        {
            Stopwatch stopwatch = new Stopwatch();
            // Begin timing
            stopwatch.Start();
            for (int i = 0; i < 100000; i++)
            {
                Console.WriteLine("G0 ........!!!1!");
            }
            // Stop timing
            stopwatch.Stop();
            Console.WriteLine("Time Elapsed : {0}", stopwatch.Elapsed);
        }
    }
}
