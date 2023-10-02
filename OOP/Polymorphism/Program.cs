using OOP.Polymorphism.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Polymorphism
{
    //This script uses polymorphism to make different getArea functions for each type of geometrical shape
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new(3);
            Square square = new(3);
            Rectangle rectangle = new(2, 3);
            
            Console.WriteLine("The circle has an area of " + circle.getArea());
            Console.WriteLine("The square has an area of " + square.getArea());
            Console.WriteLine("The rectangle has an area of " + rectangle.getArea());


        }
    }
}
