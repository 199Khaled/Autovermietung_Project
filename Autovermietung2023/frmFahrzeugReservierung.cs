using Busniss_Layer;
using clsHilfsMethoden;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Autovermietung2023
{
    public partial class frmFahrzeugReservierung : Form
    {
        clsFahrzeug _fahrzeugDaten;
        public frmFahrzeugReservierung()
        {
            InitializeComponent();
            
        }
        private void _LadeAllFahrzeugType()
        {
            DataTable dt = clsFahrzeug.GetAllFahrzeugType();
            cbType.Items.Clear();

            foreach(DataRow row in dt.Rows)
            {
                cbType.Items.Add(row["typ"]);
            }
            cbType.SelectedIndex = 0;
        }

        private void _GetAllBezeichnungenByTyp()
        {
            cbBezeichnung.Items.Clear();

            //wir wählen alle fahrzeuge aus, die zu einem bestimmten Type gehören.....
            DataTable _dtFahrzeugDaten = clsFahrzeug.GetFahrzeugDatenByTyp(cbType.SelectedItem.ToString());

            foreach(DataRow row in _dtFahrzeugDaten.Rows)
            {
                cbBezeichnung.Items.Add(row["bezeichnung"]);
            }
            cbBezeichnung.SelectedIndex = 0;

        }
        
         private void _GetFahrzeugDatenByBezeichnungAndTyp()
         {
            string bezeichnung = cbBezeichnung.Text.Trim();
            string typ = cbType.Text.Trim();
            
              _fahrzeugDaten= clsFahrzeug.GetFahrzeugDatenByBezeichnungAndTyp(bezeichnung, typ);

            if(_fahrzeugDaten == null)
            {
                return;
            }
            txtFahrzeugNummer.Text = clsNummerFormatierung.FormatiereEingefügteNummer("Fahrzeug", _fahrzeugDaten.fahrzeugNummer);
            txtPreiProTag.Text = _fahrzeugDaten.preisProTag.ToString("C");

        }

        private void _DatenSpeichern()
        {
            clsReservierung reservierung = new clsReservierung();

            reservierung.reservierungsDatum = dtpGueltigBis.Value;
            reservierung.fahrzeugNummer = _fahrzeugDaten.fahrzeugNummer;
            reservierung.kundeNummer = clsGlobal.kunde.kundeNummer;

            if(reservierung.Save() && clsFahrzeug.SetzeFahrzeugAlsReserviert(reservierung.fahrzeugNummer))
            {
                txtReservierungNummer.Text = clsNummerFormatierung.FormatiereEingefügteNummer("Reser",reservierung.reservierungNummer);
                MessageBox.Show("Reservierung erfolgreich gespeichert","Erfolg",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnReservieren.Enabled = false;
            }
            else
            {
                MessageBox.Show("Fehler bei der Reservierung ist aufgetreten","Fehler",
                    MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        private void btnReservieren_Click(object sender, EventArgs e)
        {
            _DatenSpeichern();
        }

        private void _DatumEinrichten()
        {
            dtpGueltigBis.Format = DateTimePickerFormat.Custom;
            dtpGueltigBis.CustomFormat = "dd.MM.yyyy   HH:mm";

            dtpGueltigBis.Value = DateTime.Now.AddDays(1);
;        }
        private void frmFahrzeugReservierung_Load(object sender, EventArgs e)
        {
            _DatumEinrichten();
            _LadeAllFahrzeugType();
        }

        private void btnAbbrechen_Click(object sender, EventArgs e)
        {
            Close();
        }
      
        private void cbBezeichnung_SelectedIndexChanged(object sender, EventArgs e)
        {
            _GetFahrzeugDatenByBezeichnungAndTyp();
        }

        private void cbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            _GetAllBezeichnungenByTyp();
            //_GetFahrzeugDatenByBezeichnungAndTyp();
;        }
    }
}
