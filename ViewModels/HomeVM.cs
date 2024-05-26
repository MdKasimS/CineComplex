using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineComplex.ViewModels
{
    public class HomeVM
    {
        private HomeVM _instance;

        public HomeVM Instance
        {
            get 
            { 
                if(_instance==null)
                {
                    _instance = new HomeVM();
                }
                return _instance; 
            }
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
