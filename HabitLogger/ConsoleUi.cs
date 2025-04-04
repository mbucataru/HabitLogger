namespace HabitLogger;

public static class ConsoleUi
{
    public static void Start()
    {
        bool keepRunning = true;
        while (keepRunning)
        {
            PrintMenu();
            string? userInput = Console.ReadLine();

            switch (userInput)
            {
                case "0":
                    Close();
                    keepRunning = false;
                    break;
                case "1":
                    View();
                    break;
                case "2":
                    Insert();
                    break;
                case "3":
                    Delete();
                    break;
                case "4":
                    Update();
                    break;
               default:
                   Console.WriteLine("---Invalid Input. Try again.---\n");
                   continue;
            }
        }
    }

    private static void PrintMenu()
    {
        Console.WriteLine("MAIN MENU\n");
        Console.WriteLine("What would you like to do?\n");
        Console.WriteLine("Type 0 to Close Application.");
        Console.WriteLine("Type 1 to View All Records.");
        Console.WriteLine("Type 2 to Insert Record.");
        Console.WriteLine("Type 3 to Delete Record.");
        Console.WriteLine("Type 4 to Update Record.");
        Console.WriteLine("------------------------------------");
    }
    
    
    /*
     * NOTE: There is a very real chance that literally all of these functions are useless and will just be
     * 1-2 line calls to DatabaseManager. If that is the case, probably remove them.
     * Additionally, Close() may literally be no longer other than a print statement, since DatabaseManager
     * is a static class.
     */
    private static void Close()
    {
        
    }

    private static void View()
    {
        
    }

    private static void Insert()
    {
        
    }

    private static void Delete()
    {
        
    }

    private static void Update()
    {
        
    }
}