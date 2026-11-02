using MySql.Data.MySqlClient;
using ProjetModificationSportif;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetConnexionSportif
{
    public partial class FrmConnexion : Form
    {
        public FrmConnexion()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnConnexion_Click(object sender, EventArgs e)
        {
            string connexion = ConfigurationManager.ConnectionStrings["cnxBdSport"].ConnectionString;

            using (MySqlConnection cnx = new MySqlConnection(connexion))
            {
                cnx.Open();

                string sql = "SELECT COUNT(*) FROM User WHERE login = @login AND mdp = @mdp";

                using (MySqlCommand cmd = new MySqlCommand(sql, cnx))
                {
                    cmd.Parameters.AddWithValue("@login", txtBoxLogin.Text);
                    cmd.Parameters.AddWithValue("@mdp", txtBoxMdp.Text);

                    int resultat = Convert.ToInt32(cmd.ExecuteScalar());

                    if (resultat == 1)
                    {
                        MessageBox.Show("Connexion réussie !");

                        this.Hide();

                        FrmModification modification = new FrmModification();
                        modification.Show();
                    }
                    else
                    {
                        MessageBox.Show("Identifiants incorrects. Veuillez réessayer.");
                    }
                }
            }
        }

        private void lLblMdpOublier_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string connexion = ConfigurationManager.ConnectionStrings["cnxBdSport"].ConnectionString;

            using (MySqlConnection cnx = new MySqlConnection(connexion))
            {
                cnx.Open();

                // Vérifier si le login existe
                string sql = "SELECT COUNT(*) FROM User WHERE login = @login";

                using (MySqlCommand cmd = new MySqlCommand(sql, cnx))
                {
                    cmd.Parameters.AddWithValue("@login", txtBoxLogin.Text);

                    int resultat = Convert.ToInt32(cmd.ExecuteScalar());

                    if (resultat == 1)
                    {
                        // enleve le mdp 
                        string sqlUpdate = "UPDATE User SET mdp = '' WHERE login = @login";

                        using (MySqlCommand cmdUpdate = new MySqlCommand(sqlUpdate, cnx))
                        {
                            cmdUpdate.Parameters.AddWithValue("@login", txtBoxLogin.Text);
                            cmdUpdate.ExecuteNonQuery();
                        }


                        this.Hide();
                        FrmMdpOublier modification = new FrmMdpOublier();
                        modification.Show();
                    }
                    else
                    {
                        MessageBox.Show("Login inexistant. Veuillez réessayer.");
                    }
                }
            }
        }

        private void lLblCreerCompte_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            FrmNouveauCompte connexion = new FrmNouveauCompte();
            connexion.Show();
        }
    }
}
