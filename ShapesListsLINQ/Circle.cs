using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesListsLINQ
{
    class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(double _radius)
        {
            Radius = _radius;
        }
        public override double Area()
        {
            return Math.PI * ( Math.Pow(Radius, 2) );
        }

        public override double Perimeter()
        {
            return Math.PI * (Radius * 2);
        }
    }
}
