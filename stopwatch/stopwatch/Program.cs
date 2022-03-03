using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Threading;

namespace Stopwatchdemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //create new stopwatch
            Stopwatch stopWatch = new Stopwatch();
            //Begin Timimg
            stopWatch.Start();
            //do something
            for (int i = 0; i < 1000; i++)
            {
                Thread.Sleep(1);
            }
            //stop timing
            stopWatch.Stop();
            //printing result
            Console.WriteLine("Time Elapsed:{0}", stopWatch.Elapsed);

        }
    }
}
