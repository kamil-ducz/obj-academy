using PseudoNotepad.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;

List<Note> database = new List<Note>();

while (true)
{
    Console.Clear();
    Console.WriteLine("What would you like to do?");
    Console.WriteLine("1. Show all titles from the list");
    Console.WriteLine("2. Open a note from the list");
    Console.WriteLine("3. Add a note to the list");
    Console.WriteLine("4. Remove a note from the list");
    Console.WriteLine("5. Search for a note on the list");
    Console.WriteLine("6. Close the application");

    var userInput = Console.ReadLine();
    if (userInput == null
        || !int.TryParse(userInput, out int id)
        || (Convert.ToInt32(userInput) < 1
        || Convert.ToInt32(userInput) > 6))
    {
        Console.WriteLine("Wrong input. Try again.");
        Console.ReadKey();
        continue;
    }

    switch (Convert.ToInt32(userInput))
    {
        case 1:
            {
                if (database.Count == 0)
                {
                    Console.WriteLine("There are no notes, yet");
                    Console.ReadKey();
                    break;
                }

                foreach (var note in database)
                {
                    Console.WriteLine(note.Title);
                }

                Console.ReadKey();

                break;
            }

        case 2:
            {
                while (true)
                {
                    if (database.Count == 0)
                    {
                        Console.WriteLine("There are no notes, yet");
                        Console.ReadKey();
                        break;
                    }

                    Console.WriteLine("Enter a title to open a note or q to exit this option: ");
                    var titleToOpen = Console.ReadLine();
                    if (!database.Any(n => n.Title == titleToOpen))
                    {
                        if (titleToOpen == "q")
                        {
                            break;
                        }

                        Console.WriteLine($"Note with title { titleToOpen } doesn't exist. Try again or press q.");
                        continue;
                    }


                    Console.WriteLine(database.Find(n => n.Title == titleToOpen).Content);

                    Console.ReadKey();

                    continue;
                }

                continue;
            }

        case 3:
            {
                Console.WriteLine("Please type in a title: ");
                var titleToInsert = Console.ReadLine();
                var createdAt = DateTime.Now;
                Console.WriteLine("Please write your note and hit ENTER to add it: ");
                var contentToInsert = Console.ReadLine();

                if (titleToInsert is not null && contentToInsert is not null && titleToInsert.Length > 0)
                {
                    database.Add(new Note(titleToInsert, contentToInsert, createdAt));
                }

                continue;
            }

        case 4:
            {
                if (database.Count == 0)
                {
                    Console.WriteLine("There are no notes, yet");
                    Console.ReadKey();
                    break;
                }

                Console.WriteLine("Please type in note title to remove a note: ");
                var titleToDelete = Console.ReadLine();

                if (titleToDelete is not null)
                {
                    if (!database.Any(n => n.Title == titleToDelete))
                    {
                        Console.WriteLine($"Note with title { titleToDelete } doesn't exist.");
                        Console.ReadKey();

                        continue;
                    }

                    var noteToRemove = database.Find(n => n.Title == titleToDelete);
                    database.Remove(noteToRemove);
                    Console.WriteLine($"Note with title { titleToDelete } removed.");
                    Console.ReadKey();

                    continue;
                }


                continue;
            }

        case 5:
            {
                if (database.Count == 0)
                {
                    Console.WriteLine("There are no notes, yet");
                    Console.ReadKey();
                    break;
                }

                Console.WriteLine("Please type in a note title to search: ");
                var titleToSearch = Console.ReadLine();
                if (titleToSearch is not null
                    && database.Any(n => n.Title == titleToSearch))
                {
                    var foundNote = database.Find(n => n.Title == titleToSearch);

                    Console.WriteLine("Found: " + foundNote.Title);
                    Console.ReadKey();
                }

                Console.WriteLine($"Not found anything with title {titleToSearch }");

                Console.ReadKey();

                continue;
            }

        case 6:
            {
                Console.WriteLine("Thank you for using the app. See you :)");
                Environment.Exit(0);
                break;
            }

        default: continue;
    }
}


