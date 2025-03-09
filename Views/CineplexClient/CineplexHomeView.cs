using CineComplex.Classes.Base;
using CineComplex.Interfaces;
using CineComplex.Views.UserClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineComplex.Views.CineplexClient
{
    public class CineplexHomeView : AViewBase<CineplexHomeView>, IView
    {
        private int _choice = 0;
        public int Choice { get => _choice; set => _choice = value; }
        public List<string> MenuList { get; set; }
        public void LoadMenuList()
        {
            Instance.MenuList = new List<string>() {
                "1. Show Scheduled Shows",
                "2. Manage Shows",
                "3. Manage Tickets",
                "4. Manage Theatres",
                "5. Manage Movies",
                "6. Manage Updates & Ads",
                "7. Manage Licenses",
                "8. Exit",
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
                        //Show scheduled shows
                        break;

                    case 2:
                        //Manage shows
                        break;

                    case 3:
                        //Manage tickets
                        break;

                    case 4:
                        //Manage theatre
                        break;

                    case 5:
                        //Manage movies
                        break;

                    case 6:
                        //Manage updates & ads
                        break;

                    case 7:
                        //Manage Licenses
                        break;

                    default:
                        Console.WriteLine("Please enter the valid Choice .....");
                        break;
                }
            } while (Choice != Instance.MenuList.Count);
        }
    }
}
