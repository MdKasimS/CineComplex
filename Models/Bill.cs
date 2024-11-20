using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineComplex.Models
{
    public class Bill
    {
        private static Dictionary<int, Bill>? _bills;



        #region Dictionaries
        public static Dictionary<int, Bill>? Bills { get => _bills; set => _bills = value; }


        #endregion
    }
}
