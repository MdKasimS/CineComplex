using CineComplex.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineComplex.Classes.Base
{
    public class AServiceBase<T> : ABaseSingleton<T> where T : AServiceBase<T>, new()
    {
    }
}
