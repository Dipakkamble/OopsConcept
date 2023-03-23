using OopsConcept.Inheritance;
using OopsConcept.Polymorphism;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcept
{
    internal class Program
    {
        int id; string name;
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the option below:");
            Console.WriteLine("\n1:class and object\n2:Inheritance\n3:Methodoverloading\n4:MethodOveriding");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Program p1 = new Program();
                    p1.id = 101; p1.name = "sonoo jaiswal";
                    Console.WriteLine(p1.id);
                    Console.WriteLine(p1.name);
                    break;
                case 2:
                    Dog d1 = new Dog();
                    d1.eat();
                    d1.bark();
                    break;
                case 3:
                    MethodOverloading mo = new MethodOverloading();
                    mo.Add(7,3);
                    mo.Add(6.9f, 4.2f);
                    mo.Add(5, 5.3f);
                    mo.Add(8.5f, 7);
                    break;
                case 4:
                    MethodOverriding or = new MethodOverriding();
                    or.Add(3,9);
                    break;
            }
            Console.ReadLine();
        }
    }
}
