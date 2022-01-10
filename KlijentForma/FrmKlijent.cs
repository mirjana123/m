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
        
        private bool KlinkuoPrikzi = false;
        private bool OtvorenKombo1 ;
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
            if ( OtvorenKombo1 == true)
            {
                cmbPrijavljeniKorisnici.DataSource = transfer.ListaKorisnika;
                cmbPrijavljeniKorisnici.DisplayMember = "Email";
                cmbPrijavljeniKorisnici.ValueMember = "Email";
            }
               
                                   
                cmbPrijavljeniPrikaz.DataSource = transfer.ListaKorisnika;
                cmbPrijavljeniPrikaz.SelectedIndex = -1;
                cmbPrijavljeniPrikaz.DisplayMember = "Email";
                cmbPrijavljeniPrikaz.ValueMember = "Email";
            

            BindingList<PoslatePoruke> prveTri = new BindingList<PoslatePoruke>();
            BindingList<PoslatePoruke> ostalo = new BindingList<PoslatePoruke>();
            for(int i= transfer.listaPoslatihPoruka.Count-1; i>=0  ; i--)
            {
                if (transfer.listaPoslatihPoruka[i].Prima == null || transfer.listaPoslatihPoruka[i].Prima == User) { 
                if (i > transfer.listaPoslatihPoruka.Count - 1-3)
                {
                    prveTri.Add(transfer.listaPoslatihPoruka[i]);

                }
                else
                {
                    ostalo.Add(transfer.listaPoslatihPoruka[i]);

                }
                }

            }
           
            dgvSviOstalo.DataSource = ostalo;
            dgvSviTri.DataSource = prveTri;
            dgvSviTri.Columns["Prima"].Visible = false;
            dgvSviOstalo.Columns["Prima"].Visible = false;
            dgvSviOstalo.Columns["Prima"].Width = 20;


            BindingList<PoslatePoruke> triJedan = new BindingList<PoslatePoruke>();
            BindingList<PoslatePoruke> ostaloJedan = new BindingList<PoslatePoruke>();

            if (KlinkuoPrikzi)
            {
                Korisnik k = (Korisnik)cmbPrijavljeniPrikaz.SelectedItem;
                for (int i = transfer.listaPoslatihPoruka.Count - 1; i >= 0; i--)
                {
                    if(transfer.listaPoslatihPoruka[i].Salje == k && (transfer.listaPoslatihPoruka[i].Prima == null || transfer.listaPoslatihPoruka[i].Prima == User))
                    {
                        if (i > transfer.listaPoslatihPoruka.Count - 1 - 3)
                        {
                            triJedan.Add(transfer.listaPoslatihPoruka[i]);

                        }
                        else
                        {
                            ostaloJedan.Add(transfer.listaPoslatihPoruka[i]);

                        }
                    }
                    

                }

                dgvOstaloJedan.DataSource = ostalo;
                dgvTriJedan.DataSource = prveTri;


                

            }



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
                transfer.Ulogovan = true;
                Komunikacija.Instance.PosaljiPoruku(transfer);
            }
            catch (Exception ex)
            {
                MessageBox.Show(">>>" + ex);
            }

        }

        private void btnPrikazi_Click(object sender, EventArgs e)
        {

            KlinkuoPrikzi = true;

        }

        private void cmbPrijavljeniKorisnici_DropDown(object sender, EventArgs e)
        {
            OtvorenKombo1 = true;
        }

        private void cmbPrijavljeniKorisnici_DropDownClosed(object sender, EventArgs e)
        {
            OtvorenKombo1 = false;
        }
    }
}
