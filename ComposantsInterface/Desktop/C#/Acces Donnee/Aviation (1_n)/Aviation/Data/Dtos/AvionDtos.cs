using Aviation.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aviation.Data.Dtos
{

    public partial class AvionDtosIn
    {
        public AvionDtosIn()
        {
        }

        public string TypeAvion { get; set; }
        public int IdAgence { get; set; }

    }


    public partial class AvionDtosOut
    {
        public AvionDtosOut()
        {

        }

        public string TypeAvion { get; set; }
    }

    public partial class AvionDtosAvecAgence
    {
        public AvionDtosAvecAgence()
        {
        }

        public string TypeAvion { get; set; }
        public int IdAgence { get; set; }

        public virtual Agence Agence { get; set; }
    }



}
