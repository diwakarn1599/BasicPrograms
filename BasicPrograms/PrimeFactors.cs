using System;
using System.Collections.Generic;
using System.Text;

namespace BasicPrograms
{
    class PrimeFactors
    {
        public static void GetPrimeFactors()
        {
            Console.WriteLine("Enter the value of N");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The prime factors are:");
            for(int i = 2; i * i <= n; i++)
            {
                if(n%i == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
        

    }
}
