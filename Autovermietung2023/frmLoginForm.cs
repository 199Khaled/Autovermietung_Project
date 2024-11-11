using Busniss_Layer;
using clsHilfsMethoden;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Autovermietung2023
{
    public partial class frmLoginForm : Form
    {
        bool flage = true;
        public frmLoginForm(frmMainForm mainForm)
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnEinloggen_Click(object sender, EventArgs e)
        {

            string email = txtEmail.Text.Trim();
            string passwort = txtPasswort.Text.Trim();

            clsKunde kunde = clsKunde.GetKundeDatenByEmailAndPasswort(email, passwort);

            if (kunde != null)
            {
                if(kunde.istAktive == false)
                {
                    MessageBox.Show("Kundedaten sind leider nicht mehr Aktive\n" +
                        "Bitte regestrieren Sie sich erneut","Daten sind Alt",MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }
                //wir speichern die kundeDaten für späte verwendung im System.
                clsGlobal.kunde = kunde;

                if (cbErennereMich.Checked)
                    clsDateiZumSpeichern.SaveToFile(email, passwort, true);
                else
                    clsDateiZumSpeichern.SaveToFile("", "", false);

                frmFahrzeugReservierung frm = new frmFahrzeugReservierung();

                this.Close();
                frm.ShowDialog();

            }
            else
            {
                lblFehlerText.Visible = true;
                lblFehlerText.Text = "Ungültige Anmeldedaten. \nBitte melden Sie sich erneut an oder registrieren Sie sich!";
            }
        }

        private void btnKontoErstellen_Click(object sender, EventArgs e)
        {
            frmAddnewKunde frm = new frmAddnewKunde();
            frm.ShowDialog();
            frm.Dispose();
        }

        private void frmLoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void btnAnzeigen_Click(object sender, EventArgs e)
        {
            if (flage)
                txtPasswort.PasswordChar = '\0';
            else
                txtPasswort.PasswordChar = '*';

            flage = !flage;
        }

        private void _GetGespeicherteEmailAndPasswort()
        {
            string email = "", passwort = "";
            
            if(clsDateiZumSpeichern.ReadFromFile(ref email, ref passwort))
            {
                txtEmail.Text = email;
                txtPasswort.Text = passwort;
                cbErennereMich.Checked = true;
            }
            else
            {
                cbErennereMich.Checked = false;
            }
        }
        private void frmLoginForm_Load(object sender, EventArgs e)
        {
            _GetGespeicherteEmailAndPasswort();
        }

        private void frmLoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //this.Close();
        }

        private void cbErennereMich_CheckedChanged(object sender, EventArgs e)
        {
            if (cbErennereMich.Checked)
                clsDateiZumSpeichern.SaveToFile(string.Empty, string.Empty, true);
        }
    }
}
