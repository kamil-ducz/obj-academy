using PseudoNotepad.Core.Models;

while (true)
{
    Console.Clear();
    Console.WriteLine("What would you like to do?");
    Console.WriteLine("1. Show all notes titles from the list");
    Console.WriteLine("2. Open a note from the list");
    Console.WriteLine("3. Add a note to the list");
    Console.WriteLine("4. Remove a note from the list");
    Console.WriteLine("5. Search for a note on the list");
    Console.WriteLine("6. Close the application");

    var userInput = Console.ReadLine();
    if (userInput == null 
        || !int.TryParse(userInput, out int id) 
        || (Convert.ToInt32(userInput) < 1 
        || Convert.ToInt32(userInput) > 5))
    {
        Console.WriteLine("Wrong input. Try again.");
        Console.ReadKey();
        continue;
    }

    List<Database> notes = new List<Database>();

    switch(Convert.ToInt32(userInput))
    {
        case 1:
            {

                break;
            }

        case 2:
            {

                break;
            }

        case 3:
            {
                break;
            }

        case 4:
            {

                break;
            }

        case 5:
            {
                Console.WriteLine("Thank you for using the app. See you :)");
                Environment.Exit(0);
                break;
            }
        
        default: continue;
    }
}


