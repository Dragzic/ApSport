namespace ProjetModificationSportif
{
    partial class FrmModification
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.lstViewAfficher = new System.Windows.Forms.ListView();
            this.btnRechercher = new System.Windows.Forms.Button();
            this.cbBoxCritere = new System.Windows.Forms.ComboBox();
            this.txtBoxChercher = new System.Windows.Forms.TextBox();
            this.lblTips = new System.Windows.Forms.Label();
            this.txtBoxNom = new System.Windows.Forms.TextBox();
            this.txtBoxPrenom = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.txtBoxRue = new System.Windows.Forms.TextBox();
            this.txtBoxCp = new System.Windows.Forms.TextBox();
            this.txtBoxVille = new System.Windows.Forms.TextBox();
            this.txtBoxExperience = new System.Windows.Forms.TextBox();
            this.txtBoxSport = new System.Windows.Forms.TextBox();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstViewAfficher
            // 
            this.lstViewAfficher.HideSelection = false;
            this.lstViewAfficher.Location = new System.Drawing.Point(12, 194);
            this.lstViewAfficher.Name = "lstViewAfficher";
            this.lstViewAfficher.Size = new System.Drawing.Size(776, 244);
            this.lstViewAfficher.TabIndex = 0;
            this.lstViewAfficher.UseCompatibleStateImageBehavior = false;
            this.lstViewAfficher.SelectedIndexChanged += new System.EventHandler(this.lstViewAfficher_SelectedIndexChanged);
            // 
            // btnRechercher
            // 
            this.btnRechercher.Location = new System.Drawing.Point(12, 65);
            this.btnRechercher.Name = "btnRechercher";
            this.btnRechercher.Size = new System.Drawing.Size(75, 23);
            this.btnRechercher.TabIndex = 1;
            this.btnRechercher.Text = "Rechercher";
            this.btnRechercher.UseVisualStyleBackColor = true;
            this.btnRechercher.Click += new System.EventHandler(this.btnRechercher_Click);
            // 
            // cbBoxCritere
            // 
            this.cbBoxCritere.FormattingEnabled = true;
            this.cbBoxCritere.Location = new System.Drawing.Point(12, 12);
            this.cbBoxCritere.Name = "cbBoxCritere";
            this.cbBoxCritere.Size = new System.Drawing.Size(121, 21);
            this.cbBoxCritere.TabIndex = 2;
            this.cbBoxCritere.SelectedIndexChanged += new System.EventHandler(this.cbBoxCritere_SelectedIndexChanged);
            // 
            // txtBoxChercher
            // 
            this.txtBoxChercher.Location = new System.Drawing.Point(12, 39);
            this.txtBoxChercher.Name = "txtBoxChercher";
            this.txtBoxChercher.Size = new System.Drawing.Size(100, 20);
            this.txtBoxChercher.TabIndex = 3;
            // 
            // lblTips
            // 
            this.lblTips.AutoSize = true;
            this.lblTips.Location = new System.Drawing.Point(139, 46);
            this.lblTips.Name = "lblTips";
            this.lblTips.Size = new System.Drawing.Size(29, 13);
            this.lblTips.TabIndex = 4;
            this.lblTips.Text = "label";
            // 
            // txtBoxNom
            // 
            this.txtBoxNom.Location = new System.Drawing.Point(478, 1);
            this.txtBoxNom.Name = "txtBoxNom";
            this.txtBoxNom.Size = new System.Drawing.Size(100, 20);
            this.txtBoxNom.TabIndex = 13;
            // 
            // txtBoxPrenom
            // 
            this.txtBoxPrenom.Location = new System.Drawing.Point(478, 22);
            this.txtBoxPrenom.Name = "txtBoxPrenom";
            this.txtBoxPrenom.Size = new System.Drawing.Size(100, 20);
            this.txtBoxPrenom.TabIndex = 14;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(477, 43);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 15;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtBoxRue
            // 
            this.txtBoxRue.Location = new System.Drawing.Point(477, 65);
            this.txtBoxRue.Name = "txtBoxRue";
            this.txtBoxRue.Size = new System.Drawing.Size(100, 20);
            this.txtBoxRue.TabIndex = 16;
            // 
            // txtBoxCp
            // 
            this.txtBoxCp.Location = new System.Drawing.Point(478, 87);
            this.txtBoxCp.Name = "txtBoxCp";
            this.txtBoxCp.Size = new System.Drawing.Size(100, 20);
            this.txtBoxCp.TabIndex = 17;
            // 
            // txtBoxVille
            // 
            this.txtBoxVille.Location = new System.Drawing.Point(478, 109);
            this.txtBoxVille.Name = "txtBoxVille";
            this.txtBoxVille.Size = new System.Drawing.Size(100, 20);
            this.txtBoxVille.TabIndex = 18;
            // 
            // txtBoxExperience
            // 
            this.txtBoxExperience.Location = new System.Drawing.Point(477, 130);
            this.txtBoxExperience.Name = "txtBoxExperience";
            this.txtBoxExperience.Size = new System.Drawing.Size(100, 20);
            this.txtBoxExperience.TabIndex = 19;
            // 
            // txtBoxSport
            // 
            this.txtBoxSport.Location = new System.Drawing.Point(477, 154);
            this.txtBoxSport.Name = "txtBoxSport";
            this.txtBoxSport.Size = new System.Drawing.Size(100, 20);
            this.txtBoxSport.TabIndex = 20;
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(674, 18);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(75, 23);
            this.btnModifier.TabIndex = 21;
            this.btnModifier.Text = "ValiderModif";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(674, 65);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(75, 23);
            this.btnAjouter.TabIndex = 22;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(674, 109);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(75, 23);
            this.btnSupprimer.TabIndex = 23;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // FrmModification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.txtBoxSport);
            this.Controls.Add(this.txtBoxExperience);
            this.Controls.Add(this.txtBoxVille);
            this.Controls.Add(this.txtBoxCp);
            this.Controls.Add(this.txtBoxRue);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.txtBoxPrenom);
            this.Controls.Add(this.txtBoxNom);
            this.Controls.Add(this.lblTips);
            this.Controls.Add(this.txtBoxChercher);
            this.Controls.Add(this.cbBoxCritere);
            this.Controls.Add(this.btnRechercher);
            this.Controls.Add(this.lstViewAfficher);
            this.Name = "FrmModification";
            this.Text = "Modification";
            this.Load += new System.EventHandler(this.FrmModification_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lstViewAfficher;
        private System.Windows.Forms.Button btnRechercher;
        private System.Windows.Forms.ComboBox cbBoxCritere;
        private System.Windows.Forms.TextBox txtBoxChercher;
        private System.Windows.Forms.Label lblTips;
        private System.Windows.Forms.TextBox txtBoxNom;
        private System.Windows.Forms.TextBox txtBoxPrenom;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox txtBoxRue;
        private System.Windows.Forms.TextBox txtBoxCp;
        private System.Windows.Forms.TextBox txtBoxVille;
        private System.Windows.Forms.TextBox txtBoxExperience;
        private System.Windows.Forms.TextBox txtBoxSport;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnSupprimer;
    }
}

