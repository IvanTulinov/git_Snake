using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Walls
    {
        List<Figure> wList;
        
        public Walls(int mapWidth, int mapHeight)
        {
            wList = new List<Figure>();

            HorizontalLine hLineTop = new HorizontalLine(0, mapWidth-2, 0, '+');
            HorizontalLine hLineDown = new HorizontalLine(0, mapWidth-2, mapHeight-1, '+');
            VerticalLine vLineLeft = new VerticalLine(0, mapHeight-1, 0, '+');
            VerticalLine vLineRight = new VerticalLine(0, mapHeight-1, mapWidth-2, '+');

            wList.Add(hLineTop);
            wList.Add(hLineDown);
            wList.Add(vLineLeft);
            wList.Add(vLineRight);
        } 

        internal bool IsHit( Figure figure )
        {
            foreach(var wall in wList)
            {
                if (wall.IsHit(figure))
                {
                    return true;
                }
            }
            return false;
        }

        public void Draw()
        {
            foreach (var item in wList)
            {
                item.Drow();
            }
        }
    }
}
