﻿using MostarGuide.Model.Requests;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MostarGuide.WinUI.Sekcije
{
    public partial class frmSekcijeDetalji : Form
    {
        private readonly APIService _sekcije = new APIService("sekcija");
        private readonly APIService _kategorije = new APIService("kategorija");

        private int? _id = null;

        public frmSekcijeDetalji(int? korisnikId = null)
        {
            InitializeComponent();
            _id = korisnikId;
        }

        SekcijeUpsertRequest request = new SekcijeUpsertRequest();

        private async void frmSekcijeDetalji_Load(object sender, EventArgs e)
        {
            if (_id.HasValue)
            {
                var s = await _sekcije.GetById<Model.Sekcije>(_id);

                txtNaziv.Text = s.Naziv;
                txtOpis.Text = s.Opis;
                txtAdresa.Text = s.Adresa;
                txtWebStr.Text = s.Webstranica;

                if (s.Slika.Length > 0)
                {
                    pictureBox1.Image = BaytesToImage(s.Slika);
                    request.Slika = s.Slika;
                }

                request.KategorijaId = s.KategorijaId;
            }
        }

        private async void btnSacuvaj_Click(object sender, EventArgs e)
        {
            request.Naziv = txtNaziv.Text;
            request.Opis = txtOpis.Text;
            request.Webstranica = txtWebStr.Text;
            request.Adresa = txtAdresa.Text;

            await _sekcije.Update<Model.Sekcije>(_id.Value, request);
            
            MessageBox.Show("Operacija uspješna!");
            this.Close();
        }
        private Image BaytesToImage(byte[] slika)
        {
            MemoryStream m = new MemoryStream(slika);
            return Image.FromStream(m);
        }
        private void btnDodajSliku_Click(object sender, EventArgs e)
        {
            var result = openFileDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                var fileName = openFileDialog1.FileName;

                var file = File.ReadAllBytes(fileName);

                request.Slika = file;
                txtSlika.Text = fileName;

                Image image = Image.FromFile(fileName);
                pictureBox1.Image = image;
            }
        }

        private void txtNaziv_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNaziv.Text))
            {
                errorProvider1.SetError(txtNaziv, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }

            else
            {
                errorProvider1.SetError(txtNaziv, null);
            }
        }

        private void txtAdresa_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAdresa.Text))
            {
                errorProvider1.SetError(txtAdresa, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }

            else
            {
                errorProvider1.SetError(txtAdresa, null);
            }
        }

        private void txtWebStr_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtWebStr.Text))
            {
                errorProvider1.SetError(txtWebStr, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }

            else
            {
                errorProvider1.SetError(txtWebStr, null);
            }
        }
    }
}
