using System;
using System.Collections.Generic;
using System.Text;

namespace BasicPrograms
{
    class QuotientAndReminder
    {
        public static void GetQuotientAndReminder()
        {
            Console.WriteLine("Enter the value of divident");
            int divident = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value of divisor");
            int divisor = Convert.ToInt32(Console.ReadLine());

            // formula for quotient
            int quotient = divident / divisor;

            //formula for reminder
            int reminder = divident % divisor;

            Console.WriteLine("Quotient = "+quotient);
            Console.WriteLine("Reminder = "+reminder);

        } 
    }
}
