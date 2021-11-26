﻿using MySql.Data.MySqlClient.Memcached;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Voitures.Data.Dtos
{
    public class VoituresDtosIn
    {
        public string Modele { get; set; }
        public string Marque { get; set; }
        public string Couleur { get; set; }
        public List<ClientsDtosOut> ListIdClient { get; set; } 
    }

}
