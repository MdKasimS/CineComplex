using CineComplex.Classes.Base;
using CineComplex.Interfaces;
using CineComplex.Models;
using Microsoft.IdentityModel.Tokens;

namespace CineComplex.Views.UserClient.Forms
{
    public class ProfileFormView : AViewBase<ProfileFormView>, IView
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
                    " 1. User Name",
                    " 2. Email",
                    " 3. Contact",
                    " 4. Pasword",
                    " 5. Add Address",
                    " 6. Add Bank Account",
                    " 7. Update Details",
                    " 8. Exit"
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
                Console.WriteLine("================================================");

                Console.WriteLine($"User Profile : {Credential.Instance.LoggedInUser.Username,-35}");
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
                    case 5:
                        await AddressFormView.Instance.View();
                        break;

                    default:
                        Console.WriteLine("Please enter the valid Choice .....");
                        break;
                }

            } while (Choice != Instance.MenuList.Count);
        }
    }
}
