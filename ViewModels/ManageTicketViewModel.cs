using CineComplex.Interfaces;
using CineComplex.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineComplex.ViewModels
{
    public class ManageTicketViewModel : IViewModel
    {
        private static ManageTicketViewModel _instance;

        public static ManageTicketViewModel Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ManageTicketViewModel();
                }
                return _instance;
            }
        }

        private ManageTicketViewModel() { }

        public void BookTickets()
        {
            Console.Clear();
            Console.WriteLine("I will back...");
            Console.ReadLine();

            //HomeView screen = new HomeView();
            //screen.View();
        }


    }
}
