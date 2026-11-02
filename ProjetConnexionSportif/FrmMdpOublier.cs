using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetConnexionSportif
{
    public partial class FrmMdpOublier : Form
    {
        public FrmMdpOublier()
        {
            InitializeComponent();
        }

        private void btnNewMdp_Click(object sender, EventArgs e)
        {
            if (txtBoxNewMdp.Text == "" || txtBoxNewMdpConfirmation.Text == "")
            {
                MessageBox.Show("Veuillez remplir tous les champs !");
                return;
            }

            if (txtBoxNewMdp.Text != txtBoxNewMdpConfirmation.Text)
            {
                MessageBox.Show("Les mots de passe ne correspondent pas !");
                return;
            }

            string connexion = ConfigurationManager.ConnectionStrings["cnxBdSport"].ConnectionString;

            using (MySqlConnection cnx = new MySqlConnection(connexion))
            {
                cnx.Open();

                string sql = "UPDATE User SET mdp = @mdp WHERE mdp = ''";

                using (MySqlCommand cmd = new MySqlCommand(sql, cnx))
                {
                    cmd.Parameters.AddWithValue("@mdp", txtBoxNewMdp.Text);

                    int resultat = cmd.ExecuteNonQuery();

                    if (resultat == 1)
                    {
                        MessageBox.Show("Mot de passe modifié avec succès !");


                        this.Hide();
                        FrmConnexion connexionForm = new FrmConnexion();
                        connexionForm.Show();
                    }
                }
            }
        }
    }
}
