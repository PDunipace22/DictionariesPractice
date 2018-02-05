using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionariesPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //Syntax - Dictionary<key data type, value data type> dictionaryName
            Dictionary<string, int> studentGrades = new Dictionary<string, int>()
            {
                {"Kerry",90}, //"Kerry" is the key, 90 is the value
                {"Barry",85},
                {"Michelle",100}
            };

            Dictionary<string, string> snackMachine = new Dictionary<string, string>()
            {
                {"A1","Snickers"},
                {"A2","Swedish Fish"},
                {"A3","Sour Patch Kids"},
                {"A4", "Funyuns"}
            };

            Dictionary<int,string> drinkMachine = new Dictionary<int, string>();
            //Using the Add method, let's add drinks to our drink machine
            //This machine uses just a number to vend an item instead of
            //a letter-number pair.

            drinkMachine.Add(10, "Ginger Ale");
            drinkMachine.Add(11, "Orange Juice");
            drinkMachine.Add(12, "Bottled Water");
            drinkMachine.Add(13, "Diet Pepsi");
            drinkMachine.Add(14, "Mountain Dew");
            drinkMachine.Add(15, "Sprite");


            //Count is a property, returns the size of the dictionary
            Console.WriteLine(drinkMachine.Count);

            //We have another property, called .Key
            foreach(KeyValuePair<int,string> drink in drinkMachine)
            {
                Console.WriteLine(drink.Key);
            }

            foreach (KeyValuePair<int, string> drink in drinkMachine)
            {
                Console.WriteLine(drink.Value);
            }

            //Create a dictionary for a theater coat check with 10 elements.
            //The key will be a number and the value will be the coat style.
            //Print all values to the console.

            Dictionary<int, string> coatCheck = new Dictionary<int, string>()
            {
                {1,"Black Leather Jacket"},
                {2,"Orange Winter Coat"},
                {3,"Blue Sport Coat"},
                {4,"Black Sport Coat"},
                {5,"Black Sport Coat"},
                {6,"Yellow Winter Coat"},
                {7,"Blue Sport Coat"},
                {8,"Black Suit Coat"},
                {9,"Black Leather Jacket"},
                {10,"Blue Sport Coat"}
            };
            
            foreach(KeyValuePair<int,string> coat in coatCheck)
            {
                Console.WriteLine(coat.Value);
            }

            //Create a dictionary for a car valet service with 10 cars.
            //The key will be the customer's last name and the value.
            //will be the car make. Print all keys to the console.

            Dictionary<string, string> carService = new Dictionary<string, string>()
            {
                {"Johnson","Honda"},
                {"Lewis","Ford"},
                {"Allen","Aston Martin"},
                {"Alonso","Porshe"},
                {"Smith","Subaru"},
                {"Santana","Toyota"},
                {"Jones","Fiat"},
                {"Robinson","Ford"},
                {"Bennett","Subaru"},
                {"Alomar","Subaru"}
            };

            foreach(KeyValuePair<string,string> lastName in carService)
            {
                Console.WriteLine(lastName.Key);
            }

            //Create a dictionary of 10 zoo animals. The key will be 
            //the animal type and the value will be the number of that
            //animal type at the zoo. Print the animal with the highest 
            //quantity to the console.

            Dictionary<string, int> zooAnimals = new Dictionary<string, int>()
            {
                {"Giraffe",10},
                {"Gorilla",13},
                {"Chimpanzee",10},
                {"Otter",23},
                {"Lion",4},
                {"Tiger",5},
                {"Black Bear",12},
                {"Emu",13},
                {"Bunny",11},
                {"Armadillo",2}
            };

            int highest = 0;
            foreach(KeyValuePair<string, int> animal in zooAnimals)
            {
                if(animal.Value > highest)
                {
                    highest = animal.Value;
                }
            }

            foreach (KeyValuePair<string, int> animal in zooAnimals)
            {
                if (animal.Value == highest)
                {
                    Console.WriteLine(animal.Key);
                }
            }
        }
    }
}
