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

namespace MostarGuide.WinUI.Izleti
{
    public partial class frmIzleti : Form
    {
        private readonly APIService _APIService = new APIService("izlet");

        public frmIzleti()
        {
            InitializeComponent();
        }

        private async void btnPrikazi_Click(object sender, EventArgs e)
        {
            var search = new IzletiSearchRequest()
            {
                Naziv = txtNaziv.Text
            };

            var result = await _APIService.Get<List<Model.Izleti>>(search);
            dgvIzleti.AutoGenerateColumns = false;
            dgvIzleti.DataSource = result;
        }

        private void dgvIzleti_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var id = dgvIzleti.SelectedRows[0].Cells[0].Value;
            frmIzletiDetalji frm = new frmIzletiDetalji(int.Parse(id.ToString())); 
            frm.Show();
        }
    }
}
