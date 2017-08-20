using System;
using System.Collections.Generic;
using System.Text;

namespace Animal
{
    class Dog : Animal, IAnimalJump, IAnimalRun, IAnimalSwim, IAnimalWalk
    {
        public void jump()
        {
            Console.WriteLine("Dog jumps");
        }

        public void run()
        {
            Console.WriteLine("Dog runs");
        }

        public void swim()
        {
            Console.WriteLine("Dog swims");
        }

        public void walk()
        {
            Console.WriteLine("Dog walks");

        }

        public override void makeSound()
        {
            Console.WriteLine("Dog barks");
        }
    }
}
