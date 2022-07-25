using OOP.Core.Models;
using System;
using System.Collections.Generic;

namespace OOP.Core.Helpers
{
    public class DiceHelpers
    {
        //public static List<RollingDice> ReturnRollingDicesCollection()
        //{
        //    List<RollingDice> availableDices = new List<RollingDice>();


        //    availableDices.Add(new RollingDice(2));
        //    availableDices.Add(new RollingDice(3));
        //    availableDices.Add(new RollingDice(4));
        //    availableDices.Add(new RollingDice(6));
        //    availableDices.Add(new RollingDice(8));
        //    availableDices.Add(new RollingDice(10));
        //    availableDices.Add(new RollingDice(12));
        //    availableDices.Add(new RollingDice(100));


        //    return availableDices;
        //}

        //public Dictionary<string, RollingDice> availableDicesByNames = new Dictionary<string, RollingDice>();
        

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
