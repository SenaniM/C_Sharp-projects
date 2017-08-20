using System;
using System.Collections.Generic;
using System.Text;

namespace Animal
{
    class YellowBird :Animal, IAnimalFly
    {
        public void fly()
        {
            Console.WriteLine("Yellow Bird flies ");
        }

        public override void makeSound()
        {
            Console.WriteLine("Yellow Bird chirping ");
        }
    }
}
