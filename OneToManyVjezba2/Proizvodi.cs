using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneToManyVjezba2
{
    public class Proizvodi
    {
        public int Id { get; set; }
        public string NazivProizvoda { get; set; }
        public int Cijena { get; set; }
        public float Masa { get; set; }
        public string Opis { get; set; }
        public  virtual Pekara Pekara { get; set; }
    }
}
