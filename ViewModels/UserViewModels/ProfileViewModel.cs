using CineComplex.Classes;
using CineComplex.Classes.Base;
using CineComplex.Interfaces;
using CineComplex.Models;


namespace CineComplex.ViewModels.UserViewModels
{
    public class ProfileViewModel : AViewModelBase<ProfileViewModel>, IViewModel
    {
        #region Properties

        public User LoggedInUser { get; set; } = Credential.Instance.LoggedInUser;

        #endregion

        #region Commands
        #endregion

        #region Methods


        #endregion
    }
}
