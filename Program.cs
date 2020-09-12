using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Timer
{
    class Program
    {
        static void Main(string[] args)
        {
            var watchOne = new Stopwatch();
            watchOne.StartTheTime();
            Thread.Sleep(5000);
            watchOne.StopTheTime();
            Console.WriteLine("The elapsed time is {0}", watchOne.ShowDuration());
        }
    }
}