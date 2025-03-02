using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineComplex.Models
{
    public class Discount
    {
        public int Id { get; set; }

        public string Code { get; set; }

        public double Percentage { get; set; }

        public int MaxDiscountValue { get; set; }
        public int MinOrderValur { get; set; }
    }
}
