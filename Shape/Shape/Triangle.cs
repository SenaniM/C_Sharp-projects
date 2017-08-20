using System;
using System.Collections.Generic;
using System.Text;

namespace Shape
{
    class Triangle : Rectangle
    {
        private float baseEdge;
        private float hypotenuse;

        public Triangle(float baseEdge, float hypotenuse) : base(baseEdge, hypotenuse)
        {
            this.baseEdge = baseEdge;
            this.hypotenuse = hypotenuse;
        }

        public override float area()
        {
            return base.area()/2;
        }

        public override float perimeter()
        {
            return (3 * baseEdge); // for Equilateral Triangle
        }
    }
}
