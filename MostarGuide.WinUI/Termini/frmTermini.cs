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

namespace MostarGuide.WinUI.Termini
{
    public partial class frmTermini : Form
    {
        private readonly APIService _vodici = new APIService("korisnik");
        private readonly APIService _izleti = new APIService("izlet");
        private readonly APIService _termini = new APIService("termin");

        public frmTermini()
        {
            InitializeComponent();
        }

        private async void frmTermini_Load(object sender, EventArgs e)
        {
            try
            {
                await LoadVodici();
                await LoadTermini(0);
            }
            catch (Exception)
            {

                MessageBox.Show("Ne mozete pristupiti podacima!");
            }
            
        }

        private async Task LoadVodici()
        {
            var result = await _vodici.Get<List<Model.Korisnici>>(null);
            result.Insert(0, new Model.Korisnici());
            cmbVodic.DataSource = result;
            cmbVodic.DisplayMember = "Ime";
            cmbVodic.ValueMember = "KorisnikId";
            cmbVodic.SelectedText = "--Odaberite--";
        }

        List<Model.Termini> result = null;
        private async Task LoadTermini(int korisnikId)
        {
            try
            {
                if (korisnikId == 0)
                {
                    result = await _termini.Get<List<Model.Termini>>(null);
                }
                else
                {
                    result = await _termini.Get<List<Model.Termini>>(new TerminiSearchRequest()
                    {
                        KorisnikId = korisnikId
                    });

                }

                foreach (var t in result)
                {
                    var k = await _vodici.GetById<Model.Korisnici>(t.KorisnikId);
                    var i = await _izleti.GetById<Model.Izleti>(t.IzletId);
                    t.Izlet = i.Naziv;
                    t.Vodic = k.Ime + " " + k.Prezime;
                }

                dgvTermini.AutoGenerateColumns = false;
                dgvTermini.DataSource = result;
            }
            catch (Exception)
            {
                MessageBox.Show("Ne mozete pristupiti podacima!");
            }


        }

        private async void cmbVodic_SelectedIndexChanged(object sender, EventArgs e)
        {
            var idObj = cmbVodic.SelectedValue;

            if (int.TryParse(idObj.ToString(), out int id))
            {
                await LoadTermini(id);
            }
        }

        private void dgvTermini_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var id = dgvTermini.SelectedRows[0].Cells[0].Value;
            frmTerminiDetalji frm = new frmTerminiDetalji(int.Parse(id.ToString())); 
            frm.Show();
        }

        private void cmbVodic_Format(object sender, ListControlConvertEventArgs e)
        {
            string ime = ((Model.Korisnici)e.ListItem).Ime;
            string prezime = ((Model.Korisnici)e.ListItem).Prezime;
            e.Value = ime + " " + prezime;
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            frmTerminiDetalji frm = new frmTerminiDetalji();
            frm.Show();
        }
    }
}
