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

namespace Autovermietung2023
{
    public partial class frmMainForm : Form
    {

        public frmMainForm()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
        
            frmLoginForm frm = new frmLoginForm(this);
            frm.ShowDialog();
        }

        private void _ResetDatumAufStandardWerte()
        {
            dtpAbholdatum.Format = DateTimePickerFormat.Custom;
            dtpAbholdatum.CustomFormat = "dd.MM.yyyy";
            dtpAbholdatum.Value = DateTime.Now;

            dtRückgabedatum.Format = DateTimePickerFormat.Custom;
            dtRückgabedatum.CustomFormat = "dd.MM.yyyy";
            dtRückgabedatum.Value = DateTime.Now.AddDays(2);
        }

        private List<string> _generiereZeitFenster()
        {
            TimeSpan interval = TimeSpan.FromMinutes(30);
            TimeSpan startzeit = TimeSpan.FromHours(8);
            TimeSpan endzeit = TimeSpan.FromHours(17);

            List<string> zeitFenster = new List<string>();

            while(startzeit < endzeit)
            {
                TimeSpan next = startzeit + interval;

                if (next > endzeit)
                    break;

                string zeitfensterString = $"{startzeit.ToString(@"hh\:mm")} - {next.ToString(@"hh\:mm")}";

                zeitFenster.Add(zeitfensterString);

                startzeit = next;
            }

            return zeitFenster;
        }

        private void _FülleComboBoxMitAbhol_RueckgabeOrte()
        {
            cbAbholUndRueckgabe.Items.Clear();  
            List<string> abholorte = new List<string>()
               {
                    "Berlin Hauptbahnhof",
                    "München Flughafen",
                    "Hamburg Innenstadt",
                    "Frankfurt Hauptbahnhof",
                    "Köln Zentrum",
                    "Stuttgart Flughafen",
                    "Düsseldorf Innenstadt",
                    "Dresden Altstadt",
                    "Leipzig Messe",
                    "Nürnberg Hauptbahnhof",
                    "Hannover Flughafen",
                    "Bremen Hauptbahnhof",
                    "Essen Zentrum",
                    "Karlsruhe Bahnhof",
                    "Mannheim Innenstadt",
                    "Augsburg West",
                    "Wiesbaden Hauptbahnhof",
                    "Mainz Altstadt",
                    "Freiburg Bahnhof",
                    "Kiel Hafen"
            };

            foreach (string abholOrt in abholorte)
            {
                cbAbholUndRueckgabe.Items.Add(abholOrt);
            }
        }
        private void _FülleComboBoxeMitZeiten()
        {
            cbAbholUhrzeit.Items.Clear();
            cbRückgabeUhezeit.Items.Clear();

            List<string> zeitFenster = _generiereZeitFenster();

            foreach (var zeit in zeitFenster)
            {
                cbAbholUhrzeit.Items.Add(zeit);
                cbRückgabeUhezeit.Items.Add(zeit);
            }
        }
        private void frmMainForm_Load(object sender, EventArgs e)
        {
            _ResetDatumAufStandardWerte();
            _FülleComboBoxeMitZeiten();
            _FülleComboBoxMitAbhol_RueckgabeOrte();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnSuchen_Click(object sender, EventArgs e)
        {
            frmVerfügbareFahrzeugListe frm = new frmVerfügbareFahrzeugListe();
            frm.ShowDialog();
            frm.Dispose();
        }
    }
}
