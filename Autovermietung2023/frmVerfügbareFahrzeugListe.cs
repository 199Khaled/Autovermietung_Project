using Busniss_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Autovermietung2023
{
    public partial class frmVerfügbareFahrzeugListe : Form
    {
        public frmVerfügbareFahrzeugListe()
        {
            InitializeComponent();
        }

        private void _listViewEinrichten()
        {
            DataTable dt = clsFahrzeug.GetAllVerfügbareFahrzeuge();
            dataGridView1.DataSource = dt;
        }
        private void frmVerfügbareFahrzeugListe_Load(object sender, EventArgs e)
        {
            _listViewEinrichten();
        }

    }
}
