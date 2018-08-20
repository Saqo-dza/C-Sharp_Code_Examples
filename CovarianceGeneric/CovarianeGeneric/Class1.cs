using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CovarianGeneric
{
    class car
    {
    }
    class mator:car
    {
    }
    interface Iengine<out T>
    {
        T Mark { get; }
        T print();
    } 
    public class details<T>:Iengine<T>
    {
        public T Mark { get; }

        public T print()
        {
            throw new NotImplementedException();
        }
    }
}
