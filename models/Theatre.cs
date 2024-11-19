 namespace CineComplex.Models
{
    public class Theatre
    {
        private int id;
        private string theatreName;
        private int numberOfSeats;

        public int Id { get => id; set => id = value; }
        public string TheatreName { get => theatreName; set => theatreName = value; }
        public int NumberOfSeats { get => numberOfSeats; set => numberOfSeats = value; }

        public void DisplayTheaterDetails()
        {
            Console.WriteLine($"Theatre ID : {Id}");
            Console.WriteLine($"Theatre Name : {TheatreName}");
            Console.WriteLine($"Seating Capacity : {NumberOfSeats}");
        }
    }
}