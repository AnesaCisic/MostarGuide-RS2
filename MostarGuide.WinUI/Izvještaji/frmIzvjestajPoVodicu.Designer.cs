namespace MostarGuide.WinUI.Izvještaji
{
    partial class frmIzvjestajPoVodicu
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label3 = new System.Windows.Forms.Label();
            this.btnPrikaziIzvjestaj = new System.Windows.Forms.Button();
            this.txtgodina = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.chartIzvjestaj = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dgvUposlenici = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ImePrezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UkupanBrojTermina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ukupnazarada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.chartIzvjestaj)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUposlenici)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(505, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "label3";
            // 
            // btnPrikaziIzvjestaj
            // 
            this.btnPrikaziIzvjestaj.Location = new System.Drawing.Point(304, 105);
            this.btnPrikaziIzvjestaj.Name = "btnPrikaziIzvjestaj";
            this.btnPrikaziIzvjestaj.Size = new System.Drawing.Size(127, 20);
            this.btnPrikaziIzvjestaj.TabIndex = 10;
            this.btnPrikaziIzvjestaj.Text = "Prikazi izvjestaj";
            this.btnPrikaziIzvjestaj.UseVisualStyleBackColor = true;
            this.btnPrikaziIzvjestaj.Click += new System.EventHandler(this.btnPrikaziIzvjestaj_Click);
            // 
            // txtgodina
            // 
            this.txtgodina.Location = new System.Drawing.Point(46, 105);
            this.txtgodina.Name = "txtgodina";
            this.txtgodina.Size = new System.Drawing.Size(215, 20);
            this.txtgodina.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(218, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Unesite godinu po kojoj zelite da pretrazujete";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(312, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Izvještaj po vodiču";
            // 
            // chartIzvjestaj
            // 
            chartArea3.Name = "ChartArea1";
            this.chartIzvjestaj.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartIzvjestaj.Legends.Add(legend3);
            this.chartIzvjestaj.Location = new System.Drawing.Point(469, 171);
            this.chartIzvjestaj.Name = "chartIzvjestaj";
            series5.ChartArea = "ChartArea1";
            series5.Color = System.Drawing.Color.RoyalBlue;
            series5.IsValueShownAsLabel = true;
            series5.Legend = "Legend1";
            series5.Name = "Vodic";
            series6.ChartArea = "ChartArea1";
            series6.Color = System.Drawing.Color.MediumAquamarine;
            series6.IsValueShownAsLabel = true;
            series6.Legend = "Legend1";
            series6.Name = "Zarada";
            this.chartIzvjestaj.Series.Add(series5);
            this.chartIzvjestaj.Series.Add(series6);
            this.chartIzvjestaj.Size = new System.Drawing.Size(414, 261);
            this.chartIzvjestaj.TabIndex = 13;
            this.chartIzvjestaj.Text = "chart1";
            // 
            // dgvUposlenici
            // 
            this.dgvUposlenici.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvUposlenici.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvUposlenici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUposlenici.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ImePrezime,
            this.UkupanBrojTermina,
            this.Ukupnazarada});
            this.dgvUposlenici.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUposlenici.Location = new System.Drawing.Point(3, 16);
            this.dgvUposlenici.Name = "dgvUposlenici";
            this.dgvUposlenici.Size = new System.Drawing.Size(379, 264);
            this.dgvUposlenici.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvUposlenici);
            this.groupBox1.Location = new System.Drawing.Point(46, 155);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(385, 283);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Uposlenici";
            // 
            // ImePrezime
            // 
            this.ImePrezime.DataPropertyName = "ImePrezime";
            this.ImePrezime.HeaderText = "Ime i Prezime";
            this.ImePrezime.Name = "ImePrezime";
            // 
            // UkupanBrojTermina
            // 
            this.UkupanBrojTermina.DataPropertyName = "Ukupanbrojtermina";
            this.UkupanBrojTermina.HeaderText = "Ukupan broj termina";
            this.UkupanBrojTermina.Name = "UkupanBrojTermina";
            // 
            // Ukupnazarada
            // 
            this.Ukupnazarada.DataPropertyName = "Ukupnozaradjeno";
            this.Ukupnazarada.HeaderText = "Ukupna zarada(KM)";
            this.Ukupnazarada.Name = "Ukupnazarada";
            // 
            // frmIzvjestajPoVodicu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.chartIzvjestaj);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnPrikaziIzvjestaj);
            this.Controls.Add(this.txtgodina);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmIzvjestajPoVodicu";
            this.Text = "frmIzvjestajPoVodicu";
            ((System.ComponentModel.ISupportInitialize)(this.chartIzvjestaj)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUposlenici)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnPrikaziIzvjestaj;
        private System.Windows.Forms.TextBox txtgodina;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartIzvjestaj;
        private System.Windows.Forms.DataGridView dgvUposlenici;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImePrezime;
        private System.Windows.Forms.DataGridViewTextBoxColumn UkupanBrojTermina;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ukupnazarada;
    }
}