using CineComplex.Classes.Base;
using CineComplex.Interfaces;
using CineComplex.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineComplex.Services
{
    public class SessionService : AServiceBase<SessionService>, IService
    {
        public static async void TerminateSession(string tokenId)
        {
            await Session.DeleteSession(tokenId);
        }

        public static async Task LogSession(Auth auth)
        {
            await Session.CreateSessionAsync(auth);

        }
      
    }
}
