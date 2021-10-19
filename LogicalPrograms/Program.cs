using System;

namespace LogicalPrograms
{
    class LogicalProgram
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------------------------------------------------------------------------------");
            Console.WriteLine("Welcome To Logocal Programs");
            Console.WriteLine("----------------------------------------------------------------------------------");
            Console.WriteLine("1. Fabonacci series\n2. Prime Number\n3. Reverse Number\n4. Coupon Number\n5. Perfect Number\n6. Stopwatch");
            Console.WriteLine("----------------------------------------------------------------------------------");
            Console.Write("Enter a Serial Number of Application: ");
            int index = Convert.ToInt32(Console.ReadLine());
            switch (index )
            {
                case 1:
                    Fibonacci.Formation();
                    break;

                case 2:
                    PrimeNumber.Computing();
                    break;

                case 3:
                    ReverseNumber.Reversing();
                    break;

                case 4:
                    CouponNumer.Checking();
                    break;

                case 5:
                    PerfectNumber.PerfectNumberFinding();
                    break;

                case 6:
                    TimeMeasure.Calculating();
                    break;

            }

        }
    }
}
