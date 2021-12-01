using System;
using System.Collections.Generic;




namespace Aviation.Data.Dtos
{

        public partial class ApparteniragenceDtosIn
        {
            public int? IdAgence { get; set; }
            public int? IdClient { get; set; }

        }

        public partial class ApparteniragenceDtosOut
        {
            public int IdApparteniragence { get; set; }
            public int? IdAgence { get; set; }
            public int? IdClient { get; set; }

        }
        public partial class ApparteniragenceDtosAvecAgence
        {
            public virtual AgenceDtosOut Agence { get; set; }
        }

        public partial class ApparteniragenceDtosAvecAgenceEtClient
        {
            public virtual ClientDtosOut Course { get; set; }
            public virtual AgenceDtosOut Agence { get; set; }
        }

        public partial class ApparteniragenceDtosAvecClient
        {
            public virtual ClientDtosOut Course { get; set; }
        }
}

