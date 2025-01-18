using System;

class VendingMachine
{
    static void Main()
    {
        while (true)
        {
            DisplayMenu();
            int selection = GetSelection();
            if (selection == 5)
            {
                VendItem(selection);
                break;
            }
            VendItem(selection);
        }
    }

    static void DisplayMenu()
    {
        Console.WriteLine("Welcome to the Free Vending Machine!");
        Console.WriteLine("1. Soda");
        Console.WriteLine("2. Chips");
        Console.WriteLine("3. Candy");
        Console.WriteLine("4. Water");
        Console.WriteLine("5. Exit");
    }

    static int GetSelection()
    {
        Console.Write("Please enter the number of your selection: ");
        int selection;
        while (!int.TryParse(Console.ReadLine(), out selection))
        {
            Console.Write("Invalid input. Please enter a number: ");
        }
        return selection;
    }

    static void VendItem(int selection)
    {
        switch (selection)
        {
            case 1:
                Console.WriteLine("Vending Soda...");
                break;
            case 2:
                Console.WriteLine("Vending Chips...");
                break;
            case 3:
                Console.WriteLine("Vending Candy...");
                break;
            case 4:
                Console.WriteLine("Vending Water...");
                break;
            case 5:
                Console.WriteLine("Thank you for using the Free Vending Machine. Goodbye!");
                break;
            default:
                Console.WriteLine("Invalid selection. Please try again.");
                break;
        }
    }
}

