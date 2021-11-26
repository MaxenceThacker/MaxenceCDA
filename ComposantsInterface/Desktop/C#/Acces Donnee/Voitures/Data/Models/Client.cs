using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Voitures.Data.Models
{
    public class Client
    {
        [Key]
        public int IdClient { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
    }
}
