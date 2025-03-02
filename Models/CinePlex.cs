using CineComplex.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace CineComplex.Models
{
    public class CinePlex
    {
        public int Id { get; set; }
        public string FranchiseOperator { get; set; }
        public int NumberOfTheatres { get; set; }
        public UserProfile Profile { get; set; }       
        public int UserProfileId { get; set; }

        public static async Task CreateNewCinePlex(CinePlex _newCinePlex)
        {
            await Task.Run(() =>
            {
                SQLInteraction.Db.UserProfiles.Add(_newCinePlex.Profile);
                SQLInteraction.Db.SaveChangesAsync();

                _newCinePlex.UserProfileId = _newCinePlex.Profile.Id;
                SQLInteraction.Db.Cineplexes.Add(_newCinePlex);
                SQLInteraction.Db.SaveChangesAsync();

            });
        }
    }
}
