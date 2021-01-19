using System;
using System.Collections.Generic;

namespace NovemberProjekt
{
    public class Crime
    {

     public int crimeCount;

    public string activeCrime;

    public static Random generator = new Random();


        
    private List<string> crimes = new List<string>()
    {"Incest","Mord"};

 
    public List<string> description = new List<string>()
    {"INCEST - 6 kap 7§ Den som, i annat fall än som avses förut i detta kapitel, har samlag med eget barn eller dess avkomling, döms för samlag med avkomling till fängelse i högst två år.",
     "MORD - 3 kap 1§ Den som berövar annan livet, döms för mord till fängelse på viss tid, lägst tio och högst arton år, eller på livstid. Som skäl för livstids fängelse ska det särskilt beaktas om gärningen föregåtts av noggrann planering, präglats av särskild förslagenhet, syftat till att främja eller dölja annan brottslighet, inneburit svårt lidande för offret eller annars varit särskilt hänsynslös"
    
    };

        public Crime(List<string> crimes)
        {
            crimeCount = generator.Next(crimes.Count);

            string activeCrime = crimes[crimeCount];

            System.Console.WriteLine(activeCrime);
        }

        public void Present()
        {
            System.Console.WriteLine(crimes[crimeCount]);

        }

        

    


    }



}
