namespace CineComplex.Models
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
        private Dictionary<int, Booking>? _bookings;

        #region Dictionaries
        public Dictionary<int, Booking>? Bookings { get => _bookings; set => _bookings = value; }


        #endregion

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

        public Booking(int showId, string customerNumber, int numberOfSeats, string seatType, string email, decimal amountToPay)
        {
            ShowId = showId;
            CustomerName = customerNumber;
            NumberOfSeats = numberOfSeats;
            SeatType = seatType;
            Email = email;
            Amount = amountToPay;
        }
    }
}