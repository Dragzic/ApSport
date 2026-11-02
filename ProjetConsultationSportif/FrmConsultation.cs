using MySql.Data.MySqlClient;
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


namespace ProjetConsultationSportif
{
    public partial class FrmConsultation : Form
    {
        public FrmConsultation()
        {
            InitializeComponent();
        }

        //Elements
        private void cbBoxCritere_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblTips.Text = "";
            if (cbBoxCritere.SelectedIndex == 2)
            {
                lblTips.Text = "YYYY-MM-DD";
            }
            else if (cbBoxCritere.SelectedIndex == 6)
            {
                lblTips.Text = "Débutant\nConfirmé\nAvancé\nProfessionnel\n ";
            }
        }
        private void txtBoxChercher_TextChanged(object sender, EventArgs e)
        {

        }
        private void btnRechercher_Click(object sender, EventArgs e)
        {
            string critere = cbBoxCritere.Text;
            string recherche = txtBoxChercher.Text;

            string colonne = "";

            if (critere == "Nom")
                colonne = "nom";
            else if (critere == "Prénom")
                colonne = "prenom";
            else if (critere == "Date de naissance")
                colonne = "dateNais";
            else if (critere == "Rue")
                colonne = "rue";
            else if (critere == "Code postal")
                colonne = "cp";
            else if (critere == "Ville")
                colonne = "ville";
            else if (critere == "Niveau d'expérience")
                colonne = "nivExperience";
            else if (critere == "Nom du sport")
                colonne = "nomSport";

            try
            {
                string connexion = ConfigurationManager.ConnectionStrings["cnxBdSport"].ConnectionString;

                using (MySqlConnection cnx = new MySqlConnection(connexion))
                {
                    cnx.Open();

                    string sql;

                    if (recherche == "")
                    {
                        sql = "SELECT * FROM sportif";
                    }
                    else
                    {
                        sql = "SELECT * FROM sportif WHERE " + colonne + " LIKE @recherche";
                    }

                    MySqlCommand cmd = new MySqlCommand(sql, cnx);

                    if (recherche != "")
                    {
                        cmd.Parameters.AddWithValue("@recherche", "%" + recherche + "%");
                    }

                    MySqlDataReader reader = cmd.ExecuteReader();

                    lstViewAfficher.Items.Clear();

                    while (reader.Read())
                    {
                        ListViewItem item = new ListViewItem(reader["id"].ToString());

                        item.SubItems.Add(reader["nom"].ToString());
                        item.SubItems.Add(reader["prenom"].ToString());
                        item.SubItems.Add(reader["dateNais"].ToString());
                        item.SubItems.Add(reader["rue"].ToString());
                        item.SubItems.Add(reader["cp"].ToString());
                        item.SubItems.Add(reader["ville"].ToString());
                        item.SubItems.Add(reader["nivExperience"].ToString());
                        item.SubItems.Add(reader["nomSport"].ToString());

                        lstViewAfficher.Items.Add(item);
                    }

                    reader.Close();

                    if (lstViewAfficher.Items.Count == 0)
                    {
                        MessageBox.Show("Aucun sportif trouvé.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message);
            }
        }

        private void lstViewAfficher_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FrmConsultation_Load(object sender, EventArgs e)
        {

            //Structure de la listView
            lstViewAfficher.View = View.Details;

            lstViewAfficher.Columns.Add("ID", 50);
            lstViewAfficher.Columns.Add("Nom", 100);
            lstViewAfficher.Columns.Add("Prénom", 100);
            lstViewAfficher.Columns.Add("Date de naissance", 120);
            lstViewAfficher.Columns.Add("Adresse", 150);
            lstViewAfficher.Columns.Add("Code postal", 80);
            lstViewAfficher.Columns.Add("Ville", 100);
            lstViewAfficher.Columns.Add("Niveau d'expérience", 120);
            lstViewAfficher.Columns.Add("Sport", 100);

            //Ajouter valeur db
            ChargerSportifs();

            //Remplir la combobox
            cbBoxCritere.Items.Add("Nom");
            cbBoxCritere.Items.Add("Prénom");
            cbBoxCritere.Items.Add("Date de naissance");
            cbBoxCritere.Items.Add("Rue");
            cbBoxCritere.Items.Add("Code postal");
            cbBoxCritere.Items.Add("Ville");
            cbBoxCritere.Items.Add("Niveau d'expérience");
            cbBoxCritere.Items.Add("Nom du sport");

            cbBoxCritere.SelectedIndex = 0;

        }

        private void lblTips_Click(object sender, EventArgs e)
        {

        }

        //Methode
        private void ChargerSportifs()
        {
            string connexion = ConfigurationManager.ConnectionStrings["cnxBdSport"].ConnectionString;
            lstViewAfficher.Items.Clear();

            using (MySqlConnection cnx = new MySqlConnection(connexion))
            {
                cnx.Open();

                string sql = "SELECT * FROM sportif";

                MySqlCommand cmd = new MySqlCommand(sql, cnx);

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    ListViewItem item = new ListViewItem(reader["id"].ToString());

                    item.SubItems.Add(reader["nom"].ToString());
                    item.SubItems.Add(reader["prenom"].ToString());
                    item.SubItems.Add(reader["dateNais"].ToString());
                    item.SubItems.Add(reader["rue"].ToString());
                    item.SubItems.Add(reader["Cp"].ToString());
                    item.SubItems.Add(reader["ville"].ToString());
                    item.SubItems.Add(reader["nivExperience"].ToString());
                    item.SubItems.Add(reader["nomSport"].ToString());

                    lstViewAfficher.Items.Add(item);
                }
            }
        }
    }
}
