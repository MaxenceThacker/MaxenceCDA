using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Voitures.Data.Dtos
{
    public class ClientsDtosPut
    {
        public int IdClient { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
    }
}
