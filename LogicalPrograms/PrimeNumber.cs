using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalPrograms
{
    class PrimeNumber
    {
         public static void CheckPrimeNumber()
        {
            Console.WriteLine("Enter a number");
            int number = Convert.ToInt32(Console.ReadLine());
            int result = Check_Prime(number);
            if (result == 0)
            {
                Console.WriteLine(number + " is not a prime number");
            }
            else
            {
                Console.WriteLine(number + " is  a prime number");
            }
        }

        private static int Check_Prime(int number)
        {
            int i;
            for (i = 2; i <= number - 1; i++)
            {
                if (number % i == 0)
                {
                    return 0;
                }
            }
            if (i == number)
            {
                return 1;
            }
            return 0;
        }
    }
}
