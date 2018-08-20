using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iclone
{
    class A
    {
        private int age;
        private string name;
        private B b;

        public A(string s,int n,B b)
        {
            this.age = n;
            this.name = s;
            this.b = b;
        }

        public int Age
        {
            get { return this.age; }
            set { this.age = value; }
        }
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public B B
        {
            get { return b.Clone() as B; }
            
        }
    }
    class B : ICloneable
    {
        private int age;
        private string name;
        public B(string s,int n )
        {
            this.age = n;
            this.name = s;
        }
        public int Age
        {
            get { return this.age; }
            set { this.age = value; }
        }
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public object Clone()
        {
            return new B(this.name,this.age);
        }
    }
}
