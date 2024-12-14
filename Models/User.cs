using CineComplex.Classes.SQL;
using CineComplex.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineComplex.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Contact { get; set; }

        public static async Task CreateNewUser(User _newUser)
        {
            await Task.Run(() =>
            {
                SQLInteraction.Db.Users.Add(_newUser);
                SQLInteraction.Db.SaveChanges();

                SQLInteraction.Db.Auths.Add(new Auth()
                {
                    UserId = _newUser.Id,
                    Password = _newUser.Password,
                    PrivilegeLevel = 0
                });
                SQLInteraction.Db.SaveChanges();

            });
        }

        private static bool AreAllFieldsForRegistartionAvailable(User _newUser)
        {
            if (string.IsNullOrWhiteSpace(_newUser.Username)
                || string.IsNullOrWhiteSpace(_newUser.Password)
                || string.IsNullOrWhiteSpace(_newUser.Email))
            {
                return false;  
            }
            return true;
        }
        public static bool IsValidUserRegistration(User _newUser)
        {
           //:TODO please remove any view related code
           if(AreAllFieldsForRegistartionAvailable(_newUser))
            {
                if (!AuthenticationService.IsValidEmail(_newUser.Email))
                {
                    return false;
                }
            return AuthenticationService.AuthorizeNewUser(_newUser);
            }
            return false;

            
            
        }

    }
}
