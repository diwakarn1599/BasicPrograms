using System;
using System.Collections.Generic;
using System.Text;

namespace BasicPrograms
{
    class PrimeFactors
    {
        public static bool CheckPrime(int number)
        {
            int Flag = 0;
            
            if (number == 2)
            {
                return true;
            }
            else if (number % 2 == 0)
            {
                return false;
            }
            else
            {
                for (int i = 3; i * i <= number; i++)
                {
                    if (number % i == 0)
                    {
                        Flag = 1;
                        break;
                    }

                }
                if (Flag == 1)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }
        public static void GetPrimeFactors()
        {
            Console.WriteLine("Enter the value of N");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The prime factors are:");
            for(int i = 2; i * i <= n; i++)
            {
                if(n%i == 0)
                {
                    //Console.WriteLine(i);
                    if (CheckPrime(i))
                    {
                        Console.WriteLine(i);
                    }
                    
                }
            }
        }
        

    }
}
