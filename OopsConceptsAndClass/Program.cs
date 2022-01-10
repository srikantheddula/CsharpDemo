using OopsConceptsAndClass.Oops;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OopsConceptsAndClass
{
    internal class Program
    {
        static void Main()
        {
            Dog obj1 = new Dog();
            obj1.breed = "bull";
            obj1.color = "red";
            Console.WriteLine("breed:" + obj1.breed + "\ncolor is:" + obj1.color);

            Dog obj2 = new Dog();
            obj2.breed = "lab";
            obj2.color = "white";
            Console.WriteLine("breed:" + obj2.breed + "\ncolor is:" + obj2.color);

            Dog.bark();
            Dog.sleep();
            Console.ReadLine();

        }
    }
    }

