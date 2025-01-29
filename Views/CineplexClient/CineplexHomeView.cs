using CineComplex.Classes.Base;
using CineComplex.Interfaces;
using CineComplex.Views.UserClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineComplex.Views.CineplexClient
{
    public class CineplexHomeView : AViewBase<CineplexHomeView>, IView
    {
        public int Choice { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public List<string> MenuList { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void LoadMenuList()
        {
            throw new NotImplementedException();
        }

        public void View()
        {
            throw new NotImplementedException();
        }
    }
}
