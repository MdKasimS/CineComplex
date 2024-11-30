using CineComplex.Classes.Base;
using CineComplex.Interfaces;
using CineComplex.ViewModels.FormViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineComplex.Views.FormViews
{
    public class SignUpFormView : AViewBase<SignUpFormView>, IView
    {
        private int _choice = 0;
        public int Choice { get => _choice; set => _choice = value; }
        public List<string> MenuList { get; set; }

        public void LoadMenuList()
        {
            SignUpFormView.Instance.MenuList = new List<string>()
            {
                "1. Enter Name",
                "2. Enter Email",
                "3. Enter Contact",
                "4. Enter Password",
                "5. Sign Up",
                "6. Reset",
                "7. Exit"
            };
        }

        public void View()
        {
            SignUpFormView.Instance.LoadMenuList();
            do
            {
                Console.Clear();
                Console.WriteLine("\t----- !!! Salam Hindusthan !!! -----");
                Console.WriteLine("================================================");

                Console.WriteLine("\nSign Up Form - CineComplex");
                Console.WriteLine("-------------------------------------------------");

                SignUpFormViewModel.Instance.ShowFormData();
                Console.WriteLine();

                Console.WriteLine("\nMenu : ");
                Console.WriteLine("---------------");

                foreach (string instr in SignUpFormView.Instance.MenuList)
                {
                    Console.WriteLine(instr);
                }

                Console.Write("Enter Your Choice : ");

                int.TryParse(Console.ReadLine(), out _choice);
                switch (Choice)
                {
                    case 1:
                        SignUpFormViewModel.Instance.UserName = Console.ReadLine();
                        break;
                    case 2:
                        SignUpFormViewModel.Instance.Email = Console.ReadLine();
                        break;
                    case 3:
                        SignUpFormViewModel.Instance.Contact = Console.ReadLine();
                        break;
                    case 4:
                        SignUpFormViewModel.Instance.Password = Console.ReadLine();
                        break;

                    case 5:
                        SignUpFormViewModel.Instance.CreateUser();
                        break;

                    case 6:
                        SignUpFormViewModel.Instance.ResetForm();
                        break;

                    default:
                        Console.WriteLine("Please enter the valid Choice .....");
                        break;
                }


            } while (Choice != SignUpFormView.Instance.MenuList.Count);
        }
    }
}
