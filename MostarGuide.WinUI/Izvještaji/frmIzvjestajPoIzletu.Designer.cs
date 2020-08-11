namespace MostarGuide.WinUI.Izvještaji
{
    partial class frmIzvjestajPoIzletu
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbGodine = new System.Windows.Forms.ComboBox();
            this.dgvIzvjestaji = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chartIzvjestaj = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.labelukupnazarada = new System.Windows.Forms.Label();
            this.Izlet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Zarada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Brojrezervacija = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UkupanBrojOsoba = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIzvjestaji)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartIzvjestaj)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(306, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Godisnji izvještaj po izletima";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label2.Location = new System.Drawing.Point(45, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Odaberite godinu:";
            // 
            // cmbGodine
            // 
            this.cmbGodine.FormattingEnabled = true;
            this.cmbGodine.Location = new System.Drawing.Point(45, 85);
            this.cmbGodine.Name = "cmbGodine";
            this.cmbGodine.Size = new System.Drawing.Size(156, 21);
            this.cmbGodine.TabIndex = 5;
            this.cmbGodine.SelectedIndexChanged += new System.EventHandler(this.cmbGodine_SelectedIndexChanged);
            // 
            // dgvIzvjestaji
            // 
            this.dgvIzvjestaji.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvIzvjestaji.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvIzvjestaji.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvIzvjestaji.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIzvjestaji.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Izlet,
            this.Zarada,
            this.Brojrezervacija,
            this.UkupanBrojOsoba});
            this.dgvIzvjestaji.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvIzvjestaji.Location = new System.Drawing.Point(3, 16);
            this.dgvIzvjestaji.Name = "dgvIzvjestaji";
            this.dgvIzvjestaji.Size = new System.Drawing.Size(404, 264);
            this.dgvIzvjestaji.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvIzvjestaji);
            this.groupBox1.Location = new System.Drawing.Point(45, 138);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(410, 283);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Izvjestaj po izletima";
            // 
            // chartIzvjestaj
            // 
            chartArea1.Name = "ChartArea1";
            this.chartIzvjestaj.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartIzvjestaj.Legends.Add(legend1);
            this.chartIzvjestaj.Location = new System.Drawing.Point(513, 154);
            this.chartIzvjestaj.Name = "chartIzvjestaj";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Izlet";
            this.chartIzvjestaj.Series.Add(series1);
            this.chartIzvjestaj.Size = new System.Drawing.Size(394, 253);
            this.chartIzvjestaj.TabIndex = 2;
            this.chartIzvjestaj.Text = "chart1";
            // 
            // labelukupnazarada
            // 
            this.labelukupnazarada.AutoSize = true;
            this.labelukupnazarada.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelukupnazarada.Location = new System.Drawing.Point(510, 91);
            this.labelukupnazarada.Name = "labelukupnazarada";
            this.labelukupnazarada.Size = new System.Drawing.Size(47, 15);
            this.labelukupnazarada.TabIndex = 8;
            this.labelukupnazarada.Text = "label3";
            // 
            // Izlet
            // 
            this.Izlet.DataPropertyName = "Izlet";
            this.Izlet.HeaderText = "Izlet";
            this.Izlet.Name = "Izlet";
            this.Izlet.Width = 51;
            // 
            // Zarada
            // 
            this.Zarada.DataPropertyName = "ZaradaPoIzletu";
            this.Zarada.HeaderText = "Zarada (KM)";
            this.Zarada.Name = "Zarada";
            this.Zarada.Width = 91;
            // 
            // Brojrezervacija
            // 
            this.Brojrezervacija.DataPropertyName = "BrojRezervacija";
            this.Brojrezervacija.HeaderText = "Broj rezervacija";
            this.Brojrezervacija.Name = "Brojrezervacija";
            this.Brojrezervacija.Width = 96;
            // 
            // UkupanBrojOsoba
            // 
            this.UkupanBrojOsoba.DataPropertyName = "UkupanBrojOsoba";
            this.UkupanBrojOsoba.HeaderText = "Ukupan broj osoba";
            this.UkupanBrojOsoba.Name = "UkupanBrojOsoba";
            this.UkupanBrojOsoba.Width = 86;
            // 
            // frmIzvjestajPoIzletu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 450);
            this.Controls.Add(this.labelukupnazarada);
            this.Controls.Add(this.chartIzvjestaj);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbGodine);
            this.Controls.Add(this.label1);
            this.Name = "frmIzvjestajPoIzletu";
            this.Text = "frmIzvjestajPoIzletu";
            this.Load += new System.EventHandler(this.frmIzvjestajPoIzletu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIzvjestaji)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartIzvjestaj)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbGodine;
        private System.Windows.Forms.DataGridView dgvIzvjestaji;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartIzvjestaj;
        private System.Windows.Forms.Label labelukupnazarada;
        private System.Windows.Forms.DataGridViewTextBoxColumn Izlet;
        private System.Windows.Forms.DataGridViewTextBoxColumn Zarada;
        private System.Windows.Forms.DataGridViewTextBoxColumn Brojrezervacija;
        private System.Windows.Forms.DataGridViewTextBoxColumn UkupanBrojOsoba;
    }
}