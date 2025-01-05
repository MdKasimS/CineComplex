using CineComplex.Classes.Base;
using CineComplex.Interfaces;
using CineComplex.Models;
using CineComplex.Services;
using CineComplex.ViewModels.FormViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineComplex.ViewModels.AdminViewModels
{
    public class AdminHomeViewModel : AViewModelBase<AdminHomeViewModel>, IViewModel
    {
        public void SignOut()
        {
            SessionService.TerminateSession(Credential.Instance.SessionTokenId);
        }

    }
}
