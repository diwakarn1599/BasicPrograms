using System;
using System.Collections.Generic;
using System.Text;

namespace BasicPrograms
{
    class SwapNumbers
    {
        public static void SwapTwoNumbers()
        {
            Console.WriteLine("Enter the value of num 1");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value of num 2");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Before Swapping");
            Console.WriteLine("Num 1 = "+num1);
            Console.WriteLine("Num 2 = "+num2);

            //Swapping two numbers without using 3rd variable
            num1 = num1 + num2;
            num2 = num1 - num2;
            num1 = num1 - num2;

            Console.WriteLine("After Swapping");
            Console.WriteLine("Num 1 = " + num1);
            Console.WriteLine("Num 2 = " + num2);

        }
    }
}
