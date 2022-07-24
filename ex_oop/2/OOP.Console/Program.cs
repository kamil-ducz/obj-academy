using OOP.Core.Models;

Console.WriteLine("How many sides should dice have? Acceptable values are 2-20 and 100: Input: ");
int result;

while(true)
{
    var sides = Console.ReadLine();
    if(sides == null 
        || int.TryParse(sides, out var side) == false 
        || !(Convert.ToInt32(sides) >= 2 && Convert.ToInt32(sides) <= 20 ^ Convert.ToInt32(sides) == 100))
    {
        Console.WriteLine("Wrong input");
        continue;
    }

    result = Convert.ToInt32(sides);
    break;
}

RollingDice dice = new RollingDice(result);
RollingDice diceDefault = new RollingDice();

Console.WriteLine($"Dice with { dice.GetSidesCount() } sides successfully created.");
Console.WriteLine($"Default dice with { diceDefault.GetSidesCount() } sides successfully created.");

Console.WriteLine(dice.ShowRollResult());
Console.WriteLine(diceDefault.ShowRollResult());