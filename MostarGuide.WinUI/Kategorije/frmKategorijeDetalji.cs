using MostarGuide.Model.Requests;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MostarGuide.WinUI.Kategorije
{
    public partial class frmKategorijeDetalji : Form
    {
        private readonly APIService _kategorije = new APIService("kategorija");
        private int? _id = null;

        public frmKategorijeDetalji(int? kategorijaId = null)
        {
            InitializeComponent();
            _id = kategorijaId;

        }

        KategorijeUpsertRequest request = new KategorijeUpsertRequest();

        private async void frmKategorijeDetalji_Load(object sender, EventArgs e)
        {
            if (_id.HasValue)
            {
                var s = await _kategorije.GetById<Model.Kategorije>(_id);

                txtNazivv.Text = s.Naziv;
            }
        }

        private async void btnSacuvaj_Click(object sender, EventArgs e)
        {
            request.Naziv = txtNazivv.Text;

            if (_id.HasValue)
            {
                await _kategorije.Update<Model.Kategorije>(_id.Value, request);
            }
            else
            {
                await _kategorije.Insert<Model.Kategorije>(request);
            }

            MessageBox.Show("Operacija uspješna!");
            this.Close();
        }

        private void txtNazivv_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNazivv.Text))
            {
                errorProvider1.SetError(txtNazivv, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }

            else
            {
                errorProvider1.SetError(txtNazivv, null);
            }
        }
    }
}
