using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace GF.Core.Domain
{
    public class Salle
    {
        public int IdSalle { get; set; }
        public string NomSalle { get; set; }
        public string AdresseSalle { get; set; }
        public int Capacite { get; set; }
        public Double PrixParHeure { get; set; }

        public IList<Fete> Fetes { get; set; }
    }
}
