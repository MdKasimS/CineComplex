using System.Collections.ObjectModel;

namespace CineComplex.Models
{
    public class Theatre
    {
        public int Id { get; set; }
        public int TheatreNumber { get; set; }
        public int Capacity { get; set; }
        public CinePlex CineComplexOfTheatre { get; set; }
        public int CinePlexId { get; set; }
        public ObservableCollection<Seat> SeatsInTheatre { get; set; }
        public ObservableCollection<Show> AllShowsOfThisTheatre { get; set; }
    }
}