using OOP.Polymorphism.AbstractClasses;
using OOP.Polymorphism.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Polymorphism.Clases
{
    internal class Circle : AbstractGeometry
    {
        static private double Pi = 3.14;
        private readonly double Radius;
        public Circle(double radius) {
            Radius = radius;
        }

        public override double getArea()
        {
            return Pi * Radius * Radius;
        }
    }
}
