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

namespace MostarGuide.WinUI.OcjeneSekcije
{
    public partial class frmOcjeneSekcije : Form
    {
        private readonly APIService _sekcije = new APIService("sekcija");
        private readonly APIService _ocjene = new APIService("ocjenasekcija");
        private readonly APIService _korisnici = new APIService("korisnikmob");

        public frmOcjeneSekcije()
        {
            InitializeComponent();
        }

        private async void frmOcjeneSekcije_Load(object sender, EventArgs e)
        {
            await LoadSekcije();
            await LoadOcjene(0);
        }
        private async Task LoadSekcije()
        {
            var result = await _sekcije.Get<List<Model.Sekcije>>(null);
            result.Insert(0, new Model.Sekcije());
            cmbSekcija.DisplayMember = "Naziv";
            cmbSekcija.ValueMember = "SekcijaId";
            cmbSekcija.DataSource = result;
        }

        List<Model.OcjeneSekcije> result = null;

        private async Task LoadOcjene(int sekcijaid)
        {
            if (sekcijaid == 0)
            {
                result = await _ocjene.Get<List<Model.OcjeneSekcije>>(null);
            }
            else
            {
                result = await _ocjene.Get<List<Model.OcjeneSekcije>>(new OcjeneSekcijeSearchRequest()
                {
                    SekcijaId = sekcijaid
                });

            }

            foreach (var o in result)
            {
                var s = await _sekcije.GetById<Model.Sekcije>(o.SekcijaId);
                var k = await _korisnici.GetById<Model.KorisniciMob>(o.KorisnikId);

                o.Korisnik = k.KorisnickoIme;
                o.Sekcija = s.Naziv;
            }

            dgvOcjene.DataSource = result;
            dgvOcjene.AutoGenerateColumns = false;

        }

        private async void cmbSekcija_SelectedIndexChanged(object sender, EventArgs e)
        {
            var idObj = cmbSekcija.SelectedValue;

            if (int.TryParse(idObj.ToString(), out int id))
            {
                await LoadOcjene(id);
            }
        }
    }
}
