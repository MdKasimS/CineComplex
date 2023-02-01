using CineComplex;
using OrderBooking;

namespace DataFiles{
    public class MovieDataStore{
        private List<Movie>? _movies;
        private List<Theatre>? _theatres;
        private List<Customer>? _customers;
        private List<LoginDetails>? _logins;
        private List<Show>? _shows;
        private List<Booking>? _bookings;

        public List<Movie>? Movies { get => _movies; set => _movies = value; }
        public List<Customer>? Customers { get => _customers; set => _customers = value; }
        public List<Show>? Shows { get => _shows; set => _shows = value; }
        public List<Booking>? Bookings { get => _bookings; set => _bookings = value; }
        public List<Theatre>? Theatres { get => _theatres; set => _theatres = value; }
        public List<LoginDetails>? Logins { get => _logins; set => _logins = value; }

        public MovieDataStore(){
            Movies = new List<Movie>();
            Theatres = new List<Theatre>();
            Customers = new List<Customer>();
            Logins = new List<LoginDetails>();
            Shows = new List<Show>();
            Bookings = new List<Booking>();

            FetchBookings();
            FetchCustomers();
            FetchLogins();
            FetchMovies();
            FetchShows();
            FetchTheatres();
        }

        public void FetchMovies(){
            //This method must feth all movies from Movie.csv and add them to Movies collection.
            Console.WriteLine("This will fetch Movies");
        }

        public void FetchTheatres(){
            //This method must fetch all theatres details from the Theatres.csv file and add them to Theatres collection.
            Console.WriteLine("This will fetch Theatres");
        }
        public void FetchCustomers(){
            // This mehtod should fetch all the customer details form the Login.csv fiel and add them to customers collection.
            Console.WriteLine("This will fetch Customers");
        }
        public void FetchLogins(){
            // This method should fetch all the login details form the Login.csv file and aad them to the Logins collection.
            Console.WriteLine("This will fetch Logins");
        }
        public void FetchShows(){
            // This method should fetch all the shows details from the Shopws.csv fiel and add them to the Shows collection.
            Console.WriteLine("This will fetch Shows");
        }
        public void FetchBookings(){
            // This method should fetch all the bookings information and ad them to the Bookings Collection.
            Console.WriteLine("This will fetch Bookings");
        }
    }
}