namespace OrderBooking
{
    public class Booking
    {
        private string? _email;
        private string? _seatType;
        private string? _customerName;
        private string? _bookingStatus;
        private int _bookingId;
        private int _showId;
        private int _numberOfSeats;
        private List<int>? _seatNumbers;
        private DateTime _dateTime;
        private decimal _amount;

        public string? Email { get => _email; set => _email = value; }
        public string? BookingStatus { get => BookingStatus1; set => BookingStatus1 = value; }
        public int ShowId { get => ShowId1; set => ShowId1 = value; }

        public List<int>? GetSeatNumbers1()
        { return _seatNumbers; }
        public void SetSeatNumbers1(List<int>? value)
        {
            _seatNumbers = value;
        }

        public string? SeatType { get => _seatType; set => _seatType = value; }
        public DateTime DateTime { get => _dateTime; set => _dateTime = value; }
        public decimal Amount { get => _amount; set => _amount = value; }
        public int ShowId1 { get => _showId; set => _showId = value; }
        public int NumberOfSeats { get => _numberOfSeats; set => _numberOfSeats = value; }
        public string? BookingStatus1 { get => _bookingStatus; set => _bookingStatus = value; }
        public int BookingId { get => _bookingId; set => _bookingId = value; }
        public string? CustomerName { get => _customerName; set => _customerName = value; }
    }
}