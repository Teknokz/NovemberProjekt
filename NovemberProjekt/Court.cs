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

        Crime newcrime = new Crime();

        public void GetList();
        {
            List<string> calledlist = crimes.GetList();
        }

        


        public Court(string n, List<string> crimes)
        {


        
            name = n;

            crimeCount = generator.Next(crimes.Count);

            string activeCrime = crimes[crimeCount];

            System.Console.WriteLine(activeCrime);

            


        }
        public string Present(string n, string activeCrime)
        {

            string write = System.Console.WriteLine("Välkommen till domstolen åklagare " + n);

            

        }

    }

}
