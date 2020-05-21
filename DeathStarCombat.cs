using System;
using System.Collections.Generic;
using System.Linq;

namespace MockAss2
{
    class DeathStarCombated
    {
        //public static void Main(string[] args)
        //{
        //    var combat = new Dictionary<string, int>();

        //    combat.Add("Yoda", 90);
        //    combat.Add("Darthvader", 300);
        //    combat.Add("Luke", 9000);

        //    Console.WriteLine(DeathStarCombat(combat));
        //    Console.WriteLine();

        //    //add starwars Characters
        //    var characters = new string[] { "darth vader", "jar jar", "luke skywalker", "dark maul" };
        //    Console.WriteLine($"I found yoda at index: {AddStarWarsCharacters(characters)}");
        //}

        // characters.Add
        // public static void Test()  //TEST is the METHOD
        //{ var dict = new Dictionary <int, int>() <intial dictionary
        //dictionary.Add(15,3); dictionary needs two intergers  ( 15 is the KEY)
        //dictionary.Add(15,"attack);
        //dictionary.Add(30, "deffense);
        //Console.WL(dictionar);

        public static string DeathStarCombat(Dictionary<string, int> characters)
        {
            //characters.Keys.ElementAt(i);


            //var attackOfCharacter1 = characters;
            //var attackOfCharacter2 = characters.Values.ElementAt(1);
            //var nameOfCharacter1 = characters.Values.ElementAt(0);
            //var nameOfCharacter2 = characters.Values.ElementAt(1);

            //if (attackOfCharacter1 < attackOfCharacter2)
            //{
            //    return characters(attackOfCharacter2);

            //}
            //else if (attackOfCharacter1 > attackOfcharacter2)
            //{
            //    return nameOfCharacter1;
            //}

           

            int maxPower = characters.Values.Max();
            string strongest = "";

            foreach(KeyValuePair<string, int> kvp in characters)
            {
                if(kvp.Value == maxPower)
                {
                    strongest = kvp.Key;
                }
            }

            return strongest;
       
        }


        public static int AddStarWarsCharacters(string[] characters)
        {
            for (int index = 0; index < characters.Length; index++)
            {
                if (characters[index] == "yoda")
                {
                    return index;
                }
            }
            return -1;
        }
        //                                            parameter
        public static List<string> ConvertPlanets(string[] planets)

        //                declairing        initializing
        //var planet = new string[]{ Jupiter", "Mars", Earth"}
        // ConvertPlanets(planet); call it by its name and the parameter is in the ()
        {
            //List<string> reversePlanets = new List<string>();

            var newPlanets = new List<string>(); //declaring list (empty)

            //    0      1      2
            //{jupiter, Mars, Earth}

            for (int i = planets.Length - 1; i >= 0; i--)  // the index is alway less than 1  (Minus 1)
                                                           //for lenght is adding the last planet in first to loop planet in (reverse) 
            {
                newPlanets.Add(planets[i]);
                Console.WriteLine(planets[i]);

            }
            return newPlanets;
        }
        //                              takes in a List Parameter   
        public static double AverageDroids(List<int> droids)
        {
            //how many droids(elements) are in the list =9 for below 0

            int sum = 0;
            int count = 0;
            double average = 0;


            foreach (var droid in droids)
            {
                //  if droids is divisible by 2 means its even because the ==0 is 0remainder


                if (droid % 2 == 0)
                {
                    count++;//increment by 1
                    sum += droid;// sum of droid
                }

            }

            average = sum / count;

            return average;
        }


        //create static method named TryToCatchDarthVador method will take in string as a parameter and parse string as integer.
        //return type                  perameter
        public static string TryToCatchDarthVader(string darthVader)//
        {
            try
            {
                int.Parse(darthVader); //parsing string as an INT
                return "Vader was captured!";// return "vader was captured (means return type is automatically a string
                                             // if true return "Vader was captured!"

            }
            catch (Exception ex)
            {
                return "Vader Got Away!";
                //if return is false    return "vader got away!"
            }
            //return "";// return an empty string  **do not need located in TRYPARSE
        }
    }
}