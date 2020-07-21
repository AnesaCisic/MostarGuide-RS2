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
            await LoadVodici();
            await LoadIzleti();
            dgvTermini.AutoGenerateColumns = false;
        }

        private async Task LoadVodici()
        {
            var result = await _vodici.Get<List<Model.Korisnici>>(null);
            result.Insert(0, new Model.Korisnici());
            cmbVodic.DataSource = result;
            cmbVodic.DisplayMember = "Ime";
            cmbVodic.ValueMember = "KorisnikId";
        }

        private async Task LoadIzleti()
        {
            var result = await _izleti.Get<List<Model.Izleti>>(null); //dohvatimo podatke
            result.Insert(0, new Model.Izleti());
            cmbIzlet.DataSource = result;//ucitavamo u combo box podatke
            cmbIzlet.DisplayMember = "Naziv";
            cmbIzlet.ValueMember = "IzletId";
        }

        private void cmbVodic_Format(object sender, ListControlConvertEventArgs e)
        {
            string ime = ((Model.Korisnici)e.ListItem).Ime;
            string prezime = ((Model.Korisnici)e.ListItem).Prezime;
            e.Value = ime + " " + prezime;
        }

        private async void cmbVodic_SelectedIndexChanged(object sender, EventArgs e)
        {
            var idObj = cmbVodic.SelectedValue;

            if (int.TryParse(idObj.ToString(), out int id))
            {
                await LoadTermini(id);
            }
        }

        private async Task LoadTermini(int korisnikId)
        {
            var result = await _termini.Get<List<Model.Termini>>(new TerminiSearchRequest
            {
                KorisnikId = korisnikId
            });


            dgvTermini.DataSource = result;
        }

        private async void btnDodaj_Click(object sender, EventArgs e)
        {
            TerminiUpsertRequest request = new TerminiUpsertRequest();

            var izletObj = cmbIzlet.SelectedValue;

            if (int.TryParse(izletObj.ToString(), out int izletId))
            {
                request.IzletId = izletId;
            }

            var vodicObj = cmbIzlet.SelectedValue;

            if (int.TryParse(vodicObj.ToString(), out int vodicId))
            {
                request.KorisnikId = vodicId;
            }

            request.VrijemeTermina = dtpVrijemeTermina.Value.Date + dtpVrijemeTermina.Value.TimeOfDay;

            await _termini.Insert<Model.Termini>(request);
            MessageBox.Show("Uspješno izvršeno");
            //this.Close();
        }
    }
}
