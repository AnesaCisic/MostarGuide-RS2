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
        private readonly APIService _vodici = new APIService("korisnik");
        private readonly APIService _izleti = new APIService("izlet");
        private readonly APIService _termini = new APIService("termin");
        private int? _id = null;

        public frmTerminiDetalji(int? korisnikId = null)
        {
            InitializeComponent();
            _id = korisnikId;
        }
       
       
        private async Task LoadVodici()
        {
            var result = await _vodici.Get<List<Model.Korisnici>>(null);
            cmbVodic.DisplayMember = "Ime";
            cmbVodic.ValueMember = "KorisnikId";
            cmbVodic.DataSource = result;
            cmbIzlet.SelectedItem = null;
        }

        private async Task LoadIzleti()
        {
            var result = await _izleti.Get<List<Model.Izleti>>(null);
            cmbIzlet.DisplayMember = "Naziv";
            cmbIzlet.ValueMember = "IzletId";
            cmbIzlet.DataSource = result;
            cmbIzlet.SelectedItem = null;
        }

        private async void frmTerminiDetalji_Load(object sender, EventArgs e)
        {
            await LoadVodici();
            await LoadIzleti();

            if (_id.HasValue)
            {
                var termin = await _termini.GetById<Model.Termini>(_id);
                var k = await _vodici.GetById<Model.Korisnici>(termin.KorisnikId);
                var i = await _izleti.GetById<Model.Izleti>(termin.IzletId);

                //cmbVodic.SelectedIndex = cmbVodic.FindStringExact(k.Ime + " " + k.Prezime);
                //cmbIzlet.SelectedIndex = cmbIzlet.FindStringExact(i.Naziv);

                cmbVodic.SelectedValue = int.Parse(termin.KorisnikId.ToString());
                cmbIzlet.SelectedValue = int.Parse(termin.IzletId.ToString());
                dtpDatum.Value = termin.VrijemeTermina.Date;
                dtpVrijeme.Value = termin.VrijemeTermina;

            }
        }


        private async void btnSacuvaj_Click(object sender, EventArgs e)
        {
            TerminiUpsertRequest request = new TerminiUpsertRequest();

            var vodic = cmbVodic.SelectedValue;

            if (int.TryParse(vodic.ToString(), out int idVodic))
            {
                request.KorisnikId = idVodic;
            }

            var izlet = cmbIzlet.SelectedValue;

            if (int.TryParse(izlet.ToString(), out int idIzlet))
            {
                request.IzletId = idIzlet;
            }

            request.VrijemeTermina = dtpDatum.Value.Date + dtpVrijeme.Value.TimeOfDay;

            if (_id.HasValue)
            {
                await _termini.Update<Model.Termini>(_id.Value, request);
            }
            else
            {
                var termini = await _termini.Get<List<Model.Termini>>(
                    new TerminiSearchRequest { KorisnikId = request.KorisnikId, Datum = request.VrijemeTermina });
                if (termini.Count() > 0)
                {
                    MessageBox.Show("Vodic je zauzet; na drugom je izletu!");
                }
                else
                {
                    await _termini.Insert<Model.Termini>(request);
                    MessageBox.Show("Uspješno sačuvani podaci");
                    this.Close();

                }

            }

        }

        private void cmbVodic_Format(object sender, ListControlConvertEventArgs e)
        {
            string ime = ((Model.Korisnici)e.ListItem).Ime;
            string prezime = ((Model.Korisnici)e.ListItem).Prezime;
            e.Value = ime + " " + prezime;
        }


    }
}
