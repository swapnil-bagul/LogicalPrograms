using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using System.Threading;

namespace LogicalPrograms
{
    class TimeMeasure
    {
        public static void Calculating()
        {
            //Used Stopwatch Predefined Class
            Stopwatch stopwatch = new Stopwatch(); 

            Console.WriteLine("Enter 0 for Start");
            int start = Convert.ToInt32 (Console.ReadLine());

            //Used Start () Predefined Method in Stopwatch class
            stopwatch.Start(); 

            for(int i=0; i<1000; i++)
            {
                Thread.Sleep(1);
            }

            Console.WriteLine("Enter 1 for Stop");
            int stop = Convert.ToInt32(Console.ReadLine());

            //Used Stop () Predefined Method in Stopwatch class
            stopwatch.Stop();

            Console.WriteLine("Time elapsed: {0}", stopwatch.Elapsed );
        }
    }
}
