using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalPrograms
{
    class Fibonacci
    {
        public static void Formation()
        {
            Console.Write("Enter term of series: ");
            int num = Convert.ToInt32(Console.ReadLine());
            //local variable
            int num1 = 0, num2 = 1, num3;
            Console.Write(num1+" "+num2+" ");

            //Programming construct
            for (int i = 2; i < num; i++) 
            {
                num3 = num1 + num2;
                Console.Write(num3 + " ");
                num1 = num2;
                num2 = num3;

            }

        }
    }
}
