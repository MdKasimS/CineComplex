using CineComplex;
using OrderBooking;

Console.WriteLine("\t----- Salam Hindusthan !!! -----");
Console.WriteLine("============================================");
Console.Write("Theatres : 4                       Shows : 16\n");

Movie movie = new Movie("alhamdulillah" ,"kasim", "sache", "is", 8976.67, "great", "Mashallah" );

movie.DisplayMovieDetails();

Theatre theatre = new Theatre("PVRT-1", 500);
theatre.DisplayTheaterDetails();

Customer customer = new Customer("Vipul Bajaj", "Pune");
customer.DisplayCustomerDetails();

Booking book = new Booking(3234, "Vipul Bajaj", 4, "Platinum", "vb66@gmail.com", 459.65m);

Show show = new Show(456, 112, new DateTime(2023, 02, 01, 10, 30, 00) , new DateTime(2023, 02, 01, 13, 40, 00), 110.25m, 90.00m, 80.50m);
show.DisplayShowDetails();