using System;

namespace procedural_vs_oop
{
    class Program
    {
        public class Lamp
        {
            string status;

            public Lamp(string s)
            {
                status = s;
                Console.WriteLine("New lamp created");
            }

            public void turnOn()
            {
                status = "On";
                Console.WriteLine("Lamp turn on");
            }
            public void turnOff()
            {
                status = "Off";
                Console.WriteLine("Lamp turn off");
            }
        }
        static void table(int x)
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(x + " times " + i + " is " + (x * i));
            }
        }
        static void Main(string[] args)
        {
            // What is the difference between procedural and object oriented programming?
            /* Procedural programming creates functions that can be called at any time in the program
               Object oriented programming creates methods for elements that belongs to the class created */
            Lamp desk = new Lamp("Off");
            desk.turnOn();
            desk.turnOff();

            table(7);
            // When would you want to use one versus the other?
            /* If the main purpose of the program is to represent something from the real world is better
               to use OOP to describe its behavior. If the program is more logic and has a lot of repeated
               methods is better to use procedural programming */
        }
    }
}
