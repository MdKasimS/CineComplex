using CineComplex.Classes.Base;
using CineComplex.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineComplex.Views.AdminClient
{
    public class ManageCineplexView: AViewBase<ManageCineplexView>, IView
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
                "1. Register New CinePlex",
                "2. Show Our Cineplexes",
                "3. De-Register Cineplex",
                "4. Upate A CineComplex",
                "5. Update Our GST Number",
                "6. Update Our A/C Number",
                "7. Collect Deposit Amount",
                "8. Generate Deposit Receipt",
                "9. Trasfer Deposit Amount",
                "10. Manage Our Licenses",
                "11. Exit",

            };
        }

        public void View()
        {
            throw new NotImplementedException();
        }
    }
}
