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

namespace MostarGuide.WinUI.Sekcije
{
    public partial class frmSekcije : Form
    {
        private readonly APIService _sekcije = new APIService("sekcija");
        private readonly APIService _kategorije = new APIService("kategorija");
        public frmSekcije()
        {
            InitializeComponent();
        }

        private async void frmSekcije_Load(object sender, EventArgs e)
        {
            await LoadKategorije();
            await LoadSekcije(0);
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

        List<Model.Sekcije> result = null;

        private async Task LoadSekcije(int kategorijaId)
        {
            if(kategorijaId == 0)
            {
                result = await _sekcije.Get<List<Model.Sekcije>>(null);
            }
            else
            {
                result = await _sekcije.Get<List<Model.Sekcije>>(new SekcijeSearchRequest()
                {
                    KategorijaId = kategorijaId
                }) ;
            }

            dgvSekcije.AutoGenerateColumns = false;
            dgvSekcije.DataSource = result;

        }

        private async void cmbKategorija_SelectedIndexChanged(object sender, EventArgs e)
        {
            var idObj = cmbKategorija.SelectedValue;

            if (int.TryParse(idObj.ToString(), out int id))
            {
                await LoadSekcije(id);
            }

        }

        private void dgvSekcije_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var id = dgvSekcije.SelectedRows[0].Cells[0].Value;
            frmSekcijeDetalji frm = new frmSekcijeDetalji(int.Parse(id.ToString()));
            frm.Show();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            frmSekcijeDodaj frm = new frmSekcijeDodaj();
            frm.Show();
        }
    }
}
