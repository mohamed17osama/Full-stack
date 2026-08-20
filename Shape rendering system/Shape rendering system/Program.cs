using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shape_rendering_system.models;

namespace Shape_rendering_system
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Shape[] shapes =
            {
                new Circle(20),
                new Triangle(50),
                new Rectangle(100)
            }; 
            foreach (Shape shape in shapes)
            {
                shape.Describe();
                shape.Draw();
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
