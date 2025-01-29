using CineComplex.Classes.Base;
using CineComplex.Interfaces;
using CineComplex.Views.FormViews;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineComplex.Views
{
    public class StartView : AViewBase<StartView>, IView
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
            StartView.Instance.MenuList = new List<string>() {
                "1. Login ",
                "2. Register ",
                "3. Forgot Password ",
                "4. Create View And ViewModel Files",
                "5. Exit",
            };
        }

        public void View()
        {
            StartView.Instance.LoadMenuList();

            do//main loop
            {
                Console.Clear();
                Console.WriteLine("\t----- !!! Salam Hindusthan !!! -----");
                Console.WriteLine("================================================");

                Console.WriteLine("\nStart - CineComplex");
                Console.WriteLine("-------------------------------------------------");

                Console.WriteLine();

                Console.WriteLine("\nMenu : ");
                Console.WriteLine("---------------");

                foreach (string instr in StartView.Instance.MenuList)
                {
                    Console.WriteLine(instr);
                }

                Console.Write("Enter Your Choice : ");


                int.TryParse(Console.ReadLine(), out _choice);
                switch (Choice)
                {
                    case 1:
                        HomeView.Instance.View();
                        break;

                    case 2:
                        break;

                    case 3:
                        ForgotPasswordFormView.Instance.View();
                        break;

                    default:
                        Console.WriteLine("Please enter the valid Choice .....");
                        break;
                }
            } while (Choice != StartView.Instance.MenuList.Count);
        }
    }
}
