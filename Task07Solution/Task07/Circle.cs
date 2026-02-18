using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Task07
{
    internal class Circle : IShape
    {
        public double Radius { get; set; }


        public Double Area
        {
            get { return Math.PI * Radius * Radius; }
        }

        public Circle(double _Radius)
        { Radius = _Radius; }
        void IShape.Draw()
        {
            Console.WriteLine($"Drawing a circle with radius: {Radius}");
        }
    }
}
