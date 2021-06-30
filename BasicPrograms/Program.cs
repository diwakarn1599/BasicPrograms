using System;

namespace BasicPrograms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Basic Programs :");

            // creating menu for basic programs
            Console.WriteLine("MENU\n1.FlipCoin\n2.Leap Year\n3.Power Of Two\n4.Harmonic Number\n5.Primefactor\n6.Quotient and Reminder\n7.Swap Numbers\n8.Even or Odd\n9.Exit");

            Console.WriteLine("Enter the option");

            //Switch case for menu
            switch (Convert.ToInt32(Console.ReadLine()))
            {
                case 1:
                    FlipCoin.FilpCoinPercentage();
                    break;
                case 2:
                    LeapYear.CheckLeapYear();
                    break;
                case 3:
                    PowerOfTwo.CheckPowerOfTwo();
                    break;
                case 4:
                    HarmonicNumber.GetHormonicNumber();
                    break;
                case 5:
                    PrimeFactors.GetPrimeFactors();
                    break;
                case 6:
                    QuotientAndReminder.GetQuotientAndReminder();
                    break;
                case 7:
                    SwapNumbers.SwapTwoNumbers();
                    break;
                case 8:
                    EvenOrOdd.CheckEvenorOdd();
                    break;

                case 9:
                    Console.WriteLine("Exited");
                    break;
                default:
                    Console.WriteLine("Enter the correct option");
                    break;

            }
            
        }
    }
}
