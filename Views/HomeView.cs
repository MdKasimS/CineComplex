using CineComplex.models;
using CineComplex.ViewModels;
using MongoDB.Driver;


namespace CineComplex.Views
{
    public class HomeView
    {
        private int _choice = 0;
        public int Choice { get => _choice; set => _choice = value; }


        public void View()
        {


            do//main loop
            {
                Console.Clear();
                Console.WriteLine("\t----- !!! Salam Hindusthan !!! -----");
                Console.WriteLine("================================================");

                Console.WriteLine("\nLogin Screen : ");
                Console.WriteLine("\t1. Enter Login Id: ");
                Console.WriteLine("\t2. Enter Password: ");
                Console.WriteLine("\t3. Exit");
                Console.Write("Select Your Choice 1/2/3 : ");


                int.TryParse(Console.ReadLine(), out _choice);
                switch (Choice)
                {
                    case 1:
                        Console.Clear();
                        HomeVM.Instance.LoginPrompt();
                        Console.Clear();
                        break;

                    case 2:
                        Console.Clear();
                        HomeVM.Instance.PasswordPrompt();
                        Console.Clear();
                        break;

                    case 3:
                        Console.Write("\nPress any key.....");
                        Console.ReadKey();
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Please enter the valid Choice .....");
                        break;
                }
            } while (Choice > 0 || Choice < 4);
        }

    }
}
