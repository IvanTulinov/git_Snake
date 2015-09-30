using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Point
    {
        public int x;
        public int y;
        public char sym;

        public Point ()
        {
        }

        public Point(int _x, int _y, char _sym)
        {
            x = _x;
            y = _y;
            sym = _sym;
        }

        public Point(Point p)
        {
            x = p.x;
            y = p.y;
            sym = p.sym;
        }

        public void Move(int ofset, Direction direction)
        {
            if(direction==Direction.Right)
            {
                x = x + ofset;
            }
            else if (direction==Direction.Left)
            {
                x = x - ofset;
            }
            else if (direction==Direction.Up)
            {
                y = y - ofset;
            }
            else if(direction==Direction.Down)
            {
                y = y + ofset;
            }
        }

        internal void Clear()
        {
            /* это моя реализация
            Console.SetCursorPosition(x,y);
            Console.WriteLine(' ');
            */
            sym = ' ';
            Show();
        }

        public void Show()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }

        public bool IsHit(Point p)
        {
            return this.x == p.x && this.y == p.y;
        }

        internal void Snake()
        {
            sym = '*';
            Show();
        }
    }
}
