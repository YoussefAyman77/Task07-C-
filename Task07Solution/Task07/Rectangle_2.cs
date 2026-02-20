using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task07
{
    internal class Rectangle_2 : Shape
    {
        public double Lenght { get; set; }
        public double Width { get; set; }

        public Rectangle_2(double _Lenght, double _Width)
        {
            Lenght = _Lenght;
            Width = _Width;
        }
        public override double CalculatArea()
        {
            return Lenght * Width;
        }
        
        public override void Draw()
        {
            Console.WriteLine("Drawing rectangle");
        }
    }
}
