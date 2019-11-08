using System;

namespace Ovning1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mata in ditt namn: ");
            string readText = Console.ReadLine();
            Console.Write("Välkommen: ");
            Console.Write(readText);
            Console.ReadLine();
        }
    }
}
