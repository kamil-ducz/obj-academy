using System;
using System.Collections.Generic;

List<double> wholeList = new List<double>();
List<double> doublesFromWholeList = new List<double>();

Console.WriteLine("Keep entering numbers and after each value hit ENTER.");
Console.WriteLine("Only integer or comma-separated input acceptable.");
Console.WriteLine("Enter value q to finish the program now or after inputs for results.");

string? input = Console.ReadLine();
if (input == "q")
{
    Environment.Exit(0);
}
if (!double.TryParse(input, out double result))
{
    Environment.Exit(0);
}

wholeList.Add(Convert.ToDouble(input));
double wholeListSum = Convert.ToDouble(input);

while (input is not null)
{
    input = Console.ReadLine();
    if (input == "q")
    {
        break;
    }

    if (!double.TryParse(input, out double result2))
    {
        break;
    }

    wholeList.Add(Convert.ToDouble(input));

    if (input.Split(',').Length == 2)
    {
        doublesFromWholeList.Add(Convert.ToDouble(input));
    }

    wholeListSum += (Convert.ToDouble(input));
};

Console.WriteLine("\nBelow are results:");
Console.WriteLine("Values separated by comma: ");
for (int i = 0; i < doublesFromWholeList.Count; i++)
{
    Console.WriteLine(doublesFromWholeList[i]);
}
Console.WriteLine("Average value of all elements: " + wholeListSum / wholeList.Count);
Console.WriteLine("First value entered by user: " + wholeList[0]);

