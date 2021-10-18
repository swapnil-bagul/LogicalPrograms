using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalPrograms
{
    class ReverseNumber
    {
        public static void Reversing()
        {
            Console.Write("Enter a Number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            int reverse = 0, rem;
            while (num!=0)
            {
                rem = num % 10;
                reverse = reverse * 10 + rem;
                num = num / 10;
            }
            Console.WriteLine("Reverse Number is: {0}", reverse);
        }
    }
}
