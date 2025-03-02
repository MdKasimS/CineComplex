using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineComplex.Models
{
    public class Ticket
    {
        public int Id { get; set; }
        public Show ShowBooked { get; set; }
        public int ShowId { get; set; }
        public Seat SeatBooked { get; set; }
        public int SeatId { get; set; }

    }
}
