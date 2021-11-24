using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Personnes.Data.Dtos
{
    public class PersonnesDTO
    {
        public string Nom { get; set; }
        public string Prenom { get; set; }

        internal void Dump()
        {
            throw new NotImplementedException();
        }
    }
}
