using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcept.Polymorphism
{
    internal class MethodOverriding
    {
        public virtual void Add(int a,int b)
        {
            Console.WriteLine("The two nos. having same data type");
        }
        public class Addtion : MethodOverriding
        {
            public override void Add(int a, int b)
            {
                Console.WriteLine("first call parent class method");
            }
        }
    }
}
