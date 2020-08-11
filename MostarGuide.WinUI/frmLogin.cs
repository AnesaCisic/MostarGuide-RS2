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

namespace MostarGuide.WinUI
{
    public partial class frmLogin : Form
    {
        private readonly APIService _service = new APIService("sekcija");
        private readonly APIService _serviceLogin = new APIService("korisnikmob");

        public frmLogin()
        {
            InitializeComponent();
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            APIService.Username = txtUsername.Text;
            APIService.Password = txtPassword.Text;
            string username = txtUsername.Text;
            List<Model.KorisniciMob> lista = null;

            try
            {
                await _service.Get<dynamic>(null);
                lista = await _serviceLogin.Get<List<Model.KorisniciMob>>(new KorisniciMobSearchRequest { KorisnickoIme = username });
                
                if (lista.Count > 0)
                {
                    Application.Restart();
                }
                else
                {
                    frmIndex frm = new frmIndex();
                    this.Hide();
                    frm.ShowDialog();
                    this.Close();
                }
            }
            catch (Exception ex)
            {

            }
        }
    }
}
