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

namespace MostarGuide.WinUI.KorisniciMob
{
    public partial class frmKorisniciMob : Form
    {
        private readonly APIService _korisnici = new APIService("korisnikmob");

        public frmKorisniciMob()
        {
            InitializeComponent();
        }

        private async void btnPretrazi_Click(object sender, EventArgs e)
        {
            var search = new KorisniciMobSearchRequest()
            {

                Ime = txtIme.Text,
                Prezime = txtPrezime.Text
            };

            var list = await _korisnici.Get<List<Model.KorisniciMob>>(search);
            dgvKorisnici.AutoGenerateColumns = false;

            dgvKorisnici.DataSource = list;
        }

        private async void frmKorisniciMob_Load(object sender, EventArgs e)
        {
            var list = await _korisnici.Get<List<Model.KorisniciMob>>(null);
            dgvKorisnici.AutoGenerateColumns = false;

            dgvKorisnici.DataSource = list;
        }

       
    }
}
