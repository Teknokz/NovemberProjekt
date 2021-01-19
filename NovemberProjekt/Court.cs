using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;
using Microsoft.Win32.SafeHandles;
using System.Collections.Generic;
using System;

namespace NovemberProjekt
{
    public class Court
    {
        public string name;

        //Crime newcrime = new Crime();
        
        public Court(string n)
        {
            
            name = n;
            
            System.Console.WriteLine("Välkommen Åklagare " + n);



            


        }

    }

}
