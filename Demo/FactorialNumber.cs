using System;
using System.Collections.Generic;
using System.Text;

namespace Demo
{
    internal class FactorialNumber
    {
        
        public void FactNumExample()
        {
            int i, fact = 1;
            Console.WriteLine("Enter any Number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            
            for (i=1; i<= number; i++)
            {
                fact*= i;
            }
            Console.Write("Factorial of " + number + " is: " + fact);
        }

    }
}
