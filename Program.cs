using MongoDB.Driver;
using MongoDB.Bson;
using CineComplex.Views;
using System.Runtime.InteropServices;
using System.Xml.Serialization;
using CineComplex.Classes.Base;
using CineComplex.Interfaces;
using CineComplex.Models;
using CineComplex.Views.FormViews;
using CineComplex.Views.AdminClient;
using CineComplex.Views.UserClient;


namespace CineComplex
{


    internal class Program
    {
        [DllImport("user32.dll")]
        public static extern int DeleteMenu(IntPtr hMenu, int nPosition, int wFlags);

        [DllImport("user32.dll")]
        private static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);

        [DllImport("kernel32.dll", ExactSpelling = true)]
        private static extern IntPtr GetConsoleWindow();

        const int MF_BYCOMMAND = 0x00000000;
        const int SC_MINIMIZE = 0xF020;
        const int SC_MAXIMIZE = 0xF030;
        const int SC_SIZE = 0xF000;

        private static void Main(string[] args)
        {
            Console.WindowHeight = 25;
            Console.WindowWidth = 120;


            Console.BufferHeight = Console.WindowHeight; // Set the buffer height equal to the window height
            Console.BufferWidth = Console.WindowWidth;   // Set the buffer width equal to the window width


            DeleteMenu(GetSystemMenu(GetConsoleWindow(), false), SC_MINIMIZE, MF_BYCOMMAND);
            DeleteMenu(GetSystemMenu(GetConsoleWindow(), false), SC_MAXIMIZE, MF_BYCOMMAND);
            DeleteMenu(GetSystemMenu(GetConsoleWindow(), false), SC_SIZE, MF_BYCOMMAND);

            int choice;
            
            List<string> MenuList = new List<string>()
            {
              "1.Start View",
              "2.Home View",
              "3.Manage Ticket View",
              "4.SignUp View",
              "5.User Home View",
              "6.User Management View",
              "7.Account View",
              "8.Forgot Password View ", 
              "9.Exit",
              "10. Admin Home View"
            };

            SQLInteraction.Instance.Init();

            do
            {
                Console.Clear();
                Console.WriteLine("\t----- !!! Salam Hindusthan !!! -----");
                Console.WriteLine("================================================");

                foreach (string instr in MenuList)
                {
                    Console.WriteLine(instr);
                }

                Console.Write("Enter Your Choice : ");
                int.TryParse(Console.ReadLine(), out choice);

                IView app = StartView.Instance;

                switch (choice)
                {

                    case 1:
                        //Start View
                        app.View();
                        break;

                    case 2:
                        //Home View
                        app = SignInView.Instance;
                        app.View();
                        Console.WriteLine("SignIn View");
                        break;

                    case 3:
                        //ManageTicket View
                        app = ManageTicketsView.Instance;
                        app.View();
                        Console.WriteLine("Admin ManageTickets View");
                        break;

                    case 4:
                        //SignUp View
                        app = SignUpFormView.Instance;
                        app.View();
                        Console.WriteLine("SignUp View");
                        break;

                    case 5:
                        //User Home View
                        app = UserHomeView.Instance;
                        app.View();
                        Console.WriteLine("User HomeView View");
                        break;

                    case 6:
                        //User Management View
                        app = UserManagementView.Instance;
                        app.View();
                        Console.WriteLine("UserManagementView View");
                        break;

                    case 7:
                        //Profile View
                        app = AccountView.Instance;
                        app.View();
                        Console.WriteLine("AccountView View");
                        break;

                    case 8:
                        //ForgotPassowrd View
                        app = ForgotPasswordFormView.Instance;
                        app.View();
                        Console.WriteLine("AccountView View");
                        break;

                    case 9:
                        //Keep this empty for easy testing purposes
                        break;

                    case 10:
                        app = AdminHomeView.Instance;
                        app.View();
                        Console.WriteLine("AccountView View");
                        break;

                    default:
                        Console.WriteLine("Ok");
                        break;

                }
            } while (choice != 9);

        }
    }
}