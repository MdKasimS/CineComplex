using System;
using System.Collections.Generic;
using System.Linq;
using CineComplex.Classes.Base;
using CineComplex.Classes.SQL;
using CineComplex.Interfaces;
using CineComplex.Models;

namespace CineComplex.Services
{
    public class AuthenticationService : AServiceBase<AuthenticationService>, IService
    {

        public AuthenticationService()
        {
            Console.WriteLine("Authenticaition Service Is On...");
        }

        public static bool AuthenticateUserForGivenCredential()
        {
            if (AuthenticationService.Instance._isValidUser())
            {
                Console.WriteLine($"User {Credential.Instance.LoginId} logged in.");
                return true;
            }
            return false;
        }

        private bool _isValidUser()
        {
            Console.WriteLine("Alert: A malicious user logged in");
            return false;
        }

        private bool _isPasswordCorrect()
        {
            return false;
        }

        public static bool AuthorizeNewUser(User _newUser)
        {
            try
            {
                
                if (SQLInteraction.Db.Users.Any(u => u.Contact == _newUser.Contact))
                {
                    Console.Clear();
                    Console.WriteLine("Username already exists. Press any key to continue...");
                    Console.ReadKey();
                    return false;

                }

                if (SQLInteraction.Db.Users.Any(u => u.Email == _newUser.Email))
                {
                    Console.Clear();
                    Console.WriteLine("Email already registered. Press any key to continue...");
                    Console.ReadKey();
                    return false;

                }
                return true;

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }

    }
}
