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

// Booking book = new Booking();