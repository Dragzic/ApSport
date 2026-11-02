using ProjetConnexionSportif;
using ProjetConsultationSportif;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetApSport
{
    public partial class FrmAccueil : Form
    {
        public FrmAccueil()
        {
            InitializeComponent();
        }

        private void consultationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmConsultation consultation = new FrmConsultation();
            consultation.Show();
        }

        private void modificationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmConnexion connexion = new FrmConnexion();
            connexion.Show();
        }

        private void connexionToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void FrmAccueil_Load(object sender, EventArgs e)
        {

        }

    }
}
