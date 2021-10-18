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
            int n1 = 0, n2 = 1, n3;
            Console.Write(n1+" "+n2+" ");
            //Programming construct
            for (int i = 2; i < num; i++) 
            {
                n3 = n1 + n2;
                Console.Write(n3 + " ");
                n1 = n2;
                n2 = n3;

            }

        }
    }
}
