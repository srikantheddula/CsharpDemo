using System;
using System.Collections.Generic;
using System.Text;

namespace Demo
{
    internal class AlphabetsVowelOrConsonant
    {
        public  static void CheckAlphabateIsVowelsProgram()
        {
            Console.Write("insert an alphabate: ");
            string alphabet = Convert.ToString(Console.ReadLine());
            switch (alphabet)
            {
                case "a":
                case "e":
                case "i":
                case "o":
                case "u":

                    Console.WriteLine($"{alphabet} is a Vowel");
                    break;

                default:
                    Console.WriteLine($"{alphabet} is consonant");
                    break;
            }
        }
    }
}
