using System;
using System.Collections.Generic;
using System.Text;

namespace BasicPrograms
{
    class PowerOfTwo
    {
        public static void CheckPowerOfTwo()
        {
            Console.WriteLine("Enter the value of N");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n < 31)
            {
                for (int i = 0; i <= n; i++)
                {
                    Console.WriteLine("2 power " + i + " is = " + Math.Pow(2, i));
                }
            }
            else
            {
                Console.WriteLine("N value should not exceed 30");
                CheckPowerOfTwo();
            }
        }
    }
}
