using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake1
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(1, 3, '*');
            p1.Draw();

            Point p2 = new Point(4, 5, '#');
            p2.Draw();

            horizontline lineOne = new horizontline(0, 20, 0, '*');
            VertikalLine lineTwo = new VertikalLine(8, 12, 10, '+');
            lineOne.Drow();
            lineTwo.Drow();
           



            Console.ReadLine();
        }
       
    }
}
