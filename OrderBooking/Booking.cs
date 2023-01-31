namespace OrderBooking
{
    public class Booking
    {
        public Booking(string sid, string sn, int nos, string seatType, string email, string amount)
        {
            private string? _customerName;
            private string? _seatType;
            private string? _email;
            private string? _bookingStatus;
            private int? _bookingId;
            private int? _ShowId;
            private int? _numberOfSeats;
            private List<int>? _seatNumbers;
            private decimal? _amount;
            private DateTime? _dateTime;

        public string? CustomerName { get => _customerName; set => _customerName = value; }
        public string? SeatType { get => _seatType; set => _seatType = value; }
        public string? Email { get => _email; set => _email = value; }
        public string? BookingStatus { get => _bookingStatus; set => _bookingStatus = value; }
        public DateTime? DateTime { get => _dateTime; set => _dateTime = value; }
        public decimal? Amount { get => _amount; set => _amount = value; }
        public int? NumberOfSeats { get => _numberOfSeats; set => _numberOfSeats = value; }
        public int? BookingId { get => _bookingId; set => _bookingId = value; }
        public int? ShowId { get => _ShowId; set => _ShowId = value; }
    }
    }
}
    