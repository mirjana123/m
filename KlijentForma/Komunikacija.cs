using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KlijentForma
{
    public class Komunikacija
    {
        private static Komunikacija instance;
        NetworkStream stream;
        BinaryFormatter formatter = new BinaryFormatter();
        Socket socket;
        public Komunikacija()
        {

        }

        public static Komunikacija Instance
        {
            get
            {
                if (instance == null) instance = new Komunikacija();
                return instance;
            }
        }

        public PomocnaKlasa PrijaviSe(string ime, string sifra)
        {
            socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            socket.Connect("127.0.0.1", 9090);
            stream = new NetworkStream(socket);
            Korisnik k = new Korisnik();
            k.Email = ime;
            k.Sifra = sifra;
            PomocnaKlasa zahtevOdKlijenta = new PomocnaKlasa { Korisnik = k };
            formatter.Serialize(stream, zahtevOdKlijenta);
            PomocnaKlasa odg = (PomocnaKlasa)formatter.Deserialize(stream);
            if (!odg.Ulogovan)
            {
                socket.Close();
                MessageBox.Show(odg.Odgovor);

            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Uspesno povezan sa serverom!");

            }
            return odg;
        }

        public void PosaljiPoruku(PomocnaKlasa z)
        {
            formatter.Serialize(stream, z);
        }

        public PomocnaKlasa ProcitajPorukuOdServera()
        {
            return (PomocnaKlasa)formatter.Deserialize(stream);
        }





    }
}
