using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
    internal class Point
    {
        private int x;
        private int y;

        public Point(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public int X { get => x; set => x = value; }
        public int Y { get => y; set => y = value; }

        public void PrintPointValues ()
        {
            Console.WriteLine($"Coordinate X- {X}, coordinate Y- {Y}");
        }
        public static void FillArrayOfPointsWithRandomValues (Point[] array)
        {
            Random rnd = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = new Point(rnd.Next(1, 100), rnd.Next(1, 100));
            }
        }

        public static void PrintArrayOfPoints(Point[] array)
        {
            foreach (Point point in array)
            {
                point.PrintPointValues();
            }
        }
    }
}
