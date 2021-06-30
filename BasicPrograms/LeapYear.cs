using System;
using System.Collections.Generic;
using System.Text;

namespace BasicPrograms
{
    class LeapYear
    {
        public static void CheckLeapYear()
        {
            string year;
            //get year
            Console.WriteLine("Enter the year");
            year = Console.ReadLine();

            //check year length
            if(year.Length == 4)
            {
                int n = Convert.ToInt32(year);
                if (n % 400 == 0)
                {
                    
                    Console.WriteLine(n+ " is a Leap Year!");
                }else if (n % 100 == 0)
                {
                    
                    Console.WriteLine(n + " is Not a Leap Year!");
                }
                else if (n % 4 == 0)
                {
                    
                    Console.WriteLine(n + " is a Leap Year!");
                }
                else
                {
                    
                    Console.WriteLine(n + " is Not a Leap Year!");
                }
            }
            else
            {
                Console.WriteLine("Enter the correct year");
                CheckLeapYear();
            }
        }
    }
}
