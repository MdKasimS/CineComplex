namespace OrderBooking
{
    public class Booking
    {
        private int? _bookingId;//Must come from database starting from 1000
        private int? _showId;
        private int? _numberOfSeats;
        private string? _email;
        private string? _customerName;
        private string? _seatType;
        private string? _bookingStatus;
        private decimal? _amount;
        private DateTime? _dateTime;
        private List<int>? _seatNumbers;
        public int? BookingId { get => _bookingId; set => _bookingId = value; }
        public int? ShowId { get => _showId; set => _showId = value; }
        public int? NumberOfSeats { get => _numberOfSeats; set => _numberOfSeats = value; }
        public string? Email { get => _email; set => _email = value; }
        public string? CustomerName { get => _customerName; set => _customerName = value; }
        public string? SeatType { get => _seatType; set => _seatType = value; }
        public decimal? Amount { get => _amount; set => _amount = value; }
        public List<int>? SeatNumbers { get => _seatNumbers; set => _seatNumbers = value; }

        public Booking(string sid, string sn, int nos, string seatType, string email, string amount)
        {
            
        }
    }
}