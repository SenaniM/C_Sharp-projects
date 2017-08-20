using System;
using Shape;

namespace ShapePrint
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle(4, 8);
            Square sq = new Square(5);
            Triangle trian = new Triangle(8, 14);
            Circle cr = new Circle(21);
            Parallelogram parllel = new Parallelogram(3, 8, 6);

            Console.WriteLine(r.area);
            Console.WriteLine(r.perimeter);
            Console.WriteLine(sq.area);
            Console.WriteLine(sq.perimeter);
        }
    }
}