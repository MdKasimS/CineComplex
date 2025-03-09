using CineComplex.Models;
using CineComplex.Classes.Base;
using CineComplex.Services;
using CineComplex.ViewModels.FormViewModels;
using CineComplex.Classes;


namespace CineComplex.ViewModels.UserClient
{
    public class SignInViewModel : AViewModelBase<SignInViewModel>
    {
       
        public SignInViewModel() { }

        public void GetSignInId()
        {
            Credential.Instance.LoginId = Console.ReadLine();
        }
        public void GetSignIPassword()
        {
            Credential.Instance.Password = Console.ReadLine();
        }

        public void ForgotPassword()
        {
            //Now this method is in VM and we need View to be created when this method is called. Don't know how to handle it?
            if(AuthenticationService.AreAllCredentialsAvailable().IsSuccessful)
            {
               
            }

        }

        public Result<bool> SignIn()
        {
            return AuthenticationService.AuthenticateUserForGivenCredential();
        }

        public void ResetFormCommand()
        {
            Credential.Instance.LoginId = "";
            Credential.Instance.Password = "";
        }

        
    }
}
