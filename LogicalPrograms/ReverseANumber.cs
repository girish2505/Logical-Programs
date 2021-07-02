using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalPrograms
{
    class ReverseANumber
    {
        public static void ReverseNumber()
        {
                Console.WriteLine("Enter a Nuumber to reverse");
            int Number = Convert.ToInt32(Console.ReadLine());
                int Reverse = 0;
                while (Number > 0)
                {
                    int remainder = Number % 10;
                    Reverse = (Reverse * 10) + remainder;
                    Number = Number / 10;
                }
                Console.WriteLine(Reverse + " is the Reverse number");
        }
    }
}
