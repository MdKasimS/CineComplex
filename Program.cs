using CineComplex;
using OrderBooking;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("\t----- Salam Hindusthan !!! -----");
        Console.WriteLine("================================================");

        Console.WriteLine("\nChoose User Type : ");
        Console.WriteLine("\t1. Customer");
        Console.WriteLine("\t2. Admin");
        Console.WriteLine("\t3. Exit");
        Console.Write("Press 1 or 2 : ");

        string? userTypeInput = "";
        int choice = 0;
        string? pwd = new String("");
        string? loginId = new String("");

        do
        {
            userTypeInput = Console.ReadLine();
            if (userTypeInput != null)
            {
                choice = int.Parse(userTypeInput);
            }
            switch (choice)
            {
                case 1:
                    Console.Clear();
                    Console.Write("Enter LoginID : ");
                    loginId = Console.ReadLine();
                    Console.Write("Enter Password : ");
                    pwd = Console.ReadLine();
                    
                    Console.ReadKey();
                    Console.Clear();
                    System.Environment.Exit(0);
                    break;

                case 2:
                    Console.Clear();
                    Console.Write("Enter LoginID : ");
                    System.Environment.Exit(0);
                    break;

                case 3:
                    System.Environment.Exit(0);
                    break;
                    
                default:
                    Console.WriteLine("Please enter the valid choice .....");
                    break;
            }
        } while (choice > 0 || choice < 4);
    }

}