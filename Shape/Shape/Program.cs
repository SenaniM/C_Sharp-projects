using System;

namespace Shape
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle(8,4);
            double areaR = rect.area();
            double periR = rect.perimeter();
            Console.WriteLine("Area of the Rectangle :{0}", areaR);
            Console.WriteLine("Perimeter of the Rectangle :{0}", periR);

            Square squre = new Square(7);
            double areaS = squre.area();
            double periS = squre.perimeter();
            Console.WriteLine("Area of the Square :{0}", areaS);
            Console.WriteLine("Perimeter of the Square :{0}", periS);

            Triangle triangle = new Triangle(6, 7);
            double areaT = triangle.area();
            double periT = triangle.perimeter();
            Console.WriteLine("Area of the Triangle :{0}", areaT);
            Console.WriteLine("Perimeter of the Triangle :{0}", periT);

            Circle circle = new Circle(14);
            double areaC = circle.area();
            double periC = circle.perimeter();
            Console.WriteLine("Area of the Circle :{0}", areaC);
            Console.WriteLine("Perimeter of the Circle :{0}", periC);

            Parallelogram parallel = new Parallelogram(12, 6, 9);
            double areaP = parallel.area();
            double periP = parallel.perimeter();
            Console.WriteLine("Area of the Parallelogram :{0}", areaP);
            Console.WriteLine("Perimeter of the Parallelogram :{0}", periP);
            Console.ReadLine();

        }
    }
}