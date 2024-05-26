using CineComplex.models;
using MongoDB.Driver;


namespace CineComplex.Views
{
    public class HomeView
    {
        private int _choice = 0;
        public int Choice { get => _choice; set => _choice = value; }

        
        public void View()
        {
            

            do//main loop
            {
                Console.Clear();
                Console.WriteLine("\t----- !!! Salam Hindusthan !!! -----");
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
                        HomeVm.Instance.CustomerLoginPrompt();
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
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Please enter the valid Choice .....");
                        break;
                }
            } while (Choice > 0 || Choice < 4);
        }
        
    }
}
