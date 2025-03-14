using CineComplex.Classes.Base;
using CineComplex.Interfaces;
using CineComplex.Models;
using Microsoft.IdentityModel.Tokens;
using System.Collections.ObjectModel;


namespace CineComplex.ViewModels.UserViewModels
{
    public class ProfileViewModel : AViewModelBase<ProfileViewModel>, IViewModel
    {
        #region Properties

        public User LoggedInUser { get; set; } = Credential.Instance.LoggedInUser;

        #region Collections

        public ObservableCollection<Address> AddressesOfUser { get; set; }

        #endregion

        #endregion

        #region Commands

        #endregion

        #region Methods

        public void Init()
        {
            if (AddressesOfUser.IsNullOrEmpty())
            {
                AddressesOfUser = new ObservableCollection<Address>();

                foreach (Address address in SQLInteraction.Db.Addresses.Where(ad => ad.UserProfileId == Credential.Instance.LoggedInUser.UserProfileId).ToList())
                {
                    AddressesOfUser.Add(address);
                }
            }
        }

        #endregion
    }
}
