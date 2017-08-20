using System;
using System.Collections.Generic;
using System.Text;

namespace Shape
{
    class Square : Rectangle
    {
        private float length;

        public Square(float length) : base(length, length)
        {
           
        }

        public override float area()
        {
            return (length * length);
        }

        public override float perimeter()
        {
            return (length * 4);
        }
    }
}
