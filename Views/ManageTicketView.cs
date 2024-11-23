using CineComplex.Classes.Base;
using CineComplex.Interfaces;
using CineComplex.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineComplex.Views
{
    public class ManageTicketView : AViewBase<ManageTicketView>, IView
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
            ManageTicketView.Instance.LoadMenuList();

            do//main loop
            {
                Console.Clear();
                Console.WriteLine("\t----- !!! Salam Hindusthan !!! -----");
                Console.WriteLine("================================================");

                Console.WriteLine(" Manage Tickets");
                Console.WriteLine("-------------------------------------------------");


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
                        Console.Clear();
                        break;

                    case 2:
                        HomeViewModel.Instance.PasswordPrompt();
                        Console.Clear();
                        break;

                    case 3:
                        Services.AuthenticationService.AuthenticateUserForGivenCredential();
                        break;

                    case 4:
                        break;

                    case 5:
                        break;

                    case 6:
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
            ManageTicketView.Instance.MenuList = new List<string>() 
            { 
                "1. Book Ticket", 
                "2. Show Shows", 
                "3. Cancel Tickets", 
                "4. Previous Bookings", 
                "5. Account", 
                "6. Exit ", 
            };
        }
    }
}

