namespace ProjetConsultationSportif
{
    partial class FrmConsultation
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
            this.cbBoxCritere = new System.Windows.Forms.ComboBox();
            this.txtBoxChercher = new System.Windows.Forms.TextBox();
            this.btnRechercher = new System.Windows.Forms.Button();
            this.lstViewAfficher = new System.Windows.Forms.ListView();
            this.lblTips = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbBoxCritere
            // 
            this.cbBoxCritere.FormattingEnabled = true;
            this.cbBoxCritere.Location = new System.Drawing.Point(212, 13);
            this.cbBoxCritere.Name = "cbBoxCritere";
            this.cbBoxCritere.Size = new System.Drawing.Size(121, 21);
            this.cbBoxCritere.TabIndex = 0;
            this.cbBoxCritere.SelectedIndexChanged += new System.EventHandler(this.cbBoxCritere_SelectedIndexChanged);
            // 
            // txtBoxChercher
            // 
            this.txtBoxChercher.Location = new System.Drawing.Point(473, 12);
            this.txtBoxChercher.Name = "txtBoxChercher";
            this.txtBoxChercher.Size = new System.Drawing.Size(100, 20);
            this.txtBoxChercher.TabIndex = 1;
            this.txtBoxChercher.TextChanged += new System.EventHandler(this.txtBoxChercher_TextChanged);
            // 
            // btnRechercher
            // 
            this.btnRechercher.Location = new System.Drawing.Point(357, 124);
            this.btnRechercher.Name = "btnRechercher";
            this.btnRechercher.Size = new System.Drawing.Size(75, 23);
            this.btnRechercher.TabIndex = 2;
            this.btnRechercher.Text = "Rechercher";
            this.btnRechercher.UseVisualStyleBackColor = true;
            this.btnRechercher.Click += new System.EventHandler(this.btnRechercher_Click);
            // 
            // lstViewAfficher
            // 
            this.lstViewAfficher.HideSelection = false;
            this.lstViewAfficher.Location = new System.Drawing.Point(12, 204);
            this.lstViewAfficher.Name = "lstViewAfficher";
            this.lstViewAfficher.Size = new System.Drawing.Size(776, 234);
            this.lstViewAfficher.TabIndex = 3;
            this.lstViewAfficher.UseCompatibleStateImageBehavior = false;
            this.lstViewAfficher.SelectedIndexChanged += new System.EventHandler(this.lstViewAfficher_SelectedIndexChanged);
            // 
            // lblTips
            // 
            this.lblTips.AutoSize = true;
            this.lblTips.Location = new System.Drawing.Point(470, 45);
            this.lblTips.Name = "lblTips";
            this.lblTips.Size = new System.Drawing.Size(17, 13);
            this.lblTips.TabIndex = 4;
            this.lblTips.Text = "lbl";
            this.lblTips.Click += new System.EventHandler(this.lblTips_Click);
            // 
            // FrmConsultation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTips);
            this.Controls.Add(this.lstViewAfficher);
            this.Controls.Add(this.btnRechercher);
            this.Controls.Add(this.txtBoxChercher);
            this.Controls.Add(this.cbBoxCritere);
            this.Name = "FrmConsultation";
            this.Text = "Consultation";
            this.Load += new System.EventHandler(this.FrmConsultation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbBoxCritere;
        private System.Windows.Forms.TextBox txtBoxChercher;
        private System.Windows.Forms.Button btnRechercher;
        private System.Windows.Forms.ListView lstViewAfficher;
        private System.Windows.Forms.Label lblTips;
    }
}

