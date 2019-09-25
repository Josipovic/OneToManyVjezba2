using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneToManyVjezba2
{
    class PekaraContext:DbContext
    {
        public  DbSet<Pekara>Pekare { get; set; }
        public  DbSet<Proizvodi>Proizvodi { get; set; }

    }
}
