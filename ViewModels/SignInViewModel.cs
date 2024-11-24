using CineComplex.Models;
using CineComplex.Classes.Base;


namespace CineComplex.ViewModels
{
    public class SignInViewModel : AViewModelBase<SignInViewModel>
    {
       
        public SignInViewModel() { }

        public void GetSignInId()
        {
            Console.Write("Enter LoginID : ");
            Credential.Instance.LoginId = Console.ReadLine();
            Console.Clear();
        }
        public void GetSignIPassword()
        {
            Console.Write("Enter Password : ");
            Credential.Instance.Password = Console.ReadLine();
            Console.Clear();
        }

        public void ForgotPassword()
        {

        }
    }
}
