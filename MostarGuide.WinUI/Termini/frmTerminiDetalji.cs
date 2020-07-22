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
    public partial class frmTerminiDetalji : Form
    {
        private readonly APIService _termini = new APIService("termin");
        private readonly APIService _izleti = new APIService("izlet");
        private readonly APIService _vodici = new APIService("korisnik");
        private int? _id = null;

        public frmTerminiDetalji(int? terminId = null)
        {
            InitializeComponent();
            _id = terminId;

        }

        private async Task LoadVodici()
        {
            var result = await _vodici.Get<List<Model.Korisnici>>(null);
            cmbVodic.DataSource = result;
            cmbVodic.DisplayMember = "Ime";
            cmbVodic.ValueMember = "KorisnikId";
        }

        private async Task LoadIzleti()
        {
            var result = await _izleti.Get<List<Model.Izleti>>(null); //dohvatimo podatke
            cmbIzlet.DataSource = result;//ucitavamo u combo box podatke
            cmbIzlet.DisplayMember = "Naziv";
            cmbIzlet.ValueMember = "IzletId";
        }

        private async void frmTerminiDetalji_Load(object sender, EventArgs e)
        {
            await LoadVodici();
            await LoadIzleti();

            dtpVrijemeTermina.Format = DateTimePickerFormat.Custom;
            dtpVrijemeTermina.CustomFormat = "dd/MM/yyyy hh:mm";

            if (_id.HasValue)
            {
                var termin = await _termini.GetById<Model.Termini>(_id);

                var k = await _vodici.GetById<Model.Korisnici>(termin.KorisnikId);//trazimo odredjenog korisnika
                cmbVodic.SelectedIndex = cmbVodic.FindStringExact(k.Ime + " " + k.Prezime);

                var i = await _izleti.GetById<Model.Izleti>(termin.IzletId);
                cmbIzlet.SelectedIndex = cmbIzlet.FindStringExact(i.Naziv);

                dtpVrijemeTermina.Value = termin.VrijemeTermina.Date + termin.VrijemeTermina.TimeOfDay;
            }

        }


        private async void btnDodaj_Click(object sender, EventArgs e)
        {
            TerminiUpsertRequest request = new TerminiUpsertRequest();

            var izletObj = cmbIzlet.SelectedValue;

            if (int.TryParse(izletObj.ToString(), out int izletId))
            {
                request.IzletId = izletId;
            }

            var vodicObj = cmbVodic.SelectedValue;

            if (int.TryParse(vodicObj.ToString(), out int vodicId))
            {
                request.KorisnikId = vodicId;
            }

            request.VrijemeTermina = dtpVrijemeTermina.Value.Date + dtpVrijemeTermina.Value.TimeOfDay;

            Model.Termini entity = null;

            if (_id.HasValue)
            {
                request.TerminId = _id.Value;
                entity = await _termini.Update<Model.Termini>(_id, request);
            }
            else
            {
                entity = await _termini.Insert<Model.Termini>(request);
            }

            if (entity != null)
               MessageBox.Show("Operacija uspješna!");
        }
    }
}
