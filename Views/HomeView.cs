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

                Console.WriteLine("\nLogin Window : ");
                Console.WriteLine("-------------------------------------------------");

                Console.WriteLine($"Entered Login Id : {Credential.Instance.LoginId}");
                Console.WriteLine($"Entered Password : {Credential.Instance.Password}");

                Console.WriteLine();

                Console.WriteLine("\nMenu : ");
                Console.WriteLine("---------------");

                Console.WriteLine("1. Enter Login Id: ");
                Console.WriteLine("2. Enter Password: ");
                Console.WriteLine("3. Exit");
                
                Console.Write("Enter Your Choice : ");


                int.TryParse(Console.ReadLine(), out _choice);
                switch (Choice)
                {
                    case 1:

                        HomeVM.Instance.LoginPrompt();
                        Console.Clear();
                        break;

                    case 2:

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
