using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Rextester
{
    public class Program
    {
        public static void Main(string[] args)
        {
            for (int x = 1; x <= 100; x++)
            {
                int divisors = 0;
                for (int i = 1; i <= x; i++)
                {
                    if (divisors > 2)
                    {
                        break;
                    }
                    else if (x % i == 0)
                    {
                        divisors++;
                    }
                }
                if (divisors == 2)
                {
                    Console.Write("Prime ");
                }
                if (x % 3 == 0 & x % 5 == 0)
                {
                    Console.WriteLine("Fizz buzz");
                }
                else if (x % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (x % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(x);
                }
            }
        }
    }
}
