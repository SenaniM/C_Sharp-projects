using System;
using System.Collections.Generic;
using System.Text;

namespace Animal
{
    class GoldFish : IAnimalSwim
    {
        public void swim()
        {
            Console.WriteLine("Gold fish swims ");
        }
    }
}
