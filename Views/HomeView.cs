using CineComplex.Classes.Base;
using CineComplex.Interfaces;
using CineComplex.Models;
using CineComplex.ViewModels;
using MongoDB.Driver;


namespace CineComplex.Views
{
    public class HomeView : AViewBase<HomeView>
    {
        private int _choice = 0;
        public int Choice { get => _choice; set => _choice = value; }


        public override void View()
        {


            do//main loop
            {
                Console.Clear();
                Console.WriteLine("\t----- !!! Salam Hindusthan !!! -----");
                Console.WriteLine("================================================");

                Console.WriteLine("\nLogin");
                Console.WriteLine("-------------------------------------------------");

                Console.WriteLine($"Entered Login Id : {Credential.Instance.LoginId}");
                Console.WriteLine($"Entered Password : {Credential.Instance.Password}");

                Console.WriteLine();

                Console.WriteLine("\nMenu : ");
                Console.WriteLine("---------------");

                Console.WriteLine("1. Enter Login Id ");
                Console.WriteLine("2. Enter Password ");
                Console.WriteLine("3. Login ");
                Console.WriteLine("4. Forgot Password ");
                Console.WriteLine("5. Exit");
                
                Console.Write("Enter Your Choice : ");


                int.TryParse(Console.ReadLine(), out _choice);
                switch (Choice)
                {
                    case 1:
                        HomeViewModel.Instance.LoginPrompt();
                        Console.Clear();
                        break;

                    case 2:
                        HomeViewModel.Instance.PasswordPrompt();
                        Console.Clear();
                        break;

                    case 3:
                        if(Services.AuthenticationService.AuthenticateUserForGivenCredential())
                        {
                            ManageTicketView.Instance.View();
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Authentication Failed... Press Any Key To Continue.");
                            Console.ReadLine();
                        }
                        break;

                    case 5:
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
