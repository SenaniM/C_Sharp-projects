using System;
using System.Collections.Generic;
using System.Text;

namespace Shape
{
    class Circle : Shape
    {
        private float radius;
        private const float pi = 22 / 7;

        public Circle(float r)
        {
            this.radius = r;
        }

        public override float area()
        {
            return (pi * radius * radius);
        }

        public override float perimeter()
        {
            return (2 * pi * radius);
        }

    }
}
