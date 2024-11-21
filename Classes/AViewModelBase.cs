using CineComplex.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineComplex.Classes
{
    public class AViewModelBase<T> : ABaseSingleton<T>, IViewModel where T : AViewModelBase<T>, new()
    {
    }
}
