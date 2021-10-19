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
            //local variable
            int num = Convert.ToInt32(Console.ReadLine());
            int reverse = 0, rem;
            //While Loop Programming Construct 
            while (num!=0)
            {
                //to get reminder
                rem = num % 10;
                reverse = reverse * 10 + rem;
                //to reduce size of number by one digit
                num = num / 10;
            }
            Console.WriteLine("Reverse Number is: {0}", reverse);
        }
    }
}
