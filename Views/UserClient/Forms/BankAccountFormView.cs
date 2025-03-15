using CineComplex.Classes.Base;
using CineComplex.Interfaces;
using CineComplex.Models;
using CineComplex.ViewModels.UserViewModels.FormViewModels;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineComplex.Views.UserClient.Forms
{
    class BankAccountFormView : AViewBase<BankAccountFormView>, IView
    {
        private int _choice = 0;
        public int Choice { get => _choice; set => _choice = value; }

        public List<string> MenuList { get; set; }
        public void LoadMenuList()
        {
            if (Instance.MenuList.IsNullOrEmpty())
            {
                Instance.MenuList = new List<string>()
                {
                    "1. Enter AccountNumber",
                    "2. Enter GSTNumber",
                    "3. Enter Bank Name",
                    "4. Enter IFSCNumber",
                    "5. Enter Account Holder Name",
                    "6. Add Bank Account",
                    "7. Exit ",
                };
            }
        }

        public async Task View()
        {
            Instance.LoadMenuList();

            do//main loop
            {
                Console.Clear();
                Console.WriteLine("\t----- !!! Salam Hindusthan !!! -----");
                Console.WriteLine("=================================================");

                Console.WriteLine("\nAdd Bank Account - Form");
                Console.WriteLine("-------------------------------------------------");

                BankAccountFormView.Instance.ShowFormData();
                Console.WriteLine();

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
                        BankAccountFormViewModel.Instance.AccountNumber = Console.ReadLine();
                        break;
                    
                    case 2:
                        BankAccountFormViewModel.Instance.GSTNumber = Console.ReadLine();
                        break;
                    
                    case 3:
                        BankAccountFormViewModel.Instance.BankName = Console.ReadLine();
                        break;
                    
                    case 4:
                        BankAccountFormViewModel.Instance.IFSCNumber = Console.ReadLine();
                        break;
                    
                    case 5:
                        BankAccountFormViewModel.Instance.AccountHolderName = Console.ReadLine();
                        break;
                    
                    case 6:
                        await BankAccountFormViewModel.Instance.AddBankAccountCommand();
                        break;

                    default:
                        Console.WriteLine("Please enter the valid choice .....");
                        break;
                }

            } while (Choice != Instance.MenuList.Count);
        }

        public void ShowFormData()
        {
            Console.WriteLine($"Entered AccountNumber : {BankAccountFormViewModel.Instance.AccountNumber}");
            Console.WriteLine($"Entered GSTNumber : {BankAccountFormViewModel.Instance.GSTNumber}");
            Console.WriteLine($"Entered BankName : {BankAccountFormViewModel.Instance.BankName}");
            Console.WriteLine($"Entered IFSCNumber : {BankAccountFormViewModel.Instance.IFSCNumber}");
        }
    }
}
