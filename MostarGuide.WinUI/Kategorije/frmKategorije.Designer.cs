namespace MostarGuide.WinUI.Kategorije
{
    partial class frmKategorije
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
            this.dgvKategorije = new System.Windows.Forms.DataGridView();
            this.KategorijaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKategorije)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvKategorije);
            this.groupBox1.Location = new System.Drawing.Point(41, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(488, 239);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kategorije";
            // 
            // dgvKategorije
            // 
            this.dgvKategorije.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKategorije.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.KategorijaId,
            this.Naziv});
            this.dgvKategorije.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvKategorije.Location = new System.Drawing.Point(3, 16);
            this.dgvKategorije.MultiSelect = false;
            this.dgvKategorije.Name = "dgvKategorije";
            this.dgvKategorije.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKategorije.Size = new System.Drawing.Size(482, 220);
            this.dgvKategorije.TabIndex = 0;
            this.dgvKategorije.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvKategorije_MouseClick);
            // 
            // KategorijaId
            // 
            this.KategorijaId.DataPropertyName = "KategorijaId";
            this.KategorijaId.HeaderText = "KategorijaId";
            this.KategorijaId.Name = "KategorijaId";
            this.KategorijaId.Visible = false;
            // 
            // Naziv
            // 
            this.Naziv.DataPropertyName = "Naziv";
            this.Naziv.HeaderText = "Naziv";
            this.Naziv.Name = "Naziv";
            // 
            // frmKategorije
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 307);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmKategorije";
            this.Text = "frmKategorije";
            this.Load += new System.EventHandler(this.frmKategorije_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKategorije)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvKategorije;
        private System.Windows.Forms.DataGridViewTextBoxColumn KategorijaId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
    }
}