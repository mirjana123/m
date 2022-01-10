using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerForma
{
   public class Repozitorijum
   {
        private List<Korisnik> listaKorisnika;

        public Repozitorijum()
        {
            listaKorisnika = new List<Korisnik>();

            listaKorisnika.Add(new Korisnik { Ime = "К1-ime", Prezime = "К1-prezime", Email = "k1@gmail.com", Sifra ="sifra1" });
            listaKorisnika.Add(new Korisnik { Ime = "К2-ime", Prezime = "К2-prezime", Email = "k2@gmail.com", Sifra = "sifra2" });
            listaKorisnika.Add(new Korisnik { Ime = "К3-ime", Prezime = "К3-prezime", Email = "k3@gmail.comm", Sifra = "sifra3" });
            listaKorisnika.Add(new Korisnik { Ime = "К4-ime", Prezime = "К4-prezime", Email = "k4@gmail.com", Sifra = "sifra4" });


        }

        public List<Korisnik> vratiListuKorisnika()
        {
            return listaKorisnika;
        }
    }
}
