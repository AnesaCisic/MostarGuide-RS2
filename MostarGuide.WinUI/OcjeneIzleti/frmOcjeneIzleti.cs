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

namespace MostarGuide.WinUI.OcjeneIzleti
{
    public partial class frmOcjeneIzleti : Form
    {
        private readonly APIService _izleti = new APIService("izlet");
        private readonly APIService _ocjene = new APIService("ocjenaizlet");
        private readonly APIService _korisnici= new APIService("korisnikmob");
        public frmOcjeneIzleti()
        {
            InitializeComponent();
        }
       
        private async void frmOcjeneIzleti_Load(object sender, EventArgs e)
        {
            await LoadIzleti();
            await LoadOcjene(0);
        }
        private async Task LoadIzleti()
        {
            var result = await _izleti.Get<List<Model.Izleti>>(null);
            result.Insert(0, new Model.Izleti());
            cmbIzlet.DisplayMember = "Naziv";
            cmbIzlet.ValueMember = "IzletId";
            cmbIzlet.DataSource = result;
        }

        List<Model.OcjeneIzleti> result = null;

        private async Task LoadOcjene(int izletid)
        {
            if (izletid == 0)
            {
                result = await _ocjene.Get<List<Model.OcjeneIzleti>>(null);
            }
            else
            {
                result = await _ocjene.Get<List<Model.OcjeneIzleti>>(new OcjeneIzletiSearchRequest()
                {
                    IzletId = izletid
                });

            }

            foreach(var o in result)
            {
                var i = await _izleti.GetById<Model.Izleti>(o.IzletId);
                var k = await _korisnici.GetById<Model.KorisniciMob>(o.KorisnikId);

                o.Korisnik = k.KorisnickoIme;
                o.Izlet = i.Naziv;
            }

            dgvOcjene.DataSource = result;
            dgvOcjene.AutoGenerateColumns = false;

        }

        private async void cmbIzlet_SelectedIndexChanged(object sender, EventArgs e)
        {
            var idObj = cmbIzlet.SelectedValue;

            if (int.TryParse(idObj.ToString(), out int id))
            {
                await LoadOcjene(id);
            }
        }
    }
}
