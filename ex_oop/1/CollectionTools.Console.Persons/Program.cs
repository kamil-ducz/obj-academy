using CollectionTools.Console.Persons.Models;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

const string NAME_REGEX = "^[A-Z]{1}[A-Za-z]{1,}$";
const string AGE_REGEX = "^[0-9]{2}$";

Console.WriteLine("How many persons would you like to input?");
var peopleCount = Convert.ToInt32(Console.ReadLine());

List<Person> people = new List<Person>();

for(int i = 0; i < peopleCount; i++)
{
    Console.WriteLine("Enter name: ");
    var name = Console.ReadLine();
    if (name == null || !Regex.IsMatch(name, NAME_REGEX))
    {
        Console.WriteLine("Incorrect name format. Enter person details again.");
        i--;
        continue;
    }

    Console.WriteLine("Enter age: ");
    var age = Console.ReadLine();
    if (age == null || !int.TryParse(age, out int result) || !Regex.IsMatch(age, AGE_REGEX))
    {
        Console.WriteLine("Incorrect age format. Enter person details again.");
        i--;
        continue;
    }

    people.Add(new Person(name, Convert.ToInt32(age)));
}

Console.WriteLine("\nPeople stored on the list are: \n");

for (int i = 0; i < people.Count; i++)
{
    Console.Write((i+1) + ". ");
    Console.WriteLine("Name: " + people[i].Name + ", age: " + people[i].Age);
}