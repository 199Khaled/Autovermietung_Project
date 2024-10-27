using Busniss_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HilfsMethoden;
using clsHilfsMethoden;

namespace Autovermietung2023
{
    public partial class frmAddnewKunde : Form
    {
        bool flage = true; // um zu wecheln zwischen männlich und weiblich.

        clsKunde _neueKunde;
        clsKontakt _neueKontakt;
        enum enMode { addnew = 0, update = 1}
        enMode _mode;
        public frmAddnewKunde()
        {
            InitializeComponent();
        }
        private void _DatumEinrichten()
        {
            dtpGeburtsdatum.Format = DateTimePickerFormat.Custom;
            dtpGeburtsdatum.CustomFormat = "dd.MM.yyyy";
            dtpGeburtsdatum.Value = DateTime.Now.AddYears(-17);

            dtpKundeSeit.Format = DateTimePickerFormat.Custom;
            dtpKundeSeit.CustomFormat = "dd.MM.yyyy";
            dtpKundeSeit.Value = DateTime.Now;
        }

        private void ResetKundeDatenAufStandardWerte()
        {
            _DatumEinrichten();

            txtKundeNummer.Text = Convert.ToString(-1);
            txtName.Clear();
            txtVorname.Clear();
            checkBox1Männlich.Checked = true;
            checkBox2Weiblich.Checked = false;
            txtStraße.Clear();
            txtPostleitzahl.Clear();
            txtOrt.Clear();          
        }

        private void ResetKontaktDatenAufStandardWerte()
        {
            txtKontaktID.Text = Convert.ToString(-1);
            txtEmail.Clear();
            txtPasswort.Clear();
            txtTelefon1.Clear();
            txtTelefon2.Clear();
        }

        private void _FülleKundeDaten()
        {
             _neueKunde = new clsKunde();

            _neueKunde.name = txtName.Text;
            _neueKunde.vorname = txtVorname.Text;
            _neueKunde.geburtsDatum = dtpGeburtsdatum.Value;
            _neueKunde.geschlecht = (checkBox1Männlich.Checked) ? clsPerson.enGeschlecht.männlich : clsPerson.enGeschlecht.weiblich;
            _neueKunde.strasse = txtStraße.Text;
            _neueKunde.postleitzahl = txtPostleitzahl.Text;
            _neueKunde.ort = txtOrt.Text;

            _FülleKontaktDaten();
        }

        private void _FülleKontaktDaten()
        {
            _neueKontakt = new clsKontakt();

            _neueKontakt.email = txtEmail.Text;
            _neueKontakt.passwort = txtPasswort.Text;
            _neueKontakt.telefon1 = txtTelefon1.Text;
            _neueKontakt.telefon2 = txtTelefon2.Text;
        }
        private void frmAddnewKunde_Load(object sender, EventArgs e)
        {
            _DatumEinrichten();
            ResetKundeDatenAufStandardWerte();
            ResetKontaktDatenAufStandardWerte();

            if (_mode == enMode.addnew)
                _FülleKundeDaten();
        }

        private bool _ValiedereKundenFelder()
        {
            bool isValid = true;

            isValid = _ValidiereEinFeld(txtName, "Name");
            isValid &= _ValidiereEinFeld(txtVorname, "Vorname");
            isValid &= _ValidiereEinFeld(txtStraße, "Straße");
            isValid &= _ValidiereEinFeld(txtPostleitzahl, "Postleitzahl");
            isValid &= _ValidiereEinFeld(txtOrt, "Ort");
            isValid &= _ValidiereEinFeld(txtEmail, "Email");
            isValid &= _ValidiereEinFeld(txtPasswort, "Passwort");

            return isValid; // Gibt zurück, ob alle Felder gültig sind
        }
        private bool _ValidiereEinFeld(TextBox txtboxName, string name)
        {
            if (string.IsNullOrEmpty(txtboxName.Text))
            {
                errorProvider1.SetError(txtboxName, $"{name} darf nicht leer sein!");
                txtboxName.BackColor = Color.LightPink;  // Hintergrundfarbe ändern
                txtboxName.BorderStyle = BorderStyle.FixedSingle;

                return false;
            }
            else
            {
                errorProvider1.SetError(txtboxName, null);
                txtboxName.BackColor = Color.White;  // Standardfarbe wiederherstellen
                txtboxName.BorderStyle = BorderStyle.FixedSingle;
            }

                return true;
        }

        private bool _ValidierePostleitzahl()
        {
            if (!int.TryParse(txtPostleitzahl.Text, out int _))
            {
                errorProvider1.SetError(txtPostleitzahl, "Postleitzahl muss aus Ziffern besetehen!");
                txtPostleitzahl.BackColor = Color.LightPink;  // Hintergrundfarbe ändern
                txtPostleitzahl.BorderStyle = BorderStyle.FixedSingle;
                return false;
            }

            if (txtPostleitzahl.TextLength != 5)
            {
                errorProvider1.SetError(txtPostleitzahl, "Postleitzahl muss 5 Ziffer lang sein!");
                txtPostleitzahl.BackColor = Color.LightPink;  // Hintergrundfarbe ändern
                txtPostleitzahl.BorderStyle = BorderStyle.FixedSingle;
                return false;
            }

            errorProvider1.SetError(txtPostleitzahl, null);
            txtPostleitzahl.BackColor = Color.White;  // Standardfarbe wiederherstellen
            txtPostleitzahl.BorderStyle = BorderStyle.FixedSingle;

            return true;
        }

        private bool _ValiediereTelefonNummer()
        {
            if (!string.IsNullOrEmpty(txtTelefon1.Text))
            {
                //wir wollen hier nur bestätigen, dass die umwandlung erfolgreich war.
                if (long.TryParse(txtTelefon1.Text, out _) && txtTelefon1.TextLength == 12) // _ ist ein WegwerfVariable  
                {
                    errorProvider1.SetError(txtTelefon1, null);
                    txtTelefon1.BackColor = Color.White;  // Standardfarbe wiederherstellen
                    txtTelefon1.BorderStyle = BorderStyle.FixedSingle;
                }
                else
                {
                    errorProvider1.SetError(txtTelefon1, "Telefonnummer muss 12 Ziffern lang sein!");
                    txtTelefon1.BackColor = Color.LightPink;  // Hintergrundfarbe ändern
                    txtTelefon1.BorderStyle = BorderStyle.FixedSingle;
                    return false;
                }
              
            }


            if (!string.IsNullOrEmpty(txtTelefon2.Text))
            {
                if (long.TryParse(txtTelefon2.Text, out _) && txtTelefon2.TextLength == 12) // long weil telfonnummer große zahl hat 
                {
                    errorProvider1.SetError(txtTelefon2, null);
                    txtTelefon2.BackColor = Color.White;  // Standardfarbe wiederherstellen
                    txtTelefon2.BorderStyle = BorderStyle.FixedSingle;
                }
                else
                {
                    errorProvider1.SetError(txtTelefon2, "Telefonnummer muss aus 12 Ziffern bestehen!");
                    txtTelefon2.BackColor = Color.LightPink;  // Hintergrundfarbe ändern
                    txtTelefon2.BorderStyle = BorderStyle.FixedSingle;
                    return false;
                }
            }

            return true;

        }

        private bool _ValidiereEmail()
        {
            if (!clsValidierung.ValidateEmail(txtEmail.Text.Trim()))
            {
                errorProvider1.SetError(txtEmail, "Bitte geben Sie eine gültige E-Mail-Adresse ein!");
                txtEmail.BackColor = Color.LightPink;  // Hintergrundfarbe ändern
                txtEmail.BorderStyle = BorderStyle.FixedSingle;
                return false;
            }

            errorProvider1.SetError(txtEmail, null);
            txtEmail.BackColor = Color.White;  // Standardfarbe wiederherstellen
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            return true;
        }
        private bool _IstValid()
        {
            if (!_ValiedereKundenFelder()  || !_ValidierePostleitzahl() || !_ValiediereTelefonNummer() || !_ValidiereEmail())
            {
                return false;
            }
           
            return true;
        }
        private void _SpeichereKundeDaten()
        {
            if (!_IstValid())
                return;


            _FülleKundeDaten();

            string status = string.Empty;
            if (_mode == enMode.addnew)
                status = "Kunde erfolgreich hinzugefügt";
            else
                status = "Kunde erfolgreich aktualisiert";

            if(_neueKunde.Save())
            {
                txtKundeNummer.Text = clsNummerFormatierung.FormatiereKundenNummer(_neueKunde.kundeNummer);
                _mode = enMode.update;

                int personID = _neueKunde.personID;

                if(_neueKontakt.Save(personID))
                {
                    txtKontaktID.Text = _neueKontakt.kontakID.ToString();
                    _mode = enMode.update;
                    MessageBox.Show(status, "Erfolg", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    btnSpeichern.Enabled = false; // wir deaktivieren speichernTaste, um die gleichen daten vermeiden zu speichern!
                }
                else
                {
                    MessageBox.Show("Fehler beim Speichern der Kontaktdaten ist aufgetreten", "Fehler",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Fehler beim Speichern der Kundedaten ist aufgetreten", "Fehler",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bntAbrechen_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSpeichern_Click(object sender, EventArgs e)
        {
            _SpeichereKundeDaten();
        }

        private void checkBox1Männlich_Click(object sender, EventArgs e)
        {
            if(flage)
            {
                checkBox1Männlich.Checked = false;
                checkBox2Weiblich.Checked = true;
            }
            else
            {
                checkBox1Männlich.Checked = true;
                checkBox2Weiblich.Checked = false;
            }

            flage = !flage;
        }

        private void checkBox2Weiblich_Click(object sender, EventArgs e)
        {
            if(flage)
            {
                checkBox1Männlich.Checked = false;
                checkBox2Weiblich.Checked = true;
            }
            else
            {
                checkBox1Männlich.Checked = true;
                checkBox2Weiblich.Checked = false;
            }
            flage = !flage;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
