using OOP.Polymorphism.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Polymorphism.AbstractClasses
{
    internal abstract class AbstractGeometry : IGeometry
    {
        public abstract double getArea();
    }
}
