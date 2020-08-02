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
    public partial class frmKategorije : Form
    {
        private readonly APIService _kategorije = new APIService("kategorija");

        public frmKategorije()
        {
            InitializeComponent();
        }

        private async void frmKategorije_Load(object sender, EventArgs e)
        {
            var result = await _kategorije.Get<List<Model.Kategorije>>(null);

            dgvKategorije.AutoGenerateColumns = false;
            dgvKategorije.DataSource = result;
        }

        private void dgvKategorije_MouseClick(object sender, MouseEventArgs e)
        {
            var id = dgvKategorije.SelectedRows[0].Cells[0].Value;
            frmKategorijeDetalji frm = new frmKategorijeDetalji(int.Parse(id.ToString()));
            frm.Show();
        }
    }
}
