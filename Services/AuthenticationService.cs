using System;
using System.Collections.Generic;
using System.Linq;
using CineComplex.Classes.Base;
using CineComplex.Models;

namespace CineComplex.Services
{
    public class AuthenticationService: AServiceBase<AuthenticationService>
    {
       
        public AuthenticationService()
        {
            Console.WriteLine("Authenticaition Service Is On...");
        }

        public static bool AuthenticateUserForGivenCredential()
        {
            if(AuthenticationService.Instance._isValidUser())
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
    }
}
