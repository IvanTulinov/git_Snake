using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class VerticalLine
    {
        List<Point> pList;

        public VerticalLine(int yTop, int yFoot, int x, char sym)
        {
            pList = new List<Point>();
            for (int y = yTop; y < yFoot; y++)
            {
                Point p = new Point(x, y, sym);
                pList.Add(p);
            }
        }

        public void Drow()
        {
            foreach (var item in pList)
            {
                item.Show();
            }
        }
    }
}
