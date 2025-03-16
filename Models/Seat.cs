using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineComplex.Models
{
    public enum SeatType
    { 
        Platinum,
        Gold,
        Seat
    }

    public enum SeatStatus
    {
        Available,
        Reserved,
    }

    public class Seat
    {
        public int Id { get; set; }
        public int RowNum { get; set; }
        public string  ColumnNum { get; set; }
        public SeatStatus SeatAvailability { get; set; }
        public SeatType TypeOfSeat { get; set; }
        public Theatre CineComplexTheatre { get; set; }
        public int TheatreId { get; set; }// Foreign Key
        public Ticket TicketForThisSeat { get; set; }// One-to-One
    }
}
