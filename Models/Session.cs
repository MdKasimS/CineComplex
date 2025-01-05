using CineComplex.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineComplex.Models
{
    public class Session 
    { 
        public int Id { get; set; } 
        public int UserId { get; set; } 
        public string Token { get; set; } 
        public DateTime LoginTimestamp { get; set; } 
        public DateTime ExpirationTimestamp { get; set; } 

        public async static Task CreateSession(Auth auth)
        {
            await Task.Run(() =>
            {
                Session userSession = new Session()
                {
                    UserId = 2,
                    Token = Guid.NewGuid().ToString(), // Generate a unique token
                    LoginTimestamp = DateTime.Now,
                    ExpirationTimestamp = DateTime.Now.AddHours(1)
                };

                SQLInteraction.Db.Sessions.Add(userSession);
                SQLInteraction.Db.SaveChanges();

                SessionService.AllSessionDictionary.Add(userSession.Token,userSession);
                Credential.Instance.SessionTokenId = userSession.Token;
            });
        }

        public async static Task DeleteSession(string tokenId)
        {
            Session session = SQLInteraction.Db.Sessions.FirstOrDefault(s => s.Token == tokenId); 
            if (session != null) 
            {
                SQLInteraction.Db.Sessions.Remove(session);
                SQLInteraction.Db.SaveChanges();
            }
        }
    }
}
