using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ff
{
    class Figure
    {
        static int origTop = Console.CursorTop;
        static int origLeft = Console.CursorLeft;
        //---------x, y graphic -------
        public static void PrintXY()
        {
            Console.SetWindowSize(80, 40);
            WriteAt("^ Y", 20, 1);
            for (int i = 2; i <= 30; i++)
            {
                if (i==15)
                {
                    for (int j = 0; j <= 44; j++)
                    {
                        if (j==22)
                        {
                            WriteAt("0", 19, 14);
                        }
                        WriteAt(". > X", j, 15);
                    }
                }
                WriteAt(".", 20, i);
            }
        }
        //-------y=f(x)--------
        public static void Func1()
        {
            int j = 3;
            WriteAt("y=f(x)", 30, 5);

            for (int i = 44; i >= 0; i -= 2)
            {
                WriteAt(".", i, j);
                j++;
            }
            WriteAt("Function: y=f(x) \n\n", 0, 32);
            Console.ReadKey();
        }
        //-------y=f(x^2)--------
        public static void Func2()
        {
            int y1 = 15;
            int y2 = 14;
            WriteAt("y=f(x^2)", 33, 5);
            for (int x = 21; x <=35; x ++)
            {
                if (x>30)
                {
                    WriteAt(".", 30, y1);
                    y1--;
                    continue;
                }
                WriteAt(".", x, y1);
                y1--;
            }
            for (int x = 18; x >=5; x--)
            {
                if (x<11)
                {
                    WriteAt(".", 10, y2);
                    y2--;
                    continue;
                }
                WriteAt(".",x , y2);
                y2--;
            }
            WriteAt("Function: y=f(x^2) \n\n", 0, 32);
            Console.ReadKey();
        }
        //--------y=ln2x--------
        public static void Func3()
        {
            int y1 = 17;
            int y2 = 15;
            WriteAt("y=f(ln2x) ", 33, 8);
            WriteAt(".", 22, 18);
            for (int x = 23; x <= 45; x++)
            {
                if (x > 29)
                {
                    WriteAt(".", x, y1);
                    if (y2>18)
                    {
                        WriteAt(".", 22, y2);
                    }
                    y2++;
                    continue;
                }
                WriteAt(".", x, y1);
                y1--;
            }
            WriteAt("Function: y=f(ln2x) \n\n", 0, 32);
            Console.ReadKey();
        }
        //-----------coordinates x,y-----------
        public static void WriteAt(string s, int x, int y)
        { 
            try
            {
                Console.SetCursorPosition(origLeft + x, origTop + y);
                Console.Write(s);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.Clear();
                Console.WriteLine(e.Message);
            }
        }
        //-------------------
        public static void SelectFunction()
        {
            int num;
            Console.WriteLine("choose graphic you want");
            Console.WriteLine("1 = y=f(x), 2 = y=f(x^2), 3 = y=f(ln2x)");
            int.TryParse(Console.ReadLine(), out num);
            Console.Clear();
            switch (num)
            {
                case 1:
                    PrintXY();
                    Func1();
                    break;
                case 2:
                    PrintXY();
                    Func2();
                    break;
                case 3:
                    PrintXY();
                    Func3();
                    break;
                default:
                    Console.WriteLine("Error: incorrect value");
                    break;
            }
        }
    }
}
