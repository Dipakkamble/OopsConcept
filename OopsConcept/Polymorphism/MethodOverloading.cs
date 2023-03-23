using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcept.Polymorphism
{
    internal class MethodOverloading
    {
        public void Add(int a, int b)
        {
            Console.WriteLine("The two numbers are:" + a + "," + b);
        }
        public void Add(float a, float b)
        {
            Console.WriteLine("The two numbers are:" + a + "," + b);
        }
        public void Add(int a, float b)
        {
            Console.WriteLine("The two numbers are:" + a + "," + b);
        }
        public void Add(float a, int b)
        {
            Console.WriteLine("The two numbers are:" + a + "," + b);
        }
    }
}
