using System;
using System.Collections.Generic;
using System.Linq;
using CineComplex.Classes.Base;
using CineComplex.Classes.SQL;
using CineComplex.Models;

namespace CineComplex.Services
{
    public class AuthenticationService : AServiceBase<AuthenticationService>
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
            //Credential.Instance.LoginId

            //Code to Check in database

            //Make it red after using Spectre
            System.Console.WriteLine("Alert: A malicious user logged in");
            return false;
        }

        private bool _isPasswordCorrect()
        {
            return false;
        }

        public static async Task<bool> IsValidRegistration(User _newUser)
        {
            await Task.Run(() =>
            {
                if (string.IsNullOrWhiteSpace(_newUser.Username) || string.IsNullOrWhiteSpace(_newUser.Password) || string.IsNullOrWhiteSpace(_newUser.Email))
                {
                    Console.WriteLine("All fields are required.");
                    return false;
                }

                if (!System.Text.RegularExpressions.Regex.IsMatch(_newUser.Email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
                {
                    Console.WriteLine("Invalid email format.");
                    return false;
                }

                using (var context = new CineComplexDb())
                {
                    if (context.Users.Any(u => u.Contact == _newUser.Contact))
                    {
                        Console.WriteLine("Username already exists.");
                        return false;

                    }

                    if (context.Users.Any(u => u.Email == _newUser.Email))
                    {
                        Console.WriteLine("Email already registered.");
                        return false;

                    }
                }
                        return false;

            });
            return true;
        }
    }
}
