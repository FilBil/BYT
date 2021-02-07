using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VetReserve.Models
{
    public class PatientCardModel
    {
        public int Id { get; set; }
        public string AnimalName { get; set; }
        public bool IsIll { get; set; }
        public string Medicines { get; set; }
        public int Dose { get; set; }
    }
}
