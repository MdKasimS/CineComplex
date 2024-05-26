namespace CineComplex.models
{
    public class Show
    {
        private int _showId;//Must be done internally from database
        private int _movieId;
        private int _theatreId;
        private decimal _platinumSeatRate;
        private decimal _goldSeatRate;
        private decimal _silverSeatRate;
        private DateTime _startDate;
        private DateTime _endDate;

        public int ShowId { get => _showId; set => _showId = value; }
        public int MovieId { get => _movieId; set => _movieId = value; }
        public int TheatreId { get => _theatreId; set => _theatreId = value; }
        public decimal PlatinumSeatRate { get => _platinumSeatRate; set => _platinumSeatRate = value; }
        public decimal GoldSeatRate { get => _goldSeatRate; set => _goldSeatRate = value; }
        public decimal SilverSeatRate { get => _silverSeatRate; set => _silverSeatRate = value; }
        public DateTime StartDate { get => _startDate; set => _startDate = value; }
        public DateTime EndDate { get => _endDate; set => _endDate = value; }

        public Show(int movieId, int theatreId, DateTime startDate, DateTime endDate, decimal platinumRate, decimal goldRate, decimal silverRate)
        {
            MovieId = movieId;
            TheatreId = theatreId;
            StartDate = startDate;
            EndDate = endDate;
            PlatinumSeatRate = platinumRate;
            GoldSeatRate = goldRate;
            SilverSeatRate = silverRate;
            ShowId = 10101;// Constructor must generate from database
        }

        public void DisplayShowDetails()
        {
            Console.WriteLine($"Show ID : {ShowId}");
            Console.WriteLine($"Movie ID : {MovieId}");
            Console.WriteLine($"Theatre ID : {TheatreId}");
            Console.WriteLine($"Platinum Seat Rate : {PlatinumSeatRate}");
            Console.WriteLine($"Gold Seat Rate : {GoldSeatRate}");
            Console.WriteLine($"Silver Seat Rate : {SilverSeatRate}");
        }
    }
}