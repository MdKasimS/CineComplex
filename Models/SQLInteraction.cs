namespace CineComplex.Models
{
    public class SQLInteraction
    {
        private Dictionary<int,Movie>? _movies;
        private Dictionary<int,Theatre>? _theatres;
        private Dictionary<int,Customer>? _customers;
        private Dictionary<int,Credential>? _logins;
        private Dictionary<int,Show>? _shows;
        private Dictionary<int,Booking>? _bookings;

        public Dictionary<int,Movie>? Movies { get => _movies; set => _movies = value; }
        public Dictionary<int,Customer>? Customers { get => _customers; set => _customers = value; }
        public Dictionary<int,Show>? Shows { get => _shows; set => _shows = value; }
        public Dictionary<int,Booking>? Bookings { get => _bookings; set => _bookings = value; }
        public Dictionary<int,Theatre>? Theatres { get => _theatres; set => _theatres = value; }
        public Dictionary<int,Credential>? Logins { get => _logins; set => _logins = value; }

        public SQLInteraction()
        {
            Movies = new Dictionary<int,Movie>();
            Theatres = new Dictionary<int,Theatre>();
            Customers = new Dictionary<int,Customer>();
            Logins = new Dictionary<int,Credential>();
            Shows = new Dictionary<int,Show>();
            Bookings = new Dictionary<int,Booking>();


            FetchBookings();
            FetchCustomers();
            FetchLogins();
            FetchMovies();
            FetchShows();
            FetchTheatres();
        }

        public void FetchMovies()
        {
            //This method must feth all movies from Movie.csv and add them to Movies collection.
            Console.WriteLine("This will fetch Movies");
        }

        public void FetchTheatres()
        {
            //This method must fetch all theatres details from the Theatres.csv file and add them to Theatres collection.
            Console.WriteLine("This will fetch Theatres");
        }
        public void FetchCustomers()
        {
            // This mehtod should fetch all the customer details form the Login.csv fiel and add them to customers collection.
            Console.WriteLine("This will fetch Customers");
        }
        public void FetchLogins()
        {
            // This method should fetch all the login details form the Login.csv file and aad them to the Logins collection.
            Console.WriteLine("This will fetch Logins");
        }
        public void FetchShows()
        {
            // This method should fetch all the shows details from the Shopws.csv fiel and add them to the Shows collection.
            Console.WriteLine("This will fetch Shows");
        }
        public void FetchBookings()
        {
            // This method should fetch all the bookings information and ad them to the Bookings Collection.
            Console.WriteLine("This will fetch Bookings");
        }
        public void AddMovie(Movie obj)
        {
            // if obj ==null throw Null Reference Exception
            // Exception Messsage - "Movie details can't be null."
        }
        public void AddTheatre(Theatre obj)
        {
            // if obj == null thriw Null Reference Exception
            // Exception message - "Theatre details can't be null."
        }
        public void AddCustomers(Customer obj)
        {

        }
        public void AddShows(Show obj)
        {

        }
        public void AddBookings(Booking obj)
        {

        }
        public void DeleteMovie(Movie obj)
        {

        }
        public void DeleteTheatre(Theatre obj)
        {

        }
        public void DeleteCustomers(Customer obj)
        {

        }
        public void DeleteShows(Show obj)
        {

        }
        public void DeleteBookings(Booking obj)
        {

        }
        public void UpdateMovie(Movie obj)
        {

        }
        public void UpdateTheatre(Theatre obj)
        {

        }
        public void UpdateCustomers(Customer obj)
        {

        }
        public void UpdateShows(Show obj)
        {

        }
        public void UpdateBookings(Booking obj)
        {

        }
        public void SearchMovie(Movie obj)
        {

        }
        public void SearchTheatre(Theatre obj)
        {

        }
        public void SearchCustomers(Customer obj)
        {

        }
        public void SearchShows(Show obj)
        {

        }
        public void SearchBookings(Booking obj)
        {

        }
    }
}