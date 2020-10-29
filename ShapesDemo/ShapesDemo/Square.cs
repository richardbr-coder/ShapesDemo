using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesDemo
{
    class Square : Rectangle
    {
            public Square(double height0, double width0)
            {
                if (height0 != width0)
                {
                    Height = height0;
                    Width = height0;
                }
            }
            
            public Square(double height1)
            {
                Height = height1;
                Width = height1;
            }
            
            public override double ComputeArea()
            {
                area = Width * Height;
                return area;
            }
    }
}

    

