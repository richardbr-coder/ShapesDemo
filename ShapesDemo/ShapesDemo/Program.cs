using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesDemo
{
    class Program
    {
        static void Main()
        {
            //Prompting user for height and width
            Write("Enter Height: ");
            double height = double.Parse(ReadLine());
            Write("Enter Width: " ); 
            double width = double.Parse(ReadLine());

            //Rectangle
            Rectangle rec = new Rectangle();
            rec.Height = height;
            rec.Width = width;
            double recArea = rec.ComputeArea();
            WriteLine($"Area of Rectangle: {recArea.ToString()}");

            #region square
            //square
            Square squ0 = new Square(height,width); 
            double squArea0 = squ0.ComputeArea();
            WriteLine("\nFirst constructor in square class");
            WriteLine($"Area of Square:{squArea0.ToString()}");//trying to better understand string interpolation

            //square
            Square squ1 = new Square(height);
            double squArea1 = squ1.ComputeArea();
            WriteLine("\nSecond constructor in square class");
            WriteLine($"Area of Square:{squArea1.ToString()}");
            #endregion square

            //Triangle
            Triangle tri = new Triangle();
            tri.Height = height;
            tri.Width = width;
            double triArea = tri.ComputeArea();
            WriteLine($"Area of Triangle: {triArea.ToString()}");
            
            ReadLine();
        }
    }
}
