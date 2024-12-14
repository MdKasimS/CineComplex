using CineComplex.Models;
using CineComplex.Classes.Base;


namespace CineComplex.ViewModels
{
    public class SignInViewModel : AViewModelBase<SignInViewModel>
    {
       
        public SignInViewModel() { }

        public void GetSignInId()
        {
            Credential.Instance.LoginId = Console.ReadLine();
            Console.Clear();
        }
        public void GetSignIPassword()
        {
            Credential.Instance.Password = Console.ReadLine();
            Console.Clear();
        }

        public void ForgotPassword()
        {

        }
    }
}
