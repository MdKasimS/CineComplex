using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineComplex.Models
{
    public class Seat
    {
        public int Id { get; set; }
        public Theatre CineComplexTheatre { get; set; }
        public int TheatreId { get; set; }
    }
}
