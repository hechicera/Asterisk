using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zvezdochka
{
    class Program
    {
        static void Main(string[] args)
        {            
            int x = 50;
            int y = 12;
            int flag1 = 119;
            int flag2 = -1;
            ConsoleKeyInfo k;

            do
            {
                Console.SetCursorPosition(x, y);
                Console.Write("*");
                Console.CursorVisible = false;
                k = Console.ReadKey();

                if (k.Key == ConsoleKey.UpArrow)
                    y--;
                else if (k.Key == ConsoleKey.DownArrow)
                    y++;
                else if (k.Key == ConsoleKey.LeftArrow)
                    x--;
                else if (k.Key == ConsoleKey.RightArrow)
                    x++;
                if (x >= flag1)
                    x--;
                if (y <= flag2)
                    y++; 
                Console.Clear();
            } while (k.Key != ConsoleKey.Escape);

            
            Console.ReadKey();
        }
    }
}
