using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    public class ReverseNumber
    {
        public void Reverse()
        {
            int number, reverse = 0, remainder;
            Console.Write("Enter a number to reverse that number : ");
            number = Convert.ToInt32(Console.ReadLine());
            int temp = number;
            while (number != 0)
            {
                remainder = number % 10;
                reverse = reverse * 10 + remainder;
                number /= 10;
            }
            Console.WriteLine("Entered Number : " + temp);
            Console.WriteLine("Reversed Number : " + reverse);
            if (reverse == temp)
            {
                Console.WriteLine("{0} = {1}", temp, reverse);
                Console.WriteLine("{0} is a PALINDROME !", reverse);
            }
            else
            {
                Console.WriteLine("{0} != {1}", temp, reverse);
                Console.WriteLine("{0} is not a Palidrome", reverse);
            }
        }
    }
}
