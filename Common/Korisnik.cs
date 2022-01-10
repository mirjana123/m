using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{   
    [Serializable]
    public class Korisnik
    {
        public override bool Equals(object obj)
        {
            var v = obj as Korisnik;
            return (v != null && v.Email == this.Email && v.Sifra == this.Sifra);
        }
        public override string ToString()
        {
            return Email;
        }


        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Email { get; set; }
        public string Sifra { get; set; }

    }
}
