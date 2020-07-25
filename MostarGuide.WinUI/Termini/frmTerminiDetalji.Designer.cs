namespace MostarGuide.WinUI.Termini
{
    partial class frmTerminiDetalji
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpVrijemeTermina = new System.Windows.Forms.DateTimePicker();
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.cmbVodic = new System.Windows.Forms.ComboBox();
            this.cmbIzlet = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 35;
            this.label2.Text = "Vodič";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 37;
            this.label1.Text = "Izlet";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 38;
            this.label3.Text = "Datum izleta";
            // 
            // dtpVrijemeTermina
            // 
            this.dtpVrijemeTermina.Location = new System.Drawing.Point(66, 210);
            this.dtpVrijemeTermina.Name = "dtpVrijemeTermina";
            this.dtpVrijemeTermina.Size = new System.Drawing.Size(193, 20);
            this.dtpVrijemeTermina.TabIndex = 39;
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.Location = new System.Drawing.Point(177, 266);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(82, 21);
            this.btnSacuvaj.TabIndex = 40;
            this.btnSacuvaj.Text = "Sačuvaj";
            this.btnSacuvaj.UseVisualStyleBackColor = true;
            this.btnSacuvaj.Click += new System.EventHandler(this.btnSacuvaj_Click);
            // 
            // cmbVodic
            // 
            this.cmbVodic.FormattingEnabled = true;
            this.cmbVodic.Location = new System.Drawing.Point(68, 79);
            this.cmbVodic.Name = "cmbVodic";
            this.cmbVodic.Size = new System.Drawing.Size(190, 21);
            this.cmbVodic.TabIndex = 41;
            this.cmbVodic.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.cmbVodic_Format);
            // 
            // cmbIzlet
            // 
            this.cmbIzlet.FormattingEnabled = true;
            this.cmbIzlet.Location = new System.Drawing.Point(66, 146);
            this.cmbIzlet.Name = "cmbIzlet";
            this.cmbIzlet.Size = new System.Drawing.Size(191, 21);
            this.cmbIzlet.TabIndex = 42;
            // 
            // frmTerminiDetalji
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 330);
            this.Controls.Add(this.cmbIzlet);
            this.Controls.Add(this.cmbVodic);
            this.Controls.Add(this.btnSacuvaj);
            this.Controls.Add(this.dtpVrijemeTermina);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "frmTerminiDetalji";
            this.Text = "frmTerminiDetalji";
            this.Load += new System.EventHandler(this.frmTerminiDetalji_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpVrijemeTermina;
        private System.Windows.Forms.Button btnSacuvaj;
        private System.Windows.Forms.ComboBox cmbVodic;
        private System.Windows.Forms.ComboBox cmbIzlet;
    }
}