using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalPrograms
{
    class CouponNumbers
    {
        Random rand = new Random();
        private int RandomNumber(int start, int end)
        {
            int randNum = rand.Next(start, end);
            return randNum;
        }
        public static void GenerateCoupon()
        {
            int start, end, genratedCoupon, Count = 0;

            Console.WriteLine("Enter the start range ");
            start = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the end range");
            end = Convert.ToInt32(Console.ReadLine());

            HashSet<int> Coupons = new HashSet<int>();

            CouponNumbers cn = new CouponNumbers();

            while (Coupons.Count <= Math.Abs(start - end))
            {
                genratedCoupon = cn.RandomNumber(start, end + 1);
                Count++;
                Coupons.Add(genratedCoupon);
            }

            Console.WriteLine("The coupons are");
            foreach (int i in Coupons)
            {
                Console.Write(i + ", ");
            }

            Console.WriteLine(Count + " Random number generated to generate coupon");
        }
    }
}
