using CineComplex.Classes.Base;
using CineComplex.Interfaces;
using CineComplex.ViewModels.FormViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineComplex.ViewModels.AdminViewModels.FormsViewModels
{
    public class RegisterCineplexFormViewModel : AViewModelBase<RegisterCineplexFormViewModel>, IViewModel
    {
        #region Properties
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Contact { get; set; }
        #endregion
    }
}
