using System;
using System.Collections.Generic;

namespace LunchBuddies
{
    class Program
    {
        static void Main(string[] args)
        {
            LunchBuddy lunchBuddy = new LunchBuddy("Frank", "Sinatra");
            LunchBuddy lunchBuddy2 = new LunchBuddy("Dolly", "Parton");
            LunchBuddy lunchBuddy3 = new LunchBuddy("John", "Mayer");
            LunchBuddy lunchBuddy4 = new LunchBuddy("Kendrick", "Lamar");
            List<LunchBuddy> companions = new List<LunchBuddy>();
            companions.Add(lunchBuddy2);
            companions.Add(lunchBuddy3);
            companions.Add(lunchBuddy4);

            lunchBuddy.eat();
            lunchBuddy.eat("Cocoa Crispies");
            lunchBuddy.eat(companions);
            lunchBuddy.eat("Cocoa Crispies", companions);
        }
    }
}
