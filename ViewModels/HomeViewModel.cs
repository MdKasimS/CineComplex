﻿using CineComplex.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CineComplex.Interfaces;
using CineComplex.Classes;


namespace CineComplex.ViewModels
{
    public class HomeViewModel : ABaseSingleton<HomeViewModel>
    {
        //private static HomeViewModel _instance;

        //public static HomeViewModel Instance
        //{
        //    get 
        //    { 
        //        if(_instance==null)
        //        {
        //            _instance = new HomeViewModel();
        //        }
        //        return _instance; 
        //    }
        //}

        public HomeViewModel() { }

        public void LoginPrompt()
        {
            Console.Write("Enter LoginID : ");
            Credential.Instance.LoginId = Console.ReadLine();
            Console.Clear();
        }
        public void PasswordPrompt()
        {
            Console.Write("Enter Password : ");
            Credential.Instance.Password = Console.ReadLine();
            Console.Clear();
        }
    }
}
