using System.Reflection.Metadata;
using System;
using System.Collections.Generic;

namespace NovemberProjekt
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Vad heter du?");

            string n = Console.ReadLine();

            Court newCourt = new Court(n);


            Console.ReadLine();
        }
    }
}
