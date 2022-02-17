using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Elevators
{
    class Program
    {
        public class Elevator
        {
            public int level;
            public int call;
            public int rangeL;
            public int rangeH;
            public int time;

            public Elevator(int mRange, int uRange)
            {
                rangeL = mRange;
                rangeH = uRange;
                level = 0;
                call = 0;
                time = 0;
            }

            public void Open()
            {
                Console.WriteLine("Open doors");
            }

            public void Close()
            {
                Console.WriteLine("Close doors");
            }

            public void Call(int newlevel)
            {
                time = 0;
                int dif = Math.Abs(level - newlevel);
                time += dif;
                Console.WriteLine("Call from " + newlevel + " level. Time " + dif + " seconds.");
                Open();
                level = newlevel;
                Options();
            }

            public void Options()
            {
                if (level == 10)
                {
                    Console.WriteLine("Down");
                }
                else if (level > 1 & level < 10)
                {
                    Console.WriteLine("Up or Down");
                }
                else if (level < 0)
                {
                    Console.WriteLine("Up");
                }
            }

            public void Move(int newlevel)
            {
                Close();
                if (newlevel >= rangeL & newlevel <= rangeH)
                {
                    int dif = Math.Abs(level - newlevel);
                    time += dif;
                    level = newlevel;
                    Console.WriteLine("Move to " + level + " level. " + dif + " seconds.");
                    Open();
                    Close();
                }
                else
                {
                    Console.WriteLine("Move out of range");
                }
            }

            public void Stop()
            {
                Console.WriteLine("Emergency stop in level " + level);
            }
        }
        public static void Main(string[] args)
        {
            Elevator elevatorA = new Elevator(-1, 9);
            Elevator elevatorB = new Elevator(1, 10);
            bool stop = false;
            
            while (!stop)
            {
                Console.WriteLine("Choose the elevator (A or B)");
                string elevator = Console.ReadLine().ToUpper();
                Console.Clear();
                if (elevator == "A")
                {
                    Console.WriteLine("Enter the level of call");
                    int level = Convert.ToInt32(Console.ReadLine());
                    elevatorA.Call(level);
                    Console.WriteLine("Enter the level of destiny");
                    level = Convert.ToInt32(Console.ReadLine());
                    elevatorA.Move(level);
                    Console.ReadLine();
                    Console.Clear();
                    continue;
                }
                else if (elevator == "B")
                {
                    Console.WriteLine("Enter the level of call");
                    int level = Convert.ToInt32(Console.ReadLine());
                    elevatorB.Call(level);
                    Console.WriteLine("Enter the level of destiny");
                    level = Convert.ToInt32(Console.ReadLine());
                    elevatorB.Move(level);
                    Console.ReadLine();
                    Console.Clear();
                    continue;
                }
                else if (elevator == "CLOSE")
                {
                    stop = true;
                    break;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Invalid option. Tyr again.");
                    Console.ReadLine();
                    continue;
                }
            }
        }
    }
}
