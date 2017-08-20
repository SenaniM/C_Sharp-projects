using System;
using System.Collections.Generic;
using System.Text;

namespace Animal
{
    class Human : Animal, IAnimalClap, IAnimalJump, IAnimalRun, IAnimalSwim, IAnimalWalk
    {
        public void clap()
        {
            Console.WriteLine("Human claps");
        }

        public override void makeSound()
        {
            Console.WriteLine("Human talks");
        }

        public void run()
        {
            Console.WriteLine("Human runs");
        }

        public void swim()
        {
            Console.WriteLine("Human swims");
        }

        public void walk()
        {
            Console.WriteLine("Human walks");
        }
    }
}
