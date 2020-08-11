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

namespace MostarGuide.WinUI.Izvještaji
{
    public partial class frmIzvjestajPoVodicu : Form
    {
        public APIService _vodic = new APIService("korisnik");
        public APIService _rezervacija = new APIService("rezervacija");
        public APIService _termin = new APIService("termin");
        public APIService _izlet = new APIService("izlet");
        public frmIzvjestajPoVodicu()
        {
            InitializeComponent();
        }

        private async Task LoadIzvjestaj()
        {

            int ukupanbrojtermina = 0;
            int ukupnazarada = 0;
            int? _godina = null;


            List<Model.Korisnici> vodici = await _vodic.Get<List<Model.Korisnici>>(null);
            List<Model.IzvjestajPoVodicu> izvjestaj = new List<Model.IzvjestajPoVodicu>();

            if (int.TryParse(txtgodina.Text.ToString(), out int godinaId))
            {
                _godina = godinaId;
                label3.Text = "Izvjestaj za vodice za " + _godina.ToString() + ".godinu.";
            }
            else
                label3.Text = "Cjelokupni izvjestaj za vodice.";

            if (chartIzvjestaj.Series["Vodic"].Points.Count > 0)
            {
                chartIzvjestaj.Series["Vodic"].Points.Clear();
                chartIzvjestaj.Series["Zarada"].Points.Clear();

            }

            foreach (var v in vodici)
            {
                //Daj mi sve termine koje je odradio ovaj vodic
                List<Model.Termini> termini = await _termin.Get<List<Model.Termini>>(new TerminiSearchRequest { KorisnikId = v.KorisnikId});
                
                foreach (var t in termini)
                {
                    //daj mi sve rezervacije za ovaj termin; da mogu zaradu izracunati
                    var rezervacije = await _rezervacija.Get<List<Model.Rezervacije>>(new RezervacijeSearchRequest { TerminId = t.TerminId, Godina = _godina });
                    
                    foreach (var r in rezervacije)
                    {
                        var izlet = await _izlet.GetById<Model.Izleti>(t.IzletId);
                        ukupnazarada += (int)izlet.Cijena * r.BrojOsoba;
                    }
                    ukupanbrojtermina++;
                }

                chartIzvjestaj.Series["Vodic"].Points.AddXY(v.Ime + " " + v.Prezime, ukupanbrojtermina);
                chartIzvjestaj.Series["Zarada"].Points.AddXY(v.Ime + " " + v.Prezime, ukupnazarada);


                izvjestaj.Add(new Model.IzvjestajPoVodicu { ImePrezime = v.Ime + " " + v.Prezime, Ukupanbrojtermina= ukupanbrojtermina, Ukupnozaradjeno = ukupnazarada });
                ukupanbrojtermina = 0;
                ukupnazarada = 0;

            }
            chartIzvjestaj.ChartAreas[0].AxisX.LabelStyle.Angle = 45;

            dgvUposlenici.AutoGenerateColumns = false;
            dgvUposlenici.DataSource = izvjestaj;

        }

        private async void btnPrikaziIzvjestaj_Click(object sender, EventArgs e)
        {
            await LoadIzvjestaj();
        }
    }
}
