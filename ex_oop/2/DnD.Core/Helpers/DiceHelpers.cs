using OOP.Core.Models;
using System;
using System.Collections.Generic;

namespace OOP.Core.Helpers
{
    public class DiceHelpers
    {
        public static int SelectDiceSidesCount()
        {
            Console.WriteLine("How many sides should dice have? Acceptable values are 2-20 and 100: Input: ");

            while (true)
            {
                var sides = Console.ReadLine();
                if (sides == null
                    || int.TryParse(sides, out var side) == false
                    || !(Convert.ToInt32(sides) >= 2 && Convert.ToInt32(sides) <= 20 ^ Convert.ToInt32(sides) == 100))
                {
                    Console.WriteLine("Wrong input");
                    continue;
                }

                return Convert.ToInt32(sides);
            }
        }
    }
}
