using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aviation.Data.Dtos
{

        public partial class ClientDtosIn
        {
            public ClientDtosIn()
            {
            }

            public string NomClient { get; set; }

        }


        public partial class ClientDtosOut
        {
            public ClientDtosOut()
            {
            }

            public string NomClient { get; set; }

        }


        public partial class ClientDtosAvecApparteniragence
        {
            public ClientDtosAvecApparteniragence()
            {
                Apparteniragences = new HashSet<ApparteniragenceDtosOut>();
            }

            public int IdClient { get; set; }
            public string NomClient { get; set; }

            public virtual ICollection<ApparteniragenceDtosOut> Apparteniragences { get; set; }
        }
}

