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
            bool state1 = true;
            bool state2 = false;

            if (state1 || state2)
            {
                if (state1 && state2)
                {
                    Console.WriteLine("Both statements are true");
                }
                else if(state1)
                {
                    Console.WriteLine("Statement 1 is true");
                }
                else
                {
                    Console.WriteLine("Statement 2 is false");
                }
            }

        }
    }
}
