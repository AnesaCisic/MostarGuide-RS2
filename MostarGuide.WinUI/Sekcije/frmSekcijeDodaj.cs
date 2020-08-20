using MostarGuide.Model.Requests;
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
    public partial class frmSekcijeDodaj : Form
    {
        private readonly APIService _sekcije = new APIService("sekcija");
        private readonly APIService _kategorije = new APIService("kategorija");
        public frmSekcijeDodaj()
        {
            InitializeComponent();
        }

        private async Task LoadKategorije()
        {
            var result = await _kategorije.Get<List<Model.Kategorije>>(null);
            result.Insert(0, new Model.Kategorije());
            cmbKategorija.DataSource = result;
            cmbKategorija.DisplayMember = "Naziv";
            cmbKategorija.ValueMember = "KategorijaId";
            cmbKategorija.SelectedText = "--Odaberite--";
        }
        private async void frmSekcijeDodaj_Load(object sender, EventArgs e)
        {
            await LoadKategorije();
        }


        SekcijeUpsertRequest request = new SekcijeUpsertRequest();

        private async void btnSacuvaj_Click(object sender, EventArgs e)
        {
            request.Naziv = txtNaziv.Text;
            request.Opis = txtOpis.Text;
            request.Webstranica = txtWebStr.Text;
            request.Adresa = txtAdresa.Text;

            var k = cmbKategorija.SelectedValue;

            if (int.TryParse(k.ToString(), out int idKategorija))
            {
                request.KategorijaId = idKategorija;
            }

            await _sekcije.Insert<Model.Sekcije>(request);

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
