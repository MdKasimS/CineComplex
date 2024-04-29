namespace CineComplex.models
{
    public class Movie
    {
        public string? MovieID;
        private string? MovieName;
        private string? DirectorName;
        private string? ProducerName;
        private string? Story;
        private string? Genre;
        private string? Language;
        private double? Duration;

        public Movie()
        {
            Console.WriteLine("This is Movie Class");
        }
        public Movie(string movieName,
                     string producerName,
                     string directorName,
                     string lang,
                     double duration,
                     string genre,
                     string story)
        {

            setDirectorName(directorName);
            setDuration(duration);
            setGenre(genre);
            setLanguage(lang);
            setMovieName(movieName);
            setProducerName(producerName);
            setStory(story);
            setMovieId(movieName.Substring(0, 2) + "-" + directorName.Substring(0, 2) + "-" + genre.Substring(0, 2) + "-" + lang.Substring(0, 2));
        }

        public void setMovieId(string m)
        {
            MovieID = m;
        }

        public string? getMovieId()
        {
            return MovieID;
        }

        public void setMovieName(string m)
        {
            MovieName = m;
        }
        public string? getMovieName()
        {
            return MovieName;
        }

        public void setDirectorName(string d)
        {
            DirectorName = d;
        }

        public string? getDirectorName()
        {
            return DirectorName;
        }

        public void setProducerName(string p)
        {
            ProducerName = p;
        }

        public string? getProducerName()
        {
            return ProducerName;
        }

        public void setGenre(string g)
        {
            Genre = g;
        }

        public string? getGenre()
        {
            return Genre;
        }

        public string? getStory()
        {
            return Story;
        }

        public void setStory(string s)
        {
            Story = s;
        }

        public string? getLanguage()
        {
            return Language;
        }

        public void setLanguage(string l)
        {
            Language = l;
        }

        public double? getDuration()
        {
            return Duration;
        }

        public void setDuration(double d)
        {
            Duration = d;
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