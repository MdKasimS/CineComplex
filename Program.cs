using MongoDB.Driver;
using MongoDB.Bson;
using CineComplex.Views;
using System.Runtime.InteropServices;
using System.Xml.Serialization;
using CineComplex.Classes.Base;
using CineComplex.Interfaces;


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
            int choice;
            List<string> MenuList = new List<string>()
        {
            "1.Home View",
            "2.ManageTicketView View",
            "9.Exit"
        };


            Console.WindowHeight = 25;
            Console.WindowWidth = 80;


            Console.BufferHeight = Console.WindowHeight; // Set the buffer height equal to the window height
            Console.BufferWidth = Console.WindowWidth;   // Set the buffer width equal to the window width


            DeleteMenu(GetSystemMenu(GetConsoleWindow(), false), SC_MINIMIZE, MF_BYCOMMAND);
            DeleteMenu(GetSystemMenu(GetConsoleWindow(), false), SC_MAXIMIZE, MF_BYCOMMAND);
            DeleteMenu(GetSystemMenu(GetConsoleWindow(), false), SC_SIZE, MF_BYCOMMAND);




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

                IView app = SignInView.Instance;


                switch (choice)
                {

                    case 1:
                        app.View();
                        break;

                    case 2:
                        app = ManageTicketsView.Instance;
                        app.View();
                        break;

                    case 3:
                        Console.WriteLine("HomeView View");
                        break;

                    case 4:
                        Console.WriteLine("HomeView View");
                        break;

                    case 5:
                        Console.WriteLine("HomeView View");
                        break;

                    case 6:
                        break;

                    case 7:
                        break;

                    case 8:
                        break;
                    case 9:
                        break;
                    case 10:
                        break;

                    default:
                        Console.WriteLine("Ok");
                        break;

                }
            } while (choice != 9);

        }
    }
}