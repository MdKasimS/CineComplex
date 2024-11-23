using CineComplex.Classes.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineComplex.ViewModels
{
    public class ManageTicketsViewModel : ABaseSingleton<ManageTicketsViewModel>
    {

        public ManageTicketsViewModel() { }

        public void BookTickets()
        {
            Console.Clear();
            Console.WriteLine("I will back...");
            Console.ReadLine();

        }


    }
}
