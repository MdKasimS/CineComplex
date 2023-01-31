using System;

namespace OrderBooking
{
public class booking
{
    public booking(string sid, string sn, int nos, string seattype, string email, string amount)
    {
        private string? _customername;
        private string? _seattype;
        private string? _email;
        private string? _bookingstatus;
        private int? _bookingid;
        private int? _showid;
        private int? _numberofseats;
        private List<int>? _seatnumbers;
        private decimal? _amount;
        private DateTime? _datetime;

    public string? Customername { get => _customername; set => _customername = value; }
    public string? Seattype { get => _seattype; set => _seattype = value; }
    public string? Email { get => _email; set => _email = value; }
    public string? Bookingstatus { get => _bookingstatus; set => _bookingstatus = value; }
    public DateTime? Datetime { get => _datetime; set => _datetime = value; }
    public decimal? Amount { get => _amount; set => _amount = value; }
    public int? Numberofseats { get => _numberofseats; set => _numberofseats = value; }
    public int? Bookingid { get => _bookingid; set => _bookingid = value; }
    public int? Showid { get => _showid; set => _showid = value; }
}
}
}