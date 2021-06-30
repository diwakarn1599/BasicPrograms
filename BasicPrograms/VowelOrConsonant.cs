using System;
using System.Collections.Generic;
using System.Text;

namespace BasicPrograms
{
    class VowelOrConsonant
    {
        public static void CheckVowelOrConsonant()
        {
            Console.WriteLine("Enter the character");
            string chr = Console.ReadLine();

            if (chr == "a" || chr == "e" || chr == "i" || chr == "o" || chr == "u" || chr == "A" || chr == "E" || chr == "I" || chr == "O" || chr == "U")
            {
                Console.WriteLine(chr + " is a vowel");
            }
            else
            {
                Console.WriteLine(chr + " is a consonant");
            }

        }
    }
}
