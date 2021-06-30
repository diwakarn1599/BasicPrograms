using System;

namespace BasicPrograms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Basic Programs :");

            // creating menu for basic programs
            Console.WriteLine("MENU\n1.FlipCoin\n2.Exit");

            Console.WriteLine("Enter the option");

            //Switch case for menu
            switch (Convert.ToInt32(Console.ReadLine()))
            {
                case 1:
                    FlipCoin.FilpCoinPercentage();
                    break;
                case 2:
                    Console.WriteLine("Exited");
                    break;
                default:
                    Console.WriteLine("Enter the correct option");
                    break;

            }
            
        }
    }
}
