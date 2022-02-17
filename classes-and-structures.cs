using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Classes
{
    // What is the difference between classes and structure?
    /* The main difference between them is the support of inheritance and polimorphism which have classes
       that structures do not. Classes are reference type and structures are value type.*/
    public abstract class elementA
    {
        public int id_;
        public string name_;
        public int count;

        public abstract void print();
    }

    public class Agent : elementA
    {
        public Agent(int id, string name)
        {
            id_ = id;
            name_ = name;
            count++;
        }

        public override void print()
        {
            Console.WriteLine("Name: " + name_ + " & Id: " + id_);
        }
    }

    // When would you want to use one versus the other?
    /* If there is no need of inheritance or polimorphism is better to use structures since they are simpler
       and use classes if needs to be used inheritance and plimorphism*/
    public struct structureA
    {
        public int id_;
        public string name_;

        public structureA(int id, string name)
        {
            id_ = id;
            name_ = name;
        }

        public string introduce()
        {
            return "The name is " + name_;
        }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            Agent Mark = new Agent(1, "Mark");
            structureA structA = new structureA(1, "Element 1");
            Mark.print();
            Console.WriteLine(structA.introduce());
        }
    }
}
