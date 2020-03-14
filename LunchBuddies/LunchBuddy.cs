using System;
using System.Collections.Generic;
using System.Text;

namespace LunchBuddies
{
    class LunchBuddy
    {
        public string FirstName { get; set; } = "";
        public string LastName { get; set; } = "";
        public LunchBuddy(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public Restaurant eat()
        {
            Restaurant restaurant = new Restaurant();
            Console.WriteLine($"{FirstName} {LastName} is at {restaurant.Name}.");
            return restaurant;
        }

        public void eat(string food)
        {
            var specificFood = food;
            Console.WriteLine($"{FirstName} {LastName} ate {specificFood} at the office.");
        }

        public void eat(List<LunchBuddy> companions)
        {
            Restaurant restaurant = new Restaurant();
            var allBuddies = companions;
            string buddyString = "";
            for (var i = 0; i < allBuddies.Count; i++)
            {
                if (i == allBuddies.Count - 2)
                {
                    string value = allBuddies[i].FirstName + ", and ";
                    buddyString += value;
                }
                else
                {
                    string value = allBuddies[i].FirstName + ", ";
                    buddyString += value;
                }
            }
            char[] charToTrim = { ',', ' ' };
            Console.WriteLine($"{FirstName} {LastName} is at {restaurant.Name} with {buddyString.TrimEnd(charToTrim)}.");
        }

        public void eat(string food, List<LunchBuddy> companions)
        {
            Restaurant restaurant = new Restaurant();
            var specificFood = food;
            var allBuddies = companions;
            string buddyString = "";
            for (var i = 0; i < allBuddies.Count; i++)
            {
                if (i == allBuddies.Count - 2)
                {
                    string value = allBuddies[i].FirstName + ", and ";
                    buddyString += value;
                }
                else
                {
                    string value = allBuddies[i].FirstName + ", ";
                    buddyString += value;
                }
            }
            char[] charToTrim = { ',', ' ' };
            Console.WriteLine($"{FirstName} {LastName} ordered the {specificFood} at {restaurant.Name} while they were chilling with {buddyString.TrimEnd(charToTrim)}.");
        }
    }
}
