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

namespace ProjetModificationSportif
{
    public partial class FrmModification : Form
    {
        public FrmModification()
        {
            InitializeComponent();
        }

        private void FrmModification_Load(object sender, EventArgs e)
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

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void lstViewAfficher_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (lstViewAfficher.SelectedItems.Count == 0)
            {
                return;
            }

            ListViewItem sportif = lstViewAfficher.SelectedItems[0];

            txtBoxNom.Text = sportif.SubItems[1].Text;
            txtBoxPrenom.Text = sportif.SubItems[2].Text;
            textBox3.Text = Convert.ToDateTime(sportif.SubItems[3].Text).ToString("yyyy-MM-dd");
            txtBoxRue.Text = sportif.SubItems[4].Text;
            txtBoxCp.Text = sportif.SubItems[5].Text;
            txtBoxVille.Text = sportif.SubItems[6].Text;
            txtBoxExperience.Text = sportif.SubItems[7].Text;
            txtBoxSport.Text = sportif.SubItems[8].Text;
        }


        private void btnAjouter_Click(object sender, EventArgs e)
        {
            try
            {
                string connexion = ConfigurationManager.ConnectionStrings["cnxBdSport"].ConnectionString;

                using (MySqlConnection cnx = new MySqlConnection(connexion))
                {
                    cnx.Open();

                    string sql = @"INSERT INTO sportif
            (nom, prenom, dateNais, rue, cp, ville, nivExperience, nomSport)
            VALUES
            (@nom, @prenom, @dateNais, @rue, @cp, @ville, @nivExperience, @nomSport)";

                    MySqlCommand cmd = new MySqlCommand(sql, cnx);

                    cmd.Parameters.AddWithValue("@nom", txtBoxNom.Text);
                    cmd.Parameters.AddWithValue("@prenom", txtBoxPrenom.Text);
                    cmd.Parameters.AddWithValue("@dateNais", Convert.ToDateTime(textBox3.Text));
                    cmd.Parameters.AddWithValue("@rue", txtBoxRue.Text);
                    cmd.Parameters.AddWithValue("@cp", txtBoxCp.Text);
                    cmd.Parameters.AddWithValue("@ville", txtBoxVille.Text);
                    cmd.Parameters.AddWithValue("@nivExperience", txtBoxExperience.Text);
                    cmd.Parameters.AddWithValue("@nomSport", txtBoxSport.Text);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Sportif ajouté avec succès !");

                    ChargerSportifs();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message);
            }
        }


        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (lstViewAfficher.SelectedItems.Count == 0)
            {
                MessageBox.Show("Veuillez sélectionner un sportif.");
                return;
            }

            DialogResult resultat = MessageBox.Show(
                "Voulez-vous vraiment supprimer ce sportif ?",
                "Confirmation de suppression",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (resultat == DialogResult.Yes)
            {
                try
                {
                    string id = lstViewAfficher.SelectedItems[0].SubItems[0].Text;

                    string connexion = ConfigurationManager.ConnectionStrings["cnxBdSport"].ConnectionString;

                    using (MySqlConnection cnx = new MySqlConnection(connexion))
                    {
                        cnx.Open();

                        string sql = "DELETE FROM sportif WHERE id = @id";

                        MySqlCommand cmd = new MySqlCommand(sql, cnx);

                        cmd.Parameters.AddWithValue("@id", id);

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Sportif supprimé avec succès !");

                        ChargerSportifs();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur : " + ex.Message);
                }
            }
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            if (lstViewAfficher.SelectedItems.Count == 0)
            {
                MessageBox.Show("Veuillez sélectionner un sportif.");
                return;
            }

            try
            {
                string id = lstViewAfficher.SelectedItems[0].SubItems[0].Text;

                string connexion = ConfigurationManager.ConnectionStrings["cnxBdSport"].ConnectionString;

                using (MySqlConnection cnx = new MySqlConnection(connexion))
                {
                    cnx.Open();

                    string sql = @"UPDATE sportif SET
                           nom = @nom,
                           prenom = @prenom,
                           dateNais = @dateNais,
                           rue = @rue,
                           cp = @cp,
                           ville = @ville,
                           nivExperience = @nivExperience,
                           nomSport = @nomSport
                           WHERE id = @id";

                    MySqlCommand cmd = new MySqlCommand(sql, cnx);

                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@nom", txtBoxNom.Text);
                    cmd.Parameters.AddWithValue("@prenom", txtBoxPrenom.Text);
                    cmd.Parameters.AddWithValue("@dateNais", Convert.ToDateTime(textBox3.Text));
                    cmd.Parameters.AddWithValue("@rue", txtBoxRue.Text);
                    cmd.Parameters.AddWithValue("@cp", txtBoxCp.Text);
                    cmd.Parameters.AddWithValue("@ville", txtBoxVille.Text);
                    cmd.Parameters.AddWithValue("@nivExperience", txtBoxExperience.Text);
                    cmd.Parameters.AddWithValue("@nomSport", txtBoxSport.Text);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Sportif modifié avec succès !");

                    ChargerSportifs();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message);
            }
        }
    }
}
