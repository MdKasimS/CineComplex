using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineComplex.Interfaces
{
    public interface IView
    {
        public void View();
        public int Choice { get; set; }
        public List<string> MenuList { get; set; }
        public void LoadMenuList();
    }
}
