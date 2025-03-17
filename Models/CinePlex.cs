using CineComplex.Interfaces;
using CineComplex.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace CineComplex.Models
{
    public class CinePlex // Almost similar to User enity
    {
        //TODO: Create issue to update Cineplex by removing User specific Properties
        public int Id { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Contact { get; set; }
        public string OperatorName { get; set; }
        public string CineplexName { get; set; }
        public int NumberOfTheatres { get; set; }
        public UserProfile AccountProfile { get; set; }       
        public int AccountProfileId { get; set; }
        public ObservableCollection<Theatre> Theatres { get; set; }

        public static async Task CreateNewCinePlex(CinePlex _newCinePlex)
        {
            await Task.Run(() =>
            {
                SQLInteraction.Db.UserProfiles.Add(_newCinePlex.AccountProfile);
                SQLInteraction.Db.SaveChangesAsync();

                _newCinePlex.AccountProfileId = _newCinePlex.AccountProfile.Id;
                SQLInteraction.Db.Cineplexes.Add(_newCinePlex);
                SQLInteraction.Db.SaveChangesAsync();

            });
        }
    }
}
