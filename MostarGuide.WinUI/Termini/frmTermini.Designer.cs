namespace MostarGuide.WinUI.Termini
{
    partial class frmTermini
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
            this.dgvTermini = new System.Windows.Forms.DataGridView();
            this.cmbVodic = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.dtpVrijemeTermina = new System.Windows.Forms.DateTimePicker();
            this.cmbIzlet = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Datum = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTermini)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvTermini);
            this.groupBox1.Location = new System.Drawing.Point(42, 214);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(500, 277);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Termini";
            // 
            // dgvTermini
            // 
            this.dgvTermini.AllowUserToAddRows = false;
            this.dgvTermini.AllowUserToDeleteRows = false;
            this.dgvTermini.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTermini.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTermini.Location = new System.Drawing.Point(3, 16);
            this.dgvTermini.Name = "dgvTermini";
            this.dgvTermini.ReadOnly = true;
            this.dgvTermini.Size = new System.Drawing.Size(494, 258);
            this.dgvTermini.TabIndex = 0;
            // 
            // cmbVodic
            // 
            this.cmbVodic.FormattingEnabled = true;
            this.cmbVodic.Location = new System.Drawing.Point(42, 163);
            this.cmbVodic.Name = "cmbVodic";
            this.cmbVodic.Size = new System.Drawing.Size(205, 21);
            this.cmbVodic.TabIndex = 24;
            this.cmbVodic.SelectedIndexChanged += new System.EventHandler(this.cmbVodic_SelectedIndexChanged);
            this.cmbVodic.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.cmbVodic_Format);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Vodič";
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(303, 163);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(82, 21);
            this.btnDodaj.TabIndex = 27;
            this.btnDodaj.Text = "Sačuvaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // dtpVrijemeTermina
            // 
            this.dtpVrijemeTermina.Location = new System.Drawing.Point(42, 52);
            this.dtpVrijemeTermina.Name = "dtpVrijemeTermina";
            this.dtpVrijemeTermina.Size = new System.Drawing.Size(205, 20);
            this.dtpVrijemeTermina.TabIndex = 21;
            // 
            // cmbIzlet
            // 
            this.cmbIzlet.FormattingEnabled = true;
            this.cmbIzlet.Location = new System.Drawing.Point(42, 105);
            this.cmbIzlet.Name = "cmbIzlet";
            this.cmbIzlet.Size = new System.Drawing.Size(205, 21);
            this.cmbIzlet.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Izlet";
            // 
            // Datum
            // 
            this.Datum.AutoSize = true;
            this.Datum.Location = new System.Drawing.Point(39, 29);
            this.Datum.Name = "Datum";
            this.Datum.Size = new System.Drawing.Size(79, 13);
            this.Datum.TabIndex = 22;
            this.Datum.Text = "Datum i vrijeme";
            // 
            // frmTermini
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 450);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.cmbIzlet);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbVodic);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Datum);
            this.Controls.Add(this.dtpVrijemeTermina);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmTermini";
            this.Text = "frmTermini";
            this.Load += new System.EventHandler(this.frmTermini_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTermini)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvTermini;
        private System.Windows.Forms.ComboBox cmbVodic;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.DateTimePicker dtpVrijemeTermina;
        private System.Windows.Forms.ComboBox cmbIzlet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Datum;
    }
}