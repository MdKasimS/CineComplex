namespace CineComplex.Models
{
    public class Booking
    {
        public int Id { get; set; }
       
        public Ticket TicketForShow { get; set; }

    }
}