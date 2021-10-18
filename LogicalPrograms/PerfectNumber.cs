using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalPrograms
{
    class PerfectNumber
    {
       public static void PerfectNumberFinding()
        {
            Console.WriteLine("Enter a Number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            //local variable
            int j = num / 2, sum=0,rem;
            //Programming Construct
            for (int i=1; i<=j; i++)
            {
                rem = num % i;
                if (rem==0)
                { 
                    sum =sum + i;
                    Console.WriteLine("{0} ", i);
                }

            }
            //Programming Construct
            if(sum==num)
            {
                Console.WriteLine("The Given Number Is Perfect Number.");
            }
            else
            {
                Console.WriteLine("The Given Number Is Not Perfect Number.");
            }

        }
    }
}
