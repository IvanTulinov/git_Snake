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
            Point p1 = new Point(1,1,'*');
            p1.Show();

            Function(p1);

            p1.Show();

            //Point p2 = new Point(4,5,'#');
            //p2.Show();

            Console.ReadKey();
        }

        public static void Function (Point p)
        {
            p.sym = '2';

            p.Show();

            p.x = 1;
            p.y = 3;
            p.sym = '3';
            p = new Point(1,4,'4');
            p.Show();

        }
    }
}
