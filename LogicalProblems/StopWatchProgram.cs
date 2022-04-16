﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Threading.Tasks;


namespace LogicalProblems
{
    public class StopWatchProgram
    {
        public void Watch()
        {
            Stopwatch stopwatch = new Stopwatch();
            Console.WriteLine("Click spacebar and enter to start stopwatch");
            string watcher = Console.ReadLine();
            if (watcher == " ")
            {
                stopwatch.Start(); 
                Console.WriteLine("Click spacebar and enter again to stop stopwatch");
                while (watcher == " ")
                {
                    watcher += Console.ReadLine();
                }
                stopwatch.Stop();
                Console.WriteLine($"Time elapsed is: {stopwatch.Elapsed} seconds");
            }
            else
            {
                Console.WriteLine("Press spacebar only!... to start and stop stopwatch");
            }
        }
    }
}
