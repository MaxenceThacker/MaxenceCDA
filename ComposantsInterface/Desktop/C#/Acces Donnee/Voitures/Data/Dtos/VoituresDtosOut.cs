using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Voitures.Data.Dtos
{
    public class VoituresDtosOut
    {
        public string Marque { get; set; }
        public string Modele { get; set; }
        public string Couleur { get; set; }
        public ClientsDtosOut Clt { get; set; }
    }
}
