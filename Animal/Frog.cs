using System;
using System.Collections.Generic;
using System.Text;

namespace Animal
{
    class Frog : Animal, IAnimalJump, IAnimalSwim
    {
        public override void makeSound()
        {
            Console.WriteLine("Frog makes sound");
        }

        public void jump()
        {
            Console.WriteLine("Frog jumps");
        }

        public void swim()
        {
            Console.WriteLine("Frog swims");
        }
    }
}
