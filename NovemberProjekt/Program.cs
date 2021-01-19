using System.Reflection.Metadata;
using System;
using System.Collections.Generic;

namespace NovemberProjekt
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int userguess = 0;

            System.Console.WriteLine("Vad heter du?");

            string n = Console.ReadLine();

            

            Court newCourt = new Court(n);

            System.Console.WriteLine("Hur vill du gå tillväga?");
            System.Console.WriteLine("1) Lägga till fler brott i brottslagret");
            System.Console.WriteLine("2) Åklaga för följande brott");

            string input = Console.ReadLine();
            
            bool success = int.TryParse(input, out userguess);

            if(userguess == 1)
            {
                System.Console.WriteLine("1");
            }
            else if(userguess == 2)
            {
                System.Console.WriteLine("2");

                 //Crime newCrime = new Crime();

                 Crime.Present();

            }
            

            



            Console.ReadLine();
        }
    }
}
