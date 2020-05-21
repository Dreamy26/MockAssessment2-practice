using System;
using System.Collections.Generic;

namespace MockAssess2
{
    public class Challenge
    {
        //Access Modifier | Static or Not | Return Type | Method Identifier |Paramemters (Data Type | Identifier(name))  <<anatamoy of a method
        public static int AddStarWarsCharacter(string[] starWarsCharacters)
        {
            int index = -1;
            // FOr (starting Point | Stopping Point | How you get there!
            // Also a condition
            for (int i = 0; i < starWarsCharacters.Length; i++)
            {
                if (starWarsCharacters[i] == "Yoda")
                {
                    index = 1;
                }
            } return index;
        }

        public static List<string> ConvertPlanets(string[] planets)
        {
            List<string> reversePlanets = new List<string>();

            for (int i = planets.Length - 1; i >= 0;  i-- )
            {
                reversePlanets.Add(planets[i]);
            }

            return reversePlanets;
        }
    }
}
