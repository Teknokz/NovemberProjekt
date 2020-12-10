using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;
using Microsoft.Win32.SafeHandles;
using System.Collections.Generic;
using System;

namespace NovemberProjekt
{
    public class Court
    {
        public static Random generator = new Random();

        public string name;

        public int crimeCount;

        public string activeCrime;

        


        public Court(string n, List<string> crimes)
        {
        
            name = n;

            crimeCount = generator.Next(crimes.Count);

            string activeCrime = crimes[crimeCount];

            System.Console.WriteLine(activeCrime);

            


        }
        public void Present(string n, string activeCrime)
        {

            System.Console.WriteLine("Välkommen till domstolen åklagare " + n);

        }

    }

}
