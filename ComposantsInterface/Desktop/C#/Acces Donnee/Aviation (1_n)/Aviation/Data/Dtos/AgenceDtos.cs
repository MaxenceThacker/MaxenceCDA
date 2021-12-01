using Aviation.Data.Models;
using System;
using System.Collections.Generic;



namespace Aviation.Data.Dtos
{

        public partial class AgenceDtosIn
        {
            public AgenceDtosIn()
            {
            }

            public string NomAgence { get; set; }

        }

        public partial class AgenceDtosOut
        {
            public AgenceDtosOut()
            {
            }

            public string NomAgence { get; set; }
        }


        public partial class AgenceDtosAvecApparteniragenceEtAvion
        {
            public AgenceDtosAvecApparteniragenceEtAvion()
            {
                Apparteniragences = new HashSet<ApparteniragenceDtosOut>();
                Avions = new HashSet<AvionDtosOut>();
            }

            public int IdAgence { get; set; }
            public string NomAgence { get; set; }

            public virtual ICollection<ApparteniragenceDtosOut> Apparteniragences { get; set; }
            public virtual ICollection<AvionDtosOut> Avions { get; set; }
        }

        public partial class AgenceDtosAvecApparteniragence
        {
            public AgenceDtosAvecApparteniragence()
            {
                Apparteniragences = new HashSet<ApparteniragenceDtosOut>();
            }

            public int IdAgence { get; set; }
            public string NomAgence { get; set; }

            public virtual ICollection<ApparteniragenceDtosOut> Apparteniragences { get; set; }
        }

        public partial class AgenceDtosAvecAvion
        {
            public AgenceDtosAvecAvion()
            {
                Avions = new HashSet<AvionDtosOut>();
            }

            public int IdAgence { get; set; }
            public string NomAgence { get; set; }

            public virtual ICollection<AvionDtosOut> Avions { get; set; }
        }
}

