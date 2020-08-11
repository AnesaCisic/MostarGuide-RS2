namespace MostarGuide.WinUI.Rezervacije
{
    partial class frmRezervacije
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvRezervacije = new System.Windows.Forms.DataGridView();
            this.RezervacijaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KorisnikMobId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Korisnik = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TerminId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Izlet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TerminDatum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumRezervacije = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrojOsoba = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbTermini = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMjesta = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRezervacije)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvRezervacije);
            this.groupBox1.Location = new System.Drawing.Point(52, 114);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(608, 234);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rezervacije";
            // 
            // dgvRezervacije
            // 
            this.dgvRezervacije.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRezervacije.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RezervacijaId,
            this.KorisnikMobId,
            this.Korisnik,
            this.TerminId,
            this.Izlet,
            this.TerminDatum,
            this.DatumRezervacije,
            this.BrojOsoba});
            this.dgvRezervacije.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRezervacije.Location = new System.Drawing.Point(3, 16);
            this.dgvRezervacije.Name = "dgvRezervacije";
            this.dgvRezervacije.Size = new System.Drawing.Size(602, 215);
            this.dgvRezervacije.TabIndex = 0;
            // 
            // RezervacijaId
            // 
            this.RezervacijaId.DataPropertyName = "RezervacijaId";
            this.RezervacijaId.HeaderText = "RezervacijaId";
            this.RezervacijaId.Name = "RezervacijaId";
            this.RezervacijaId.Visible = false;
            // 
            // KorisnikMobId
            // 
            this.KorisnikMobId.DataPropertyName = "KorisnikMobId";
            this.KorisnikMobId.HeaderText = "KorisnikMobId";
            this.KorisnikMobId.Name = "KorisnikMobId";
            this.KorisnikMobId.Visible = false;
            // 
            // Korisnik
            // 
            this.Korisnik.DataPropertyName = "Korisnik";
            this.Korisnik.HeaderText = "Korisnik";
            this.Korisnik.Name = "Korisnik";
            // 
            // TerminId
            // 
            this.TerminId.DataPropertyName = "TerminId";
            this.TerminId.HeaderText = "TerminId";
            this.TerminId.Name = "TerminId";
            this.TerminId.Visible = false;
            // 
            // Izlet
            // 
            this.Izlet.DataPropertyName = "Izlet";
            this.Izlet.HeaderText = "Izlet";
            this.Izlet.Name = "Izlet";
            // 
            // TerminDatum
            // 
            this.TerminDatum.DataPropertyName = "TerminDatum";
            this.TerminDatum.HeaderText = "Termin datum";
            this.TerminDatum.Name = "TerminDatum";
            // 
            // DatumRezervacije
            // 
            this.DatumRezervacije.DataPropertyName = "DatumRezervacije";
            this.DatumRezervacije.HeaderText = "Datum rezervacije";
            this.DatumRezervacije.Name = "DatumRezervacije";
            // 
            // BrojOsoba
            // 
            this.BrojOsoba.DataPropertyName = "BrojOsoba";
            this.BrojOsoba.HeaderText = "Broj osoba";
            this.BrojOsoba.Name = "BrojOsoba";
            // 
            // cmbTermini
            // 
            this.cmbTermini.FormattingEnabled = true;
            this.cmbTermini.Location = new System.Drawing.Point(52, 53);
            this.cmbTermini.Name = "cmbTermini";
            this.cmbTermini.Size = new System.Drawing.Size(162, 21);
            this.cmbTermini.TabIndex = 1;
            this.cmbTermini.SelectedIndexChanged += new System.EventHandler(this.cmbTermini_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 34;
            this.label2.Text = "Termini";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(544, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 35;
            this.label1.Text = "Broj slobodnih mjesta";
            // 
            // txtMjesta
            // 
            this.txtMjesta.Location = new System.Drawing.Point(547, 54);
            this.txtMjesta.Name = "txtMjesta";
            this.txtMjesta.Size = new System.Drawing.Size(110, 20);
            this.txtMjesta.TabIndex = 36;
            // 
            // frmRezervacije
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 360);
            this.Controls.Add(this.txtMjesta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbTermini);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmRezervacije";
            this.Text = "frmRezervacije";
            this.Load += new System.EventHandler(this.frmRezervacije_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRezervacije)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvRezervacije;
        private System.Windows.Forms.ComboBox cmbTermini;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn RezervacijaId;
        private System.Windows.Forms.DataGridViewTextBoxColumn KorisnikMobId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Korisnik;
        private System.Windows.Forms.DataGridViewTextBoxColumn TerminId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Izlet;
        private System.Windows.Forms.DataGridViewTextBoxColumn TerminDatum;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumRezervacije;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrojOsoba;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMjesta;
    }
}