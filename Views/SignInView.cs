using CineComplex.Classes.Base;
using CineComplex.Interfaces;
using CineComplex.Models;
using CineComplex.ViewModels;

namespace CineComplex.Views
{
    public class SignInView : AViewBase<SignInView>, IView
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
            SignInView.Instance.LoadMenuList();

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

                foreach (string instr in SignInView.Instance.MenuList)
                {
                    Console.WriteLine(instr);
                }

                Console.Write("Enter Your Choice : ");


                int.TryParse(Console.ReadLine(), out _choice);
                switch (Choice)
                {
                    case 1:
                        SignInViewModel.Instance.GetSignInId();
                        Console.Clear();
                        break;

                    case 2:
                        SignInViewModel.Instance.GetSignIPassword();
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
                        SignInViewModel.Instance.ForgotPassword();
                        Console.Clear();
                        break;

                    case 5:
                        Console.Write("\nPress any key.....");
                        Console.ReadKey();
                        break;

                    default:
                        Console.WriteLine("Please enter the valid Choice .....");
                        break;
                }
            } while (Choice!=5);
        }

        public void LoadMenuList()
        {
            SignInView.Instance.MenuList = new List<string>() {
                "1. Enter Login Id ",
                "2. Enter Password ",
                "3. Login ",
                "4. Sign Up ",
                "5. Forgot Password ",
                "6. Exit",
            };
        }

    }
}
