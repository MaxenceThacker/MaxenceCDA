using MySql.Data.MySqlClient.Memcached;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace Voitures.Data.Models
{
    public partial class Voiture
    {
        [Key]
        public int IdVoiture { get; set; }
        public string Marque { get; set; }
        public string Modele { get; set; }
        public string Couleur { get; set; }
        public int IdClient { get; set; }
        public Client Clt { get; set; }
    }
}

