using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineComplex.Models
{
    public class Receipt
    {
        private static Dictionary<int, Receipt>? _receipts;



        #region Dictionaries
        public static Dictionary<int, Receipt>? Receipts { get => _receipts; set => _receipts = value; }


        #endregion

    }
}
