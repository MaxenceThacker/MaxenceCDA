using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filrouge.Data.Dtos
{
    public class ApprovisionnementsDTOIn
    {
        public int? IdProduit { get; set; }
        public int? IdFournisseur { get; set; }
        public string RefFournisseur { get; set; }
    }

    public class ApprovisionnementsDTOOut
    {
        public int IdApprovisionnement { get; set; }
        public int? IdProduit { get; set; }
        public string LibelleProduit { get; set; }
        public string RefProduit { get; set; }
        public int? IdFournisseur { get; set; }
        public string NomFournisseur { get; set; }
        public string RefFournisseur { get; set; }
    }
}
