 namespace CineComplex.Models
{
    public class Theatre
    {
        public int Id { get; set; }
        public CinePlex CineComplexOfTheatre { get; set; }
        public int CinePlexId { get; set; }
    }
}