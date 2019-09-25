using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneToManyVjezba2
{
    class Program
    {
        static void Main(string[] args)
        {
            PekaraContext db = new PekaraContext();

            Pekara a = new Pekara();
            a.Adresa = "trg slobode 4";
            a.Naziv = "Kadulja";
            a.Vlasnik = "vlasnik1";

            Pekara b = new Pekara();
            b.Adresa = "ante starcevica 2";
            b.Naziv = "europa";
            b.Vlasnik = "vlasnik2";

            Proizvodi c = new Proizvodi();
            c.Opis = "opis bureka";
            c.Masa = 200f;
            c.NazivProizvoda = "burek";
            c.Cijena = 6;


            Proizvodi d = new Proizvodi();
            d.Opis = "opis kifle";
            d.Masa = 100f;
            d.NazivProizvoda = "kifla";
            d.Cijena = 2;


            Proizvodi e = new Proizvodi();
            e.Opis = "opis sendvic";
            e.Masa = 500f;
            e.NazivProizvoda = "sendvic";
            e.Cijena = 5;

            a.Proizvod.Add(c);
            a.Proizvod.Add(d);
            b.Proizvod.Add(e);

            db.Pekare.Add(a);
            db.Pekare.Add(b);

            db.SaveChanges();


            foreach (var p in db.Pekare) {
                Console.WriteLine(p.Naziv);
                foreach (var pro in p.Proizvod) {
                    Console.WriteLine("     " + pro.NazivProizvoda + "  " + pro.Cijena);
                }

            }


            Console.Read();
        }
    }
}
