using CineComplex.Classes.Base;
using CineComplex.Interfaces;
using CineComplex.Models;
using CineComplex.ViewModels;

namespace CineComplex.Views
{
    public class HomeView : AViewBase<HomeView>, IView
    {
        private int _choice = 0;

        public int Choice { get => _choice; set => _choice = value; }
       
        public List<string> MenuList
        {
            get;
            set;
        }
        public void View()
        {
            HomeView.Instance.LoadMenuList();

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

                foreach (string instr in HomeView.Instance.MenuList)
                {
                    Console.WriteLine(instr);
                }

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
                        if (Services.AuthenticationService.AuthenticateUserForGivenCredential())
                        {
                            ManageTicketsView.Instance.View();
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Authentication Failed... Press Any Key To Continue.");
                            Console.ReadLine();
                        }
                        break;

                    case 4:
                        HomeViewModel.Instance.ForgotPasswordPrompt();
                        Console.Clear();
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

        public void LoadMenuList()
        {
            HomeView.Instance.MenuList = new List<string>() {
                "1. Enter Login Id ",
                "2. Enter Password ",
                "3. Login ",
                "4. Forgot Password ",
                "5. Exit",
            };
        }

    }
}
