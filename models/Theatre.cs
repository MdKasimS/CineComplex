namespace CineComplex.models
{
    public class Theatre
    {

        private int? TheatreID;
        private string? TheatreName;
        private int? NumberOfSeats;
        public Theatre()
        {
            Console.WriteLine("I am Theatre class");
        }

        public Theatre(string tn, int nos)
        {
            TheatreName = tn;
            NumberOfSeats = nos;
        }

        public void setTheatreName(string tn)
        {
            TheatreName = tn;
        }

        public string? getTheaterName()
        {
            return TheatreName;
        }

        public void setNumberOfSeats(int nos)
        {
            NumberOfSeats = nos;
        }

        public int? getNumberOfSeats()
        {
            return NumberOfSeats;
        }

        public void setTheatreId(int ti)
        {
            TheatreID = ti;
        }

        public int? getTheatreId()
        {
            return TheatreID;
        }

        public void DisplayTheaterDetails()
        {
            Console.WriteLine($"Theatre ID : {getTheatreId()}");
            Console.WriteLine($"Theatre Name : {getTheaterName()}");
            Console.WriteLine($"Seating Capacity : {getNumberOfSeats()}");
        }
    }
}