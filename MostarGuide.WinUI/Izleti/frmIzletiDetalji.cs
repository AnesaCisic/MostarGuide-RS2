﻿using MostarGuide.Model.Requests;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MostarGuide.WinUI.Izleti
{
    public partial class frmIzletiDetalji : Form
    {
        private readonly APIService _izleti = new APIService("izlet");
        private int? _id = null;

        public frmIzletiDetalji(int? izletId = null)
        {
            InitializeComponent();
            _id = izletId;
        }

        IzletiUpsertRequest request = new IzletiUpsertRequest();

        private Image BaytesToImage(byte[] slika)
        {
            MemoryStream m = new MemoryStream(slika);
            return Image.FromStream(m);
        }


        private async void frmIzletiDetalji_Load(object sender, EventArgs e)
        {
            if (_id.HasValue)
            {
                var izlet = await _izleti.GetById<Model.Izleti>(_id);

                txtNaziv.Text = izlet.Naziv;
                txtOpis.Text = izlet.Opis;
                txtCijena.Text = izlet.Cijena.ToString();
                txtBrojMjesta.Text = izlet.BrojMjesta.ToString();

                if (izlet.Slika.Length > 0)
                {
                    pictureBox.Image = BaytesToImage(izlet.Slika);
                    request.Slika = izlet.Slika;
                }
            }
        }

        private async void btnSacuvaj_Click(object sender, EventArgs e)
        {
            request.Naziv = txtNaziv.Text;
            request.Opis = txtOpis.Text;
            if (int.TryParse(txtBrojMjesta.Text.ToString(), out int brojMjesta))
            {
                request.BrojMjesta = brojMjesta;
            }
            if (decimal.TryParse(txtCijena.Text.ToString(), out decimal cijena))
            {
                request.Cijena = cijena;
            }

            if (_id.HasValue)
            {
                await _izleti.Update<Model.Izleti>(_id.Value, request);
            }
            else
            {
                await _izleti.Insert<Model.Izleti>(request);
            }

            MessageBox.Show("Operacija uspješna!");
            this.Close();

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
                pictureBox.Image = image;
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

        private void txtBrojMjesta_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBrojMjesta.Text))
            {
                errorProvider1.SetError(txtBrojMjesta, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else if (!Regex.IsMatch(txtBrojMjesta.Text, @"^[0-9]+$"))
            {
                errorProvider1.SetError(txtBrojMjesta, "Broj mjesta mora da sadrzi samo brojeve");
                e.Cancel = true;
            }

            else
            {
                errorProvider1.SetError(txtBrojMjesta, null);
            }
        }

        private void txtCijena_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCijena.Text))
            {
                errorProvider1.SetError(txtCijena, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else if (!Regex.IsMatch(txtCijena.Text, @"^[0-9]+$"))
            {
                errorProvider1.SetError(txtCijena, "Cijena mora da sadrzi samo brojeve");
                e.Cancel = true;
            }

            else
            {
                errorProvider1.SetError(txtCijena, null);
            }
        }
    }
}
