namespace MostarGuide.WinUI.OcjeneIzleti
{
    partial class frmOcjeneIzleti
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvOcjene = new System.Windows.Forms.DataGridView();
            this.OcjenaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IzletId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Izlet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KorisnikId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Korisnik = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Datum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ocjena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbIzlet = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOcjene)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Izlet";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvOcjene);
            this.groupBox1.Location = new System.Drawing.Point(33, 107);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(492, 185);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ocjene";
            // 
            // dgvOcjene
            // 
            this.dgvOcjene.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOcjene.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OcjenaId,
            this.IzletId,
            this.Izlet,
            this.KorisnikId,
            this.Korisnik,
            this.Datum,
            this.Ocjena});
            this.dgvOcjene.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvOcjene.Location = new System.Drawing.Point(3, 16);
            this.dgvOcjene.MultiSelect = false;
            this.dgvOcjene.Name = "dgvOcjene";
            this.dgvOcjene.Size = new System.Drawing.Size(486, 166);
            this.dgvOcjene.TabIndex = 0;
            // 
            // OcjenaId
            // 
            this.OcjenaId.DataPropertyName = "OcjenaId";
            this.OcjenaId.HeaderText = "OcjenaId";
            this.OcjenaId.Name = "OcjenaId";
            this.OcjenaId.Visible = false;
            // 
            // IzletId
            // 
            this.IzletId.DataPropertyName = "IzletId";
            this.IzletId.HeaderText = "IzletId";
            this.IzletId.Name = "IzletId";
            this.IzletId.Visible = false;
            // 
            // Izlet
            // 
            this.Izlet.DataPropertyName = "Izlet";
            this.Izlet.HeaderText = "Izlet";
            this.Izlet.Name = "Izlet";
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
            // cmbIzlet
            // 
            this.cmbIzlet.FormattingEnabled = true;
            this.cmbIzlet.Location = new System.Drawing.Point(36, 52);
            this.cmbIzlet.Name = "cmbIzlet";
            this.cmbIzlet.Size = new System.Drawing.Size(193, 21);
            this.cmbIzlet.TabIndex = 24;
            this.cmbIzlet.SelectedIndexChanged += new System.EventHandler(this.cmbIzlet_SelectedIndexChanged);
            // 
            // frmOcjeneIzleti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 349);
            this.Controls.Add(this.cmbIzlet);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "frmOcjeneIzleti";
            this.Text = "frmOcjeneIzleti";
            this.Load += new System.EventHandler(this.frmOcjeneIzleti_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOcjene)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvOcjene;
        private System.Windows.Forms.ComboBox cmbIzlet;
        private System.Windows.Forms.DataGridViewTextBoxColumn OcjenaId;
        private System.Windows.Forms.DataGridViewTextBoxColumn IzletId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Izlet;
        private System.Windows.Forms.DataGridViewTextBoxColumn KorisnikId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Korisnik;
        private System.Windows.Forms.DataGridViewTextBoxColumn Datum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ocjena;
    }
}