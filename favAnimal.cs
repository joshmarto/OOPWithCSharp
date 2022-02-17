using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace animal
{
    public class Animal
    {
        public static void Main(string[] args)
        {
            /* FAVORITE ANIMAL */
            //Set up characteristics for favorite animal
            //String and char attributes
            string animal = "Dog";
            string family = "Canidae";
            string type = "Labrador";
            string origin = "Canada";

            //Numeric attributes
            int legs = 4;
            int largeCm = 56;
            int widthCm = 13;
            int heightCm = 30;
            double weightKg = 34.5;
            int years = 11;

            //Bool attributes
            bool vertebrate = true;
            bool domestic = true;

            //Array Attributes
            string clasification = new string[2];
            clasification[0] = "Major terranova";
            clasification[1] = "Minor terranova";

            //Enumeration Attributes
            enum functions
            {
                Sheeper,
                Protector,
                Friend,
                Explorer,
                Rescue
            }
            functions func = new functions();
            func = functions.Friend;
            enum colors
            {
                Black,
                Sand,
                Chocolate
            }
            colors color = new colors();
            color = colors.Sand;

            //Display of all the attributes
            Console.WriteLine("Animal:     " + animal);
            Console.WriteLine("Family:     " + family);
            Console.WriteLine("Type:       " + type);
            Console.WriteLine("Origin:     " + origin);
            Console.WriteLine("# Legs:     " + legs);
            Console.WriteLine("Large(cm):  " + largeCm);
            Console.WriteLine("Width(cm):  " + widthCm);
            Console.WriteLine("Height(cm): " + heightCm);
            Console.WriteLine("Weight(kg): " + weightKg);
            Console.WriteLine("Avg years:  " + years);
            Console.WriteLine("Vertebrate: " + vertebrate);
            Console.WriteLine("Domestic:   " + domestic);
            Console.WriteLine("Function:   " + func);
            Console.WriteLine("Color:      " + color);
        }
    }
}
