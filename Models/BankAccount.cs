using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineComplex.Models
{
    public class BankAccount
    {
        public int Id { get; set; }
        public string AccountNumber { get; set; }
        public string GSTNumber { get; set; }
        public string BankName { get; set; }
        public string IFSCNumber { get; set; }
        public string AccountHolderName { get; set; }
        public int UserProfileId { get; set; }
        public UserProfile UserProfile { get; set; }

        public static async Task CreateNewBankAccount(BankAccount _newAccount)
        {
            await Task.Run(() =>
            {
                SQLInteraction.Db.Attach(_newAccount.UserProfile);
                SQLInteraction.Db.BankAccounts.Add(_newAccount);
                SQLInteraction.Db.SaveChanges();

            });
        }

    }
}
