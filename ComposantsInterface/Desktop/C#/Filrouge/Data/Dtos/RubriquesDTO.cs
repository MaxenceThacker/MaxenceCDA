using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filrouge.Data.Dtos
{
    public class RubriquesDTOIn
    {
        public string LibelleRubrique { get; set; }
        public int IdRubriqueMere { get; set; }
    }

    public class RubriquesRubriquesMereDTOOut
    {
        public int IdRubrique { get; set; }
        public string LibelleRubrique { get; set; }
        public int IdRubriqueMere { get; set; }
    }

    public class RubriquesDTOOut
    {
        public int IdRubrique { get; set; }
        public string LibelleRubrique { get; set; }
    }

}
