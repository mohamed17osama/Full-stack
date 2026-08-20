using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape_rendering_system.models
{
    internal abstract class Shape : IDrawable
    {
        public double area;
        public Shape(double area) 
        {
            this.area = area;
        }
        public abstract void Draw();
        public abstract double Area();

        public void Describe()
        {
            Console.WriteLine(GetType().Name + " Area: " + Area());
        }
    }
}
