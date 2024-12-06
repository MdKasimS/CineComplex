using CineComplex.Classes.Base;
using CineComplex.Interfaces;
using CineComplex.Models;
using CineComplex.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineComplex.ViewModels.FormViewModels
{
    public class SignUpFormViewModel : AViewModelBase<SignUpFormViewModel>, IViewModel
    {
        #region Properties

        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Contact { get; set; }

        #endregion

        #region Commands

        public async Task CreateUserCommand()
        {
            User _newUser = new User();
            _newUser.Username = UserName;
            _newUser.Password = Password;
            _newUser.Email = Email;
            _newUser.Contact = Contact;
            if (User.IsValidUserRegistration(_newUser))
            {
                await User.CreateNewUser(_newUser);

            }
        }

        public void ResetFormCommand()
        {
            SignUpFormViewModel.Instance.UserName = "";
            SignUpFormViewModel.Instance.Email = "";
            SignUpFormViewModel.Instance.Contact = "";
            SignUpFormViewModel.Instance.Password = "";
        }
        #endregion

        #region Methods

        public void ShowFormData()
        {
            Console.WriteLine($"Entered Name : {SignUpFormViewModel.Instance.UserName}");
            Console.WriteLine($"Entered Email : {SignUpFormViewModel.Instance.Email}");
            Console.WriteLine($"Entered Contact : {SignUpFormViewModel.Instance.Contact}");
            Console.WriteLine($"Entered Password : {SignUpFormViewModel.Instance.Password}");
        }
        #endregion
    }
}
