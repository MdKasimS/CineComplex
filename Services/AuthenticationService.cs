﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text.RegularExpressions;
using CineComplex.Classes;
using CineComplex.Classes.Base;
using CineComplex.Classes.SQL;
using CineComplex.Interfaces;
using CineComplex.Models;
using Microsoft.IdentityModel.Tokens;

namespace CineComplex.Services
{
    public class AuthenticationService : AServiceBase<AuthenticationService>, IService
    {

        public AuthenticationService()
        {
            Console.WriteLine("Authenticaition Service Is On...");
        }

        public static Result<bool> AuthenticateUserForGivenCredential()
        {
            if (!Credential.Instance.LoginId.IsNullOrEmpty() && !Credential.Instance.Password.IsNullOrEmpty())
            {
                Result<bool> emailValidationResult = AuthenticationService.IsValidEmail(Credential.Instance.LoginId);

                if (emailValidationResult.IsSuccessful)
                {
                    
                    User userToAuthenticate = SQLInteraction.Db.Users.FirstOrDefault(u => u.Email == Credential.Instance.LoginId);

                    if (userToAuthenticate != null)
                    {
                        Auth auth = SQLInteraction.Db.Auths.FirstOrDefault(a => a.UserId == userToAuthenticate.Id);
                        if (auth != null && auth.Password == Credential.Instance.Password)
                        {
                            SessionService.LogSession(auth);
                            return new Result<bool>(true, true, $"User {Credential.Instance.LoginId} Logged In..."); //false;
                        }
                        return new Result<bool>(false, false, $"Authentication Failed... Press Any Key To Continue.");
                    }
                   
                    return new Result<bool>(false, false, $"User {Credential.Instance.LoginId} Doesn't Exists... Press Any Key To Continue.");
                }
                return emailValidationResult;
            }

            return new Result<bool>(false, false, "All Fields Are Needed... Press Any Key To Continue.");
        }



        /// <summary>
        /// Check at https://www.rhyous.com/2010/06/15/csharp-email-regular-expression/
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        public static Result<bool> IsValidEmail(string email)
        {

            String theEmailPattern = @"^[\w!#$%&'*+\-/=?\^_`{|}~]+(\.[\w!#$%&'*+\-/=?\^_`{|}~]+)*"
                                   + "@"
                                   + @"((([\-\w]+\.)+[a-zA-Z]{2,4})|(([0-9]{1,3}\.){3}[0-9]{1,3}))\z";
            if (Regex.IsMatch(email, theEmailPattern))
                return new Result<bool>(true, true, "");
            else
                return new Result<bool>(false, false, "Invalid Email Address. Press Any Key To Continue...");
        }

        public static Result<bool> AuthorizeNewUser(User _newUser)
        {
            try
            {
                //:Todo Create proper error handling and message displaying for creds. Currently control doesn't reaches inside if block
                //Added Result mechanism to handle custom error messages
                if (SQLInteraction.Db.Users.Any(u => u.Contact == _newUser.Contact))
                {
                    return new Result<bool>(false, false, "Contact already exists. Press any key to continue..."); //false;
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
