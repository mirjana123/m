using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    [Serializable]
    public class PoslateJednom
    {
        public string DeoTekstaPoruke { get; set; }
        public Korisnik Salje { get; set; }
        public Korisnik Prima { get; set; }
       

    }
}
