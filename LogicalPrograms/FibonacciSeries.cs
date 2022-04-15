using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
   public class FibonacciSeries
    {
        public void Fibonacci()
        {
            int num1 = 0, num2 = 1, num3, number;
            Console.Write("Enter the number of elements: ");
            number = Convert.ToInt32(Console.ReadLine());
            Console.Write(num1 + "  " + num2 + "  ");
            for (int index = 2; index < number; index++)
            {
                num3 = num1 + num2;
                Console.Write(num3 + "  ");
                num1 = num2;
                num2 = num3;
            }
            Console.WriteLine();
        }
    }
}
