using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VetReserve.Models
{
    public class VisitModel
    {
        public int Id { get; set; }
        public string Office { get; set; }
        public string Client { get; set; }
        public string AnimalName { get; set; }
        public string VetName { get; set; }
        public string VetSurname { get; set; }
        public string OfficeAdress { get; set; }
        public DateTime VisitDate { get; set; }
    }
}
