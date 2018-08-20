using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iclone
{
    class Program
    {
        static void Main(string[] args)
        {
            B b = new B("b", 2);
            A a = new A("a", 1, b);
            
            B c = a.B;
            c.Name = "bc";
            Console.WriteLine(b.Name);
            Console.WriteLine(c.Name);

            Person p1 = new Person(23, "saqo");
            Person p2 = p1.Clone() as Person;

            p2.Age = 25;
            p2.Name = "suro";

            Console.WriteLine(p1.Age +","+p1.Name);
            Console.WriteLine(p2.Age + "," + p2.Name);

        }
    }
}
