using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Common;

namespace ServerForma
{
    public class ClientHandler
    {
       

        BinaryFormatter formatter;
        private NetworkStream tok;
        private Korisnik k;

        public ClientHandler(NetworkStream tok, Korisnik k)
        {
            this.tok = tok;
            this.k = k;
            formatter = new BinaryFormatter();
            Thread nit = new Thread(Obradi);
            nit.Start();
            

        }


        private void Obradi()
        {
            try
            {
                int operacija = 0;
                while( operacija != (int)Operacije.Kraj)
                {
                    PomocnaKlasa zahtev = (PomocnaKlasa)formatter.Deserialize(tok);
                    switch (zahtev.Operacija)
                    {
                        case Operacije.SlanjePorukeSvima:
                            Server.SlanjePorukeSvima(zahtev.TekstPoruke, zahtev.Korisnik);

                            break;
                        case Operacije.SlanjePorukeJednom:
                           // SlanjePorukeJednom(zahtev);

                            break;
                        case Operacije.Kraj:
                            //MORAS KRAJ DA DEFINISES !!!!!!!!!!!!!!!!!
                            operacija = 1; // da izadje iz petlje
                            Server.listaTokova.Remove(tok);
                            Server.UlogovaniKorisnici.Remove(k);

                            break;
                        default:

                            Console.WriteLine("DEFAULT");
                            break;
                    }

                }

            }
            catch(Exception ex)
            {
                //try
                //{
                //    Server.listaTokova.Remove(tok);
                //    Server.UlogovaniKorisnici.Remove(k);
                //}
                //catch(Exception exc)
                //{
                    MessageBox.Show(">>>" + ex);
                //    MessageBox.Show(">>>" + exc);
                //}
               
            }


        }


        



        //public EventHandler OdjavljenKlijent;
        //private bool kraj = false;
        //private object lockobject = new object();


        //internal void CloseSocket()
        //{
        //    lock (lockobject)
        //    {
        //        if (socket != null)
        //        {
        //            kraj = true;
        //            socket.Shutdown(SocketShutdown.Both);
        //            socket.Close();
        //            socket = null;
        //            OdjavljenKlijent?.Invoke(this, EventArgs.Empty);
        //        }
        //    }
        //}
    }
}
