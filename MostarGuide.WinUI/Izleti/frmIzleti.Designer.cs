namespace MostarGuide.WinUI.Izleti
{
    partial class frmIzleti
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
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.btnPrikazi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvIzleti = new System.Windows.Forms.DataGridView();
            this.IzletId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrojMjesta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cijena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Opis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIzleti)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(47, 46);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(289, 20);
            this.txtNaziv.TabIndex = 6;
            // 
            // btnPrikazi
            // 
            this.btnPrikazi.Location = new System.Drawing.Point(479, 45);
            this.btnPrikazi.Name = "btnPrikazi";
            this.btnPrikazi.Size = new System.Drawing.Size(62, 20);
            this.btnPrikazi.TabIndex = 7;
            this.btnPrikazi.Text = "Prikaži";
            this.btnPrikazi.UseVisualStyleBackColor = true;
            this.btnPrikazi.Click += new System.EventHandler(this.btnPrikazi_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Naziv";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvIzleti);
            this.groupBox1.Location = new System.Drawing.Point(44, 114);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(500, 277);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Izleti";
            // 
            // dgvIzleti
            // 
            this.dgvIzleti.AllowUserToAddRows = false;
            this.dgvIzleti.AllowUserToDeleteRows = false;
            this.dgvIzleti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIzleti.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IzletId,
            this.Naziv,
            this.BrojMjesta,
            this.Cijena,
            this.Opis});
            this.dgvIzleti.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvIzleti.Location = new System.Drawing.Point(3, 16);
            this.dgvIzleti.Name = "dgvIzleti";
            this.dgvIzleti.ReadOnly = true;
            this.dgvIzleti.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvIzleti.Size = new System.Drawing.Size(494, 258);
            this.dgvIzleti.TabIndex = 0;
            this.dgvIzleti.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvIzleti_MouseDoubleClick);
            // 
            // IzletId
            // 
            this.IzletId.DataPropertyName = "IzletId";
            this.IzletId.HeaderText = "IzletId";
            this.IzletId.Name = "IzletId";
            this.IzletId.ReadOnly = true;
            this.IzletId.Visible = false;
            // 
            // Naziv
            // 
            this.Naziv.DataPropertyName = "Naziv";
            this.Naziv.HeaderText = "Naziv";
            this.Naziv.Name = "Naziv";
            this.Naziv.ReadOnly = true;
            // 
            // BrojMjesta
            // 
            this.BrojMjesta.DataPropertyName = "BrojMjesta";
            this.BrojMjesta.HeaderText = "Broj mjesta";
            this.BrojMjesta.Name = "BrojMjesta";
            this.BrojMjesta.ReadOnly = true;
            // 
            // Cijena
            // 
            this.Cijena.DataPropertyName = "Cijena";
            this.Cijena.HeaderText = "Cijena";
            this.Cijena.Name = "Cijena";
            this.Cijena.ReadOnly = true;
            // 
            // Opis
            // 
            this.Opis.DataPropertyName = "Opis";
            this.Opis.HeaderText = "Opis";
            this.Opis.Name = "Opis";
            this.Opis.ReadOnly = true;
            // 
            // frmIzleti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 418);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPrikazi);
            this.Controls.Add(this.txtNaziv);
            this.Name = "frmIzleti";
            this.Text = "frmIzleti";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIzleti)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.Button btnPrikazi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvIzleti;
        private System.Windows.Forms.DataGridViewTextBoxColumn IzletId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrojMjesta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cijena;
        private System.Windows.Forms.DataGridViewTextBoxColumn Opis;
    }
}