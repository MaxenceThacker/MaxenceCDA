using ECF.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECF.Data.DTOs
{
    public class GroupesDTOIn
    {
        public string Logo { get; set; }
        public int NombreDeFollowers { get; set; }
        public string NomDuGroupe { get; set; }
    }

    public class GroupesDTOOut
    {
        public int IdGroupe { get; set; }
        public string Logo { get; set; }
        public int NombreDeFollowers { get; set; }
        public string NomDuGroupe { get; set; }
    }

    public class GroupesDTOOutAvecMusiciens
    {
        public GroupesDTOOutAvecMusiciens()
        {
            ListeMusiciens = new HashSet<Musicien>();
        }
        public int IdGroupe { get; set; }
        public string Logo { get; set; }
        public int NombreDeFollowers { get; set; }
        public string NomDuGroupe { get; set; }
        public virtual ICollection<Musicien> ListeMusiciens { get; set; }
    }
}
