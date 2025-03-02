using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineComplex.Models
{
    public class Address
    {
        public int Id { get; set; }
        public string BuildingDetails { get; set; }
        public string Area { get; set; }
        public string StreetName { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string PinCode { get; set; }
        public string OtherDetails { get; set; }

    }
}
