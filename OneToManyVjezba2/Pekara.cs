using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneToManyVjezba2
{
    public class Pekara
    {
        public int Id { get; set; }
        public string Naziv { get; set; }
        public string Adresa { get; set; }
        public string Vlasnik { get; set; }
        public virtual List <Proizvodi>Proizvod  { get; set; }
        public Pekara()
        {
            Proizvod = new List<Proizvodi>();
        }

    }
}
