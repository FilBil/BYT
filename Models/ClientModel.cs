using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace VetReserve.Models
{
    public class ClientModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string AnimalName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
    }
}
