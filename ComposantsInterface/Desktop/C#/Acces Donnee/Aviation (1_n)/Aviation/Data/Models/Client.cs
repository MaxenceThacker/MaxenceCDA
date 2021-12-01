using System;
using System.Collections.Generic;

#nullable disable

namespace Aviation.Data.Models
{
    public partial class Client
    {
        public Client()
        {
            Apparteniragences = new HashSet<Apparteniragence>();
        }

        public int IdClient { get; set; }
        public string NomClient { get; set; }

        public virtual ICollection<Apparteniragence> Apparteniragences { get; set; }
    }
}
