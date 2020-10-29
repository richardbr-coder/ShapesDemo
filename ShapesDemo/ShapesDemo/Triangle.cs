using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesDemo
{
    class Triangle : GeomatricFigure
    {
            public override double ComputeArea()
            {
                WriteLine("\nThe area of the Triangle is: ");
                area = Width * (Height / 2);
                return area;
            }
    }
}

