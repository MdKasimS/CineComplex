using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineComplex.Models
{
    public class UserProfile
    {
        public int Id { get; set; }
        public User UserAccount { get; set; }
        public Address AddressDetails { get; set; }
        public BankAccount BankDetails { get; set; }
        public int UserId { get; set; }
        public int AddressId { get; set; }
        public int BankAccountId { get; set; }
    }
}
