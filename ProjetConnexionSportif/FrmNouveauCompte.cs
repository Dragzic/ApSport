using MySql.Data.MySqlClient;
using ProjetModificationSportif;
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
    public partial class FrmNouveauCompte : Form
    {
        public FrmNouveauCompte()
        {
            InitializeComponent();
        }

        private void linkLabelConnexion_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            FrmConnexion connexion = new FrmConnexion();
            connexion.Show();
        }

        private void btnCrerCompte_Click(object sender, EventArgs e)
        {
            string connexion = ConfigurationManager.ConnectionStrings["cnxBdSport"].ConnectionString;

            using (MySqlConnection cnx = new MySqlConnection(connexion))
            {
                cnx.Open();

                // Vérifier si le login existe 
                string sqlVerif = "SELECT COUNT(*) FROM User WHERE login = @login";

                using (MySqlCommand cmdVerif = new MySqlCommand(sqlVerif, cnx))
                {
                    cmdVerif.Parameters.AddWithValue("@login", txtBoxLoginNewCompte.Text);

                    int resultat = Convert.ToInt32(cmdVerif.ExecuteScalar());

                    if (resultat > 0)
                    {
                        MessageBox.Show("Ce login existe déjà !");
                        return;
                    }
                }

                // Créer le compte si le login n'existe pas
                string sql = "INSERT INTO User (login, mdp) VALUES (@login, @mdp)";

                using (MySqlCommand cmd = new MySqlCommand(sql, cnx))
                {
                    cmd.Parameters.AddWithValue("@login", txtBoxLoginNewCompte.Text);
                    cmd.Parameters.AddWithValue("@mdp", txtBoxMdpNewCompte.Text);

                    int resultat = cmd.ExecuteNonQuery();

                    if (resultat == 1)
                    {
                        MessageBox.Show("Compte créé !");

                        this.Hide();

                        FrmConnexion connexionForm = new FrmConnexion();
                        connexionForm.Show();
                    }
                }
            }
        }
    }
}
