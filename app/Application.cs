using CineComplex.models;
using MongoDB.Driver;


namespace CineComplex
{
    public class Application
    {
        private string? _userTypeInput = "";
        private int _choice = 0;
        private string? _pwd = new String("");
        private string? _loginId = new String("");
        public string? LoginId { get => _loginId; set => _loginId = value; }
        public string? Pwd { get => _pwd; set => _pwd = value; }
        public string? UserTypeInput { get => _userTypeInput; set => _userTypeInput = value; }
        public int Choice { get => _choice; set => _choice = value; }
        public void run()
        {
            MovieDataStore dataSource = new MovieDataStore();   //All data fetching will be done here

            do//main loop
            {
                Console.Clear();
                Console.WriteLine("\t----- Salam Hindusthan !!! -----");
                Console.WriteLine("================================================");

                Console.WriteLine("\nChoose User Type : ");
                Console.WriteLine("\t1. Customer");
                Console.WriteLine("\t2. Admin");
                Console.WriteLine("\t3. Exit");
                Console.Write("Select Your Choice 1/2/3 : ");

                UserTypeInput = Console.ReadLine();
                if (UserTypeInput != null)
                {
                    Choice = int.Parse(UserTypeInput);//exception must be handled here
                }
                switch (Choice)
                {
                    case 1:
                        Console.Clear();
                        CustomerLoginPrompt();
                        Console.Clear();
                        break;

                    case 2:
                        Console.Clear();
                        AdminLoginPrompt();
                        Console.Clear();
                        break;

                    case 3:
                        Console.Write("\nPress any key.....");
                        Console.ReadKey();
                        System.Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Please enter the valid Choice .....");
                        break;
                }
            } while (Choice > 0 || Choice < 4);
        }
        public void CustomerLoginPrompt()
        {   
            Console.WriteLine("---------- Customer Login ----------");
            Console.Write("Enter LoginID : ");
            LoginId = Console.ReadLine();
            Console.Write("Enter Password : ");
            Pwd = Console.ReadLine();
        }
        public void AdminLoginPrompt()
        {
            Console.WriteLine("---------- Admin Login ----------");
            Console.Clear();
            Console.WriteLine("Enter LoginID : MOVIEADMIN");
            Console.Write("Enter Password : ");
            Pwd = Console.ReadLine();
        }
    }
}
