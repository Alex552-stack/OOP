using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Polymorphism.Clases
{
    internal class Rectangle : Square
    {
        private double SizeSide2;
        public Rectangle(int sizeSide, double sizeSide2) : base(sizeSide)
        {
            this.SizeSide2 = sizeSide2;
        }

        public override double getArea()
        {
            return SizeSide2 * SideSize;
        }
    }
}
