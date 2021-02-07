using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VetReserve.Models
{
    public class VetModel
    {
        public int Id { get; set; }
        public string VetName { get; set; }
        public string VetSurname { get; set; }
        public string Office { get; set; }
        public string Address { get; set; }
        public string OpeningHours { get; set; }
        public bool IsOpen { get; set; }
        
    }
}
