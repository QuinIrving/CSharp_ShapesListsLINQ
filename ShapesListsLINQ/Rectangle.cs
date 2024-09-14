using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesListsLINQ
{
    class Rectangle : Shape
    {
        public double Length { get; set; }
        public double Width { get; set; }
        
        public Rectangle(double _length, double _width)
        {
            Length = _length;
            Width = _width;
        }
        public override double Area()
        {
            return Length * Width;
        }

        public override double Perimeter()
        {
            return (Length * 2) + (Width * 2);
        }
    }
}
