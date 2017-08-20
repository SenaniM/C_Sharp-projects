using System;
using System.Collections.Generic;
using System.Text;

namespace Animal
{
    class Cat : Animal, IAnimalJump, IAnimalRun, IAnimalSwim, IAnimalWalk
    {
        public override void makeSound()
        {
            Console.WriteLine("Cat makes sound");
        }

        public void run()
        {
            Console.WriteLine("Cat runs");
        }

        public void swim()
        {
            Console.WriteLine("Cat swims");
        }

        public void walk()
        {
            Console.WriteLine("Cat walks");
        }

        public void jump()
        {
            Console.WriteLine("Cat jumps");
        }
    }
}
