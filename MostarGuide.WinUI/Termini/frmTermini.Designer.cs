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
            this.dgvTermini = new System.Windows.Forms.DataGridView();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbVodic = new System.Windows.Forms.ComboBox();
            this.TerminId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vodic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Izlet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Datum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vrijeme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTermini)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvTermini
            // 
            this.dgvTermini.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTermini.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TerminId,
            this.Vodic,
            this.Izlet,
            this.Datum,
            this.Vrijeme});
            this.dgvTermini.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTermini.Location = new System.Drawing.Point(3, 16);
            this.dgvTermini.Name = "dgvTermini";
            this.dgvTermini.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTermini.Size = new System.Drawing.Size(550, 245);
            this.dgvTermini.TabIndex = 28;
            this.dgvTermini.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvTermini_MouseDoubleClick);
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(535, 64);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(82, 21);
            this.btnDodaj.TabIndex = 35;
            this.btnDodaj.Text = "Dodaj termin";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvTermini);
            this.groupBox1.Location = new System.Drawing.Point(64, 124);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(556, 264);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Termini";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 33;
            this.label2.Text = "Vodič";
            // 
            // cmbVodic
            // 
            this.cmbVodic.FormattingEnabled = true;
            this.cmbVodic.Location = new System.Drawing.Point(64, 65);
            this.cmbVodic.Name = "cmbVodic";
            this.cmbVodic.Size = new System.Drawing.Size(193, 21);
            this.cmbVodic.TabIndex = 32;
            this.cmbVodic.SelectedIndexChanged += new System.EventHandler(this.cmbVodic_SelectedIndexChanged);
            this.cmbVodic.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.cmbVodic_Format);
            // 
            // TerminId
            // 
            this.TerminId.DataPropertyName = "TerminId";
            this.TerminId.HeaderText = "TerminId";
            this.TerminId.Name = "TerminId";
            // 
            // Vodic
            // 
            this.Vodic.DataPropertyName = "Vodic";
            this.Vodic.HeaderText = "Vodic";
            this.Vodic.Name = "Vodic";
            // 
            // Izlet
            // 
            this.Izlet.DataPropertyName = "Izlet";
            this.Izlet.HeaderText = "Izlet";
            this.Izlet.Name = "Izlet";
            // 
            // Datum
            // 
            this.Datum.DataPropertyName = "Datum";
            this.Datum.HeaderText = "Datum";
            this.Datum.Name = "Datum";
            // 
            // Vrijeme
            // 
            this.Vrijeme.DataPropertyName = "Vrijeme";
            this.Vrijeme.HeaderText = "Vrijeme";
            this.Vrijeme.Name = "Vrijeme";
            // 
            // frmTermini
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 412);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbVodic);
            this.Name = "frmTermini";
            this.Text = "frmTermini";
            this.Load += new System.EventHandler(this.frmTermini_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTermini)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTermini;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbVodic;
        private System.Windows.Forms.DataGridViewTextBoxColumn TerminId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vodic;
        private System.Windows.Forms.DataGridViewTextBoxColumn Izlet;
        private System.Windows.Forms.DataGridViewTextBoxColumn Datum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vrijeme;
    }
}