using System;
using System.Diagnostics.CodeAnalysis;

namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double length = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine());
            percent = percent / 100;

            double capacity = length * width * height;
            double capacityLiters = capacity * 0.001;
            double final = capacityLiters * (1 - percent);
            Console.WriteLine(final);
        }
    }
}
