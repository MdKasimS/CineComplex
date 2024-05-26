namespace CineComplex.models
{
    public class Movie
    {
        private int _id;
        private string? movieID;
        private string movieName;
        private string directorName;
        private string producerName;
        private double duration;
        private string story;
        private string genre;
        private string language;

        public int Id { get => _id; set => _id = value; }
        public string? MovieID { get => movieID; set => movieID = value; }
        public string MovieName { get => movieName; set => movieName = value; }
        public string DirectorName { get => directorName; set => directorName = value; }
        public string ProducerName { get => producerName; set => producerName = value; }
        public double Duration { get => duration; set => duration = value; }
        public string Story { get => story; set => story = value; }
        public string Genre { get => genre; set => genre = value; }
        public string Language { get => language; set => language = value; }

        public Movie(string movieName, string directorName, string producerName, string genre, string language, double duration, string story)
        {
            
        }
        public void DisplayMovieDetails()
        {
            Console.WriteLine($"Movie Id : {MovieID}");
            Console.WriteLine($"Movie Name : {MovieName}");
            Console.WriteLine($"Producer Name : {ProducerName}");
            Console.WriteLine($"Director Name : {DirectorName}");
            Console.WriteLine($"Language : {Language}");
            Console.WriteLine($"Duration : {Duration}");
            Console.WriteLine($"Genre : {Genre}");
            Console.WriteLine($"Story : {Story}");
        }
    }
}