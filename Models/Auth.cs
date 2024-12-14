using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineComplex.Services
{
    public class Auth
    {
        public int UserId { get; set; }
        public string Password { get; set; }
        public byte PrivilegeLevel { get; set; }

    }
}
