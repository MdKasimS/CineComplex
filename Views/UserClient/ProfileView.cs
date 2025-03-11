using CineComplex.Classes.Base;
using CineComplex.Interfaces;
using CineComplex.Models;
using CineComplex.ViewModels.UserViewModels;
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
            ConsoleTable table;
            int pageSize = 10;
            int currentPage = 0;
            bool hasMorePages = true;

            do//main loop
            {
                Console.Clear();
                Console.WriteLine("\t----- !!! Salam Hindusthan !!! -----");
                Console.WriteLine("================================================");

                Console.WriteLine($"User Profile : UID {Credential.Instance.LoginId}");
                Console.WriteLine("-------------------------------------------------");

                Console.WriteLine();

                table = new ConsoleTable(new List<string>() { "Id", "UserName", "Contact", "Email" }.ToArray());
                var pagedUsers = new List<User>(){
                                        ProfileViewModel.Instance.LoggedInUser, };

                foreach (User u in pagedUsers)
                {
                    table.AddRow($"{u.Id}", $"{u.Username,-20}", $"{u.Contact,-5}", $"{u.Email,-25}");
                }

                if (pagedUsers.Count() != 0 && pagedUsers.Count() < 10)
                {
                    for (int i = 0; i < 10 - pagedUsers.Count(); ++i)
                    {
                        table.AddRow("", "", "", "");
                    }
                }

                hasMorePages = pagedUsers.Count() == 0 ? false : true;
                if (hasMorePages)
                {
                    table.Write(Format.MarkDown);
                    Console.WriteLine($"Count {table.Rows.Count}");

                    currentPage++;

                    Console.WriteLine("\nMenu : ");
                    Console.WriteLine("---------------");
                    Console.WriteLine("1. Press Enter to view the next page");
                    Console.WriteLine("2. Enter Id For Record Selection");
                    Console.WriteLine("3. Type 3 to exit");
                    Console.Write("Your Choice: ");

                    var input = Console.ReadLine();
                    if (input?.ToLower() == "3")
                    {
                        break;
                    }

                }
            } while (hasMorePages);
        }
    }
}
