using CineComplex.Classes.Base;
using CineComplex.Classes;
using CineComplex.Interfaces;
using CineComplex.Models;
using CineComplex.ViewModels.FormViewModels;
using CineComplex.Views.FormViews;
using ConsoleTables;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineComplex.Views.AdminClient
{
    public class UserManagementView : AViewBase<UserManagementView>, IView
    {
        private int _choice = 0;
        public int Choice { get => _choice; set => _choice = value; }
        public List<string> MenuList { get; set; }
        public void LoadMenuList()
        {
            Instance.MenuList = new List<string>()
            {
                "1. Show Users",
                "2. Create User",
                "3. Update User",
                "4. Block User",
                "5. Delete User",
                "6. Show User Bookings",
                "7. Exit"
            };
        }

        public void View()
        {
            Instance.LoadMenuList();

            do
            {
                Console.Clear();
                Console.WriteLine("\t----- !!! Salam Hindusthan !!! -----");
                Console.WriteLine("================================================");

                Console.WriteLine("\nManage Users - CineComplex");
                Console.WriteLine("-------------------------------------------------");

                Console.WriteLine();

                Console.WriteLine("\nMenu : ");
                Console.WriteLine("---------------");

                foreach (string instr in UserManagementView.Instance.MenuList)
                {
                    Console.WriteLine(instr);
                }

                Console.Write("Enter Your Choice : ");

                int.TryParse(Console.ReadLine(), out _choice);
                switch (Choice)
                {
                    case 1:
                        Instance.DisplayAllUsers();
                        break;
                    case 2:
                        SignUpFormView.Instance.View();
                        break;
                    case 3:
                        break;
                    case 4:
                        break;

                    case 5:
                        break;

                    case 6:
                        break;

                    default:
                        Console.WriteLine("Please enter the valid Choice .....");
                        break;
                }


            } while (Choice != UserManagementView.Instance.MenuList.Count);
        }

        public void DisplayAllUsers()
        {
            Console.Clear();
            List<User> existingUsers = SQLInteraction.Db.Users.ToList();

            if (existingUsers.Any())
            {
                Console.Clear();
                Console.WriteLine("\t----- !!! Salam Hindusthan !!! -----");
                Console.WriteLine("================================================");

                Console.WriteLine("\nManage Users - CineComplex");
                Console.WriteLine("-------------------------------------------------");

                Console.WriteLine();

                Console.WriteLine("\nUsers : ");
                Console.WriteLine("---------------");

                ConsoleTable.From<User>(existingUsers).Write(Format.MarkDown);
                Console.WriteLine($"Count {existingUsers.Count}");
            }
            else
            {
                Console.WriteLine("No users found.");
            }
            Console.ReadKey();
        }
    }
}
