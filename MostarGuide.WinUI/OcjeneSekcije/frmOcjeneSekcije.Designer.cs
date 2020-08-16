namespace MostarGuide.WinUI.OcjeneSekcije
{
    partial class frmOcjeneSekcije
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
            this.cmbSekcija = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvOcjene = new System.Windows.Forms.DataGridView();
            this.OcjenaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SekcijaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sekcija = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KorisnikId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Korisnik = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Datum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ocjena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.no = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOcjene)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbSekcija
            // 
            this.cmbSekcija.FormattingEnabled = true;
            this.cmbSekcija.Location = new System.Drawing.Point(53, 56);
            this.cmbSekcija.Name = "cmbSekcija";
            this.cmbSekcija.Size = new System.Drawing.Size(193, 21);
            this.cmbSekcija.TabIndex = 27;
            this.cmbSekcija.SelectedIndexChanged += new System.EventHandler(this.cmbSekcija_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvOcjene);
            this.groupBox1.Location = new System.Drawing.Point(50, 111);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(509, 214);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ocjene";
            // 
            // dgvOcjene
            // 
            this.dgvOcjene.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOcjene.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OcjenaId,
            this.SekcijaId,
            this.Sekcija,
            this.KorisnikId,
            this.Korisnik,
            this.Datum,
            this.Ocjena});
            this.dgvOcjene.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvOcjene.Location = new System.Drawing.Point(3, 16);
            this.dgvOcjene.MultiSelect = false;
            this.dgvOcjene.Name = "dgvOcjene";
            this.dgvOcjene.Size = new System.Drawing.Size(503, 195);
            this.dgvOcjene.TabIndex = 0;
            // 
            // OcjenaId
            // 
            this.OcjenaId.DataPropertyName = "OcjenaId";
            this.OcjenaId.HeaderText = "OcjenaId";
            this.OcjenaId.Name = "OcjenaId";
            this.OcjenaId.Visible = false;
            // 
            // SekcijaId
            // 
            this.SekcijaId.DataPropertyName = "SekcijaId";
            this.SekcijaId.HeaderText = "SekcijaId";
            this.SekcijaId.Name = "SekcijaId";
            this.SekcijaId.Visible = false;
            // 
            // Sekcija
            // 
            this.Sekcija.DataPropertyName = "Sekcija";
            this.Sekcija.HeaderText = "Sekcija";
            this.Sekcija.Name = "Sekcija";
            // 
            // KorisnikId
            // 
            this.KorisnikId.DataPropertyName = "KorisnikId";
            this.KorisnikId.HeaderText = "KorisnikId";
            this.KorisnikId.Name = "KorisnikId";
            this.KorisnikId.Visible = false;
            // 
            // Korisnik
            // 
            this.Korisnik.DataPropertyName = "Korisnik";
            this.Korisnik.HeaderText = "Korisnik";
            this.Korisnik.Name = "Korisnik";
            // 
            // Datum
            // 
            this.Datum.DataPropertyName = "Datum";
            this.Datum.HeaderText = "Datum";
            this.Datum.Name = "Datum";
            // 
            // Ocjena
            // 
            this.Ocjena.DataPropertyName = "Ocjena";
            this.Ocjena.HeaderText = "Ocjena";
            this.Ocjena.Name = "Ocjena";
            // 
            // no
            // 
            this.no.AutoSize = true;
            this.no.Location = new System.Drawing.Point(50, 37);
            this.no.Name = "no";
            this.no.Size = new System.Drawing.Size(42, 13);
            this.no.TabIndex = 25;
            this.no.Text = "Sekcija";
            // 
            // frmOcjeneSekcije
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 378);
            this.Controls.Add(this.cmbSekcija);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.no);
            this.Name = "frmOcjeneSekcije";
            this.Text = "frmOcjeneSekcije";
            this.Load += new System.EventHandler(this.frmOcjeneSekcije_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOcjene)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbSekcija;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label no;
        private System.Windows.Forms.DataGridView dgvOcjene;
        private System.Windows.Forms.DataGridViewTextBoxColumn OcjenaId;
        private System.Windows.Forms.DataGridViewTextBoxColumn SekcijaId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sekcija;
        private System.Windows.Forms.DataGridViewTextBoxColumn KorisnikId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Korisnik;
        private System.Windows.Forms.DataGridViewTextBoxColumn Datum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ocjena;
    }
}