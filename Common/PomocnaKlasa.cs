using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{

    public enum Operacije
    {
        Kraj = 1,
        SlanjePorukeSvima,
        SlanjePorukeJednom
    }

    [Serializable]
    public class PomocnaKlasa
    {
       
        public Operacije Operacija { get; set; }
        public Korisnik Korisnik { get; set; }
        public string Odgovor { get; set; }
        public bool Ulogovan { get; set; }
        public List<Korisnik> ListaKorisnika { get; set; }
        public string TekstPoruke { get; set; }
        public Korisnik PosebanPrimalacPoruke { get; set; }
        public BindingList<PoslatePoruke> listaPoslatihPoruka { get; set; }
    }
}
