using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    public class PrimeNumber
    {
        public void Prime()
        {
            Console.Write("Enter a number to find it is Prime or not : ");
            int number = int.Parse(Console.ReadLine());
            bool IsPrime = true;
            for (int index = 2; index < number / 2; index++)
            {
                if (number % index == 0)
                {
                    IsPrime = false;
                    break;
                }
            }
            if (IsPrime)
            {
                Console.Write("{0} is a Prime Number", number);
            }
            else
            {
                Console.Write("{0} is not a Prime Number", number);
            }
            Console.WriteLine();
        }
    }
}
