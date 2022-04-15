using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    public class PerfectNumber
    {
        public void Perfect()
        {
            int sum = 0, number, temp;
            Console.Write("Enter a number to check for Perfect Number :");
            number = Convert.ToInt32(Console.ReadLine());
            temp = number;
            for (int index = 1; index < number; index++)
            {
                if (number % index == 0)
                {
                    sum = sum + index;
                }
            }
            if (sum == temp)
            {
                Console.WriteLine("{0} is a Perfect Number ", temp);
            }
            else
            {
                Console.WriteLine("{0} is not a Perfect Number", temp);
            }
        }
    }
}
