using System;

namespace Ovning2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mata in ditt förnamn: ");
            string readName = Console.ReadLine();
            Console.WriteLine("Mata in ditt efternamn: ");
            string readLastName = Console.ReadLine();
            Console.Write("Välkommen: ");
            Console.Write(readName);
            Console.Write(" ");
            Console.Write(readLastName);
            Console.ReadLine();
        }
    }
}
