using System;

namespace CharacterCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada eesnime ja perekonnanime
            //programm kuvab kasutaja eesnime ja perekonnanime ikkust kokku
            //Lenght omadust kasutamata

            Console.WriteLine("Sisetage eesnimi");
            string firstname = Console.ReadLine();
            Console.WriteLine("Sisestage perekonnanime");
            string lastname = Console.ReadLine();

            string fullname = $"{firstname}{lastname}";
                int charcounter = 0;
            foreach(char c in fullname)
            {
                charcounter++;
            }

            Console.WriteLine(charcounter);


        }
    }
}
