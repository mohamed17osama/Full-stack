using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape_rendering_system.models
{
    internal class Rectangle : Shape, IDrawable
    {
        
        public Rectangle(double area):base(area) { }
        public override double Area()
        {
            return base.area;
        }
        public override void Draw()
        {
            Console.WriteLine("-----------------");
            Console.WriteLine("|               |");
            Console.WriteLine("|               |");
            Console.WriteLine("|               |");
            Console.WriteLine("|               |");
            Console.WriteLine("-----------------");
        }

    }
}
