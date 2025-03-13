using CineComplex.Classes.Base;
using CineComplex.Interfaces;
using CineComplex.Models;

namespace CineComplex.ViewModels.UserViewModels.FormViewModels
{
    public class ProfileFormViewModel : AViewModelBase<ProfileFormViewModel>, IViewModel
    {
        #region Properties
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Contact { get; set; }
        public string Password { get; set; }
        public Address NewAddress { get; set; }
        public BankAccount NewBankAccount { get; set; }
        #endregion
    }
}
