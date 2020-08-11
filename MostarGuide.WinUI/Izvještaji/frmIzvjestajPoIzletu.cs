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
    public partial class frmIzvjestajPoIzletu : Form
    {
        public APIService _rezervacije = new APIService("rezervacija");
        public APIService _termini = new APIService("termin");
        public APIService _izleti = new APIService("izlet");
        public frmIzvjestajPoIzletu()
        {
            InitializeComponent();
        }

        private void frmIzvjestajPoIzletu_Load(object sender, EventArgs e)
        {
            LoadGodine();
        }
        private void LoadGodine()
        {
            var gZ = DateTime.Now.AddYears(5).Year;
            var gP = 2020;
            for (int i = gP; i <= gZ; i++)
            {
                cmbGodine.Items.Add(i);
            }
            cmbGodine.Text = "--Odaberite godinu--";
        }

        private async Task LoadIzvjestaj(int idGodine)
        {
            int zarada = 0;
            int ukupnazarada = 0;
            int brojrezervacija = 0;
            int brojosoba = 0;

            var izleti = await _izleti.Get<List<Model.Izleti>>(null);
            List<Model.IzvjestajPoIzletu> lista = new List<Model.IzvjestajPoIzletu>();

            if (chartIzvjestaj.Series["Izlet"].Points.Count > 0)
            {
                chartIzvjestaj.Series["Izlet"].Points.Clear();
            }

            foreach (var i in izleti)
            {
                var termini = await _termini.Get<List<Model.Termini>>(new TerminiSearchRequest { IzletId = i.IzletId});
                //sad imam sve termine za jedan izlet
                foreach (var t in termini)//prolazim kroz te termine da prebrojim rezevacije
                {
                    var rezervacije = await _rezervacije.Get<List<Model.Rezervacije>>(new RezervacijeSearchRequest { Godina = idGodine, TerminId = t.TerminId });
                    foreach (var r in rezervacije)// rez za termin 1 
                    {
                        brojrezervacija++;
                        brojosoba += r.BrojOsoba;
                    }
                    //rezosobe = brojrezervacija * brojosoba;
                    zarada += (int)i.Cijena * brojosoba;
                }

                if (brojrezervacija> 0)
                {
                    chartIzvjestaj.Series["Izlet"].Points.AddXY(i.Naziv, zarada);

                    lista.Add(new Model.IzvjestajPoIzletu() { Izlet = i.Naziv, ZaradaPoIzletu = zarada, BrojRezervacija = brojrezervacija, UkupanBrojOsoba = brojosoba });
                }

                ukupnazarada += zarada;

                brojrezervacija = 0;
                brojosoba = 0;
                zarada = 0;
            }

            
            labelukupnazarada.Text = "Ukupna zarada za " + idGodine.ToString() + ".godinu je: " + ukupnazarada.ToString() + " KM";
            chartIzvjestaj.ChartAreas[0].AxisX.LabelStyle.Angle = 45;
            chartIzvjestaj.ChartAreas[0].AxisX.Interval = 1;
            dgvIzvjestaji.AutoGenerateColumns = false;
            dgvIzvjestaji.DataSource = lista;

        }

        private async void cmbGodine_SelectedIndexChanged(object sender, EventArgs e)
        {
            var idObj = cmbGodine.SelectedItem;
            if (int.TryParse(idObj.ToString(), out int id))
            {
                await LoadIzvjestaj(id);

            }
        }
    }
}
