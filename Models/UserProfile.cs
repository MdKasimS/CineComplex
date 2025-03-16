using CineComplex.Interfaces;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineComplex.Models
{
    public class UserProfile
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public User UserAccount { get; set; } = null!;

        public ObservableCollection<Address> AddressDetails { get; set; } 
        public ObservableCollection<BankAccount> BankDetails { get; set; }
        public ObservableCollection<CinePlex> CinePlexes { get; set; }
        public ObservableCollection<Theatre> TheatresInCineplex { get; set; }
        public static UserProfile GetUserProfileByUserId(int userId)
        {
            return SQLInteraction.Db.UserProfiles.FirstOrDefault(up => up.UserId == userId);
        }
    }
}
