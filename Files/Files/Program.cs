using System;
using System.IO;

namespace Files
{
    class Program
    {
        static void check(string step)
        {
            Console.WriteLine(step, "works!");
        }
        static void Main(string[] args)
        {
            string path = @"C:\Users\User\Documents\Pirple\Files\data.csv";
            //Read in the data from the dataset
            string content = File.ReadAllText(path);
            check("Read");
            //Convert all the commas to tabs
            string newContent = content.Replace(",", "    ");
            check("Convert");
            //Create a new file called fifa-tab.tsv
            path = path.Replace("data.csv", "fifa-tab.tsv");
            if (File.Exists(path))
            {
                File.Delete(path);
                check("Delete existing file");
            }
            else
            {
                //Write the modified data to that new file.
                File.WriteAllText(path, newContent);
                check("Create new file");
            }
            Console.WriteLine(File.ReadAllText(path));
        }
    }
}
