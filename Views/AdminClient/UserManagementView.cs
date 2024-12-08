﻿using CineComplex.Classes.Base;
using CineComplex.Interfaces;
using CineComplex.Models;
using CineComplex.ViewModels.FormViewModels;
using CineComplex.Views.FormViews;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineComplex.Views.Admin
{
    public class UserManagementView : AViewBase<UserManagementView>, IView
    {
        private int _choice = 0;
        public int Choice { get => _choice; set => _choice = value; }
        public List<string> MenuList { get; set; }
        public void LoadMenuList()
        {
            UserManagementView.Instance.MenuList = new List<string>()
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
            UserManagementView.Instance.LoadMenuList();

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
                        UserManagementView.Instance.DisplayAllUsers();
                        break;
                    case 2:

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
                foreach (var user in existingUsers)
                {
                    Console.WriteLine($"ID: {user.Id}, Username: {user.Username}, Email: {user.Email}, Contact: {user.Contact}");
                }
            }
            else
            {
                Console.WriteLine("No users found.");
            }
            Console.ReadKey();
        }
    }
}
