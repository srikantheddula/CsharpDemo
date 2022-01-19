using System;
using System.Collections.Generic;
using System.Text;

namespace Demo
{
    internal class LeapYearProgram
    {
        public static void FindLeapYear()
        {
            
            Console.WriteLine("Enter a year: ");

            int year = Convert.ToInt32(Console.ReadLine());

            if (Convert.ToString(year).Length == 4)
            {
                if ((year % 4 == 0 && year %100!=0) || year % 400 == 0)
                {
                    Console.WriteLine(" leap year.  " + year);                   
                }

                else
                {
                    Console.WriteLine("\nNot a leap year.  " + year);
                }

            }
            else
            {
                Console.WriteLine("Number should be  4digt");
            }
        }
    }
}
            
          
