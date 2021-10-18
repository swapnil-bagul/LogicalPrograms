using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalPrograms
{
    class CouponNumer
    {
        public static void Checking()
        {
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            char[] stringChars = new char[6];
            
            for(int i=0; i<stringChars.Length; i++)
            {
                Random random = new Random();
                stringChars[i]= chars[random.Next(0,25)];
            }
            var couponCode = stringChars.ToString ();
            Console.WriteLine("Coupon Code:" + couponCode);
        }   
    }
}
