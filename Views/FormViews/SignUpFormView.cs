using CineComplex.Classes.Base;
using CineComplex.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineComplex.Views.FormViews
{
    public class SignUpFormView : AViewBase<SignUpFormView>, IView
    {
        public int Choice { get; set; }
        public List<string> MenuList { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }


        public void LoadMenuList()
        {
            Instance.MenuList = new List<string>()
            {
                "1. Enter Name",
                "2. Enter Email",
                "3. Enter Contact",
                "4. Enter Password",
                "5. Sign Up",
                "6. Reset",
                "7. Exit"
            };
        }

        public void View()
        {
            do
            {

            } while (Choice != Instance.MenuList.Count);
        }
    }
}
