using System;
using System.Collections.Generic;
using System.Text;

namespace Shape
{
    class Parallelogram : Rectangle
    {
        private float baseEdge;
        private float length;

        public Parallelogram(float b, float h, float l) : base(b,l)
        {
            this.baseEdge = b;
            this.height = h;
            this.length = l;
        }

        public override float area()
        {
            return (baseEdge * height);
        }

        public override float perimeter()
        {
            return base.perimeter();
        }
    }
}
