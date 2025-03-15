using CineComplex.Classes.Base;
using CineComplex.Interfaces;
using CineComplex.Models;
using CineComplex.ViewModels.UserViewModels;
using CineComplex.Views.UserClient.Forms;
using ConsoleTables;


namespace CineComplex.Views.UserClient
{
    class ProfileView : AViewBase<ProfileView>, IView
    {
        private int _choice = 0;
        public int Choice { get => _choice; set => _choice = value; }
        public List<string> MenuList { get; set; }
        public void LoadMenuList() { }

        public async Task View()
        {
            
            ProfileViewModel.Instance.Init();

            ConsoleTable tableUserAccount;
            int pageSize = 1;
            int currentPage = 0;
            bool hasMorePages = true;

            do//main loop
            {
                Console.Clear();
                Console.WriteLine("\t----- !!! Salam Hindusthan !!! -----");
                Console.WriteLine("================================================");

                Console.WriteLine($"User Profile : {Credential.Instance.LoginId}");
                Console.WriteLine("-------------------------------------------------");

                Console.WriteLine();

                tableUserAccount = new ConsoleTable(new List<string>() { "Id", "UserName", "Contact", "Email" }.ToArray());
                var pagedUsers = new List<User>(){
                                        ProfileViewModel.Instance.LoggedInUser, };

                foreach (User u in pagedUsers)
                {
                    tableUserAccount.AddRow($"{u.Id}", $"{u.Username,-20}", $"{u.Contact,-5}", $"{u.Email,-25}");
                }

                if (pagedUsers.Count() != 0 && pagedUsers.Count() < 10)
                {
                    for (int i = 0; i < pageSize - pagedUsers.Count(); ++i)
                    {
                        tableUserAccount.AddRow("", "", "", "");
                    }
                }

                ConsoleTable tableAddresses = new ConsoleTable(new List<string>() { "Id", "Address" }.ToArray());
                var pagedAddresses = ProfileViewModel.Instance.AddressesOfUser;


                foreach (Address address in pagedAddresses)
                {
                    tableAddresses.AddRow($"{address.Id}", $"{address.BuildingDetails},{address.StreetName},{address.Area},{address.City},{address.State},{address.Country},{address.OtherDetails},{address.PinCode}");
                }

                if (pagedAddresses.Count() != 0 && pagedAddresses.Count() < 10)
                {
                    for (int i = 0; i < pageSize - pagedAddresses.Count(); ++i)
                    {
                        tableAddresses.AddRow("", "");
                    }
                }

                //TODO: select out of pagedAddresses, pagedUsers and pagedBankAccounts
                hasMorePages = pagedAddresses.Count() == 0 ? false : true;
                if (hasMorePages)
                {
                    tableUserAccount.Write(Format.MarkDown);

                    Console.WriteLine("\nAddress");
                    Console.WriteLine("-------------------------------------------------");
                    tableAddresses.Write(Format.MarkDown);
                    //Console.WriteLine($"Count {tableAddresses.Rows.Count}");

                    currentPage++;

                    Console.WriteLine("\nMenu : ");
                    Console.WriteLine("---------------");
                    Console.WriteLine("1. Update the profile");
                    Console.WriteLine("2. Exit");
                    Console.Write("Your Choice: ");

                    var input = Console.ReadLine();

                    if (input?.ToLower() == "1")
                    {
                        await ProfileFormView.Instance.View();
                        break;
                    }

                    if (input?.ToLower() == "2")
                    {
                        break;
                    }

                }
            } while (hasMorePages);

            ProfileViewModel.Instance.AddressesOfUser = null;
        }
    }
}
