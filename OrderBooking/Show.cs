namespace OrderBooking
{
    public class Show
    {
        private int _showId;//Must be done internally from database
        private int _movieId;
        private int _theatreId;
        private decimal _platinumSeatRate;
        private decimal _goldSeatRate;
        private decimal _silverSeatRate;
        private DateTime _endDate;
        private DateTime _startDate;

        public int ShowId { get => _showId; set => _showId = value; }
        public int MovieId { get => _movieId; set => _movieId = value; }
        public int TheatreId { get => _theatreId; set => _theatreId = value; }
        public decimal PlatinumSeatRate { get => _platinumSeatRate; set => _platinumSeatRate = value; }
        public decimal GoldSeatRate { get => _goldSeatRate; set => _goldSeatRate = value; }
        public decimal SilverSeatRate { get => _silverSeatRate; set => _silverSeatRate = value; }
        public DateTime EndDate { get => _endDate; set => _endDate = value; }
        public DateTime StartDate { get => _startDate; set => _startDate = value; }

        public Show(int mid, int tid, DateTime sdt, DateTime edt, decimal platinumRate, decimal goldRate, decimal silverRate){
            MovieId = mid;
            TheatreId = tid;
            StartDate = sdt;
            EndDate = edt;
            PlatinumSeatRate = platinumRate;
            GoldSeatRate = goldRate;
            SilverSeatRate = silverRate;

        }

        public void DisplayShowDetails(){
            // Console.WriteLine($"Show ID : {ShowId}");
            Console.WriteLine($"Movie ID : {MovieId}");
            Console.WriteLine($"Theatre ID : {TheatreId}");
            Console.WriteLine($"Platinum Seat Rate : {PlatinumSeatRate}");
            Console.WriteLine($"Gold Seat Rate : {GoldSeatRate}");
            Console.WriteLine($"Silver Seat Rate : {SilverSeatRate}");
        }       
    }
}