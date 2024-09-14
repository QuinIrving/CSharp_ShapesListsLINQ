using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesListsLINQ
{
    class Square : Rectangle
    {
        public double Side { get; set; }
        public Square(double _side) : base(_side, _side)
        {
            Side = _side;
        }
        public override double Area()
        {
            return Side * Side;
        }

        public override double Perimeter()
        {
            return Side * 4;
        }
    }
}
