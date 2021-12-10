using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filrouge.Data.Dtos
{
    public class RolesDTOIn
    {
        public string LibelleRole { get; set; }
    }

    public class RolesDTOOut
    {
        public int IdRole { get; set; }
        public string LibelleRole { get; set; }
    }
}
