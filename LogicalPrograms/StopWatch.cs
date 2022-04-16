using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    public class StopWatch
    {
        public void StopWatchTime()
        {
            Console.Write("Enter String To Start ('s') :");
            String str = Console.ReadLine();
            TimeSpan timespan = TimeSpan.Zero;
            int hour = timespan.Hours;
            int min = timespan.Minutes;
            int sec = timespan.Seconds;
            int milsec = timespan.Milliseconds;
            if (str.Equals("s"))
            {
                Console.Write("When you want to stop the time then, Enter String ('e') :");
                String str1 = Console.ReadLine();
                if (str1.Equals("e"))
                {
                    Console.Write("Program stopped at msec -> ");
                    int hour1 = timespan.Hours;
                    int min1 = timespan.Minutes;
                    int sec1 = timespan.Seconds;
                    int milsec1 = timespan.Milliseconds;
                    Console.WriteLine(milsec1);
                    Console.WriteLine("Total time taken ->" + " Hours:" + (hour1 - hour) + " " + "Minutes:" + (min1 - min) + " " + "Seconds:" + (sec1 - sec));
                    Console.WriteLine(timespan.ToString());
                }
                else
                {
                    Console.WriteLine("Enter the correct character to stop !");
                }
            }
            else
            {
                Console.WriteLine("Enter the correct character to start !");
            }
        }
    }
}