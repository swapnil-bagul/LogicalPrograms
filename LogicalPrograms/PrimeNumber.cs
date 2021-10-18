using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalPrograms
{
    class PrimeNumber
    {
        public static void Computing()
        {
            Console.WriteLine("Enter a Number");
            int number = Convert.ToInt32(Console.ReadLine());
            int flag = 0;
            for (int i = 2; i <= number / 2; i++)
            {
                if(number %i==0)
                {
                    Console.WriteLine("{0} is not a Prime Number.", number);
                    flag = 1;
                    break;
                }
            }

            if (flag == 0)
            {
                Console.WriteLine("{0} is a Prime Number.", number);
            }

        }
    }
}
