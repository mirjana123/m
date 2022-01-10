using Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KlijentForma
{
    public partial class FrmKlijent : Form
    {
        Korisnik User;
        public FrmKlijent()
        {
            InitializeComponent();
            btnLogin.Enabled = false;

        }


      
        public void primiP()
        {
            try
            {
                while (true)
                {
                    PomocnaKlasa p = Komunikacija.Instance.ProcitajPorukuOdServera();
                    Invoke(new Action(() => prikaziP(p)));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(">>" + ex);
            }
        }

        public void prikaziP(PomocnaKlasa p)
        {
            PrikaziPodatke(p);
        } 
        public void PrikaziPodatke(PomocnaKlasa transfer)
        {
            cmbPrijavljeniKorisnici.DataSource = transfer.ListaKorisnika;
            cmbPrijavljeniKorisnici.DisplayMember = "Email";
            cmbPrijavljeniKorisnici.ValueMember = "Email";
            cmbPrijavljeniPrikaz.DisplayMember = "Email";
            cmbPrijavljeniPrikaz.ValueMember = "Email";

            cmbPrijavljeniPrikaz.DataSource = transfer.ListaKorisnika;
            BindingList<PoslatePoruke> prveTri = new BindingList<PoslatePoruke>();
            BindingList<PoslatePoruke> ostalo = new BindingList<PoslatePoruke>();
            for(int i= transfer.listaPoslatihPoruka.Count-1; i>=0  ; i--)
            {
                if (i > transfer.listaPoslatihPoruka.Count - 1-3)
                {
                    prveTri.Add(transfer.listaPoslatihPoruka[i]);

                }
                else
                {
                    ostalo.Add(transfer.listaPoslatihPoruka[i]);

                }

            }
           
            dgvSviOstalo.DataSource = ostalo;
            dgvSviTri.DataSource = prveTri;
            dgvSviTri.Columns["Prima"].Visible = false;
            dgvSviOstalo.Columns["Prima"].Visible = false;
            dgvSviOstalo.Columns["Prima"].Width = 20;





        }




        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                PomocnaKlasa transfer = new PomocnaKlasa();
                
                transfer = Komunikacija.Instance.PrijaviSe(txtEmail.Text, txtSifra.Text);
                
                if (transfer.Ulogovan)
                {
                    Thread nit = new Thread(primiP);
                    nit.Start();
                    nit.IsBackground = true;
                    User = transfer.Korisnik;
                }
                else
                {
                    MessageBox.Show(transfer.Odgovor);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            SetButton();

        }

        private void txtSifra_TextChanged(object sender, EventArgs e)
        {
            SetButton();
        }

        private void SetButton()
        {
            if ((txtSifra.Text != "") && (txtEmail.Text != ""))
            {
                btnLogin.Enabled = true;

            }
        }

        private void btnPosaljiSvima_Click(object sender, EventArgs e)
        {
            PomocnaKlasa transfer = new PomocnaKlasa();
            try
            {
                transfer.Korisnik = User;
                transfer.TekstPoruke = txtPorukaSvima.Text;
                transfer.Operacija = Operacije.SlanjePorukeSvima;
                transfer.Ulogovan = true;

                Komunikacija.Instance.PosaljiPoruku(transfer);
            }
            catch (Exception ex)
            {
                MessageBox.Show(">>>"+ex);
            }
        }

        private void btnPosaljiJednom_Click(object sender, EventArgs e)
        {
            PomocnaKlasa transfer = new PomocnaKlasa();
            try
            {
                transfer.PosebanPrimalacPoruke =(Korisnik)cmbPrijavljeniKorisnici.SelectedItem;
                transfer.TekstPoruke = txtPorukaJednom.Text;
                transfer.Operacija = Operacije.SlanjePorukeJednom;
                transfer.Korisnik = User;
                Komunikacija.Instance.PosaljiPoruku(transfer);
            }
            catch (Exception ex)
            {
                MessageBox.Show(">>>" + ex);
            }

        }
    }
}
