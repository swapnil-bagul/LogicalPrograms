using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalPrograms
{
    class CouponNumer
    {
        public static void Checking()
        {
            //local Variable
            int couponCodeLength = 6;
            Console.Write("Coupon Code: ");

            //If Loop Programming Construct
            for (int i=1; i<=couponCodeLength; i++)
            {
                //Random Predefined Class
                Random random = new Random();
                int codeElement = random.Next(0, 10);
                Console.Write("{0}", codeElement);
            }

            Console.ReadLine();
        }   
    }
}
