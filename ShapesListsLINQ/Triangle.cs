using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesListsLINQ
{
    class Triangle : Shape
    {
        public double SideA { get; set; }
        public double SideB { get; set; }
        public double SideC { get; set; }
        public Triangle(double _sideA, double _sideB, double _sideC)
        {
            SideA = _sideA;
            SideB = _sideB;
            SideC = _sideC;
        }
        public override double Area()
        {
            double s = (SideA + SideB + SideC) / 2;
            double a = s - SideA;
            double b = s - SideB;
            double c = s - SideC;
            return Math.Sqrt(s*a*b*c);
        }

        public override double Perimeter()
        {
            return SideA + SideB + SideC;
        }
    }
}
