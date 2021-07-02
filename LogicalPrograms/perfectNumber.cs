using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalPrograms
{
    class perfectNumber
    {
        public static void PerfectNumber()
        {
            int num, sum = 0;
            //getting input from user
            Console.WriteLine("enter the number : ");
            // converting into integer 
            num = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i < num; i++)
            {
                if (num % i == 0)
                {
                    sum = sum + i;
                }
            }
            if (sum == num)
            {
                Console.WriteLine(num +" is a perfect number");
            }
            else
            {
                Console.WriteLine(num +" is not a perfect number");
            }
        }

    }  
}

