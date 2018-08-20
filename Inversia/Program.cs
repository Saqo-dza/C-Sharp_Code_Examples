using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Algoritm_Home
{
    class Program
    {
        static void Main(string[] args)
        {
            int res= 0;
            int[] arr = { 1, 5, 3, 9, 10, 0, 7, 6 };

            Console.WriteLine(Inversia(arr, 0,ref res));
        }
        static int Inversia(int [] arr, int index,ref int result)//determine: how many times need swap for sorting array
        {
            for (int i = index+1; i < arr.Length; i++)
            {
                if (arr[index] >arr[i])
                {
                    result++;
                }  
            }
            if (index < arr.Length)
            {
                Inversia(arr,++index, ref result); 
            }
            return result;
        }
    }
}
