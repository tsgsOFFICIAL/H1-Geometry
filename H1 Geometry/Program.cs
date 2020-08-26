using System;

namespace H1_Geometry
    {
    class Program
        {
        static void Main(string[] args)
            {
            Square squareOne = new Square(2);
            Square squareTwo = new Square(4);
            Square squareThree = new Square(8);
            Square squareFour = new Square(16);
            Square squareFive = new Square(32);

            Console.WriteLine("This square has a perimeter of {0}", squareThree.GetPerimeter());
            Console.WriteLine("This square has an area of {0}", squareThree.GetArea());


            squareThree.Side = 5;
            Console.WriteLine("CHANGED");

            Console.WriteLine("This square has a perimeter of {0}", squareThree.GetPerimeter());
            Console.WriteLine("This square has an area of {0}", squareThree.GetArea());

            Console.ReadKey(true);
            }
        }
    }
