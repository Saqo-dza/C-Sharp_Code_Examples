using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CovarianGeneric
{
    class Program
    {
        public class animal
        {
        }
        public class cat: animal
        {
        }
        public interface Ianimal<in T>//out
        {
             //T Name { get;  }
            T Name { set; }
        }
        public class container<T> : Ianimal<T>
        {
            // public T Name { get; }
            public T Name { set { } }
        }
        static void Main(string[] args)
        {
            //Ianimal<animal> animal = new container<cat>();//upcast ,out , Covariance  
            Ianimal<cat> animal = new container<animal>();//downcast ,in ,Contravariance     

            Iengine<car> iengine=new details<mator>();
           // Iengine<mator> iengine = new details<car>();
        }
    }
}
