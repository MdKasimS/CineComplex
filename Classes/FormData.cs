using CineComplex.Classes.Base;
using CineComplex.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineComplex.Classes
{
    public class FormData: ABaseSingleton<FormData>
    {
        public User UserFormObject { get; set; }

        public FormData() { }


    }
}
