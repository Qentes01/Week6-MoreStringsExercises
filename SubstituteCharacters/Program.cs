using System;

namespace SubstituteCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutjal sisetada eesnime ja perekonnanime
            //programm asendab kõik 'a' tähed kasutaja nimes tärniga (*)
            //programm kuvab tulemust konsoolis

            Console.WriteLine("Sisesta eesnimi:");
            string firstname = Console.ReadLine();
            Console.WriteLine("Sisestage perekonnanimi");
            string lastname = Console.ReadLine();
            string fullName = $"{firstname} {lastname}";

            fullName = fullName.Replace('a', '*');

            Console.WriteLine(fullName);

        }
    }
}
