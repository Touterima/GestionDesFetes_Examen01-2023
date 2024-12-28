using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GF.Core.Domain
{
    public enum TypeFete
    {
        Anniversaire, 
        Mariage,
        Autre
    }
    public class Fete
    {
        public int IdFete { get; set; }
        public string Description { get; set; }
        public TypeFete Type { get; set; }
        public int NbInvitesMax { get; set; }
        public int Duree { get; set; }
        public DateTime DateFete { get; set; }

        public virtual Salle Salle{ get; set; }
        public virtual IList<Invite> Invites { get; set; }
    }
}
