using System;
using System.Collections.Generic;
using System.Text;

namespace BasicPrograms
{
    class EvenOrOdd
    {
        public static void CheckEvenorOdd()
        {
            Console.WriteLine("Enter the value");
            int n = Convert.ToInt32(Console.ReadLine());

            
            if (n % 2 == 0)
            {
                Console.WriteLine(n + " is a Even Number");
            }
            else
            {
                Console.WriteLine(n + " is a odd number");
            }
            
        }

    }
}
