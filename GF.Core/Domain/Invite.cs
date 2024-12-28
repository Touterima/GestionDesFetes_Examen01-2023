using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GF.Core.Domain
{
    public class Invite
    {
        public int IdInvite { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public DateTime DateNaissance { get; set; }
        public string AdresseInvite { get; set; }

        public virtual IList<Fete> Fetes { get; set; }
    }
}


/*
--> table par hierarchy configuartion:  (une seule table)
Map<Biological> (b=>b.requires("IsBiological").HasValue(1))
Map<Chimical> (c=>c.requires("IsBiological").HasValue(0))

--> table per type configuration:
Map<Biological> (b=>b.ToTable("Biologicals"))
Map<Chimical> (b=>b.ToTable("Chimicals"))

--> table per concrete type configuartion
Map<Biological> (b=>b.ToTable("Biologicals").MapInheritedProperties());
Map<Chimical> (b=>b.ToTable("Chimicals").MapInheritedProperties());

classe Product doit etre asbract

 */