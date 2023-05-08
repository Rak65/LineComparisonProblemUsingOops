﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparisonProblemUsingOops
{
    public class CalculateLength
    {
        public void CalLength()
        {
            double x1, y1, x2, y2;

            Console.WriteLine("Enter the (x , y) coordinates of the first point:");
            x1 = double.Parse(Console.ReadLine());
            y1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the (x,y) coordinates of the second point:");
            x2 = double.Parse(Console.ReadLine());
            y2 = double.Parse(Console.ReadLine());

            double length = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

            Console.WriteLine("Length of the line = " + length);
        }
    }
}
