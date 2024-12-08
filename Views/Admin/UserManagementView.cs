using CineComplex.Classes.Base;
using CineComplex.Interfaces;
using CineComplex.Views.FormViews;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineComplex.Views.Admin
{
    public class UserManagementView : AViewBase<UserManagementView>, IView
    {
        private int _choice = 0;
        public int Choice { get => _choice; set => _choice = value; }
        public List<string> MenuList { get; set; }
        public void LoadMenuList()
        {
            UserManagementView.Instance.MenuList = new List<string>()
            {
                "1. Show Users",
                "2. Create User",
                "3. Update User",
                "4. Block User",
                "5. Delete User",
                "6. Show User Bookings",
                "7. Exit"
            };
        }

        public void View()
        {
            throw new NotImplementedException();
        }
    }
}
