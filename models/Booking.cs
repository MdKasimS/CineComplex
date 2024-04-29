namespace CineComplex.models
{
    public class Booking
    {
        private string? _email;
        private string? _seatType;
        private string? _customerName;
        private string? _bookingStatus;
        private int _bookingId;//Must come from database staring from 1000
        private int _showId;
        private int _numberOfSeats;
        private List<int>? _seatNumbers;
        private DateTime _bookingDate;
        private decimal _amount;

        public string? Email { get => _email; set => _email = value; }
        public int ShowId { get => _showId; set => _showId = value; }
        public string? SeatType { get => _seatType; set => _seatType = value; }
        public decimal Amount { get => _amount; set => _amount = value; }
        public int NumberOfSeats { get => _numberOfSeats; set => _numberOfSeats = value; }
        public int BookingId { get => _bookingId; set => _bookingId = value; }
        public string? CustomerName { get => _customerName; set => _customerName = value; }
        public string? BookingStatus { get => _bookingStatus; set => _bookingStatus = value; }
        public List<int>? SeatNumbers { get => _seatNumbers; set => _seatNumbers = value; }
        public DateTime BookingDate { get => _bookingDate; set => _bookingDate = value; }

        public Booking(int sid, string cn, int nos, string seatType, string email, decimal amountToPay)
        {
            ShowId = sid;
            CustomerName = cn;
            NumberOfSeats = nos;
            SeatType = seatType;
            Email = email;
            Amount = amountToPay;
        }
    }
}