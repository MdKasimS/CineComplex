using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineComplex.Models
{
    public class Seat
    {
        private static Dictionary<int, Seat>? _seats;

        #region Dictionaries
        public static Dictionary<int, Seat>? Seats { get => _seats; set => _seats = value; }


        #endregion

    }
}
