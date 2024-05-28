using CineComplex.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineComplex.ViewModels
{
    public class HomeVM
    {
        private static HomeVM _instance;

        public static HomeVM Instance
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
        public void LoginPrompt()
        {
            Console.Write("Enter LoginID : ");
            Credential.Instance.LoginId = Console.ReadLine();
            Console.Clear();
        }
        public void PasswordPrompt()
        {
            Console.Write("Enter Password : ");
            Credential.Instance.Password = Console.ReadLine();
            Console.Clear();
        }
    }
}
