using Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServerForma
{
    public class Server
    {
        Socket socket;
        List<ClientHandler> listHandlers = new List<ClientHandler>();
        private Repozitorijum r = new Repozitorijum();
        private List<Korisnik> registrovaniKorisnici = new List<Korisnik>();
        public static List<Korisnik> UlogovaniKorisnici = new List<Korisnik>();
        public static List<NetworkStream> listaTokova = new List<NetworkStream>();
        public static BindingList<PoslatePoruke> listaPoslatihPoruka = new BindingList<PoslatePoruke>();
        BinaryFormatter formatter1 = new BinaryFormatter();
        internal bool Start()
        {
            try
            {
                socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                IPEndPoint endpoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 9090);
                socket.Bind(endpoint);
                Thread nit = new Thread(Osluskuj);
                nit.Start();
                nit.IsBackground = true;
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(">>>>" + ex);
                return false;
            }


        }

      

        void Osluskuj()
        {
            try
            {
                while (true)
                {
                    socket.Listen(5);
                    Socket klijentskiSoket = socket.Accept();
                    NetworkStream tok = new NetworkStream(klijentskiSoket);
                    BinaryFormatter formatter = new BinaryFormatter();

                    // ovo pomocna dole je kao zahtev od klijenta 
                    PomocnaKlasa transfer = (PomocnaKlasa)formatter.Deserialize(tok);
                    Korisnik k = transfer.Korisnik;

                    registrovaniKorisnici = r.vratiListuKorisnika();

                    // provera korisnika
                    
                    if (UlogovaniKorisnici.Contains(transfer.Korisnik))
                    {
                        transfer.Ulogovan = false;
                        transfer.Odgovor = "Korisnik vec ulogovan";
                        formatter.Serialize(tok, transfer);
                    }
                    else  if (!ProveraLogin(transfer.Korisnik))
                    {
                        transfer.Ulogovan = false;
                        transfer.Odgovor = "Greska";
                        formatter.Serialize(tok, transfer);

                    } else  
                    {

                        transfer.Ulogovan = true;

                        new ClientHandler(tok, k);
                        listaTokova.Add(tok);
                        UlogovaniKorisnici.Add(k);
                        transfer.ListaKorisnika = UlogovaniKorisnici;
                        formatter.Serialize(tok, transfer);
                    }


                }

            }
            catch (Exception ex)
            {
                Debug.WriteLine(">>>" + ex.Message);
            }
        }

        public bool ProveraLogin(Korisnik k)
        {
            foreach (Korisnik u in r.vratiListuKorisnika())
            {
                if (u.Email == k.Email && u.Sifra == k.Sifra)
                {
                    return true;
                }
               
            }
            return false;
        }


        public static void SlanjePorukeSvima(string tekstPoruke, Korisnik k)
        {   

            PoslatePoruke pp = new PoslatePoruke();
            if (tekstPoruke.Length > 20)
            {
                pp.DeoTekstaPoruke = tekstPoruke.Substring(0, 20);
            }
            else
            {
                pp.DeoTekstaPoruke = tekstPoruke;
            }
            pp.Salje = k;
            listaPoslatihPoruka.Add(pp);
            

        }


        internal void Stop()
        {
            
            foreach (NetworkStream tok in listaTokova.ToList())
            {
                tok.Dispose();
            }
            socket.Close();
        }
    }
}
