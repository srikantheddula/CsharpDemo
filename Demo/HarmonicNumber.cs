using System;
using System.Collections.Generic;
using System.Text;

namespace Demo
{
     class HarmonicNumber
    {
        public static void HarmonicProgram()
        {
           float harmonicValue = 0;

            Console.WriteLine("Insert a number for harmonic value");
            int num= Convert.ToInt32(Console.ReadLine());

            if (num != 0)
            {
                for (int N = 1; N <= num; N++)
                {

                    harmonicValue = harmonicValue + (float)1 / N;
                }
                Console.WriteLine("Result: Harmonic of " + num + " is = " + harmonicValue);
            }
        }
    }
}
