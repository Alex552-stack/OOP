using OOP.Polymorphism.AbstractClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Polymorphism.Clases
{
    internal class Square : AbstractGeometry
    {
        protected double SideSize;
        public Square(int sizeSide) {
            SideSize = sizeSide; }
        public override double getArea()
        {
            return SideSize * SideSize;
        }
    }
}
