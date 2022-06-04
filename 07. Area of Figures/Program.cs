using System;
namespace AreaOfFigures
{
    class Program
    {
        static void Main()
        {
            //Input
            string typeFigure = Console.ReadLine();
            //Action
            
            if (typeFigure == "square")
            {
                double lenghtSide = double.Parse(Console.ReadLine());
                double sSquare = lenghtSide * lenghtSide;
                Console.WriteLine($"{sSquare:f3}");
            }
            else if (typeFigure == "rectangle")
            {
                double lenghtSide1 = double.Parse(Console.ReadLine());
                double lenghtSide2 = double.Parse(Console.ReadLine());
                double sRectangle = lenghtSide1 * lenghtSide2;
                Console.WriteLine($"{sRectangle:f3}");
            }
            else if (typeFigure == "circle")
            {
                double radius = double.Parse(Console.ReadLine());
                double sCircle = (radius * radius) * Math.PI;
                Console.WriteLine($"{sCircle:f3}");
            }
            else if (typeFigure == "triangle")
            {
                double lenghtSide = double.Parse(Console.ReadLine());
                double lenghtHight = double.Parse(Console.ReadLine());
                double sTriangle = (lenghtSide * lenghtHight) / 2;
                Console.WriteLine(($"{sTriangle:f3}"));
            }

            //Output
        }
    }
}

