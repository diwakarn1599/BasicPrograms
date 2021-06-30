using System;
using System.Collections.Generic;
using System.Text;

namespace BasicPrograms
{
    class HarmonicNumber
    {
        public static void GetHormonicNumber()
        {
            Console.WriteLine("Enter the value of N");
            int n = Convert.ToInt32(Console.ReadLine());

            //initialize harmonic value
            float h = 1;
            if (n != 0)
            {
                for (int i = 2; i <= n; i++)
                {
                    h += (float)1 / i;
                }
                Console.WriteLine("The Nth Harmonic Value is = " + h);
            }
            else
            {
                Console.WriteLine("N Sholud not be 0");
                GetHormonicNumber();
            }
            
        }
    }
}
