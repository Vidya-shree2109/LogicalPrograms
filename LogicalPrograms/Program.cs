using System;

namespace LogicalPrograms
{
    class Program
    {
        static void Main(String[] args)
        {
            Console.WriteLine("----------Welcome To Basic Programs----------");
            bool finish = true;
            Console.WriteLine("\n1.Fibonacci Series\n2.Perfect Number\n3.Prime Number\n4.End the program");
            while (finish)
            {
                Console.Write("\nEnter an option to execute :");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        FibonacciSeries fibo = new FibonacciSeries();
                        fibo.Fibonacci();
                        break;
                    case 2:
                        PerfectNumber number = new PerfectNumber();
                        number.Perfect();
                        break;
                    case 3:
                        PrimeNumber prime = new PrimeNumber();
                        prime.Prime();
                        break;
                    case 4:
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