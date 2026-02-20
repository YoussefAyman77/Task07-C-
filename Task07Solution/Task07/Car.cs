using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task07
{
    internal class Car : IMovable
    {
        //properties
        public int Id { get; set; }
        public string Brand { get; set; }
        public decimal Price { get; set; }

        //cotrs
        public Car(int _Id, string _Brand1, decimal _Price)
        {
            Id = _Id;
            Brand = _Brand1;
            Price = _Price;
        }
        public Car(int _Id): this(_Id,"Tyota", 10000000){}
        public Car(int _Id, string _Brand):this (_Id,_Brand, 10000000){}

        //to string
        public override string ToString()
        {
            return $"Car id is {Id} and its brand is {Brand} and is price is {Price}";
        }

        public void Move()
        {
            Console.WriteLine("The car is moving");
        }
    }
}
