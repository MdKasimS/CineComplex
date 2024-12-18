using CineComplex.Classes.Base;
using CineComplex.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineComplex.Views.AdminClient
{
    public class AdminHomeView : AViewBase<AdminHomeView>, IView
    {
        private int _choice = 0;
        public int Choice { get => _choice; set => _choice = value; }
        public List<string> MenuList
        {
            get;
            set;
        }

        public void LoadMenuList()
        {
            Instance.MenuList = new List<string>() {
                "1. See Shows",
                "2. Manage Shows ",
                "3. Manage Users ",
                "4. Manage Admins ",
                "5. Manage Tickets",
                "6. Manage CineComplexes ",
                "7. Exit",
            };
        }

        public void View()
        {
            Instance.LoadMenuList();

            do//main loop
            {
                Console.Clear();
                Console.WriteLine("\t----- !!! Salam Hindusthan !!! -----");
                Console.WriteLine("================================================");

                Console.WriteLine("\nHome - CineComplex");
                Console.WriteLine("-------------------------------------------------");

                Console.WriteLine();

                Console.WriteLine("\nMenu : ");
                Console.WriteLine("---------------");

                foreach (string instr in Instance.MenuList)
                {
                    Console.WriteLine(instr);
                }

                Console.Write("Enter Your Choice : ");

                int.TryParse(Console.ReadLine(), out _choice);
                switch (Choice)
                {
                    case 1:
                        //Show all shows
                        break;

                    case 2:
                        //Manage show view
                        break;

                    case 3:
                        //Manage User view
                        UserManagementView.Instance.View();
                        break;


                    default:
                        Console.WriteLine("Please enter the valid Choice .....");
                        break;
                }
            } while (Choice != Instance.MenuList.Count);
        }

    }

}
