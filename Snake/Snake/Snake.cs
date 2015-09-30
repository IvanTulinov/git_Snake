using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Snake : Figure
    {
        Direction direction;

        public Snake(Point tail, int length, Direction _direction)
        {
            direction = _direction;
            pList = new List<Point>();
            for (int i = 0; i < length; i++)
            {
                Point p = new Point(tail);
                p.Move(i, direction);
                pList.Add(p);
            }
        }

        internal void Move()
        {
            Point tail = pList.First();
            pList.Remove( tail );
            Point head = GetNewPoint();
            pList.Add( head );

            tail.Clear();
            head.Show();
        }

        private Point GetNewPoint()
        {
            Point newPoint = new Point( pList.Last() );
            newPoint.Move(1, direction);
            return newPoint;
        }

        internal void SendKey(ConsoleKey key)
        {
            if (key == ConsoleKey.LeftArrow)
            {
                direction = Direction.Left;
            }
            else if (key == ConsoleKey.RightArrow)
            {
                direction = Direction.Right;
            }
            else if (key == ConsoleKey.DownArrow)
            {
                direction = Direction.Down;
            }
            else if (key == ConsoleKey.UpArrow)
            {
                direction = Direction.Up;
            }
        }
    }
}
