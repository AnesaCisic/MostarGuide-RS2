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

namespace MostarGuide.WinUI.Korisnici
{
    public partial class frmKorisniciDetalji : Form
    {
        private readonly APIService _aPIService = new APIService("korisnik");
        private readonly APIService _uloge = new APIService("uloga");

        private int? _id = null;
        public frmKorisniciDetalji(int? korisnikId = null)
        {
            InitializeComponent();
            _id = korisnikId;
        }

        KorisniciInsertRequest request = new KorisniciInsertRequest();
        private async void btnSnimi_Click(object sender, EventArgs e)
        {
            var uloge = clbRole.CheckedItems.Cast<Model.Uloge>().Select(x => x.UlogaId).ToList();

            if (this.ValidateChildren())
            {
                request.Ime = txtIme.Text;
                request.Prezime = txtPrezime.Text;
                request.Email = txtEmail.Text;
                request.Telefon = txtTelefon.Text;
                request.KorisnickoIme = txtKorisnickoIme.Text;
                request.Password = txtPassword.Text;
                request.PasswordConfirmation = txtPasswordConfirmation.Text;
                request.Uloge = uloge;

                if(cbAktivan.Checked == true)
                {
                    request.Status = true;
                }
                else
                {
                    request.Status = false;
                }

                if(txtPassword.Text != txtPasswordConfirmation.Text)
                {
                    MessageBox.Show("Passwordi nisu jednaki");

                }
                else
                {
                    if (_id.HasValue)
                    {
                        await _aPIService.Update<Model.Korisnici>(_id.Value, request);
                    }
                    else
                    {

                        await _aPIService.Insert<Model.Korisnici>(request);
                    }

                    MessageBox.Show("Operacija uspješna!");
                    this.Close();
                }

            }
        }

        private async void frmKorisniciDetalji_Load(object sender, EventArgs e)
        {
            var uloge = await _uloge.Get<List<Model.Uloge>>(null);
            clbRole.DisplayMember = "Naziv";
            clbRole.DataSource = uloge;

            if (_id.HasValue)
            {
                var korisnik = await _aPIService.GetById<Model.Korisnici>(_id);

                txtIme.Text = korisnik.Ime;
                txtPrezime.Text = korisnik.Prezime;
                txtEmail.Text = korisnik.Email;
                txtTelefon.Text = korisnik.Telefon;
                txtKorisnickoIme.Text = korisnik.KorisnickoIme;

                if(korisnik.Status == true)
                {
                    cbAktivan.Checked = true;
                }
                else
                {
                    cbAktivan.Checked = false;
                }
            }
        }

        private void txtIme_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIme.Text))
            {
                errorProvider1.SetError(txtIme, Properties.Resources.Validation_RequiredField);
                e.Cancel = true; 
            }

            else
            {
                errorProvider1.SetError(txtIme, null);
            }
        }

        private void txtPrezime_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPrezime.Text))
            {
                errorProvider1.SetError(txtPrezime, Properties.Resources.Validation_RequiredField);
                e.Cancel = true; 
            }

            else
            {
                errorProvider1.SetError(txtPrezime, null);
            }
        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                errorProvider1.SetError(txtEmail, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }

            else
            {
                errorProvider1.SetError(txtEmail, null);
            }
        }

        private void txtTelefon_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTelefon.Text))
            {
                errorProvider1.SetError(txtTelefon, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }

            else
            {
                errorProvider1.SetError(txtTelefon, null);
            }
        }

        private void txtKorisnickoIme_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtKorisnickoIme.Text))
            {
                errorProvider1.SetError(txtKorisnickoIme, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }

            else
            {
                errorProvider1.SetError(txtKorisnickoIme, null);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            char empty = new char();
            if(txtPassword.PasswordChar == empty && txtPasswordConfirmation.PasswordChar == empty)
            {
                txtPassword.PasswordChar = '*';
                txtPasswordConfirmation.PasswordChar = '*';
            }

            else
            {
                txtPassword.PasswordChar = empty;
                txtPasswordConfirmation.PasswordChar = empty;
            }
        }
    }
}
