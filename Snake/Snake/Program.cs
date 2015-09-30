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
            Point p2 = new Point(4,5,'#');
            Point p3 = new Point(2, 3, '@');

            List<Point> pointList = new List<Point>();
            pointList.Add(p1);
            pointList.Add(p2);
            pointList.Add(p3);

            foreach (var item in pointList)
            {
                item.Show();
            }

            HorizontalLine hLine = new HorizontalLine(3,10,2,'+');
            hLine.Drow();

            VerticalLine vLine = new VerticalLine(2, 10, 11, '+');
            vLine.Drow();

            Console.ReadKey();
        }
    }
}
