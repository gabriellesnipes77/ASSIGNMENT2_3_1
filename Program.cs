using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ASSIGNMENT2_3_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"C:\Users\BIGDON\source\repos";

            List<string> lines = File.ReadAllLines(filePath).ToList();  

            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }
            File.WriteAllLines(filePath, lines);

            Console.ReadLine();


        }
    }
}
