using System;
using System.Collections.Generic;
using System.Text;

namespace BasicPrograms
{
    class FlipCoin
    {
        public static void FilpCoinPercentage()
        {
            int n,head=0,tail=0;
            double flip, headPercentage, tailPercentage;
            Console.WriteLine("Enter The number of times to Flip Coin");
            n = Convert.ToInt32(Console.ReadLine());
            Random rand = new Random();
            if(n>0)
            {
                for (int i= 0; i < n; i++)
                {
                    flip = rand.NextDouble();
                    if (flip < 0.5)
                    {
                        tail++;
                    }
                    else
                    {
                        head++;
                    }
                }
                Console.WriteLine("Head = "+head);
                Console.WriteLine("Tail = "+tail);
                headPercentage = (double)head / n * 100;
                tailPercentage = (double)tail / n * 100;
                Console.WriteLine("Head Percentage = " + headPercentage);
                Console.WriteLine("Tail Percentage = " + tailPercentage);


            }
            else
            {
                Console.WriteLine("You have Entered a negative value...Please Enter a positive value");
                FilpCoinPercentage();
            }

        }
    }
}
