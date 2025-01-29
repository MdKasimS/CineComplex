using CineComplex.Classes.Base;
using CineComplex.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineComplex.Views.AdminClient
{
    public class RegisterCineplexView : AViewBase<RegisterCineplexView>, IView
    {
        private int _choice = 0;
        public int Choice { get => _choice; set => _choice = value; }
        public List<string> MenuList
        {
            get;
            set;
        }
        public void LoadMenuList()
        {
            Instance.MenuList = new List<string>() {
                "1. Enter Company Name",
                "2. Enter City",
                "3. Enter Area",
                "4. Enter CinePlex Name",
                "5. Enter Number Of Theatres",
                "6. Enter GST Number",
                "7. Enter A/C Number",
                "8. Enter Deposit Amount",
                "9. Manage License",
                "9. Exit",


            };
        }

        public void View()
        {
            throw new NotImplementedException();
        }
    }
}
