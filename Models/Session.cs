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
        public string Token { get; set; } 
        public DateTime LoginTimestamp { get; set; } 
        public DateTime ExpirationTimestamp { get; set; } 
        public User User { get; set; }
        public int UserId { get; set; } 

        //TODO: Please make it in ORM EFCore standard way

        public static async Task<int> CreateSession(Auth auth)
        {
            return await Task.Run(() =>
            {
                Session userSession = new Session()
                {
                    UserId = auth.UserId,
                    Token = Guid.NewGuid().ToString(), // Generate a unique token
                    LoginTimestamp = DateTime.Now,
                    ExpirationTimestamp = DateTime.Now.AddHours(1)
                };

                SQLInteraction.Db.Sessions.Add(userSession);
                SQLInteraction.Db.SaveChanges();

                SessionService.AllSessionDictionary.Add(userSession.Token,userSession);
                Credential.Instance.SessionTokenId = userSession.Token;

                return userSession.Id;
            });
            
        }

        //This implements only one client can login or logout. Limiting screens
        //A new feature for multiple client with subscription can be developed
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
