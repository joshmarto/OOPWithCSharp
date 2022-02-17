using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Rextester
{
    public class Program
    {
        public class Vehicle
        {
            public string make;
            public string model;
            public int year;
            public int weight;
            public bool needsMaintenance = false;
            public int tripsSinceMaintenance = 0;

            public void setMake(string make_)
            {
                make = make_;
            }

            public void setModel(string model_)
            {
                model = model_;
            }

            public void setYear(int year_)
            {
                year = year_;
            }

            public void setWeight(int weight_)
            {
                weight = weight_;
            }
        }

        public class Cars : Vehicle
        {
            bool isDriving = false;

            public Cars(string make_, string model_, int year_, int weight_)
            {
                make = make_;
                model = model_;
                year = year_;
                weight = weight_;
            }

            public string Drive()
            {
                isDriving = true;
                tripsSinceMaintenance += 1;
                if (tripsSinceMaintenance > 100)
                {
                    needsMaintenance = true;
                    Console.WriteLine("Maintenance required");
                }
                return "Driving...";
            }

            public void Stop()
            {
                isDriving = false;
            }

            public void Repair()
            {
                tripsSinceMaintenance = 0;
                needsMaintenance = false;
                Console.WriteLine("Car repaired");
            }
        }

        public class Plane : Vehicle
        {
            bool isFlying = false;

            public Plane(string make_, string model_, int year_, int weight_)
            {
                make = make_;
                model = model_;
                year = year_;
                weight = weight_;
            }

            public bool Flying()
            {
                if (needsMaintenance == false)
                {
                    isFlying = true;
                    tripsSinceMaintenance += 1;
                    if (tripsSinceMaintenance > 99)
                    {
                        needsMaintenance = true;
                        Console.WriteLine("Maintenance required");
                    }
                    return true;
                }
                else
                {
                    Console.WriteLine("The plane can't fly until it's repaired");
                    return false;
                }
            }

            public void Landing()
            {
                isFlying = false;
            }

            public void Repair()
            {
                tripsSinceMaintenance = 0;
                needsMaintenance = false;
                Console.WriteLine("Plane repaired");
            }
        }

        public static void Main(string[] args)
        {
            Cars M3 = new Cars("Mercedes Benz", "M3", 2019, 235);
            for (int i = 0; i < 100; i++)
            {
                M3.Drive();
                M3.Stop();
            }
            Console.WriteLine("Trips since maintence: " + M3.tripsSinceMaintenance);
            M3.Drive();
            M3.Repair();

            Plane airForce1 = new Plane("USA Goverment", "AF1", 2021, 750);
            Console.WriteLine("");
            Console.WriteLine("Air Force 1");
            for (int i = 0; i < 100; i++)
            {
                airForce1.Flying();
                airForce1.Landing();
            }
            Console.WriteLine("Flights since maintence: " + airForce1.tripsSinceMaintenance);
            Console.WriteLine("Does Air Force 1 can flight: " + airForce1.Flying());
            airForce1.Repair();
            Console.WriteLine("Does Air Force 1 can flight: " + airForce1.Flying());
        }
    }
}
