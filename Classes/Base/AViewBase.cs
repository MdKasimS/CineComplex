using CineComplex.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineComplex.Classes.Base
{
    public abstract class AViewBase<T> : ABaseSingleton<T> where T : AViewBase<T>, new()
    {
        // Protected constructor to prevent direct instantiation.
        protected AViewBase() { }

        //public abstract void View();

    }
}
