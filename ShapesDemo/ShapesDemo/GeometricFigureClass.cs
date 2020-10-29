using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesDemo
{
    public abstract class GeomatricFigure
    {
        public double area;/*<<< It said to make this readonly...
                            It breaks my code and
                            I don't understand why it needs to be readonly
                            so I left it out
                            */
        
        public double Height{ set; get; }
        public double Width { set; get; }
        
        public abstract double ComputeArea();
    }

}

