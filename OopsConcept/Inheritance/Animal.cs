using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcept.Inheritance
{
    public class Animal
    {
        public void eat() 
        {
            Console.WriteLine("Eating...");
        }
    }
    public class Dog:Animal
    {
        public void bark()
        {
            Console.WriteLine("Barking..");
        }
    }

}
