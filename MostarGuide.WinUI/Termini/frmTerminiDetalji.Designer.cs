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
            this.btnDodaj = new System.Windows.Forms.Button();
            this.cmbIzlet = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbVodic = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Datum = new System.Windows.Forms.Label();
            this.dtpVrijemeTermina = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(185, 231);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(82, 21);
            this.btnDodaj.TabIndex = 34;
            this.btnDodaj.Text = "Sačuvaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            // 
            // cmbIzlet
            // 
            this.cmbIzlet.FormattingEnabled = true;
            this.cmbIzlet.Location = new System.Drawing.Point(62, 124);
            this.cmbIzlet.Name = "cmbIzlet";
            this.cmbIzlet.Size = new System.Drawing.Size(205, 21);
            this.cmbIzlet.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "Izlet";
            // 
            // cmbVodic
            // 
            this.cmbVodic.FormattingEnabled = true;
            this.cmbVodic.Location = new System.Drawing.Point(62, 182);
            this.cmbVodic.Name = "cmbVodic";
            this.cmbVodic.Size = new System.Drawing.Size(205, 21);
            this.cmbVodic.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "Vodič";
            // 
            // Datum
            // 
            this.Datum.AutoSize = true;
            this.Datum.Location = new System.Drawing.Point(59, 48);
            this.Datum.Name = "Datum";
            this.Datum.Size = new System.Drawing.Size(79, 13);
            this.Datum.TabIndex = 29;
            this.Datum.Text = "Datum i vrijeme";
            // 
            // dtpVrijemeTermina
            // 
            this.dtpVrijemeTermina.Location = new System.Drawing.Point(62, 71);
            this.dtpVrijemeTermina.Name = "dtpVrijemeTermina";
            this.dtpVrijemeTermina.Size = new System.Drawing.Size(205, 20);
            this.dtpVrijemeTermina.TabIndex = 28;
            // 
            // frmTerminiDetalji
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 297);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.cmbIzlet);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbVodic);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Datum);
            this.Controls.Add(this.dtpVrijemeTermina);
            this.Name = "frmTerminiDetalji";
            this.Text = "frmTerminiDetalji";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.ComboBox cmbIzlet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbVodic;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Datum;
        private System.Windows.Forms.DateTimePicker dtpVrijemeTermina;
    }
}