using System;
using System.Collections.Generic;
using System.Text;

namespace Demo
{
    internal class AddTwoNumbers
    {
       
       public static void Addition()
           {
                     int sum;
                     Console.WriteLine(" enter value for a:");
                     int a = Convert.ToInt32(Console.ReadLine());
                     Console.WriteLine(" enter value for b:");
                     int b = Convert.ToInt32(Console.ReadLine());

                    sum = a + b;
                    Console.WriteLine("\n"+sum);
            }
      }     
 }