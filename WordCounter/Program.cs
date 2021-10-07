using System;

namespace WordCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm kuvab, mitu sõna on lauses "Hello World!"

            string helloW = "Hello World!";

            //while


            /* int i = 0;
           int WordCounter = 1;

           while(i < helloW.Length)
           {
               if(helloW[i] == ' ')
               {
                   WordCounter++;
               }

               i++;
           }
           Console.WriteLine($"Lauses {helloW} on {WordCounter} sõna");
           */

            //for loops

            int WordCounter = 1;
            for(int i = 0; i < helloW.Length; i++)
            {
                if(helloW[i] == ' ')
                {
                    WordCounter++;
                }
            }
            Console.WriteLine($"Lauses {helloW} on {WordCounter} sõna");


        }
    }
}
