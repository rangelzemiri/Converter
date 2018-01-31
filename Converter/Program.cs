using System;

namespace Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Converter App");
            Console.WriteLine("Description: Will convert yards to inches");

            int numYards = int.Parse(Console.ReadLine());

            int numInches = numYards * 36;

            Console.WriteLine("Number of Inches in " + numYards + " yards is " + numInches + "inches");

            Console.ReadLine();

        }

    }
}
