﻿using CineComplex.Classes.Base;
using CineComplex.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineComplex.Views.CineplexClient
{
    class ProfileView : AViewBase<ProfileView>, IView
    {
        public int Choice { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public List<string> MenuList { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void LoadMenuList()
        {
            throw new NotImplementedException();
        }

        public Task View()
        {
            throw new NotImplementedException();
        }
    }
}
