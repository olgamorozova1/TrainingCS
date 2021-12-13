using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
    internal class Task2
    {
        public static void Main()
        {
            Point[] arrayOfPoints = new Point[10];

            Point.FillArrayOfPointsWithRandomValues(arrayOfPoints);

            Point.PrintArrayOfPoints(arrayOfPoints);

            
        }
    }
}
