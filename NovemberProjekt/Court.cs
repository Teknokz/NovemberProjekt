using Microsoft.Win32.SafeHandles;
using System.Collections.Generic;
using System;

namespace NovemberProjekt
{
    public class Court
    {
        public static Random generator = new Random();

        public string name;

        public string activeCrime;


        public Court(string n)
        {
            activeCrime = generator.Next(crimes.Count);
        }
    }

}
