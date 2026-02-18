using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task07
{
    internal class Rectangle
    {
        public int Length { get; set; }
        public int Width { get; set; }

        public Rectangle(int _Length, int _Width)
        { Length = _Length; Width = _Width; }

        //public int Area() 
        //{ return Length * Width; }
        //public void Draw()
        //{
        //    Console.WriteLine($"Drawing a Rectangle with Lenght = {Length} and Width = {Width}");
        //}
    }
}
