using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetBufferSize( 80 , 25 );

            HorizontalLine hLineTop = new HorizontalLine(0,78,0,'+');
            HorizontalLine hLineDown = new HorizontalLine(0,78,24,'+');
            VerticalLine vLineLeft = new VerticalLine(0, 24, 0, '+');
            VerticalLine vLineRight = new VerticalLine(0, 25, 78, '+');
            hLineTop.Drow();
            hLineDown.Drow();
            vLineLeft.Drow();
            vLineRight.Drow();

            Point p1 = new Point(5, 5, '*');
            Snake snake = new Snake( p1, 4, Direction.Right );
            snake.Drow();

            FoodCreator foodCreator = new FoodCreator(80,25,'@');
            Point food = foodCreator.CreateFood();
            food.Show();

            while(true)
            {
                if( snake.Eat( food ) )
                {
                    food = foodCreator.CreateFood();
                    food.Show();
                }
                else
                {
                    snake.Move();
                }

                Thread.Sleep(100);

                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.SendKey(key.Key);
                }
            }

            //Console.ReadKey();
        }
    }
}
