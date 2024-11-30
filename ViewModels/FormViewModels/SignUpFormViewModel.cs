using CineComplex.Classes.Base;
using CineComplex.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineComplex.ViewModels.FormViewModels
{
    public class SignUpFormViewModel:AViewModelBase<SignUpFormViewModel>, IViewModel
    {
        public string UserName { get; set; }
        public string Password { get; set; }    
        public string Email { get; set; }
        public string Contact { get; set; }

        public void CreateUser()
        {

        }

        public void ResetForm()
        {
            SignUpFormViewModel.Instance.UserName = "";
            SignUpFormViewModel.Instance.Email = "";
            SignUpFormViewModel.Instance.Contact = "";
            SignUpFormViewModel.Instance.Password = "";
        }

        public void ShowFormData()
        {
            Console.WriteLine($"Entered Name : {SignUpFormViewModel.Instance.UserName}");
            Console.WriteLine($"Entered Email : {SignUpFormViewModel.Instance.Email}");
            Console.WriteLine($"Entered Contact : {SignUpFormViewModel.Instance.Contact}");
            Console.WriteLine($"Entered Password : {SignUpFormViewModel.Instance.Password}");
        }
    }
}
