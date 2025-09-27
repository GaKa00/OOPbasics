using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPbasics
{
    internal class Circle
    {

        private int _radius;

        public Circle(int radius)
        {
            _radius = radius;
        }

        public void GetArea()
        {
            double pi = Math.PI;
            double area = pi * _radius * _radius;
            Console.WriteLine((int)area); 
        }
    }
}
