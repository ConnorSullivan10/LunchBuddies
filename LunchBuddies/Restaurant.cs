using System;
using System.Collections.Generic;
using System.Text;

namespace LunchBuddies
{
    class Restaurant
    {
        public string Name { get; set; } = "";
        private List<string> _restaurants { get; } = new List<string> { "Applebees", "Ruths Chris", "BJs Hot Chicken"};

        public Restaurant()
        {
            var random = new Random();
            int index = random.Next(_restaurants.Count);
            string randString = _restaurants[index];
            Name = randString;
        }

    }
}
