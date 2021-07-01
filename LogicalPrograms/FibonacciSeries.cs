using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalPrograms
{
    class FibonacciSeries
    {
        public static void ReadInput()
        {
            int num1 = 0, num2 = 1, sum, n;
            Console.WriteLine("Enter the number");

            //getting value from the user and convert it into integer
            n = Convert.ToInt32(Console.ReadLine());

            //for n less than 2
            if (n == 1)
            {
                Console.WriteLine(num1);
            }
            else
            {

                Console.WriteLine(num1);
                Console.WriteLine(num2);

                n -= 2;
                //loop for generating fibbonacci series
                while (n > 0)
                {
                    sum = num1 + num2;
                    Console.WriteLine(sum);
                    num1 = num2;
                    num2 = sum;
                    n -= 1;
                }

            }
        }
    }
}
