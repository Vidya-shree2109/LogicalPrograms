using System;

namespace LogicalPrograms
{
    class Program
    {
        static void Main(String[] args)
        {
            Console.WriteLine("----------Welcome To Logical Programs----------");
            bool finish = true;
            Console.WriteLine("\n1.Fibonacci Series\n2.Perfect Number\n3.Prime Number\n4.Reverse a Number\n5.Coupon Number\n6.Stop Watch\n7.End the program");
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
                        ReverseNumber reverse = new ReverseNumber();
                        reverse.Reverse();
                        break;
                    case 5:
                        CouponNumber coupon = new CouponNumber();
                        coupon.Coupon();
                        break;
                    case 6:
                        StopWatch watch = new StopWatch();
                        watch.StopWatchTime();
                        break;
                    case 7:
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