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
            Program p1 = new Program();
            p1.id = 101;p1.name = "sonoo jaiswal";
            Console.WriteLine(p1.id);
            Console.WriteLine(p1.name);
            Console.ReadLine();
        }
    }
}
