using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Client
{
    class Client
    {
        static void Main(string[] args)
        {
            string ans;
            string path = @"C:\Users\saqo\Desktop\Problem\problem.txt";
            Console.WriteLine("Enter the problem!");
            while (true)
            {
                ans = Console.ReadLine();
                if (ans.Contains('#'))
                    break;

                using (StreamWriter sw = new StreamWriter(path, true))
                {
                    sw.AutoFlush = true;
                    sw.WriteLine(ans);
                }

                EventWaitHandle wh = EventWaitHandle.OpenExisting("ProblemIsReady11");
                wh.Set();


                EventWaitHandle here = new EventWaitHandle(false, EventResetMode.AutoReset, "Solution is Ready");
                here.WaitOne();
               Console.Clear();
               Console.WriteLine(File.ReadLines(path).Last());
                
            }
        }
    }
}
