using System;
using System.Drawing;
using System.Reflection.Metadata;

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
            // the compiler assumes that you know exactly how the object will be initialized
            #endregion

            #region Problem2
            //Calculator c01 = new Calculator();
            //Console.WriteLine(c01.sum(1,6));
            //Console.WriteLine(c01.sum(1,3,5));
            //Console.WriteLine(c01.sum(1.2,1.3));
            //It improves readability because a single method name conveys the same  instead of using different confusing names(AddInt, AddDouble).
            //It improves reusability because you can handle different types or numbers of arguments with the same logical operation, avoiding code duplication.
            #endregion

            #region Problem3
            //Child ch1 = new Child(5, 6, 7);
            //Console.WriteLine(ch1.ToString());
            //Constructor chaining ensures base class initialization happens first,
            //keeping objects properly constructed in inheritance hierarchies.
            #endregion

            #region Problem4
            //Parent p1 = new Parent(3, 4);
            //Console.WriteLine(p1.Product());
            //Child ch1 = new Child(3, 4, 5);
            //Console.WriteLine(ch1.Product());
            //override -> dynamic binding (runtime polymorphism) 
            //new -> static binding (compile-time polymorphism)
            #endregion

            #region Problem5
            //Parent P1 = new Parent(5, 3);
            //Child ch1 = new Child(9, 2, 3);
            //Console.WriteLine(P1.ToString());
            //Console.WriteLine(ch1.ToString());  
            // to give a proper representation about a specific object
            #endregion

            #region Problem6
            //Rectangle r1 = new Rectangle(5, 3);
            //r1.Draw();
            //Console.WriteLine(r1.Area);
            //Since an interface does not contain executable code for its members,
            //the compiler cannot create an object that “does something” directly.
            #endregion

            #region Problem7
            //IShape c1 = new Circle(2);
            //c1.PrintDetauls();
            //Default implementations allow you to provide a body for a method in an interface.
            #endregion

            #region Problem8
            //IMovable c1 = new Car(43, "Toyota", 1000123);
            //c1.Move();
            //Interface references let you call methods polymorphically, enabling flexible, decoupled, and reusable code.
            #endregion

            #region Problem9
            //File f1 = new File();
            //f1.Read();
            //f1.Write();
            //solves the diamond problem by allowing a class to implement multiple interfaces without ambiguity.
            #endregion

            #region Probelm10
            //Rectangle_2 r1 = new Rectangle_2(5, 3);
            //r1.Draw();
            //Console.WriteLine(r1.CalculatArea());
            //virtual methods are implemented methods which optionally can be overridden in derived classes,
            //while abstract methods are declared without implementation and must be overridden in derived classes.
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
