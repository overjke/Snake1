using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Snake1
{
    class Program 
    {
        static void Main(string[] args)
        {
            Console.SetBufferSize(80, 25);

            
            horizontline lineOne = new horizontline(0, 78, 0, '+');
            horizontline lineTwo = new horizontline(0, 78, 24, '+');
            VertikalLine lineThree = new VertikalLine(0, 24, 0, '+');
            VertikalLine lineFour = new VertikalLine(0, 24, 78, '+');
            
            lineOne.Draw();
            lineTwo.Draw();
            lineThree.Draw();
            lineFour.Draw();

            // Отрисовка точек
            Point p = new Point(4, 5, '#');
            Snake1 snake = new Snake1(p, 4, Direction.RIGHT);
            snake.Draw();
            
            while(true)
            {
                if(Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HadleKey(key.Key);
                }
                Thread.Sleep(100);
                snake.Move();
            }

            Console.ReadLine();
        }
       
    }
}
