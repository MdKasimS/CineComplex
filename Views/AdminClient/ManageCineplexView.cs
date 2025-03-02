using CineComplex.Classes;
using CineComplex.Classes.Base;
using CineComplex.Interfaces;
using CineComplex.ViewModels;
using CineComplex.Views.AdminClient.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineComplex.Views.AdminClient
{
    public class ManageCineplexView: AViewBase<ManageCineplexView>, IView
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
                " 1. Register New CineComplex",
                " 2. Show CinComplexes",
                " 3. De-Register A Cineplex",
                " 4. Upate A CineComplex",
                " 5. Update Business GST Number",
                " 6. Update Business A/C Number",
                " 7. Collect Deposit Amount",
                " 8. Print Deposit Receipts",
                " 9. Trasfer Deposit Amount",
                "10. Manage Licenses",
                "11. Exit",

            };
        }

        public void View()
        {
            ManageCineplexView.Instance.LoadMenuList();

            do//main loop
            {
                Console.Clear();
                Console.WriteLine("\t----- !!! Salam Hindusthan !!! -----");
                Console.WriteLine("================================================");

                Console.WriteLine("\nManage Cineplex View - CineComplex");
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
                        RegisterCineplexFormView.Instance.View();
                        Console.Clear();
                        break;

                    case 2:
                        
                        Console.Clear();
                        break;

                    case 3:
                        
                        break;

                    case 4:
                        break;

                    case 5:
                        Console.Clear();
                        break;

                    case 6:
                        break;

                    default:
                        Console.WriteLine("Please enter the valid Choice .....");
                        break;
                }
            } while (Choice != Instance.MenuList.Count);
        }
    }
}
