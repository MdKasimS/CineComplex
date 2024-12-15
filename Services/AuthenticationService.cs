using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text.RegularExpressions;
using CineComplex.Classes;
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

        public static Result<bool> IsValidEmail(string email)
        {
            String theEmailPattern = @"^[\w!#$%&'*+\-/=?\^_`{|}~]+(\.[\w!#$%&'*+\-/=?\^_`{|}~]+)*"
                                   + "@"
                                   + @"((([\-\w]+\.)+[a-zA-Z]{2,4})|(([0-9]{1,3}\.){3}[0-9]{1,3}))\z";
            if(Regex.IsMatch(email, theEmailPattern))
                return new Result<bool>(true, true, "");
            else
                return new Result<bool>(false, false, "Invalid Email Address. Press Any Key To Continue...");
        }

        private bool _isPasswordCorrect()
        {
            return false;
        }

        public static Result<bool> AuthorizeNewUser(User _newUser)
        {
            try
            {
                //:Todo Create proper error handling and message displaying for creds. Currently control doesn't reaches inside if block
                //Added Result mechanism to handle custom error messages
                if (SQLInteraction.Db.Users.Any(u => u.Contact == _newUser.Contact))
                {
                    return new Result<bool>(false, false, "Username already exists. Press any key to continue..."); //false;
                }

                if (SQLInteraction.Db.Users.Any(u => u.Email == _newUser.Email))
                {
                    return new Result<bool>(false, false, "Email already registered. Press any key to continue..."); //false;
                }
                return new Result<bool>(true, true, ""); //true;

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return new Result<bool>(false, false, "Something Unusual Error Occured. Press any key to continue..."); //false;
            }
        }

    }
}
