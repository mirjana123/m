namespace KlijentForma
{
    partial class FrmKlijent
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtPorukaSvima = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPosaljiSvima = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtSifra = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnPosaljiJednom = new System.Windows.Forms.Button();
            this.txtPorukaJednom = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbPrijavljeniKorisnici = new System.Windows.Forms.ComboBox();
            this.dgvSviTri = new System.Windows.Forms.DataGridView();
            this.dgvSviOstalo = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.cmbPrijavljeniPrikaz = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnPrikazi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSviTri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSviOstalo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(341, 21);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(74, 56);
            this.btnLogin.TabIndex = 7;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtPorukaSvima
            // 
            this.txtPorukaSvima.Location = new System.Drawing.Point(157, 128);
            this.txtPorukaSvima.Multiline = true;
            this.txtPorukaSvima.Name = "txtPorukaSvima";
            this.txtPorukaSvima.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtPorukaSvima.Size = new System.Drawing.Size(413, 128);
            this.txtPorukaSvima.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Email";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Sifra";
            // 
            // btnPosaljiSvima
            // 
            this.btnPosaljiSvima.Location = new System.Drawing.Point(12, 168);
            this.btnPosaljiSvima.Name = "btnPosaljiSvima";
            this.btnPosaljiSvima.Size = new System.Drawing.Size(116, 33);
            this.btnPosaljiSvima.TabIndex = 11;
            this.btnPosaljiSvima.Text = "Posalji svima";
            this.btnPosaljiSvima.UseVisualStyleBackColor = true;
            this.btnPosaljiSvima.Click += new System.EventHandler(this.btnPosaljiSvima_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(106, 18);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(210, 26);
            this.txtEmail.TabIndex = 12;
            this.txtEmail.Text = "k1@gmail.com";
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // txtSifra
            // 
            this.txtSifra.Location = new System.Drawing.Point(106, 57);
            this.txtSifra.Name = "txtSifra";
            this.txtSifra.Size = new System.Drawing.Size(210, 26);
            this.txtSifra.TabIndex = 13;
            this.txtSifra.Text = "sifra1";
            this.txtSifra.TextChanged += new System.EventHandler(this.txtSifra_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Poruka za sve";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(619, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "Poruka";
            // 
            // btnPosaljiJednom
            // 
            this.btnPosaljiJednom.Location = new System.Drawing.Point(605, 168);
            this.btnPosaljiJednom.Name = "btnPosaljiJednom";
            this.btnPosaljiJednom.Size = new System.Drawing.Size(116, 33);
            this.btnPosaljiJednom.TabIndex = 16;
            this.btnPosaljiJednom.Text = "Posalji";
            this.btnPosaljiJednom.UseVisualStyleBackColor = true;
            this.btnPosaljiJednom.Click += new System.EventHandler(this.btnPosaljiJednom_Click);
            // 
            // txtPorukaJednom
            // 
            this.txtPorukaJednom.Location = new System.Drawing.Point(742, 128);
            this.txtPorukaJednom.Multiline = true;
            this.txtPorukaJednom.Name = "txtPorukaJednom";
            this.txtPorukaJednom.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtPorukaJednom.Size = new System.Drawing.Size(371, 128);
            this.txtPorukaJednom.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(590, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 20);
            this.label5.TabIndex = 18;
            this.label5.Text = "Prijavljeni korisnici";
            // 
            // cmbPrijavljeniKorisnici
            // 
            this.cmbPrijavljeniKorisnici.FormattingEnabled = true;
            this.cmbPrijavljeniKorisnici.Location = new System.Drawing.Point(761, 49);
            this.cmbPrijavljeniKorisnici.Name = "cmbPrijavljeniKorisnici";
            this.cmbPrijavljeniKorisnici.Size = new System.Drawing.Size(340, 28);
            this.cmbPrijavljeniKorisnici.TabIndex = 19;
            // 
            // dgvSviTri
            // 
            this.dgvSviTri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSviTri.Location = new System.Drawing.Point(26, 360);
            this.dgvSviTri.Name = "dgvSviTri";
            this.dgvSviTri.RowTemplate.Height = 28;
            this.dgvSviTri.Size = new System.Drawing.Size(544, 150);
            this.dgvSviTri.TabIndex = 20;
            // 
            // dgvSviOstalo
            // 
            this.dgvSviOstalo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSviOstalo.Location = new System.Drawing.Point(605, 360);
            this.dgvSviOstalo.Name = "dgvSviOstalo";
            this.dgvSviOstalo.RowTemplate.Height = 28;
            this.dgvSviOstalo.Size = new System.Drawing.Size(546, 150);
            this.dgvSviOstalo.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 323);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(263, 20);
            this.label6.TabIndex = 22;
            this.label6.Text = "Poslednje 2 poruke od svih korisnika";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(602, 323);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(229, 20);
            this.label7.TabIndex = 23;
            this.label7.Text = "Ostale poruke od svih Korisnika";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(658, 596);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(189, 20);
            this.label8.TabIndex = 27;
            this.label8.Text = "Sve ostale poruke od svih";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(22, 596);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(263, 20);
            this.label9.TabIndex = 26;
            this.label9.Text = "Poslednje 2 poruke od svih korisnika";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(605, 633);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(546, 150);
            this.dataGridView1.TabIndex = 25;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(26, 633);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 28;
            this.dataGridView2.Size = new System.Drawing.Size(544, 150);
            this.dataGridView2.TabIndex = 24;
            // 
            // cmbPrijavljeniPrikaz
            // 
            this.cmbPrijavljeniPrikaz.FormattingEnabled = true;
            this.cmbPrijavljeniPrikaz.Location = new System.Drawing.Point(193, 551);
            this.cmbPrijavljeniPrikaz.Name = "cmbPrijavljeniPrikaz";
            this.cmbPrijavljeniPrikaz.Size = new System.Drawing.Size(284, 28);
            this.cmbPrijavljeniPrikaz.TabIndex = 29;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(22, 559);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(133, 20);
            this.label10.TabIndex = 28;
            this.label10.Text = "Prijavljeni korisnici";
            // 
            // btnPrikazi
            // 
            this.btnPrikazi.Location = new System.Drawing.Point(497, 548);
            this.btnPrikazi.Name = "btnPrikazi";
            this.btnPrikazi.Size = new System.Drawing.Size(116, 33);
            this.btnPrikazi.TabIndex = 30;
            this.btnPrikazi.Text = "Prikazi";
            this.btnPrikazi.UseVisualStyleBackColor = true;
            // 
            // FrmKlijent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1164, 815);
            this.Controls.Add(this.btnPrikazi);
            this.Controls.Add(this.cmbPrijavljeniPrikaz);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgvSviOstalo);
            this.Controls.Add(this.dgvSviTri);
            this.Controls.Add(this.cmbPrijavljeniKorisnici);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnPosaljiJednom);
            this.Controls.Add(this.txtPorukaJednom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSifra);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.btnPosaljiSvima);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPorukaSvima);
            this.Controls.Add(this.label3);
            this.Name = "FrmKlijent";
            this.Text = "Klijent";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSviTri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSviOstalo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtPorukaSvima;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPosaljiSvima;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtSifra;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnPosaljiJednom;
        private System.Windows.Forms.TextBox txtPorukaJednom;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbPrijavljeniKorisnici;
        private System.Windows.Forms.DataGridView dgvSviTri;
        private System.Windows.Forms.DataGridView dgvSviOstalo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.ComboBox cmbPrijavljeniPrikaz;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnPrikazi;
    }
}

