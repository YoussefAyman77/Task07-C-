using System;

namespace Task07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Problem1
            //Car c1 = new Car(1);
            //Car c2 = new Car(5, "reno");
            //Car c3 = new Car(17, "honda", 2500000);
            //Console.WriteLine(c1.ToString());
            //Console.WriteLine(c2.ToString());
            //Console.WriteLine(c3.ToString());
            #endregion

            #region Problem2
            //Calculator c01 = new Calculator();
            //Console.WriteLine(c01.sum(1,6));
            //Console.WriteLine(c01.sum(1,3,5));
            //Console.WriteLine(c01.sum(1.2,1.3));
            #endregion

            #region Problem3
            //Child ch1 = new Child(5, 6, 7);
            //Console.WriteLine(ch1.ToString());
            #endregion

            #region Problem4
            //Parent p1 = new Parent(3, 4);
            //Console.WriteLine(p1.Product());
            //Child ch1 = new Child(3, 4, 5);
            //Console.WriteLine(ch1.Product());
            #endregion

            #region Problem5
            //Parent P1 = new Parent(5, 3);
            //Child ch1 = new Child(9, 2, 3);
            //Console.WriteLine(P1.ToString());
            //Console.WriteLine(ch1.ToString());  
            #endregion

            #region Problem6
            //Rectangle r1 = new Rectangle(5, 3);
            //r1.Draw();
            //Console.WriteLine(r1.Area);
            #endregion

            #region Problem7
            //IShape c1 = new Circle(2);
            //c1.PrintDetauls();
            #endregion

            #region Problem8
            //IMovable c1 = new Car(43, "Toyota", 1000123);
            //c1.Move();
            #endregion

            #region Problem9
            //File f1 = new File();
            //f1.Read();
            //f1.Write();
            #endregion

            #region Probelm10
            //Rectangle_2 r1 = new Rectangle_2(5, 3);
            //r1.Draw();
            //Console.WriteLine(r1.CalculatArea());
            #endregion

            #region Part02
            //1- claas is a reference type and struct is a value type
            //2- class can be inherited but struct cannot be inherited
            //3- class can have a default constructor but struct cannot have a default constructor
            //4- class stored in heap and struct stored in stack
            //------
            //1- Associatio (uses A relationship)
            //2- Aggregation (has A relationship) but weak
            //3- Composition (has A relationship) but strong
            //4- dependency (uses A relationship) but temporary
            #endregion
        }
    }
}
