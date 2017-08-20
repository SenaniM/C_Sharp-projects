using System;
using System.Collections.Generic;
using System.Text;

namespace Shape
{
    class Rectangle : Shape

    {
        public float width, height;

        public Rectangle(float w, float h)
        {
            this.width = w;
            this.height = h;
        }

        public override float area()
        {
            return (width * height);
        }

        public override float perimeter()
        {
            return 2 * (width + height);
        }

    }
}