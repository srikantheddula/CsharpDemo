using System;
using System.Collections.Generic;
using System.Text;

namespace Demo
{
    internal class FindRemainderAndQuotient
    {
          public static void Find ()
        { 
            int quotient, remainder;

            Console.WriteLine("Enter dividend: "); 
           int  dividend=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter divisor: ");
           int  divisor=Convert.ToInt32(Console.ReadLine());

            // Computes quotient
            quotient = dividend / divisor;

            // Computes remainder
            remainder = dividend % divisor;

            Console.WriteLine("Quotient\t"+quotient);
            Console.WriteLine("Remainder\t"+remainder);
            
          }
    }
}
