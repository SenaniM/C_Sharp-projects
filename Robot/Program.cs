using System;

namespace Robot
{
    class Program
    {
        static void Main(string[] args)
        {
            Robot robot = new Robot();

            robot.Strength = 75;
            robot.Life = 100;

            robot.shoot();
        }
    }
}