using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iclone
{
    class Person:ICloneable
    {
        public int  Age { get ; set; }
        public String Name { get; set; }
        public Person(int n, string s)
        {
            this.Age = n;
            this.Name = s;
        }

        public void Method()
        {
            Console.WriteLine("person");
        }

        public object Clone()
        {
            return new Person(this.Age,this.Name);// aysinqn copy arec mer dashter@ klassi,
        }
    }
}
