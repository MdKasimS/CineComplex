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
            //var context = new CineComplexDb();
            Console.WriteLine("Creating new user...");
            await Task.Run(() =>
            {
                SQLInteraction.Db.Users.Add(_newUser);
                SQLInteraction.Db.SaveChanges();
            });
        }

        public static bool IsValidUserRegistration(User _newUser)
        {
           
            if (string.IsNullOrWhiteSpace(_newUser.Username) || string.IsNullOrWhiteSpace(_newUser.Password) || string.IsNullOrWhiteSpace(_newUser.Email))
            {
                Console.Clear();
                Console.WriteLine("All fields are required. Press any key to continue...");
                Console.ReadKey();
                return false;
            }

            if (!System.Text.RegularExpressions.Regex.IsMatch(_newUser.Email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                Console.Clear();
                Console.WriteLine("Invalid email format. Press any key to continue...");
                Console.ReadKey();
                return false;
            }
            return AuthenticationService.AuthorizeNewUser(_newUser);
            
        }

    }
}
