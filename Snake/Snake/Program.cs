using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            int x1 = 3;
            int y1 = 5;
            char sym1 = '*';

            Show(x1, y1, sym1);

            int x2 = 6;
            int y2 = 10;
            char sym2 = '#';

            Show(x2, y2, sym2);


            Console.ReadKey();
        }

        public static void Show(int x, int y, char sym)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }

    }
}
