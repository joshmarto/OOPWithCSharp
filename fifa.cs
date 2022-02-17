using System;
using System.IO;

namespace Files
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\temp\data.csv";
            //Read in the data from the dataset
            string content = File.ReadAllText(path);
            //Convert all the commas to tabs
            string newContent = content.Replace(",", "    ");
            //Create a new file called fifa-tab.tsv
            path = path.Replace("data.csv", "fifa-tab.tsv");
            if (File.Exists(path))
            {
                File.Delete(path);
            }
            else
            {
                //Write the modified data to that new file.
                File.WriteAllText(path, newContent);
            }
            Console.WriteLine(File.ReadAllText(path));
        }
    }
}
