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
        public User UserAccount { get; set; }
        public BankAccount BankDetails { get; set; }
        public Address AddressDetails { get; set; }

        public int AddressId { get; set; }
        public int UserId { get; set; }
        public int BankAccountId { get; set; }

        public static async Task CreateNewCinePlex(CinePlex _newCinePlex)
        {
            await Task.Run(() =>
            {
                SQLInteraction.Db.Users.Add(_newCinePlex.UserAccount);
                SQLInteraction.Db.SaveChangesAsync();

                SQLInteraction.Db.Addresses.Add(_newCinePlex.AddressDetails);
                SQLInteraction.Db.SaveChangesAsync();

                SQLInteraction.Db.BankAccounts.Add(_newCinePlex.BankDetails);
                SQLInteraction.Db.SaveChangesAsync();

                SQLInteraction.Db.Auths.Add(new Auth()
                {
                    UserId = _newCinePlex.UserAccount.Id,
                    Password = _newCinePlex.UserAccount.Password,
                    PrivilegeLevel = 0
                });
                SQLInteraction.Db.SaveChangesAsync();

                SQLInteraction.Db.Cineplexes.Add(_newCinePlex);
                SQLInteraction.Db.SaveChangesAsync();

            });
        }
    }
}
