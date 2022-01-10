using Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServerForma
{
    public partial class FrmServer : Form
    {
        Timer t;
        Server server;

        public FrmServer()
        {
            
            InitializeComponent();
            btnStart.Enabled = true;
            btnStop.Enabled = false;
        }

        private void Osvezi(object sender, EventArgs e)
        {
            
                BinaryFormatter formatter = new BinaryFormatter();
                PomocnaKlasa transfer = new PomocnaKlasa();
                
               
                transfer.ListaKorisnika = Server.UlogovaniKorisnici;
                transfer.listaPoslatihPoruka = Server.listaPoslatihPoruka;

                foreach (NetworkStream tok in Server.listaTokova.ToList())
                {
                    formatter.Serialize(tok, transfer);
                }
               // PrikaziPodatke();
             
                
            

        }



        private void btnStart_Click(object sender, EventArgs e)
        {
            server = new Server();
            try
            {
                if (server.Start())
                {
                    MessageBox.Show("Server je uspesno pokrenut!");
                    btnStop.Enabled = true;
                    btnStart.Enabled = false;
                    t = new Timer();
                    t.Interval = 1000;
                    t.Tick += Osvezi;
                    t.Start();
                    

                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(">>>" + ex);

            }

        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            try
            {
                server.Stop();
                server = null;
                btnStart.Enabled = true;
                btnStop.Enabled = false;
                MessageBox.Show("Server je zaustavljen!");
            
            }
            catch(Exception ex)
            {
                MessageBox.Show(">>>" + ex);

            }
        }
    }
}
