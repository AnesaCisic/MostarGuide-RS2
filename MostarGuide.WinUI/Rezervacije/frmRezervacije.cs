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

namespace MostarGuide.WinUI.Rezervacije
{
    public partial class frmRezervacije : Form
    {
        private readonly APIService _rezervacije = new APIService("rezervacija");
        private readonly APIService _termini = new APIService("termin");
        private readonly APIService _korisnici = new APIService("korisnikmob");
        private readonly APIService _izleti = new APIService("izlet");

        public frmRezervacije()
        {
            InitializeComponent();
        }

        private async Task LoadTermini()
        {
            var result = await _termini.Get<List<Model.Termini>>(null);
            foreach (var r in result)
            {
               
                var i = await _izleti.GetById<Model.Izleti>(r.IzletId);


                r.Izlet = i.Naziv;
               

            }
            cmbTermini.DisplayMember = "IzletDatum";
            cmbTermini.ValueMember = "TerminId";
            cmbTermini.DataSource = result;
        }

        private async Task LoadKorisnici()
        {
            var result = await _korisnici.Get<List<Model.KorisniciMob>>(null);
            cmbTermini.DisplayMember = "ImePrezime";
            cmbTermini.ValueMember = "KorisnikId";
            cmbTermini.DataSource = result;
        }

        private async void frmRezervacije_Load(object sender, EventArgs e)
        {
            await LoadTermini();
            await LoadRezervacije(0);
        }

        List<Model.Rezervacije> result = null;

        private async Task LoadRezervacije(int terminId)
        {

            //if (terminId == 0)
            //{
            //    result = await _rezervacije.Get<List<Model.Rezervacije>>(null);
            //}
            //else
            //{
                result = await _rezervacije.Get<List<Model.Rezervacije>>(new RezervacijeSearchRequest()
                {
                    TerminId = terminId
                });

            //}

            var brojrezervacija = 0;
            var maxbrojosoba = 0;


            foreach (var r in result)
            {
                var k = await _korisnici.GetById<Model.KorisniciMob>(r.KorisnikMobId);
                var t = await _termini.GetById<Model.Termini>(r.TerminId);
                var i = await _izleti.GetById<Model.Izleti>(t.IzletId);


                r.Korisnik = k.ImePrezime;
                r.Izlet = i.Naziv;
                r.TerminDatum = t.VrijemeTermina;

                maxbrojosoba = i.BrojMjesta;
                brojrezervacija += r.BrojOsoba;
            }


            txtMjesta.Text = (maxbrojosoba - brojrezervacija).ToString();

            dgvRezervacije.AutoGenerateColumns = false;
            dgvRezervacije.DataSource = result;
        }

        private async void cmbTermini_SelectedIndexChanged(object sender, EventArgs e)
        {
            var idObj = cmbTermini.SelectedValue;

            if (int.TryParse(idObj.ToString(), out int id))
            {
                await LoadRezervacije(id);
            }
        }

       
    }
}
