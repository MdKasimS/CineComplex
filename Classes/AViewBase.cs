using CineComplex.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineComplex.Classes
{
    public abstract class AViewBase<T> : ABaseSingleton<T>, IView where T : AViewBase<T>, new()
    {
        protected AViewBase() { }


        public abstract void View();

        //public void View();
    }
}
