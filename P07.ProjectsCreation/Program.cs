using System;
using System.Security.Cryptography.X509Certificates;

namespace P07.ProjectsCreation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int projectNumber = int.Parse(Console.ReadLine());
            int hours = projectNumber * 3;
            Console.WriteLine($"The architect {name} will need {hours} hours to complete {projectNumber} project/s.");

        }
    }
}
