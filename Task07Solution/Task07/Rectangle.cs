using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task07
{
    internal class Rectangle : IShape
    {
        public int Length { get; set; }
        public int Width { get; set; }

        public double Area
        {
            get { return Length * Width; }
        }


        public Rectangle(int _Length, int _Width)
        { Length = _Length; Width = _Width; }

        public void Draw()
        {
            Console.WriteLine("drawing a rectangle");
        }
    }
}
