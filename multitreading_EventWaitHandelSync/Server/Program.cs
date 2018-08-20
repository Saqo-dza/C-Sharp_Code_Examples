using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Server
{
    class Server
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\saqo\Desktop\Problem\problem.txt";
            while (true)
            {
                EventWaitHandle wh = new EventWaitHandle(false, EventResetMode.AutoReset, "ProblemIsReady11");
                wh.WaitOne();//Blocks the current thread until the signal is received by the WaitHandle object

                string ans = File.ReadLines(path).Last();

                using (StreamWriter sw = File.AppendText(path))
                {
                    sw.AutoFlush = true;
                    sw.WriteLine(Calc(ans));
                }
                Console.Clear();
                Console.WriteLine(ans);
                EventWaitHandle here = EventWaitHandle.OpenExisting("Solution is Ready");
                here.Set();//Sets the alarm state of the event, which allows you to continue execution to one or more pending threads.
            }
        }
        static string Calc(string a)
        {
            char[] oper = new char[4] { '+', '-', '*', '/' };

            foreach (char item in oper)
            {
                if (a.Contains(item))
                {
                    string[] arr = a.Split(item);
                    int x = int.Parse(arr[0].Trim());
                    int y = int.Parse(arr[1].Trim());

                    if (item == '\\' && y == 0)
                        return "a/0 !";

                    switch (item)
                    {
                        case '+':
                            return (x + y).ToString();
                        case '-':
                            return (x - y).ToString();
                        case '*':
                            return (x * y).ToString();
                        case '/':
                            return (x / y).ToString();
                    }

                }
            }

            return "!";
        }

    }
}
