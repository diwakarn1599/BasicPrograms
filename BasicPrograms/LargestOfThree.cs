using System;
using System.Collections.Generic;
using System.Text;

namespace BasicPrograms
{
    class LargestOfThree
    {
        public static void LargestOfThreeNumbers()
        {
            //Getting values of 3 numbers from user
            Console.WriteLine("Enter the value of num 1");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the value of num2");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the value of num3");
            int num3 = Convert.ToInt32(Console.ReadLine());

            //If else for checking largest of three numbers

            if(num1>num2 && num1 > num3)
            {
                Console.WriteLine(num1+ " is a Largest among Three numbers");
            }
            else if(num2>num1 && num2 > num3)
            {
                Console.WriteLine(num2 + " is a Largest among Three numbers");
            }
            else
            {
                Console.WriteLine(num3 + " is a Largest among Three numbers");
            }
        }

    }
}
