using System;
using System.Diagnostics.CodeAnalysis;

namespace P08.PetShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numDogFood = int.Parse(Console.ReadLine());
            int numCatFood = int.Parse(Console.ReadLine());
            double priceDog = numDogFood * 2.50;
            double priceCat = numCatFood * 4;
            double sum = priceDog + priceCat;
            Console.WriteLine($"{sum} lv.");

        }
    }
}
