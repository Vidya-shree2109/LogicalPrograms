using System;

namespace LogicalPrograms
{
    class Program
    {
        static void Main(String[] args)
        {
            Console.WriteLine("----------Welcome To Basic Programs----------");
            bool finish = true;
            Console.WriteLine("\n1.Fibonacci Series\n2.End the program");
            while (finish)
            {
                Console.WriteLine("\nEnter an option to execute :");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        FibonacciSeries fibo = new FibonacciSeries();
                        fibo.Fibonacci();
                        break;
                    case 2:
                        finish = false;
                        break;

                    default:
                        Console.WriteLine("Enter a valid option !");
                        break;
                }
            }

        }
    }
}