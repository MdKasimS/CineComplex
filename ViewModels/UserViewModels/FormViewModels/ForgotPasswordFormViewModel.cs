﻿using CineComplex.Classes.Base;
using CineComplex.Interfaces;

namespace CineComplex.ViewModels.UserViewModels.FormViewModels
{
    public class ForgotPasswordFormViewModel: AViewModelBase<ForgotPasswordFormViewModel>, IViewModel
    {
        #region Properties
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Contact { get; set; }

        #endregion

        #region Methods

        public void SetNewPasswordForUserId()
        {

        }

        #endregion
    }
}
