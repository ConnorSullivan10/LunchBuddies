using System;
using System.Collections.Generic;
using System.Text;

namespace LunchBuddies
{
    class Restaurant
    {
        public string Name { get; set; } = "";
        private List<string> Restaurants { get; } = new List<string>();

        public Restaurant(List<string> Restaurants)
        {
            var random = new Random();
            int index = random.Next(Restaurants.Count);
            string randString = Restaurants[index];
            Name = randString;
        }

        public void eat()
        {

        }
    }
}
