using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Task07
{
    internal class Child : Parent
    {
        public int Z { get; set; }

        public Child(int _X, int _Y, int _Z) : base(_X, _Y)
        { Z = _Z; }



        //public new int Product()
        //{
        //    return X * Y * Z;
        //}

        public override int Product()
        {
            return X * Y * Z;
        }

        public override string ToString()
        {
            return $" X = {X} ,  Y = {Y} , Z = {Z}";
        }
    }
}
