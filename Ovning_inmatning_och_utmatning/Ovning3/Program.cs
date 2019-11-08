using System;

namespace Ovning3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Person 1, Vänligen skriv ditt förnamn: ");
            string firstNamePersOne = Console.ReadLine();
            Console.Write("Person 1, Vänligen skriv ditt efternamn: ");
            string lastNamePersOne = Console.ReadLine();
            Console.Write("Person 2, Vänligen skriv ditt förnamn: ");
            string firstNamePersTwo = Console.ReadLine();
            Console.Write("Person 2, Vänligen skriv ditt efternamn: ");
            string lastNamePersTwo = Console.ReadLine();
            Console.WriteLine("Det var en gång en programmerare som önskade inget annat än att lära sig koda i C#.");
            Console.Write("Han hette ");
            Console.Write(firstNamePersOne + " " + lastNamePersOne);
            Console.Write(" och vilken tur att han mötte ");
            Console.Write(firstNamePersTwo + " " + lastNamePersTwo);
            Console.WriteLine(" som var väldigt duktig på att programmer samt väldigt pedagogisk i sitt sätt att lära ut.");
            Console.Write("Kort därefter blev ");
            Console.Write(firstNamePersOne + " " + lastNamePersOne);
            Console.Write(" betydligt mycket bättre på att programmera och han är ");
            Console.Write(firstNamePersTwo + " " + lastNamePersTwo);
            Console.WriteLine(" evigt tacksam!");
        }
    }
}
