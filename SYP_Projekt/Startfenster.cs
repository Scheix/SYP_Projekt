using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SYP_Projekt
{
    public partial class frmMenueFenster : Form
    {
        public frmMenueFenster()
        {
            InitializeComponent();
        }

        private void btnRechnungErstellen_Click(object sender, EventArgs e)
        {
            frmRechnungErstellen frm = new frmRechnungErstellen();
            frm.Show();
        }

        private void btnRahmenHinzufuegen_Click(object sender, EventArgs e)
        {
            frmRahmenHinzufuegen frm = new frmRahmenHinzufuegen();
            frm.Show();
        }

        private void btnLeistenBestellen_Click(object sender, EventArgs e)
        {
            frmLeistenBestellen frm = new frmLeistenBestellen();
            frm.Show();
        }

        private void btnBestellungErfassen_Click(object sender, EventArgs e)
        {
            frmBestellungErfassen frm = new frmBestellungErfassen();
            frm.Show();
        }

        private void rahmenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRahmenLeistenUebersicht frm = new frmRahmenLeistenUebersicht();
            frm.Show();
        }

        private void preiseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPreise frm = new frmPreise();
            frm.Show();
        }
    }
}
