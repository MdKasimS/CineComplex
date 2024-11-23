using CineComplex.Models;
using CineComplex.Classes.Base;


namespace CineComplex.ViewModels
{
    public class HomeViewModel : AViewModelBase<HomeViewModel>
    {
       
        public HomeViewModel() { }

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

        public void ForgotPasswordPrompt()
        {

        }
    }
}
