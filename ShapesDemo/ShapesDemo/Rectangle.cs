using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesDemo
{
        class Rectangle : GeomatricFigure
        {
            public override double ComputeArea()
            {
                WriteLine("\n\nThe area of the rectangle is: ");
                area = Width * Height;
                return area;
            }
        }
}
